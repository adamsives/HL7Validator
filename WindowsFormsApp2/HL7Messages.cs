using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class HL7Messages
    {
        //Sample HL7 messages
        string HL7MessageBlob; //= File.ReadAllText("C:\\Users\\60190319\\Documents\\2019\\08 August\\06082019\\HL7Sample.hl7");
        
        private void splitmessages()
        {
            string[] HL7Messages = HL7MessageBlob.Split((char)28);
        }
    }
}
