#include "RoomAdminRequestHandler.h"

RoomAdminRequestHandler::RoomAdminRequestHandler(const Room& room, const LoggedUser& user ,RequestHandlerFactory& factory) : m_factory{factory}, m_room{room}, m_user{user},m_RoomID{this->m_room.getRoomData().id}
{
}

bool RoomAdminRequestHandler::isReqRelevent(RequestInfo info)
{
	switch (info.RequestID)
	{
	case START_GAME_REQUEST:
	case CLOSE_ROOM_REQUEST:
	case LEAVE_ROOM_REQUEST:
	case ROOM_STATE_REQUEST:
		return true;
	break;default:
		return false;
	}
}

RequestResult RoomAdminRequestHandler::handleRequest(RequestInfo info)
{
	switch (info.RequestID)
	{
	break; case START_GAME_REQUEST: return this->startGame(info);
	break; case CLOSE_ROOM_REQUEST: return this->closeRoom(info);
	break; case LEAVE_ROOM_REQUEST: return this->closeRoom(info);
	break; case ROOM_STATE_REQUEST: return this->getRoomState(info);
	break; default: return JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ "invalid request" });
	}


}

RequestResult RoomAdminRequestHandler::closeRoom(const RequestInfo& info)
{

	if (this->m_factory.getRoomManager().deleteRoom(this->m_RoomID))
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{ 0 }), this->m_factory.createMenuRequestHandler(this->m_user));
	}
	else
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{ 1 }), this->m_factory.createMenuRequestHandler(this->m_user));

	}

}

RequestResult RoomAdminRequestHandler::startGame(const RequestInfo& info)
{
	this->m_room.getRoomData().setIsActive(true);
	//need to give every single room member game handler; not sure if in this func
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ 0 })); //need to get game handler

}

RequestResult RoomAdminRequestHandler::getRoomState(const RequestInfo& info)
{
	GetRoomStateResponse res;
	res.hasGameBegun = this->m_room.getRoomData().isActive;
	if (res.hasGameBegun) //shoulddn't be in this handler if the game begun
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(StartGameResponse{1})); //add game handler
	}
	else
	{
		res.status = 0;
	}
	res.questionCount = this->m_room.getRoomData().NumQuestions;
	res.players = this->m_room.getAllUsers();
	res.answerTimeout = this->m_room.getRoomData().timePerQuestion;
	return RequestResult(JsonResponsePacketSerializer::serializeResponse(res),this->m_factory.createRoomAdminRequestHandler(this->m_user,this->m_room));
}

