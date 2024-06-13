#include "RoomManager.h"
#include <stdexcept>

int RoomManager::id_counter = 0;

RoomManager::RoomManager()
{
}

RoomManager::~RoomManager()
{
}

int RoomManager::createRoom(LoggedUser user, roomData data)
{
	Room roomToAdd;
	
	data.id = id_counter++;
	roomToAdd.setRoomData(data);
	roomToAdd.addUser(user);


	this->m_rooms.insert({ data.id, roomToAdd });
	return data.id;
}

bool RoomManager::deleteRoom(RoomID id)
{
    return this->m_rooms.erase(id) > 0;
}

bool RoomManager::getRoomState(RoomID id) throw(std::out_of_range) {
    // throws std::out_of_range
    return this->m_rooms.at(id).getRoomData().isActive;
}

std::vector<roomData> RoomManager::getAllRooms()
{
	std::vector<roomData> rooms;
	for (auto it = this->m_rooms.begin(); it != this->m_rooms.end(); it++)
	{
		if (it->second.getRoomData().isActive == false)
		{
			rooms.push_back(it->second.getRoomData());
		}
	}
	return rooms;
}

Room& RoomManager::getRoom(RoomID id) throw(std::out_of_range)
{
    // throw std::out_of_range
    return this->m_rooms.at(id);
}
