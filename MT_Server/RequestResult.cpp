#include "RequestResult.h"

RequestResult::RequestResult(Buffer buffer, IRequestHandler* newHandler)
    : buffer(buffer), newHandler(newHandler)
{}


ErrorResponse RequestResult::error(const std::string err) {
    return ErrorResponse{ err };
}