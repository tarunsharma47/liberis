using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liberis
{
    internal class PageObjectClass
    {
        internal static By GetDemoButton = By.XPath("//a[@class='btn btn--medium js-partner-hero-button']");
        internal static By ValidationMessage = By.XPath("//div[@class='ph-error-inner']");
        internal static By GetaDemoHomePage =  By.XPath("//a[@class='btn ']");
        internal static By labelList = By.XPath("//label");
    }
}
