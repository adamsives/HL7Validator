using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    internal class HL7Fields : IEnumerable
    {
        public List<string> Fields = new List<string>();

        public HL7Fields(HL7Segment s)
        {
            foreach (string r in s)
            {
                Fields.Add(r);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Fields).GetEnumerator();
        }
    }
}