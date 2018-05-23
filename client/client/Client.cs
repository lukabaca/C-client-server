using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using fileTransferSpace;

namespace client
{
    class Client
    {
        private TcpClient clientSocket;
        private BinaryFormatter bFormatter;

        public Client(String serverIpAddress, int portNumber)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(serverIpAddress, portNumber);

            bFormatter = new BinaryFormatter();
        }

        public void sendFile(FileTransfer file)
        {
            FileTransfer a = new FileTransfer("a", "b");

            NetworkStream ntwStream = clientSocket.GetStream();//to wydziel jako pole klasy client

            bFormatter.Serialize(ntwStream, a);
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
