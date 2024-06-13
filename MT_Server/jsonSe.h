#pragma once
#include "StructResponses.h"
#include "json.hpp"
#include <map>
using json = nlohmann::json;


class jsonSe
{
public:
    static std::vector<unsigned char> serializeResponse(const GetPersonalStatsResponse& response) {
        json j;
        j["status"] = response.status;
        j["userName"] = response.userName;
        j["avgAnswerTime"] = response.avgAnswerTime;
        j["correctAnswers"] = response.correctAnswers;
        j["totalAnswers"] = response.totalAnswers;
        j["numOfGames"] = response.numOfGames;
        j["score"] = response.score;

        std::string serializedString = j.dump();
        std::vector<unsigned char> serializedBuffer(serializedString.begin(), serializedString.end());
        return serializedBuffer;
    }
};

