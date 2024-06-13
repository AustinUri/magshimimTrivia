#include "RequestHandlerFactory.h"

RequestHandlerFactory::RequestHandlerFactory(IDatabase* db) : m_DB(db) , m_loginManager(this->m_DB), m_statisticsManager(this->m_DB), m_roomManager() {}

IRequestHandler* RequestHandlerFactory::createLoginRequestHandler()
{
    return new LoginRequestHandler(*this);
}

IRequestHandler* RequestHandlerFactory::createMenuRequestHandler(const LoggedUser user)
{
    return new MenuRequestHandler(user, *this);

}

IRequestHandler* RequestHandlerFactory::createRoomAdminRequestHandler(const LoggedUser user, const Room& room)
{
	return new RoomAdminRequestHandler(room,user,*this);
}



IRequestHandler* RequestHandlerFactory::createRoomMemberRequestFactory(const LoggedUser user, const Room& room)
{
	return new RoomMemberRequestHandler(room, *this, user);
}

LoginManager& RequestHandlerFactory::getLoginManager()
{

	return this->m_loginManager;
}

statisticsManager& RequestHandlerFactory::getStatisticsManager()
{
	return this->m_statisticsManager;
}

RoomManager& RequestHandlerFactory::getRoomManager()
{
	return this->m_roomManager;
}
