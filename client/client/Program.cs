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
            Client client = new Client();
            if(!client.connectToServer(localAddress, 5000))
            {
                Console.ReadLine();
                return;
            }

            String fileName = "test.txt";

            try
            {

                

                byte[] bytes = System.IO.File.ReadAllBytes(fileName);
                //Console.WriteLine(Encoding.UTF8.GetString(bytes));

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
