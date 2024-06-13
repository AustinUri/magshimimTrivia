#pragma once
#include "IRequestHandler.h"
#include <string>
#include "StructResponses.h"
struct RequestResult
{
    Buffer buffer;
    IRequestHandler* newHandler;

    RequestResult(Buffer buffer, IRequestHandler* newHandler = nullptr);
    static ErrorResponse error(const std::string err);
};

