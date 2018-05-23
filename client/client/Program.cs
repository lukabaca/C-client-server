using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fileTransferSpace;
using System.IO;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            String localAddress = "127.0.0.1";
            Client client = new Client(localAddress, 5000);

            //testowo tutaj poki co
            try
            {
                String fileName = "test.txt";
                byte[] bytes = System.IO.File.ReadAllBytes(fileName);

                FileTransfer file = new FileTransfer(fileName, bytes);

                client.sendFile(file);

            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
            }

            //client.sendFile(new FileTransfer("ala", "kotek"));

            Console.ReadLine();
        }
    }
}
