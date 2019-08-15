using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class HL7Validator
    {

        private static AllCDMCodes allCDMCodes = new AllCDMCodes();
        public List<string> validationReport = new List<string>();//this will create a list of strings that report illegal values in the HL7 message

        public List<string> Validate(SingleHL7Message shl7m, string cdmFilename)
        {
            List<CDMCode> codes = allCDMCodes.AllCodesToBeMapped(cdmFilename);//CDM codes to be mapped for this segment

            try
            {
                foreach (CDMCode code in codes)
                {

                    string segmentField = fields[int.Parse(code.Field)];//----------this try catch is mainly for this being out of bounds.
                    string segmentComponent = fields[Int32.Parse(code.Component)];//this try catch is mainly for this being out of bounds.

                    if (code.Segment == segmentType)
                    {
                        if (segmentField == code.Field & segmentComponent == code.Component)
                        {
                            Console.WriteLine("segmentField == cdmCodeField & segmentComponent == codeComponent");
                            if (code.CodeValue == fields[Int32.Parse(code.Field) - 1])//todo: validate entire range of possible code values for that component
                            {
                                //happy path
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("there has been an exception:"+e.Message);
            }

            return validationReport;
    }
    }
}
