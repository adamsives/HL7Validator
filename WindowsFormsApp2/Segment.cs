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
        public int SegmentId { get; set; }
        public string SegmentName { get; set; }
        public List<string> Segments { get; set; }
        public List<Field> Fields { get; set; }

        private string[] MessageStrings;

        public Segment(string hl7Sample)
        {
            //--------------------------list of segments 
            MessageStrings = hl7Sample.Split('\r');

            foreach (string ms in MessageStrings)
            {
                //Add content of each field of segment to the Field.description
                Segments.Add(ms);
            }

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

