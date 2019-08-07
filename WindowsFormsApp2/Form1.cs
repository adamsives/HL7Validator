using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Sample HL7 messages
        static string HL7MessageBlob = File.ReadAllText("C:\\Users\\60190319\\Documents\\2019\\08 August\\06082019\\HL7Sample.hl7");
        string[] HL7Messages = HL7MessageBlob.Split((char)28);

        public ValidatedPID ValidatedPID { get; private set; }

        //CDM codes
        private string[] getCDMData(string segment, string field, string component)
        {
            string[] lines = File.ReadLines("C:\\Program Files (x86)\\HL7Spy 2.x\\Data\\NSWHEALTH_CMM\\ADT_CDMCodes.txt").ToArray();//---todo: make this .xlsx format
            //----TODO:create a string [] or similar object that handles escape sequences and special characters 
            //a la http://healthstandards.com/blog/2007/09/24/hl7-separator-characters/ _
            //and https://corepointhealth.com/resource-center/hl7-resources/hl7-escape-sequences/
            string sep = "\t";
            List<string> CDMCodeList = new List<string>();

            foreach (string line in lines)
            {
                if (line.Substring(0, 3) == segment)//-------todo:add field and component
                {
                    string[] cdmCodeValue = line.Split(sep.ToCharArray());
                    if (cdmCodeValue[1] == field && cdmCodeValue[2] == component)
                    {
                        CDMCodeList.Add(cdmCodeValue[3].Trim());
                        Console.WriteLine(cdmCodeValue[4].Trim());//---------------------------debug
                    }
                }
            }
            return CDMCodeList.ToArray();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                foreach(string singleHL7Message in HL7Messages)
                {
                    string[] messageSegments = singleHL7Message.Trim((char)11).Split(new char[] { '\r' });

                    foreach (string specificSegment in messageSegments)
                    {
                        if (specificSegment.Length > 3) { 
                            //-----------MSH validation
                            if (specificSegment.Substring(0,3) == "MSH")
                            {
                                string [] field = specificSegment.Split('|');
                                string messageControlID = field[8];
                                if (getCDMData(specificSegment.Substring(0, 3), "4","1").Contains(field[4]))//add 1 to the index to get the HL7 field for MSH ONLY!
                                {
                                    //add messageControlID to a list
                                    //write transgresssion to that list
                                }
                                else
                                {
                                    
                                }
                            }
                        //-----------PID validation
                        if (specificSegment.Substring(0, 3) == "PID")
                            {
                            //ValidatedPID vp = new ValidatedPID(specificSegment, getCDMData(specificSegment.Substring(0, 3), "x", "y")
                            ValidatedPID vp = new ValidatedPID(specificSegment, getCDMData(specificSegment.Substring(0, 3), "3", "4"));
                            }
                        }
                    }
                }
        }
        //TODO:-----------create a report object
        //TODO:
        private void GenerateReport(){

        }

    }
}
