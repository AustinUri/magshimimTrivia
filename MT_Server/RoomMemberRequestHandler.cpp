#include "RoomMemberRequestHandler.h"

RoomMemberRequestHandler::RoomMemberRequestHandler(const Room& room, RequestHandlerFactory& factory, const LoggedUser& user)
	:
	m_user{ user },
	m_room{ room },
	m_factory{ factory },
	m_RoomID{ 0 }
{
	try
	{
		m_RoomID = this->m_room.getRoomData().id;
	}
	catch (const std::exception& e)
	{
		// Handle initialization error
		std::cerr << "Error initializing RoomMemberRequestHandler: " << e.what() << std::endl;
	}
}
bool RoomMemberRequestHandler::isReqRelevent(RequestInfo info)
{
	switch (info.RequestID)
	{
	case LEAVE_ROOM_REQUEST: return true;
	case ROOM_STATE_REQUEST: return true;
	break; default: return false;
	}
}

RequestResult RoomMemberRequestHandler::handleRequest(RequestInfo info)
{
	switch (info.RequestID)
	{
	break; case LEAVE_ROOM_REQUEST: return this->leaveRoom(info);
	break; case ROOM_STATE_REQUEST: return this->getRoomState(info);
	break; default: return JsonResponsePacketSerializer::serializeResponse(ErrorResponse{ "invalid request" });
	}
}

RequestResult RoomMemberRequestHandler::leaveRoom(RequestInfo info)
{

	try
	{
		this->m_factory.getRoomManager().getRoomState(this->m_RoomID);
		if (this->m_room.removeUser(this->m_user));
		{
			return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{ 0 }), this->m_factory.createMenuRequestHandler(this->m_user)); //we were able to remove the player from the room
		}
	}
	catch (const std::exception&)
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{ 0 }), this->m_factory.createMenuRequestHandler(this->m_user)); //room has been closed
	}

	return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{1}), this->m_factory.createMenuRequestHandler(this->m_user)); //err
}

RequestResult RoomMemberRequestHandler::getRoomState(RequestInfo info)
{
	
	try
	{
		roomData data = this->m_room.getRoomData();
		if (true)
		{
			this->m_factory.getRoomManager().getRoom(this->m_RoomID);
			if (data.isActive == true)
			{
				return RequestResult(JsonResponsePacketSerializer::serializeResponse(StartGameResponse{ 1 })); //need to return game handler

			}
		}
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(GetRoomStateResponse{0,data.isActive,this->m_room.getAllUsers(),data.NumQuestions,data.timePerQuestion}),this->m_factory.createRoomMemberRequestFactory(this->m_user,this->m_room)); //need to return game handler
	}
	catch (const std::exception&)
	{
		return RequestResult(JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse{2 }), this->m_factory.createMenuRequestHandler(this->m_user)); 
	}

}
