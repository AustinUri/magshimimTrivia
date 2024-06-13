#pragma once
#include <string>
#include "sqlite3.h"
#include <iostream>
#include <exception>
#include <vector>
#include "json.hpp"

#define SQL_ERR 999

struct StatisticsData
{
	std::string userName;
	float avgAnswerTime;
	int correctAnswers;
	int totalAnswers;
	int numOfGames;
	float score;

	NLOHMANN_DEFINE_TYPE_INTRUSIVE_ONLY_SERIALIZE(StatisticsData, userName, avgAnswerTime, correctAnswers, totalAnswers, numOfGames,score);
};


class IDatabase
{
public:

	virtual bool open() = 0;
	virtual bool close() = 0;
	virtual int doesUserExist(std::string userName) = 0;
	virtual bool doesPasswordMatch(std::string username, std::string password) = 0;
	virtual bool addNewUser(std::string username, std::string password, std::string mail) = 0;

	virtual std::vector<StatisticsData> getHighScores() = 0;
	virtual  std::vector<StatisticsData> getUserStats(std::string username) = 0;

};

