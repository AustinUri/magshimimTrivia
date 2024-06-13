#pragma once
#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"
#include "LoggedUser.h"

class RequestHandlerFactory;



class RoomAdminRequestHandler : public IRequestHandler
{
public:
	RoomAdminRequestHandler(const Room& room, const LoggedUser& user,RequestHandlerFactory& factory);
	virtual bool isReqRelevent(RequestInfo info) override;
	virtual RequestResult handleRequest(RequestInfo info) override;


private:
	Room m_room;
	LoggedUser m_user;
	RequestHandlerFactory& m_factory;
	unsigned m_RoomID;
	RequestResult closeRoom(const RequestInfo& info);
	RequestResult startGame(const RequestInfo& info);
	RequestResult getRoomState(const RequestInfo& info);
};