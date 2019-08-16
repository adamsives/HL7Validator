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
        public List<string[]> Segments;//e.g. MSH, MRG
        public List<string[]> Fields;//e.g. MSH 4
        public List<string> SubFields;//e.g. MSH 4.3
        public string[] SubSubFields;//e.g MSH 4.3&3
        public int [] RepetitionIndices;//e.g. MSH 4.3 first instance, MSH 4.3 n instance, MSH 4.3 n+1 instance
        public string FieldValue;//e.e PID 3.4 = "X550"

        public string[][] MSH;
        public string[][] EVN;
        public string[][] PID;
        public string[][] PD1;
        public string[][] ROL;
        public string[][] PV1;
        public string[][] PV2;
        public string[][] ZPV;
        public string[][] ZRL;



        // Public constructor.
        public HL7Message(string hl7Sample)
        {
            //--------------------------list of segments 
            string[] messageStrings = hl7Sample.Split('\r');

            #region Segment List
            //--------------------------list of segment names
            List<string> segmentsList = new List<string>();
            int i = 0;
            foreach (string ms in segmentsList)
            {
                segmentsList.Add(ms[i].ToString().Substring(0, 3));
                i++;
            }
            i = 0;

            SegmentsList = segmentsList; 
            #endregion

            //--------------------------fields for each segment
            foreach (string ms in messageStrings) {

                string segmentName = ms.Substring(0, 3);

                    switch (segmentName)
                    {
                    case "MSH":
                        MSH = ParseSegment(ms);
                            break;
                    case "EVN":
                        EVN = ParseSegment(ms);
                        break;
                    case "PID":
                        PID = ParseSegment(ms);
                        break;
                    case "PD1":
                        PD1 = ParseSegment(ms);
                        break;
                    case "ROL":
                        ROL = ParseSegment(ms);
                        break;
                    case "PV1":
                        PV1 = ParseSegment(ms);
                        break;
                    case "PV2":
                        PV1 = ParseSegment(ms);
                        break;
                    default:
                        Console.WriteLine("Out of scope message segment detected:"+ ParseSegment(ms));
                    break;
                    }

                }
            //---todo: add fields to this segment
        }

        private string [] [] ParseSegment(string ms)
        {
            int i = 0;
            string[] segmentFields = ms.Split('|');//fields for this segment
            List<string> subFields = new List<string>();
            int arrayLength = segmentFields.Length;
            string[,] fieldAndIndex = new string[arrayLength,1];

            foreach (string field in segmentFields)
            {
                fieldAndIndex
            }
            throw new NotImplementedException();
        }

        private string[] SplitSubfields(string s)
        {
            //handle subfields
            int i = 0;
            string[] subFields = s.Split('~');
            return subFields;
        }

        private string[] SplitSubSubFields(string subField)
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
}
