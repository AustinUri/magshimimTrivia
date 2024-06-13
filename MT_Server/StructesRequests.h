#pragma once

#include <string>
#include "Utils.h"



struct LoginRequest
{
    std::string name;
    std::string password;
};

struct SignupRequest
{
    std::string name;
    std::string password;
    std::string mail;
};


struct  createRoomRequest
{
    std::string name;
    unsigned max_players;
    unsigned question_count; //need to define a limit
    unsigned time_to_answer;
};


struct getPlayersInRoomRequest
{
    unsigned roomID;
};


struct JoinRoomRequest
{
    unsigned roomID;
};

struct SubmitAnsRequest //v4.0.0
{
    unsigned answer; //kind of like index
};
