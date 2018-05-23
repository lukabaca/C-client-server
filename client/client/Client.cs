using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class Client
    {
        private TcpClient clientSocket;


        public Client(String serverIpAddress, int portNumber)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(serverIpAddress, portNumber);
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
