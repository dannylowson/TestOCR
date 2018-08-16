using System;
using System.Collections.Generic;
using System.Text;

namespace TestOCR
{
    internal interface IOcrLibrary
    {

        void Initalise();
        string PerformOcr(byte[] fileContents);

    }
}
