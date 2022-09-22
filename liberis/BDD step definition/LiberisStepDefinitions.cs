using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace liberis
{
    [Binding]
    internal class LiberisStepDefinitions : webDriver
    {
        [Given(@"Set implicit wait on the driver")]
        public void GivenSetImplicitWaitOnTheDriver()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Given(@"I'm on Become a partner page")]
        public void GivenImOnBecomeAPartnerPage()
        {
            try
            {
                driver.Url = "https://www.liberis.com/become-a-partner";
            }
            catch (Exception)
            {
                Assert.Fail("Failed to open become a partner page");
            }
        }

        [When(@"I select ""([^""]*)"" button")]
        public void WhenISelectButton(string button)
        {
            driver.FindElement(By.XPath($"//label[@for=\"{button}\"]")).Click();
        }

        [When(@"click get demo")]
        public void WhenClickGetDemo()
        {
            driver.FindElement(GetDemoButton).Click();
        }

        [Then(@"I should be on '([^']*)' page")]
        public void ThenIShouldBeOnPage(string url)
        {
            Assert.IsTrue(driver.Url.Equals(url));
        }

        [Then(@"I should get validation message")]
        public void ThenIShouldGetValidationMessage()
        {
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
    }
}
