using iTextSharp.text.pdf;
using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.GlobalUtilities
{
    public static class PDFStampTemplates
    {
        public static void Stamp(string filepath, MemoryStream ms, PERSONNEL_DATA owner)
        {
            PdfReader pdfReader = new PdfReader(filepath);

            using (PdfStamper pdfStamper = new PdfStamper(pdfReader, ms))
            {
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                pdfFormFields.SetField("1 NAME Last First Middle", owner.LAST_NAME + ", " + owner.FIRST_NAME + " " + owner.MIDDLE_NAME);
                pdfFormFields.SetField("2 RANK", owner.RANK);
                pdfFormFields.SetField("3 DOD ID NUMBER", owner.DOD_NUMBER);
                pdfFormFields.SetField("4 ORGANIZATION", owner.ORGANIZATION); //ask about this
                pdfFormFields.SetField("5 SEX", owner.SEX);
                pdfFormFields.SetField("6 HEIGHT", owner.WEIGHT);
                pdfFormFields.SetField("7 WEIGHT", owner.WEIGHT);
                pdfFormFields.SetField("8 EYE COLOR", owner.EYE_COLOR);
                pdfFormFields.SetField("9 HAIR COLOR", owner.HAIR_COLOR);
                pdfFormFields.SetField("10 PLACE OF BIRTH City and State", owner.PLACE_OF_BIRTH);
                pdfFormFields.SetField("11 DOB YYYYMMMDD", owner.DOB.Year.ToString() + owner.DOB.Month.ToString() + owner.DOB.Day.ToString());
                pdfFormFields.SetField("12 STATE OF ISSUE", owner.CIVILIAN_LIC_STATE);
                pdfFormFields.SetField("13 LICENSE NUMBER", owner.CIVILIAN_LIC_NUMBER);
                pdfFormFields.SetField("14 ISSUE DATE MMDDYYYY", owner.CIVILIAN_ISSUE_DATE.Month.ToString() + "/" + owner.CIVILIAN_ISSUE_DATE.Day.ToString() + "/" + owner.CIVILIAN_ISSUE_DATE.Year.ToString());
                pdfFormFields.SetField("15 EXP DATE MMDDYYYY", owner.CIVILIAN_EXP_DATE.Month.ToString() + "/" + owner.CIVILIAN_EXP_DATE.Day.ToString() + "/" + owner.CIVILIAN_EXP_DATE.Year.ToString());
                pdfFormFields.SetField("16 CLASS OF VEHICLE", owner.CLASS_OF_VEHICLE);

                pdfStamper.FormFlattening = false;

            }
        }
    }
}
