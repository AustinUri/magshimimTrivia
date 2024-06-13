#pragma once
#include "IDatabase.h"
#include "LoginRequestHandler.h"
#include "LoginManager.h"
#include "RoomManager.h"
#include "statisticsManager.h"
#include "IRequestHandler.h"
#include "MenuRequestHandler.h"
#include "RoomAdminRequestHandler.h"
#include "RoomMemberRequestHandler.h"



class RequestHandlerFactory
{
private:

	IDatabase* m_DB;
	LoginManager m_loginManager;
	statisticsManager m_statisticsManager;
	RoomManager m_roomManager;

public:
	RequestHandlerFactory(IDatabase* db);
	IRequestHandler* createLoginRequestHandler();
	IRequestHandler* createMenuRequestHandler(const LoggedUser user);
	IRequestHandler* createRoomAdminRequestHandler(const LoggedUser user, const Room& room);
	IRequestHandler* createRoomMemberRequestFactory(const LoggedUser user,const Room& room);
	LoginManager& getLoginManager();
	statisticsManager& getStatisticsManager();
	RoomManager& getRoomManager();

};

