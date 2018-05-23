using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using fileTransferSpace;
using System.Runtime.Serialization;

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
            //FileTransfer a = new FileTransfer("ala", "kotek");

            NetworkStream ntwStream = clientSocket.GetStream();//to wydziel jako pole klasy client
            try
            {
                IFormatter formater = bFormatter;
                formater.Serialize(ntwStream, file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
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
