using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace fileTransferSpace
{
    public class CustomFormatter
    {
        private IFormatter formater;

        public CustomFormatter()
        {
            this.formater = new BinaryFormatter();
        }

        public FileTransfer deserialize(NetworkStream networkStream)
        {
            FileTransfer file = null;
            try
            {
                file = (FileTransfer)formater.Deserialize(networkStream);
                return file;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }

        public Boolean serialize(NetworkStream networkStream, FileTransfer file)
        {
            
            try
            {
                formater.Serialize(networkStream, file);
                Console.WriteLine("A file with filename: " + file.FileName + " has been serialized");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Serializing was not succesful");
                return false;
            }
            
        }

    }
}
