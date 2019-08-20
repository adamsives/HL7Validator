using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class SubSubfield : IEnumerable
    {
        public int SubfieldId { get; set; }
        public Field Field { get; set; }
        public List<string> SubSubFields { get; set; }
        public int SubfieldFinger { get; set; }

        public SubSubfield(Subfield sf)
        {
            foreach (string s in sf)
            {
                SubSubFields.Add(s);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
