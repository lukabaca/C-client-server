﻿using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using fileTransferSpace;
using System.Runtime.Serialization;

namespace client
{
    class Client
    {
        private TcpClient clientSocket;
        private CustomFormatter formatter;

        public Client()
        {
            clientSocket = new TcpClient();

            formatter = new CustomFormatter();
        }

        public Boolean connectToServer(String serverIpAddress, int portNumber)
        {
            try
            {
                clientSocket.Connect(serverIpAddress, portNumber);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured while connecting to server");
                return false;
            }
        }

        public void sendFile(FileTransfer file)
        {
            
            NetworkStream ntwStream = clientSocket.GetStream();//to wydziel jako pole klasy client
            if (formatter.serialize(ntwStream, file))
            {
                Console.WriteLine("A file with filename: " + file.FileName + " has been sent");
            }
        }

        public TcpClient SocketForServer
        {
            get
            {
                return clientSocket;
            }

            set
            {
                clientSocket = value;
            }
        }
    }
}
