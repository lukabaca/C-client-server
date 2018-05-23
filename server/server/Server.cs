using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace server
{
    class Server
    {
        private int serverPort;
        private IPAddress serverAddr;

        private TcpListener serverSocket;


        private Boolean isRunning;

        public Server(String serverAddress, int serverPort)
        {
            this.serverPort = serverPort;
            this.serverAddr = IPAddress.Parse(serverAddress);

            this.serverSocket = new TcpListener(serverAddr, serverPort);
            this.serverSocket.Start();

            this.isRunning = true;

            Console.WriteLine("Server is working at port: " + serverPort);

            waitForClients();
        }

        private void waitForClients()
        {
            while(isRunning)
            {
                Console.WriteLine("Server is waiting for clients...");
                TcpClient client = serverSocket.AcceptTcpClient();
                Console.WriteLine("Client was found: ");
                
                Thread thread = new Thread(() => handleClient(client));
                thread.Start();
                
            }

            serverSocket.Stop();
        }

        private void handleClient(TcpClient client)
        {
            Console.WriteLine("TU zrob obsluge clienta poszczegolnego");
            TcpClient newClient = client;
        }
    }
}
