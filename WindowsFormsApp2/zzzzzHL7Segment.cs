using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class zzzzzHL7Segment : IEnumerable
    {
        private string[] MessageStrings;
        public List<string> Segment;
        public List<string> Fields;

        public zzzzzHL7Segment(string hl7Sample)
        {
            //--------------------------list of segments 
            MessageStrings = hl7Sample.Split('\r');

            foreach (string ms in MessageStrings)
            {
                    Segment.Add(ms);
            }

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
