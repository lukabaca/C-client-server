using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fileTransferSpace;
namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            String localAddress = "127.0.0.1";
            Client client = new Client(localAddress, 5000);

            client.sendFile(new FileTransfer("ala", "kotek"));

            Console.ReadLine();
        }
    }
}
