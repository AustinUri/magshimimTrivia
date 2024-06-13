#include "LoginRequestHandler.h"
#include "Helper.h"
#include "RequestHandlerFactory.h"

LoginRequestHandler::LoginRequestHandler(RequestHandlerFactory& factory) : m_handlerFactory(factory){}


bool LoginRequestHandler::isReqRelevent(RequestInfo info)
{
	return info.RequestID == LOG_IN_REQUEST || info.RequestID == SIGN_UP_REQUEST;
}

RequestResult LoginRequestHandler::handleRequest(RequestInfo info)
{
	//check type code
	switch (info.RequestID) {
	break; case LOG_IN_REQUEST: {
		LoginRequest req = JsonRequestPacketDeserializer::deserializeLoginRequest(info.buffer);
		std::cout << "Username:" << req.name << " Password:" << req.password << std::endl;
		return this->login(req.name, req.password);
	}

	break; case SIGN_UP_REQUEST: {
		SignupRequest req = JsonRequestPacketDeserializer::deserializeSignupRequest(info.buffer);
		std::cout << "Username:" << req.name << " Password:" << req.password << " Mail:" << req.mail << std::endl;
		return this->signup(req.name, req.password, req.mail);
	}

	break; default:
	{
		ErrorResponse kaki = RequestResult::error("Invalid request");
		return JsonResponsePacketSerializer::serializeResponse(kaki);
	}
	}
}

RequestResult LoginRequestHandler::signup(
	const std::string& username,
	const std::string& password,
	const std::string& mail
) {
	SignupStatus status = this->m_handlerFactory.getLoginManager().signup(username, password, mail);
	switch (status) {
	break; case SignupStatus::Success: return RequestResult(JsonResponsePacketSerializer::serializeResponse(SignupResponse{0}),this->m_handlerFactory.createMenuRequestHandler(LoggedUser{username}));
	break; case SignupStatus::AlreadyExists: return RequestResult(JsonResponsePacketSerializer::serializeResponse(SignupResponse{ 1 }),this->m_handlerFactory.createLoginRequestHandler());
	break; case SignupStatus::ServerERR: return RequestResult(JsonResponsePacketSerializer::serializeResponse(SignupResponse{ 2 }), nullptr);

	}
}

RequestResult LoginRequestHandler::login(const std::string& username, const std::string& password) {
	LoginStatus status = this->m_handlerFactory.getLoginManager().login(username,password);
	switch (status)
	{
	break; case LoginStatus::Success: return RequestResult(JsonResponsePacketSerializer::serializeResponse(LoginResponse{ 0 }),this->m_handlerFactory.createMenuRequestHandler(LoggedUser{username}));
	break; case LoginStatus::DoesNotExist: return RequestResult(JsonResponsePacketSerializer::serializeResponse(LoginResponse{1}),this->m_handlerFactory.createLoginRequestHandler());
	break; case LoginStatus::AlreadyConnected: return RequestResult(JsonResponsePacketSerializer::serializeResponse(LoginResponse{ 2 }),this->m_handlerFactory.createLoginRequestHandler());
	break; case LoginStatus::ServerERR: return RequestResult(JsonResponsePacketSerializer::serializeResponse(SignupResponse{ 3 }), nullptr);
	break; case LoginStatus::WrongPassword: return RequestResult(JsonResponsePacketSerializer::serializeResponse(LoginResponse{ 4 }), this->m_handlerFactory.createLoginRequestHandler());
	}
}

