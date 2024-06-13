#pragma once

#include <string>
#include "Utils.h"
#include "room.h"
#include "statisticsManager.h"




struct ErrorResponse
{
    std::string msg;
};

struct LoginResponse
{
    unsigned status;
};

struct SignupResponse
{
    unsigned status;
};

struct LogoutResponse
{
    unsigned status;
};

struct GetRoomsResponse
{
    unsigned status;
    std::vector<roomData> rooms;
};

struct GetPlayersInRoomResponse
{
    unsigned status;
    std::vector<std::string> players;
};

struct GetHighScoreResponse
{
    unsigned status;
    std::vector<StatisticsData> highScoress;
};

struct GetPersonalStatsResponse 
{
    unsigned status;
    StatisticsData statistics;
};

struct CreateRoomResponse
{
    unsigned status;
};

struct JoinRoomResponse
{
    unsigned status;
};

struct CloseRoomResponse
{
    unsigned status;
};

struct StartGameResponse
{
    unsigned status;
};

struct GetRoomStateResponse
{
    unsigned status;
    bool hasGameBegun;
    std::vector<std::string> players;
    unsigned questionCount;
    unsigned answerTimeout; //not sure if unsigned is the right type
};

struct LeaveRoomResponse
{
    unsigned status;
};

















//In signup and login - everything except 0 means failure 
//0 means signup/login success