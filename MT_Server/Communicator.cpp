#include "Communicator.h"
#include <exception>
#include <string>
#include <vector>
#include <thread>
#include "LoginRequestHandler.h"
#include "JsonResponsePacketSerializer.h"
#include <iostream>
#include "RequestResult.h"


Communicator::Communicator(RequestHandlerFactory* factory) : m_factory(factory) 
{

	 //this server use TCP. that why SOCK_STREAM & IPPROTO_TCP
	 //if the server use UDP we will use: SOCK_DGRAM & IPPROTO_UDP
	_serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

	if (_serverSocket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__ " - socket");
}

Communicator::~Communicator()
{
	try
	{
		// the only use of the destructor should be for freeing 
		 //resources that was allocated in the constructor
		closesocket(_serverSocket);
	}
	catch (...) {}
}

void Communicator::bindAndListen()
{
	struct sockaddr_in sa = { 0 };

	sa.sin_port = htons(PORT); // port that server will listen for
	sa.sin_family = AF_INET;   // must be AF_INET
	sa.sin_addr.s_addr = INADDR_ANY;    // when there are few ip's for the machine. We will use always "INADDR_ANY"

	//Connects between the socket and the configuration (port and etc..)
	if (bind(_serverSocket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");

	//Start listening for incoming requests of clients
	if (listen(_serverSocket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - listen");
	std::cout << "Listening on port " << PORT << std::endl;
	
}




void Communicator::acceptClient()
{

	//this accepts the client and create a specific socket from server to this client
	//the process will not continue until a client connects to the server
	SOCKET client_socket = accept(_serverSocket, NULL, NULL);
	if (client_socket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__);

	std::cout << "Client accepted. Server and client can speak" << std::endl;
	//the function that handle the conversation with the client
	std::thread clientH(&Communicator::clientHandler, this, client_socket);
	clientH.detach();

	this->m_clients[client_socket] = this->m_factory->createLoginRequestHandler();

}


void Communicator::clientHandler(SOCKET clientSocket) 
{
	try
	{
		RequestInfo info;

		char code;
		char lenBuffer[4];
		int bytesReadFromSocket = 0;
		while (bytesReadFromSocket != SOCKET_ERROR) 
		{
			bytesReadFromSocket = recv(clientSocket, &code, 1, 0);
			if (bytesReadFromSocket <= 0)
			{
				throw std::exception("Connection error");
			}
			info.RequestID = code;

			bytesReadFromSocket = recv(clientSocket, lenBuffer, 4, 0);
			if (bytesReadFromSocket <= 0)
			{
				throw std::exception("Connection error");
			}

			int len = Helper::fromBinaryToint(lenBuffer);

			char* temp = new char[len];
			bytesReadFromSocket = recv(clientSocket, temp, len, 0); // length

			if (bytesReadFromSocket <= 0)
			{
				throw std::exception("Connection error");
			}
			std::vector<char> buf(temp, temp + len);
			delete[] temp;

			info.buffer = buf;

			if (this->m_clients[clientSocket]->isReqRelevent(info))
			{
				RequestResult res = this->m_clients[clientSocket]->handleRequest(info);
				send(clientSocket, res.buffer.data(), res.buffer.size(), 0);

				delete this->m_clients[clientSocket];
				if(res.newHandler != nullptr) //not always need a new handler
				{ 
					this->m_clients[clientSocket] = res.newHandler;
				}
				else
				{
					res.error("Handler error");
					send(clientSocket, res.buffer.data(), res.buffer.size(), 0);
					throw std::exception("invalid code");
				}
			}
			else
			{
				//send error responce
				ErrorResponse error = RequestResult::error("Invalid code");
				Buffer buf = JsonResponsePacketSerializer::serializeResponse(error);
				send(clientSocket, buf.data(), buf.size(), 0);
				throw std::exception("req isn't relevent\n");
			}
		}
	}
	catch (const std::exception& e) {
		std::cout << e.what() << std::endl;
		this->m_clients.erase(clientSocket);
		//this->m_factory->getLoginManager().logout(); need to somehow logout so he can reconnect if he wants...
		closesocket(clientSocket);
	}
}

void Communicator::messageHandler() {
	bindAndListen();
	while (true)
	{
		//the main thread is only accepting clients 
		//and add then to the list of handlers
		std::cout << "Waiting for client connection request" << std::endl;
		acceptClient();
	}
}

IRequestHandler* Communicator::getCurrHandler(SOCKET client_socket)
{
	return this->m_clients[client_socket];
}








