#include "LoginManager.h"

LoginManager::LoginManager(IDatabase* db)
{
	this->m_DB = db;
}

SignupStatus LoginManager::signup(const std::string& username,const std::string& password,const std::string& mail)
{
	int exist = this->m_DB->doesUserExist(username);

	if (exist == 1)
	{
		return SignupStatus::AlreadyExists;
	}
	else if (exist == SQL_ERR)
	{
		return SignupStatus::ServerERR;
	}
	if (!this->m_DB->addNewUser(username, password, mail))
	{
		throw std::exception("Unable to add user to the db"); //the error is printed in the func itself
	}

	return SignupStatus::Success;
}

LoginStatus LoginManager::login(const std::string& username,const std::string& password)
{

	int exist = this->m_DB->doesUserExist(username);

	if (exist  == 0)
	{
		return LoginStatus::DoesNotExist;
	}
	else if (exist == SQL_ERR)
	{
		return LoginStatus::ServerERR;
	}

	if (!this->m_DB->doesPasswordMatch(username, password))
	{
		return LoginStatus::WrongPassword;
	}

	if (std::find(this->m_loggedUsers.begin(), this->m_loggedUsers.end(), username) != this->m_loggedUsers.end()) {
		return  LoginStatus::AlreadyConnected;
	}

	this->m_loggedUsers.emplace_back(username);

	return LoginStatus::Success;
}

bool LoginManager::logout(const std::string& username)
{
	for (auto it = this->m_loggedUsers.begin(); it != this->m_loggedUsers.end();++it)
	{
		if (it->username == username)
		{
			this->m_loggedUsers.erase(it);
			return true;
		}
	}

	return false;
	

}

