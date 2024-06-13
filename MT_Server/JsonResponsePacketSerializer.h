#pragma once
#include "StructResponses.h"
#include "json.hpp"
#include <map>
using json = nlohmann::json;


class JsonResponsePacketSerializer
{
public:
	static Buffer serializeResponse(ErrorResponse err);
	static Buffer serializeResponse(LoginResponse response);
	static Buffer serializeResponse(SignupResponse response);
	static Buffer serializeResponse(LogoutResponse response);
	static Buffer serializeResponse(GetRoomsResponse response);
	static Buffer serializeResponse(GetPlayersInRoomResponse response);  //review is needed
	static Buffer serializeResponse(JoinRoomResponse response); 
	static Buffer serializeResponse(CreateRoomResponse response);
	static Buffer serializeResponse(GetPersonalStatsResponse response);  //review is needed
	static Buffer serializeResponse(GetHighScoreResponse response); //review is needed
	static Buffer serializeResponse(CloseRoomResponse response);
	static Buffer serializeResponse(StartGameResponse response);
	static Buffer serializeResponse(LeaveRoomResponse response);
	static Buffer serializeResponse(GetRoomStateResponse response);

private:

	static Buffer convertIntToFourByte(int size);
	static Buffer serializeResponse(json j, MessageType code);


};

