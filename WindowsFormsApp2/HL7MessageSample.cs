using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class HL7MessageSample : System.Collections.IEnumerable
    {
        private string hL7FileName;
        public string [] ParsedSample;

        public HL7MessageSample(string hL7FileName)
        {
            this.hL7FileName = hL7FileName;
            ParsedSample = GenerateMessages(hL7FileName);
        }

        //Sample HL7 messages
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private string[] GenerateMessages(string fileName)
        {
            List<string> HL7Messages = new List<string>();
            string HL7MessageBlob = File.ReadAllText(this.hL7FileName);
            string[] untrimmedHL7Messages = HL7MessageBlob.Split((char)28);//char 28 = FS = File Separator

            foreach(string message in untrimmedHL7Messages)
            {
                HL7Messages.Add(message.Trim());
            }

            string[] messages = HL7Messages.ToArray();

            return messages;
        }
    }
}
