#pragma once
#include <map>
#include "IRequestHandler.h"
#include <mutex>
#include <thread>
#include <WinSock2.h>
#include "Message.h"
#include "RequestHandlerFactory.h" 


#define PORT 7722

class Communicator
{
private:
	SOCKET _serverSocket;
	std::map<SOCKET, IRequestHandler*> m_clients;
	void clientHandler(SOCKET clientSocket);
	std::mutex _queueMutex;
	void acceptClient();
	RequestHandlerFactory* m_factory;
public:
	Communicator(RequestHandlerFactory* factory);
	~Communicator();
	void bindAndListen();
	void messageHandler();
	IRequestHandler* getCurrHandler(SOCKET client_socket);


};


