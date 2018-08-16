using System.IO;
using Aspose.Pdf;

namespace TestOCR
{
    internal class Licensing
    {

        public static void LicenseAspose(byte[] licenseFileButeBytes)
        {

            using (var license = new MemoryStream(licenseFileButeBytes))
            {
                new License().SetLicense(license);
            }

        }


    }
}
