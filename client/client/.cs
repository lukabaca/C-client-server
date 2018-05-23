using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    [Serializable]
    class FileTransfer 
    {
        /*
        private String fileName { get; set; }
        private byte[] file { get; set; }

        public FileTransfer(String fileName, byte[] fileTarget)
        {
            this.fileName = fileName;
            Array.Copy(file, fileTarget, fileTarget.Length);
        }
        */
        String a;
        String b;

        public FileTransfer(String a, String b)
        {
            this.a = a;
            this.b = b;
        }



    }
}
