using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    internal class zzzzzHL7SubField : IEnumerable
    {
        public List<string> Field = new List<string>();

        public zzzzzHL7SubField(zzzzzHL7Field s)
        {
            foreach (string r in s)
            {
                Field.Add(r);
            }
        }

        public object Current => throw new System.NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

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