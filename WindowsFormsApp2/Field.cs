using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Field : IEnumerable
    {
        public int FieldId { get; set; }
        public string FieldDescription { get; set; }
        public List<string> Fields { get; set; }
        public Segment Segment { get; set; }
        public List<Subfield> Subfields { get; set; }

        public Field(Segment s) {
            foreach (string f in s) {
                Fields.Add(f);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
