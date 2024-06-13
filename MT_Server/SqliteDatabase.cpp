#include "SqliteDatabase.h"

//callbacks


int print_callback(void* data, int argc, char** argv, char** azColName)
{
    for (int i = 0; i < argc; i++)
    {
        std::cout << azColName[i] << " = " << argv[i] << " , ";
    }
    std::cout << std::endl;
    return 0;
}


int putInVector_callback(void* data, int argc, char** argv, char** azColName)
{
    std::vector<std::string> *userStats = (std::vector<std::string>*)data;
    for (int i = 0; i < argc; i++)
    {
        userStats->push_back(argv[i]);
    }
    return 0;
}


/*
int statisticsVector_Callback(void* data, int argc, char** argv, char** azColName) //need debugging
{
    std::vector<StatisticsData>* statistics = static_cast<std::vector<StatisticsData>*>(data);

    StatisticsData statData;

    statData.userName = argv[0];
    
    statData.totalAnswers = std::stoi(argv[1]); 

    statData.avgAnswerTime = std::stod(argv[2]);

    statData.correctAnswers = std::stoi(argv[3]);
    
    statData.numOfGames = std::stoi(argv[4]);

    statData.score = std::stod(argv[5]);

    statistics ->push_back(statData);

    return 0;
}

*/

int statisticsVector_Callback(void* data, int argc, char** argv, char** azColName) {
    std::vector<StatisticsData>* statistics = static_cast<std::vector<StatisticsData>*>(data);

    StatisticsData statData;
    statData.userName = argv[0] ? argv[0] : "";
    statData.totalAnswers = argv[1] ? std::stoi(argv[1]) : 0;
    statData.avgAnswerTime = argv[2] ? std::stod(argv[2]) : 0.0;
    statData.correctAnswers = argv[3] ? std::stoi(argv[3]) : 0;
    statData.numOfGames = argv[4] ? std::stoi(argv[4]) : 0;
    statData.score = argv[5] ? std::stod(argv[5]) : 0.0;

    statistics->push_back(statData);

    return 0;
}

int countCallback(void* data, int argc, char** argv, char** azColName)
{
    (*(int*)data)++;
    return 0;
}


//__________________________________________________


SqliteDatabase::SqliteDatabase()
{
    this->open();
}

bool SqliteDatabase::open()
{

    int const flags = SQLITE_OPEN_READWRITE | SQLITE_OPEN_CREATE | SQLITE_OPEN_FULLMUTEX;
    int const o = sqlite3_open_v2("TriviaDB.db", &this->_db, flags, NULL);
    if (o != SQLITE_OK)
    {
        std::string msg = "Unable to open DB TriviaDB.db" ;
        return false;
    }
    return true;

}

bool SqliteDatabase::close()
{
    try
    {
        sqlite3_close(_db);
        return true;
        
    }
    catch (const std::exception&)
    {
        std::cout << "Unable to close db!(Error)" << std::endl;
        return false;
    }
}

int SqliteDatabase::doesUserExist(std::string username)
{
    const std::string sql = "SELECT * FROM USERS WHERE USERNAME = '" + username + "';";
    char* zErrMsg = nullptr;
    int count = 0;


    int rc = sqlite3_exec(this->_db, sql.c_str(), &countCallback, &count, &zErrMsg);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << zErrMsg << std::endl;
        sqlite3_free(zErrMsg);
        return SQL_ERR;
    }
    
    return count;
}


bool SqliteDatabase::doesPasswordMatch(std::string username, std::string password)
{
    const std::string sql = "SELECT * FROM USERS WHERE USERNAME = '" + username +  "' AND PASSWORD = '" + password + "';";
    char* zErrMsg = nullptr;
    int count = 0;


    int rc = sqlite3_exec(this->_db, sql.c_str(), &countCallback, &count, &zErrMsg);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << zErrMsg << std::endl;
        sqlite3_free(zErrMsg);
        return false;
    }

    return count;
}





bool SqliteDatabase::addNewUser(std::string username, std::string password, std::string mail)
{
    std::string sqlStatement = "INSERT INTO USERS (USERNAME,PASSWORD,MAIL) VALUES ('" + username + "',' " + password + "',' " + mail + "');";
    char* errMessage = nullptr;
    int res = sqlite3_exec(this->_db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
    if (res != SQLITE_OK) {
        std::cerr << "Error executing SQL: " << errMessage << std::endl;
        sqlite3_free(errMessage);
        return false;
    }
    return true;
}

std::vector<StatisticsData> SqliteDatabase::getHighScores()
{
    std::vector<StatisticsData> highestScores;
    const std::string sql = "SELECT * FROM Statistics ORDER BY SCORE DESC LIMIT 5;";
    char* errMessage = nullptr;

    int rc = sqlite3_exec(this->_db, sql.c_str(), &statisticsVector_Callback, &highestScores, &errMessage);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << errMessage << std::endl;
        sqlite3_free(errMessage);
    }

    return highestScores;
}


std::vector<StatisticsData> SqliteDatabase::getUserStats(std::string username) {
    std::vector<StatisticsData> userStats;
    const std::string sql = "SELECT * FROM Statistics WHERE USERNAME = '" + username + "';";
    char* errMessage = nullptr;

    int rc = sqlite3_exec(this->_db, sql.c_str(), statisticsVector_Callback, &userStats, &errMessage);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << errMessage << std::endl;
        sqlite3_free(errMessage);
    }

    return userStats;
}
