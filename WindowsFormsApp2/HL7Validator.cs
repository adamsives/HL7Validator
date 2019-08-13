using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class HL7Validator
    {

        private static AllCDMCodes allCDMCodes = new AllCDMCodes();


        public List<string> validate(string segment, string segmentType, string cdmFilename, string HL7FileName)
        {
            List<string> validationReport = new List<string>();
            List<string> cdmSegments = allCDMCodes.SegmentsInCDM(cdmFilename);
            List<CDMCode> codes = allCDMCodes.AllCodesToBeMapped(cdmFilename, segmentType);
            
            foreach (CDMCode code in codes)
            {
                string[] fields = segment.Split('|');

                if (code.Segment == segmentType)
                {
                    if (fields[Int32.Parse(code.Field)-1] == code.Field & fields[Int32.Parse(code.Component)-1] == code.Component)//fields[Int32.Parse(code.Component)])
                    {

                        if (code.CodeValue == fields[Int32.Parse(code.Field) - 1])//todo: validate entire range of possible code values for that component
                        {
                            //happy path
                        }
                    }
                }
            }

            return validationReport;
    }
    }
}
