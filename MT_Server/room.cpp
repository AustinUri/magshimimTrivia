#include "room.h"
#include <algorithm>
#include <iostream> //maybe not needed when finished 1.0.3;
#include "RoomManager.h"

Room::Room()
{
}

Room::~Room()
{
    //nothing to clear
}

std::vector<std::string> Room::getAllUsers()
{
    std::vector<std::string> result;

    if (this->m_members.size() < 1)
    {
        result.push_back("There are no users in the room");
        return result;
    }
    else
    {
        for (size_t i = 0; i < this->m_members.size(); i++)
        {
            result.push_back(this->m_members[i].username);
        }
    }
    return result;
}

void Room::setRoomData(roomData data)
{
    this->m_data = data;
}

bool Room::addUser(const LoggedUser& user)
{
    if (this->m_data.isActive)
    {
        return false;
    }

    if (this->isUserInRoom(user)) {
        return false;
    }

    this->m_members.push_back(user);
    return true;


}

bool Room::removeUser(const LoggedUser& user)
{
    auto it = std::find(this->m_members.begin(), this->m_members.end(), user);
    if (it == this->m_members.end()) {
        return false;
    }

    this->m_members.erase(it);
    return true;
}

bool Room::isUserInRoom(const LoggedUser& user)
{
    auto it = std::find(this->m_members.begin(), this->m_members.end(), user);
    return it != this->m_members.end();
}


roomData Room::getRoomData()
{
    return this->m_data;
}

void roomData::setIsActive(bool IsActive)
{
    this->isActive = IsActive;
}
