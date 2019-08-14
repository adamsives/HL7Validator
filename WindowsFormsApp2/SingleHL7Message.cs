using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class SingleHL7Message
    {
        private string segmentName;
        private string segment;
        private string [] field;
        private string [] component;
        //todo: repeatigng fields??? e.g. different identifier types? test for ~ character

        //this class parses a string and splits it into
        //segments, which have 
        //-----------------one or many fields, which
        //-----------------have 1 or many sets of components
        //-----------------Each set may repeat 0 or many times

        //--------accept string

        public string Segment(){

            return segment;
        }

        public string SegmentName()
        {

            return segmentName;
        }

        public string [] Field()
        {
            //split segment on '|'
            //check for field repeats
            return field;
        }

        public string[] Commponent()
        {

            return component;
        }


    }
}
