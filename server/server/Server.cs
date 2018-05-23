using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server
{
    class Server
    {
        private int serverPort;
        private TcpListener serverSocket;
        private Boolean isRunning;

        public Server(int serverPort)
        {
            this.serverPort = serverPort;

            this.serverSocket = new TcpListener(serverPort);
            this.serverSocket.Start();

            this.isRunning = true;

            Console.WriteLine("Server is working at port: " + serverPort);
        }

        private void waitForClients()
        {
            while(isRunning)
            {
                Console.WriteLine("Server is waiting for clients...");
                TcpClient client = serverSocket.AcceptTcpClient();
                Console.WriteLine("Client was found: ");
                Thread thread = new Thread(handleClient);
                thread.Start(client);

            }

            serverSocket.Stop();
        }

        private void handleClient(TcpClient client)
        {
            TcpClient newClient = client;
        }
    }
}
