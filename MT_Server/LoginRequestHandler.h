#pragma once
#include "IRequestHandler.h"
#include "StructesRequests.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"
#include <iostream>
#include "StructResponses.h"
#include "SqliteDatabase.h"
#include "RequestResult.h"

class RequestHandlerFactory; 

class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler(RequestHandlerFactory& factory);
	~LoginRequestHandler() = default;

	virtual bool isReqRelevent(RequestInfo info) override;
	virtual RequestResult handleRequest(RequestInfo info) override;
	RequestResult signup(const std::string& username ,const std::string& password , const std::string& mail );
	RequestResult login(const std::string& username ,const std::string& password);
private:
	RequestHandlerFactory& m_handlerFactory;
};

