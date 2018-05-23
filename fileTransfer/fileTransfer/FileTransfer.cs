
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

        private String fileName;
        private byte[] file;

        public FileTransfer(String fileName, byte[] fileTarget)
        {
            this.fileName = fileName;
            //this.file = new Byte[fileTarget.Length];
            this.file = fileTarget.ToArray();
            //Array.Copy(file, fileTarget, fileTarget.Length);
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

        
        
       
        
    }
}
