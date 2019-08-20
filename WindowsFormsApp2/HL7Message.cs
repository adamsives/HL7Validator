using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class HL7Message
    {
        public int HL7MessageId { get; set; }
        public string HL7MessageName { get; set; }

        public Segment Segments { get; set; }
        public Field Fields { get; set; }
        public Subfield Subfields { get; set; }
        public SubSubfield SubSubfields { get; set; }

        // Public constructor.
        public HL7Message(string msgTxt) {
            Segment segs = new Segment(msgTxt);
            Segments = segs;

            Field field = new Field(segs);
            Fields = field;

            Subfield subfield = new Subfield(field);
            Subfields = subfield;

            SubSubfield subSubfield = new SubSubfield(subfield);
            SubSubfields = subSubfield;
        }
    }
}
/*
        public HL7Message(string hl7Sample, string semgentName, string fieldName)
        {
            HL7Field f = new Hl7Field(hl7Sample, semgentName, fieldName);
            Field = f.ToString();

        }

        private List<string> ParseSegment(string ms)
        {
            string[] segmentFields = ms.Split('|');//fields for this segment
            int arrayLength = segmentFields.Length;
            List<List<string>> fieldAndIndex = new List<List<string>>();

            foreach (string field in segmentFields)
            {

                //handle ~
                if (field.Contains('~'))
                {
                    List<string> fieldRepeat = ParseFieldRepeat(field);
                    fieldAndIndex.Add(fieldRepeat);
                }
                else
                {
                    List<string> fieldsInSubfields = new List<string>();
                    fieldsInSubfields.Add(field);
                    fieldAndIndex.Add(fieldsInSubfields);
                }

                //handle ^
                if (field.Contains('^'))
                {
                    List<string> fieldsInSubfields = ParseField(field);
                    fieldAndIndex.Add(fieldsInSubfields);
                }
                else
                {
                    List<string> fieldsInSubfields = new List<string>();
                    fieldsInSubfields.Add(field);
                    fieldAndIndex.Add(fieldsInSubfields);
                }


                //handle &
                //handle \
            }

        }

        private List<string> ParseFieldRepeat(string field)
        {
            string[]repeatedFieldsBlob = field.Split('~');//repeated fields for this field
            List<string> repeatedFields = new List<string>();

            foreach (string repeat in repeatedFieldsBlob)
            {
                repeatedFields.Add(repeat);
            }

            repeatedFields.Insert(0, "N/A");

            return repeatedFields;
        }

        private List<string> ParseField(string field)
        {
            string[] subFieldsBlob = field.Split('^');//subields for this field
            List<string> subfields = new List<string>();

            foreach (string subField in subFieldsBlob)
            {
                subfields.Add(subField);
            }

            subfields.Insert(0, "N/A");

            return subfields;
        }

        private string[] SplitSubfields(string s)
        {
            //handle field repeats
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
    8?
    }
}
