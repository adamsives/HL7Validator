using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    internal class HL7Field : IEnumerator
    {
        public List<string> Field = new List<string>();

        public HL7Field(HL7Fields s)
        {
            foreach (string r in s)
            {
                Field.Add(r);
            }
        }

        public object Current => throw new System.NotImplementedException();

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}