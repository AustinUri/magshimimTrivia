#pragma once
#include <WinSock2.h>
#include <Windows.h>
#include <string>
#include <vector>
#include "Helper.h"
class Message
{
	SOCKET _client_sc;
	std::string _userName;
	std::vector<std::string> _dataMessage;
	int _msg_code;

public:
	Message(const SOCKET client, const std::string msg, const int code, const std::string userName);
	SOCKET getClientSock() const;
	std::string getUserName() const;
	std::vector<std::string> getMsgVec() const;
	int getMsgCode() const;

};

