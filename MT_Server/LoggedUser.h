#pragma once
#include <string>

struct LoggedUser
{
	std::string username;

	LoggedUser(const std::string& username);
	bool operator==(const std::string& username);
	bool operator==(const LoggedUser& user);
};