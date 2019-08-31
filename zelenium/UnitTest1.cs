using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace zelenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

           //  IWebDriver driver = new ChromeDriver();
           IWebDriver driver = new ChromeDriver(chromeOptions);

            driver.Navigate().GoToUrl("https://cvdosforfiu.azurewebsites.net");
            Console.WriteLine("=============>>>>>>> Test completed");
        }
    }
}
