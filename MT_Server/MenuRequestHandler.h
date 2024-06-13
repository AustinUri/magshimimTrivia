#pragma once
#include "IRequestHandler.h"
#include "RequestHandlerFactory.h"
#include "LoggedUser.h"

class RequestHandlerFactory;


class MenuRequestHandler : public IRequestHandler 
{
private:
	RequestHandlerFactory& m_factory;
	LoggedUser user;

	RequestResult signout(const RequestInfo& info);
	RequestResult getRomms(const RequestInfo& info);
	RequestResult createRoom(const RequestInfo& info); 
	RequestResult joinRoom(const RequestInfo& info); 
	RequestResult getPlayersInRoom(const RequestInfo& info); 
	RequestResult getPersonalStats(const RequestInfo& info); 
	RequestResult getHighScores(const RequestInfo& info); 


public:


	MenuRequestHandler(const LoggedUser& user,RequestHandlerFactory& factory);
	virtual bool isReqRelevent(RequestInfo info) override;
	virtual RequestResult handleRequest(RequestInfo info) override;




};
