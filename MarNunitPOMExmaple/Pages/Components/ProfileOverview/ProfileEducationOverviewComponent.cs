﻿using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using test.Model;
using test.Utils;

namespace test.Pages.Components
{
    public class ProfileEducationOverviewComponent : GobalHelper

    {

        private IWebElement addNewEducationButton;
        private IWebElement newCountryAddedCell;
        private IWebElement newUniversityAddedCell;
        private IWebElement newTitleAddedCell;
        private IWebElement newDegreeAddedCell;
        private IWebElement newGraduationYearAddedCell;
        //private IWebElement messageWindow;
        //private IWebElement closeMessageIcon;
        private string message = "";


        public void renderComponents()
        {
            try
            {
                addNewEducationButton = driver.FindElement(By.XPath("//*[text()='Country']/following-sibling::th[5]/div"));
                newCountryAddedCell = driver.FindElement(By.XPath("(//div[text()='Did you attend a college or university?']/parent::div/following-sibling::div//table/tbody)[last()]//td[1]"));
                newUniversityAddedCell = driver.FindElement(By.XPath("(//div[text()='Did you attend a college or university?']/parent::div/following-sibling::div//table/tbody)[last()]//td[2]"));
                newTitleAddedCell = driver.FindElement(By.XPath("(//div[text()='Did you attend a college or university?']/parent::div/following-sibling::div//table/tbody)[last()]//td[3]"));
                newDegreeAddedCell = driver.FindElement(By.XPath("(//div[text()='Did you attend a college or university?']/parent::div/following-sibling::div//table/tbody)[last()]//td[4]"));
                newGraduationYearAddedCell = driver.FindElement(By.XPath("(//div[text()='Did you attend a college or university?']/parent::div/following-sibling::div//table/tbody)[last()]//td[5]"));
                //messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                //closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void clickAddEducationButton()
        {

            //----Adding Education------------

            renderComponents();
            addNewEducationButton.Click();

            Thread.Sleep(5000);
        }


        //public void closeMessageWindow()
        //{
        //    Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
        //    closeMessageIcon.Click();
        //}


        public string getMessage()
        {
            //Returning error or success message
            return message;
        }
    }
}

