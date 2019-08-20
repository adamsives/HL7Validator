using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class HL7SubSubField : IEnumerator
    {
        public List<string> Field = new List<string>();

        public HL7SubSubField(HL7SubField s)
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