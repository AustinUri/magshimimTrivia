#pragma once
#include <iostream>
#include "IDatabase.h"
#include <vector>
#include "json.hpp"

class statisticsManager
{
private:
	IDatabase* m_data;

public:
	statisticsManager(IDatabase* data);
	~statisticsManager();
	std::vector<StatisticsData> getHighScores();
	StatisticsData getUserStats(std::string username);
};

