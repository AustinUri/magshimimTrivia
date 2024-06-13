#include "JsonRequestPacketDeserializer.h"

LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(Buffer buf)
{
	nlohmann::json jsonData = nlohmann::json::parse(buf);
	
	LoginRequest resShmolik;

	resShmolik.name = jsonData["username"].get<std::string>();
	resShmolik.password = jsonData["password"].get<std::string>();

	return resShmolik;
}

SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(Buffer buf)
{
	nlohmann::json jsonData = nlohmann::json::parse(buf);


	SignupRequest resShmolik;

	resShmolik.name = jsonData["username"].get<std::string>();
	resShmolik.password = jsonData["password"].get<std::string>();
	resShmolik.mail = jsonData["mail"].get<std::string>();

	return resShmolik;

}

getPlayersInRoomRequest JsonRequestPacketDeserializer::deserializeGetPlayersInRoomRequest(Buffer buf)
{
	nlohmann::json jsonData = nlohmann::json::parse(buf);
	return getPlayersInRoomRequest{ jsonData["roomID"].get<unsigned>() };
}

JoinRoomRequest JsonRequestPacketDeserializer::deserializeJoinRoomRequest(Buffer buf)
{
	nlohmann::json jsonData = nlohmann::json::parse(buf);
	return JoinRoomRequest{ jsonData["roomID"].get<unsigned>() };
}

createRoomRequest JsonRequestPacketDeserializer::deserializeCreateRoomRequest(Buffer buf)
{
	nlohmann::json jsonData = nlohmann::json::parse(buf);
	if (jsonData.contains("name") && jsonData.contains("max_players") && jsonData.contains("question_count") && jsonData.contains("time_to_answer"))
	{
		return createRoomRequest{ jsonData["name"].get<std::string>(),jsonData["max_players"].get<unsigned>(),jsonData["question_count"].get<unsigned>(),jsonData["time_to_answer"].get<unsigned>() };
	}
	else
	{
		throw std::exception("Json data invalid");
	}
}

