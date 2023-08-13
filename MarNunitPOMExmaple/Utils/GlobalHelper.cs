using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test.Utils
{
	public class GobalHelper
	{
        public static IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            //Thread.Sleep(1000);
        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}

