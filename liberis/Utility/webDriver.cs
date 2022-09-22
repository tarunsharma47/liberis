using OpenQA.Selenium.Chrome;
using System;

namespace liberis
{
    internal class webDriver : PageObjectClass
    {
        //static String driverPath = @"liberis\dependencies";
        static String driverPath = @"C:\Users\tarun\source\repos\.NET\liberis\liberis\dependencies";
        internal static ChromeDriver driver = new ChromeDriver(driverPath);
    }
}
