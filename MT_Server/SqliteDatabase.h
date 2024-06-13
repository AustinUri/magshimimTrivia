#pragma once

#include "IDatabase.h"
#include "statisticsManager.h"



class SqliteDatabase : public IDatabase
{
public :
	
	//constructor

	SqliteDatabase();
	
	//all the Idatabase functions
	
	virtual bool open() override;
	virtual bool close() override;
	virtual int doesUserExist(std::string userName) override;
	virtual bool doesPasswordMatch(std::string username, std::string password) override;
	virtual bool addNewUser(std::string username, std::string password, std::string mail) override;

	virtual std::vector<StatisticsData> getHighScores() override;
	virtual std::vector<StatisticsData> getUserStats(std::string username) override;


private:
	sqlite3* _db;

};

