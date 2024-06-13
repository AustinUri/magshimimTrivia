#pragma once
#include "StructResponses.h"
#include "StructesRequests.h"
#include "json.hpp"

using std::string;


using json = nlohmann::json;

class JsonRequestPacketDeserializer
{
public:

	static LoginRequest deserializeLoginRequest(Buffer buf);
	static SignupRequest deserializeSignupRequest(Buffer buf);
	static getPlayersInRoomRequest deserializeGetPlayersInRoomRequest(Buffer buf);
	static JoinRoomRequest deserializeJoinRoomRequest(Buffer buf);
	static createRoomRequest deserializeCreateRoomRequest(Buffer buf);
	
private:


};

