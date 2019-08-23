using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class HL7Message
    {

        public List<string> Segments { get; set; }

        // Public constructor.
        public HL7Message(string msgTxt) {//--------------takes raw text of HL7 message
            Segment segs = new Segment(msgTxt);
            Segments = segs.Segments;
        }
    }
}
