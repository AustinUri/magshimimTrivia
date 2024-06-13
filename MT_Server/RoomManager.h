#pragma once
#include <string>
#include "room.h"
#include "LoggedUser.h"
#include <map>
#include <iostream>


using RoomID = unsigned int;

class RoomManager
{
private:

	std::map<RoomID, Room> m_rooms;
public:
	static int id_counter;

	RoomManager();
	~RoomManager();


	int createRoom(LoggedUser user, roomData data);
	bool deleteRoom(RoomID id);
	bool getRoomState(RoomID id) throw(std::out_of_range);

	std::vector<roomData> getAllRooms();
	Room& getRoom(RoomID id) throw(std::out_of_range);


};

