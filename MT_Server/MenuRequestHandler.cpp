#include "MenuRequestHandler.h"
#include "JsonResponsePacketSerializer.h"
#include <algorithm>

MenuRequestHandler::MenuRequestHandler(const LoggedUser& user, RequestHandlerFactory& factory) : user{user} , m_factory{factory} {}

RequestResult MenuRequestHandler::signout(const RequestInfo& info)
{
	this->m_factory.getLoginManager().logout(this->user.username);
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(LogoutResponse{ 0 })); //doesn't really care what happens  afterwards so always success
}

RequestResult MenuRequestHandler::getRomms(const RequestInfo& info)
{
	
	//need to review if can be any bugs , for example sql err
	//probably need try and catch
	try
	{
		std::vector<roomData> data = this->m_factory.getRoomManager().getAllRooms();
		if (data.empty())
		{
			return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse{ 1 }), this->m_factory.createMenuRequestHandler(this->user)); //no rooms found
		}
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse{ 0 , data}),this->m_factory.createMenuRequestHandler(this->user)); //success
	}
	catch (const std::exception& e)
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(ErrorResponse{e.what()}));//err , can't happen but we dont want the server to crush in case it does for some reason
	}
}

RequestResult MenuRequestHandler::createRoom(const RequestInfo& info)
{
	

	createRoomRequest req = JsonRequestPacketDeserializer::deserializeCreateRoomRequest(info.buffer);
	roomData data;
	data.maxPlayers = req.max_players;
	data.NumQuestions = std::min(req.question_count, (unsigned) QUESTIONS_COUNT_LIMIT);
	data.name = req.name;
	data.timePerQuestion = req.time_to_answer;
	

	int roomId =  this->m_factory.getRoomManager().createRoom(this->user,data);
	Room& room = this->m_factory.getRoomManager().getRoom(roomId);
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(CreateRoomResponse{ 0 }),this->m_factory.createRoomAdminRequestHandler(this->user,room));
}

RequestResult MenuRequestHandler::joinRoom(const RequestInfo& info)
{
	JoinRoomRequest req = JsonRequestPacketDeserializer::deserializeJoinRoomRequest(info.buffer);

	bool result = this->m_factory.getRoomManager().getRoom(req.roomID).addUser(this->user);
	Room& room = this->m_factory.getRoomManager().getRoom(req.roomID);
	if (result)
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse{ 0 }),this->m_factory.createRoomMemberRequestFactory(user,room)); //success
	}
	else
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse{ 1 })); //any other thing..
	}


}

RequestResult MenuRequestHandler::getPlayersInRoom(const RequestInfo& info)
{
	getPlayersInRoomRequest req = JsonRequestPacketDeserializer::deserializeGetPlayersInRoomRequest(info.buffer);
	
	std::vector<std::string> players = this->m_factory.getRoomManager().getRoom(req.roomID).getAllUsers();
	if (players.empty())
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse{ 1 })); // empty room , err
	}

	return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse{ 0, players })); // success


}

RequestResult MenuRequestHandler::getPersonalStats(const RequestInfo& info)
{
	StatisticsData stats = this->m_factory.getStatisticsManager().getUserStats(this->user.username);
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetPersonalStatsResponse{ 0, stats }), this->m_factory.createMenuRequestHandler(this->user));
}

RequestResult MenuRequestHandler::getHighScores(const RequestInfo& info)
{
	std::vector<StatisticsData> stats = this->m_factory.getStatisticsManager().getHighScores();
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetHighScoreResponse{ 0  , stats }), this->m_factory.createMenuRequestHandler(this->user));
}


bool MenuRequestHandler::isReqRelevent(RequestInfo info) 
{
	switch (info.RequestID)
	{
	case LOG_OUT_REQUEST:
	case JOIN_ROOM_REQUEST:
	case CREATE_ROOM_REQUEST:
	case GET_PLAYERS_REQUEST:
    case GET_PERSONAL_STATS_REQUEST:
    case GET_ROOMS_REQUEST:
	case GET_HIGH_SCORES_REQUEST:
		return true;
	default:
		return false;
	break;
	}
}

RequestResult MenuRequestHandler::handleRequest(RequestInfo info)
{
	info.recivalTime = std::chrono::system_clock::now(); //doesn't even work
	switch(info.RequestID)
	{
	break; case LOG_OUT_REQUEST: return this->signout(info);
	break; case JOIN_ROOM_REQUEST: return this->joinRoom(info);
	break; case CREATE_ROOM_REQUEST: return this->createRoom(info);
	break; case GET_PLAYERS_REQUEST: return this->getPlayersInRoom(info);
	break; case GET_PERSONAL_STATS_REQUEST: return this->getPersonalStats(info);
	break; case GET_HIGH_SCORES_REQUEST: return this->getHighScores(info);
	break; case GET_ROOMS_REQUEST: return this->getRomms(info);
	break; default: return JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ "invalid request" });
	}
}
