#include "Server.h"
#include "SqliteDatabase.h"
#include "statisticsManager.h" //test

Server::Server() 
{
	this->m_DB = new SqliteDatabase();
	this->m_factory = new RequestHandlerFactory(this->m_DB);
	this->m_communicator = new Communicator(this->m_factory);

}

Server::~Server()
{
	delete(this->m_DB);
	delete(this->m_factory);
	delete(this->m_communicator);

}

void Server::run()
{

	std::thread messageH(&Communicator::messageHandler, this->m_communicator);
	messageH.detach();


	std::cout << "Enter command" << std::endl;
	std::string con = "";
	std::cout << std::endl;
	while (con != "EXIT") //con
	{
		std::cout << "Enter command" << std::endl;
		std::cin >> con;
		std::cout << std::endl;
		if (con == "test")
		{
			StatisticsData data = this->m_factory->getStatisticsManager().getUserStats("URI");
			this->m_DB->getHighScores();
		}
	}


}
