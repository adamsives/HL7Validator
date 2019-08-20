using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Subfield : IEnumerable
    {
        public int SubfieldId { get; set; }
        public Field Field { get; set; }
        public List<string> SubFields { get; set; }
        public int SubfieldFinger { get; set; }
        public List<SubSubfield> SubSubfields { get; set; }

        public Subfield(Field sf)
        {
            foreach (string ss in sf)
            {
                SubSubfields.Add(ss);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
