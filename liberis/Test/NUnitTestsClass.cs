using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace liberis.Test
{
    [TestFixture]
    internal class NUnitTestsClass : webDriver
    {
        [OneTimeSetUp]
        public void Setup()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [Test]
        public void OpenGetDemoPage()
        {
            try
            {
                driver.Url = "https://www.liberis.com/";
                driver.FindElement(GetaDemoHomePage).Click();
                Console.WriteLine("Get demo page opened");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception encountered, test failed");
                Assert.Fail("Exception encountered, test failed");
            }
        }
        [Test]
        public void VerifyPartnerSelectionPage()
        {
            bool flag = false;
            if (driver.Url.Equals("https://www.liberis.com/become-a-partner"))
            {
                Console.WriteLine("Partner's page");
                var elementList = driver.FindElements(labelList);
                if (elementList[0].GetAttribute("for").Equals("I'm a Broker"))
                {
                    Console.WriteLine("\"I'm a Broker element\" verified");
                }
                else { flag = true; }

                if (elementList[1].GetAttribute("for").Equals("I'm an ISO"))
                {
                    Console.WriteLine("\"I'm an ISO\" verified");
                }
                else { flag = true; }

                if (elementList[2].GetAttribute("for").Equals("I'm a Strategic Partner"))
                {
                    Console.WriteLine("\"I'm a Strategic Partner\" verified");
                }
                else { flag = true; }
            }
            else { flag = true; }

            if (flag)
            {
                Console.WriteLine("Partner Selection page verification failed");
                Assert.Fail("Partner Selection page verification failed");
            }
        }

        [Test]
        public void VerifyValidationMessage()
        {
            if (driver.Url.Equals("https://www.liberis.com/become-a-partner"))
            {
                try
                {
                    driver.FindElement(GetDemoButton).Click();
                    try
                    {
                        driver.FindElement(ValidationMessage);
                        Console.WriteLine("Validation message verified");
                    }
                    catch (NoSuchElementException)
                    {
                        Assert.Fail("Validation message not found, test failed");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Validation message verification failed");
                    Assert.Fail("Validation message verification failed");
                }

            }
            else
            {
                Console.WriteLine("Driver is not on the required page, Test failed");
                Assert.Fail("Driver is not on the required page, Test failed");
            }
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            driver.Close();
        }
    }
}
