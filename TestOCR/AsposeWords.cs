using System.IO;
using Aspose.Words;

namespace TestOCR
{
    internal class AsposeWords : IOcrLibrary     
    {
        public void Initalise()
        {
            Licensing.LicenseAspose(Properties.Resources.Aspose_Total);
        }

        public string PerformOcr(byte[] fileContents)
        {

            using (var ms = new MemoryStream(fileContents))
            {
                return GetTextFromWordDocument(new Document(ms));
            }

        }


        private static string GetTextFromWordDocument(Document wordDocument)
        {
            return wordDocument.ToString(SaveFormat.Text);
        }

    }
}
