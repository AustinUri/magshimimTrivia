#pragma once
#include <ctime>
#include <vector>
#include "sqlite3.h"
#include "Utils.h"
#include <chrono>


struct RequestInfo
{
    int RequestID;
    std::chrono::system_clock::time_point recivalTime;
    Buffer buffer;
};

struct RequestResult; // foword declaration

class IRequestHandler
{
public:
    virtual ~IRequestHandler() = default;
	virtual bool isReqRelevent(RequestInfo info) = 0;
	virtual RequestResult handleRequest(RequestInfo info) = 0;
};


