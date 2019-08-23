using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    internal class zzzzzHL7Fields : IEnumerable
    {
        public List<string> Fields = new List<string>();

        public zzzzzHL7Fields(zzzzzHL7Segment s)
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