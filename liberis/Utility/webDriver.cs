using OpenQA.Selenium.Chrome;
using System;

namespace liberis
{
    internal class webDriver : PageObjectClass
    {
        static String driverPath = @"liberis\dependencies";
        internal static ChromeDriver driver = new ChromeDriver(driverPath);
    }
}
