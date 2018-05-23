
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace fileTransferSpace
{

    [Serializable]
    public class FileTransfer
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
        private String a;
        private String b;

        public FileTransfer(String a, String b)
        {
            this.a = a;
            this.b = b;
        }

        public string A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public string B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }
    }
}
