#include "Message.h"


Message::Message(const SOCKET client, const std::string msg, const int code, const std::string userName)
{
	this->_client_sc = client;
	this->_dataMessage = std::vector<std::string>();
	this->_msg_code = code;
	this->_userName = userName;
	if (!msg.empty()) //if the string is empty then we got the login msg,else it's update client msg
	{
		int second_name_size = Helper::getIntPartFromSocket(_client_sc, 2); //gets num of bytes of second name
		std::string second_name = Helper::getStringPartFromSocket(_client_sc, second_name_size); // gets second name
		int chat_size = Helper::getIntPartFromSocket(_client_sc, 5); //getting the chat size in bytes/int
		std::string chat = Helper::getStringPartFromSocket(_client_sc, chat_size);
		this->_dataMessage.push_back(second_name);
		this->_dataMessage.push_back(chat);

	}
}

SOCKET Message::getClientSock() const
{
	return this->_client_sc;
}

std::string Message::getUserName() const
{
	return this->_userName;
}

std::vector<std::string> Message::getMsgVec() const
{
	return this->_dataMessage;
}

int Message::getMsgCode() const
{
	return this->_msg_code;
}
