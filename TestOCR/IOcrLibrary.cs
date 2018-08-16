using System;
using System.Collections.Generic;
using System.Text;

namespace TestOCR
{
    interface IOcrLibrary
    {

        void Initalise();
        string PerformOcr(byte[] fileContents);

    }
}
