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
        private String fileName;
        private byte[] file;

        public FileTransfer(String fileName, byte[] file)
        {
            this.fileName = fileName;
            //this.file = Arrays.c(file);
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public byte[] File
        {
            get
            {
                return file;
            }

            set
            {
                file = value;
            }
        }

        public object Arrays { get; private set; }
    }
}
