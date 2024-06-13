#include "statisticsManager.h"


statisticsManager::statisticsManager(IDatabase* data)
{
    this->m_data = data;
}


statisticsManager::~statisticsManager()
{

}

std::vector<StatisticsData> statisticsManager::getHighScores()
{
    std::vector<StatisticsData> heightScore = this->m_data->getHighScores();
    StatisticsData data;

    return heightScore;
}

StatisticsData statisticsManager::getUserStats(std::string username)
{
    std::vector<StatisticsData> userStats = this->m_data->getUserStats(username);
    StatisticsData data = userStats[0];
    /*
    data.userName = userStats[0];
    data.avgAnswerTime = std::stof(userStats[1]);
    data.correctAnswers = std::stoi(userStats[2]);
    data.totalAnswers = std::stoi(userStats[3]);
    data.numOfGames = std::stoi(userStats[4]);
    */
    return data;
}
