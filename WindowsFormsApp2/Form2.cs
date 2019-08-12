using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AllCDMCodes allCDMCodes = new AllCDMCodes();

            //            List<CDMCode> allCodes = allCDMCodes.CodelistToBeMapped();
            /*
            List<CDMCode> allCodes = allCDMCodes.AllCodesToBeMapped();


            foreach (CDMCode codeAndField in allCodes)
            {
                try
                {
                    //-----------debug
                    MessageBox.Show(codeAndField.Segment, "Segment");
                    MessageBox.Show(codeAndField.Field, "Field");
                    MessageBox.Show(codeAndField.Component, "Component");
                    MessageBox.Show(codeAndField.TextDescription, "Text Description");
                }
                catch (Exception)
                {

                    throw;
                }
                
            };*/

            List<string> allCodesandFields = allCDMCodes.FieldsAndSegmentsToBeMapped();

            foreach (string codeAndField in allCodesandFields)
            {
                try
                {
                    //-----------debug
                    MessageBox.Show(codeAndField, "CodeAndFIeld");
                }
                catch (Exception)
                {

                    throw;
                }

            };
        }
    }
}
