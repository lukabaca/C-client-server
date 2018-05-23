using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using fileTransferSpace;
using System.Text;

namespace server
{
    class Server
    {
        private int serverPort;
        private IPAddress serverAddr;
        private BinaryFormatter bFormatter;
        private TcpListener serverSocket;


        private Boolean isRunning;

        public Server(String serverAddress, int serverPort)
        {
            this.serverPort = serverPort;
            this.serverAddr = IPAddress.Parse(serverAddress);

            this.serverSocket = new TcpListener(serverAddr, serverPort);
            this.serverSocket.Start();

            this.isRunning = true;
            this.bFormatter = new BinaryFormatter();

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
            //TcpClient newClient = client;
            try
            {
                //NetworkStream ntwStream = client.G
                IFormatter formater = bFormatter;
                FileTransfer file = (FileTransfer) formater.Deserialize(client.GetStream());

                Console.WriteLine(file.FileName);
                Console.WriteLine(Encoding.UTF8.GetString(file.File));
                try
                {
                    System.IO.File.WriteAllBytes(file.FileName, file.File);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Writing to the file was not succesful");
                    Console.WriteLine(e);
                }

                //Console.WriteLine(file.B);


            }
            catch(Exception e)
            {
                Console.WriteLine("Error in server side when deserializating");
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
