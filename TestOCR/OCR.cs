using System;

namespace TestOCR
{
    public class OCR
    {

        public static string PerformPdfOcr(byte[] fileContentsToOcr)
        {
            return PerformOcr(new AsposePdf(), fileContentsToOcr);
        }

        public static string PerformWordOcr(byte[] fileContentsToOcr)
        {
            return PerformOcr(new AsposeWords(), fileContentsToOcr);
        }


        private static string PerformOcr(IOcrLibrary ocrLibrary, byte[] fileContents)
        {

            ocrLibrary.Initalise();
            return ocrLibrary.PerformOcr(fileContents);

        }

    }
}
