using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class HL7Messages : System.Collections.IEnumerable
    {

        //Sample HL7 messages
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public string[] messages(string fileName)
        {
            List<string> HL7Messages = new List<string>();
            string HL7MessageBlob = File.ReadAllText(fileName);
            string[] untrimmedHL7Messages = HL7MessageBlob.Split((char)28);//28 = FS File Separator

            foreach(string message in untrimmedHL7Messages)
            {
                HL7Messages.Add(message.Trim());
            }

            string[] messages = HL7Messages.ToArray();

            return messages;
        }
    }
}
