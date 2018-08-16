using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace TestOCR
{
    internal class AsposePdf : IOcrLibrary
    {

        public void Initalise()
        {
            Licensing.LicenseAspose(Properties.Resources.Aspose_Total);
        }


        public string PerformOcr(byte[] fileContents)
        {

            using (var ms = new MemoryStream(fileContents))
            {
                using (var pdfDocument = new Document(ms))
                {
                    return GetTextFromPdf(pdfDocument);
                }
            }    

        }


        private static string GetTextFromPdf(Document pdfDocument)
        {

            var textAbsorber = new TextAbsorber();

            pdfDocument.Pages.Accept(textAbsorber);            

            return textAbsorber.Text;

        }
 
    }
}
