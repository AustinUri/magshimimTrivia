#include "JsonResponsePacketSerializer.h"



Buffer JsonResponsePacketSerializer::serializeResponse(ErrorResponse response)
{
    json j = { { "message", response.msg } };
    return serializeResponse(j, ERROR_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(LoginResponse res)
{
    json j = { { "status", res.status } };
    return serializeResponse(j, LOG_IN_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(SignupResponse res)
{
    json j = { { "status", res.status } };
    return serializeResponse(j, SIGN_UP_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(LogoutResponse response)
{
    json j = { { "status" ,response.status } };
    return serializeResponse(j, LOG_OUT_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse response)
{
    json roomsData;
    for (const auto& room_data : response.rooms)
    {
        json roomJ = { {"ID" , room_data.id}, {"isActive",room_data.isActive} ,{"maxPlayers",room_data.maxPlayers}, {"name",room_data.name}, {"NumQuestions",room_data.NumQuestions}, {"timePerQuestion",room_data.timePerQuestion}};
        roomsData.push_back(roomJ);
    }

    json j = { { "status" , response.status } ,  {"rooms" , roomsData } };
    return serializeResponse(j,GET_ROOMS_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse response)
{
    json j = { {"status",response.status} ,{"PlayersInRoom" , response.players} };
    return serializeResponse(j, GET_PLAYERS_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse response)
{
    json j = { { "status" , response.status } };
    return serializeResponse(j,JOIN_ROOM_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(CreateRoomResponse response)
{
    json j = { { "status" , response.status } };
    return serializeResponse(j, CREATE_ROOM_RESPONSE);
}


//#TODO - with a proper struct

Buffer JsonResponsePacketSerializer::serializeResponse(GetPersonalStatsResponse response) // review is needed , need to ask Tomer
{
    json j = {{ "status" , response.status}, {"statistics",response.statistics}};
    return serializeResponse(j,GET_PERSONAL_STATS_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(GetHighScoreResponse response)
{
    json j = { {"status" , response.status} ,{"highScoress" , response.highScoress} };
    return serializeResponse(j,GET_HIGH_SCORES_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(CloseRoomResponse response)
{
    json j = { {"status",response.status}};
    return serializeResponse(j, CLOSE_ROOM_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(StartGameResponse response)
{
    json j = { {"status" , response.status} };
    return serializeResponse( j,START_GAME_RESPONSE );
}

Buffer JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse response)
{
    json j = { {"status",response.status}};
    return serializeResponse(j,LEAVE_ROOM_RESPONSE);
}

Buffer JsonResponsePacketSerializer::serializeResponse(GetRoomStateResponse response)
{
    json j = { { "status" , response.status }, { "isActive", response.hasGameBegun }, { "players",response.players }, { "NumQuestions",response.questionCount }, { "timePerQuestion",response.answerTimeout } }; //to fix
    return serializeResponse(j, ROOM_STATE_RESPONSE);
}


Buffer JsonResponsePacketSerializer::convertIntToFourByte(int size)
{
    Buffer res;

    res.push_back(size);
    res.push_back(size >> 8);
    res.push_back(size >> 16);
    res.push_back(size >> 24);
    return res;
}

Buffer JsonResponsePacketSerializer::serializeResponse(json j, MessageType code)
{
    Buffer result;
    
    std::string msg = j.dump();
    int size = msg.size();

    //pushing back msg_code
    result.push_back(code);

    //pushing back msg_size
    Buffer sizeBuffer = convertIntToFourByte(size);
    for (unsigned i = 0; i < 4; i++)
    {
        result.push_back(sizeBuffer[i]);
    }

    //pushing back msg
    for (int i = 0; i < size; i++)
    {
        result.push_back(msg[i]);
    }


    return result;


}


