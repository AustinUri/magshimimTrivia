#pragma once
#include "IDatabase.h"
#include <vector>
#include "LoggedUser.h"

enum class SignupStatus {
	Success,
	AlreadyExists,
	ServerERR,
};

enum class LoginStatus {
	Success,
	AlreadyConnected,
	DoesNotExist,
	WrongPassword,
	ServerERR ,
};

class LoginManager
{

	
public:
	LoginManager(IDatabase* db);
	SignupStatus signup(const std::string& username,const std::string& password,const std::string& mail);
	LoginStatus login(const std::string& username,const std::string& password);
	bool logout(const std::string& username);


private:
	IDatabase* m_DB;
	std::vector<LoggedUser> m_loggedUsers;


};




