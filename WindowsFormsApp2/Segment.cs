using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Segment : IEnumerable
    {
        public List<string> Segments { get; set; }
        public List<Field> Fields { get; set; }

        private string[] SegmentStrings;

        public Segment(string hl7Sample)
        {
            //--------------------------list of segments 
            SegmentStrings = hl7Sample.Split('\r');

            Field segs = new Field(ms);

            foreach (string ms in SegmentStrings)
            {
                //Add content of each field of segment to the Field.description
                Segments.Add(ms);
            }


            Fields = segs.Fields;

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

