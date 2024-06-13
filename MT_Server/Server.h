#pragma once

#include <WinSock2.h>
#include <Windows.h>
#include <thread>
#include <mutex>
#include <queue>
#include <map>
#include <vector>
#include <fstream>
#include <sstream>
#include <exception>
#include <iostream>
#include "IRequestHandler.h"
#include "Communicator.h"
#include "IDatabase.h"
#include "RequestHandlerFactory.h"

class Server
{
public:
	Server();
	~Server();
	void run();

private:
	RequestHandlerFactory* m_factory;
	Communicator* m_communicator;
	IDatabase* m_DB;
};
