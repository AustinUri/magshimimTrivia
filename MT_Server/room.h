#pragma once
#include <string>
#include "LoggedUser.h"
#include <vector>

#define QUESTIONS_COUNT_LIMIT 100 //CHANGABLE


struct roomData
{
    unsigned id;
    std::string name;
    unsigned maxPlayers;
    unsigned NumQuestions;
    unsigned timePerQuestion;
    bool isActive = false;

    void setIsActive(bool IsActive);
};

class Room
{
private:
    roomData m_data;
    std::vector<LoggedUser> m_members;
public:
    Room();
    ~Room();


    bool addUser(const LoggedUser& user); //bool because we need to check if he was added seccessfully
    bool removeUser(const LoggedUser& user); //bool because we need to check if he was removed seccessfully
    std::vector<std::string> getAllUsers();

    bool isUserInRoom(const LoggedUser& user); //to check if user was removed/added

    void setRoomData(roomData data);
    roomData getRoomData();
};













