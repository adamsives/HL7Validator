using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    class AllCDMCodes : System.Collections.IEnumerable
    {
        public List<CDMCode> CDMCodes = new List<CDMCode>();
        private static string fileLocation = "C:\\Program Files (x86)\\HL7Spy 2.x\\Data\\NSWHEALTH_CMM\\ADT_CDMCodes.txt";//---todo: make this .xlsx format
        private string[] CDMCodeLines = File.ReadLines(fileLocation).ToArray();
        public List<string> FieldsAndSegments = new List<string>();

        public AllCDMCodes()
        {

        }

        public List<CDMCode> AllCodesToBeMapped()
        {
            foreach (string CDMCodeLine in CDMCodeLines)
            {
                CDMCode currentCDMCode = new CDMCode();
                string[] CDMCodeLineArray = CDMCodeLine.Split('\t').ToArray();
                currentCDMCode.Segment = CDMCodeLineArray[0];
                currentCDMCode.Field = CDMCodeLineArray[1];
                currentCDMCode.Component = CDMCodeLineArray[2];
                currentCDMCode.TextDescription = CDMCodeLineArray[3];
                CDMCodes.Add(currentCDMCode);
            }
            return CDMCodes;
        }

        public List<string> FieldsAndSegmentsToBeMapped()
        {
            foreach (string CDMCodeLine in CDMCodeLines)
            {
                List<string> codeAdndFieldSet = new List<string>();
                string[] CDMCodeLineArray = CDMCodeLine.Split('\t').ToArray();
                if (!FieldsAndSegments.Contains((CDMCodeLineArray[0] + CDMCodeLineArray[1] + CDMCodeLineArray[2])))
                {
                    FieldsAndSegments.Add(CDMCodeLineArray[0] + CDMCodeLineArray[1] + CDMCodeLineArray[2]);

                }
            }
            return FieldsAndSegments;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)CDMCodes).GetEnumerator();
        }
    }
}

