using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
