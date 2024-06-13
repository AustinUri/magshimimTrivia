#include "LoggedUser.h"


bool LoggedUser::operator==(const std::string& username) {
	return this->username == username;
}

bool LoggedUser::operator==(const LoggedUser& user)
{
	return this->username == user.username;
}

LoggedUser::LoggedUser(const std::string& username) : username(username){}