#pragma once
#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"
#include "LoggedUser.h"
#include "room.h"

class RequestHandlerFactory;


class RoomMemberRequestHandler : public IRequestHandler
{
public:
	RoomMemberRequestHandler(const Room& room, RequestHandlerFactory& factory,const LoggedUser& user);
	virtual bool isReqRelevent(RequestInfo info) override;
	virtual RequestResult handleRequest(RequestInfo info) override;

private:
	Room m_room;
	LoggedUser m_user;
	unsigned m_RoomID;
	RequestHandlerFactory& m_factory;
	RequestResult leaveRoom(RequestInfo info);
	RequestResult getRoomState(RequestInfo info);
};

