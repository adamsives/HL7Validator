using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class HL7Message
    {
        public List<string> SegmentsList;//e.g. MSH, MRG
        public string [] Segments;//e.g. MSH, MRG
        public List<string> Fields;//e.g. MSH 4
        public string[] SubFields;//e.g. MSH 4.3
        public string[] SubSubFields;//e.g MSH 4.3&3
        public int [] RepetitionIndices;//e.g. MSH 4.3 first instance, MSH 4.3 n instance, MSH 4.3 n+1 instance
        public string ComponentValue;//e.e PID 3.4 = "X550"


        // Public constructor.
        public HL7Message(string hl7String)
        {
            //--------------------------list of segments 
            string[] segments = hl7String.Split('\r');
            Segments = segments;

            //--------------------------list of segment names
            List<string> segmentsList = new List<string>();

            foreach (string ms in segmentsList)
            {
                segmentsList.Add(ms[0].ToString());
            }

            SegmentsList = segmentsList;

            //--------------------------fields for each segment
            int i = 0;
            foreach (string s in segments) {
                string[] fields = s.Split('|');
                Fields.Add(fields[i]);
                i++;
                }

            //--------------------------subfield for each field            
            foreach (string s in Fields) {
                if (s.Contains("~"))
                {
                    //handle subfields
                    int j = 0;
                    string[] subields = s.Split('~');
                    
                    foreach (string ss in subields) {
                        //handle subSubFields in a separate method
                        if (ss.Contains("&")) {
                            string [] subSubField = HandleSubSubFields(ss);
                            //add subSubField to this subfield instance
                        }


                        //repeat index
                        //value for sub sub field

                    }
                }
                else
                {

                }
            }

        }

        private string[] HandleSubSubFields(string subField)
        {
            string[] sf = subField.Split('&');
            List<string> subSubFields = new List<string>();

            foreach (string ssf in sf)
            {
                subSubFields.Add(ssf);
            }

            return subSubFields.ToArray();
        }
    }



        public List<string> GetSegments(string hl7String)
        {
            string[] messageSegments = hl7String.Split('\r');
            return segments;
        }

        public string[] GetFields() {
            int i = 0;
            foreach (string s in this.segments)
            {
                string[] fields = s.Split('|');
                i++;
            }

            return fields;
        }

        public string[] GetSubFields()
        {
            int i = 0;

            foreach (string f in this.fields)
            {
                string[] fields = f.Split('^');
                i++;
            }

            return fields;
        }
    }
}
