using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using test.Model;
using test.Utils;

namespace test.Pages.Components
{
    public class AddEducationComponent : GobalHelper

    {

        private IWebElement universityTextBox;
        private IWebElement degreeTextBox;
        private IWebElement countryDropDown;
        private IWebElement titleDropDown;
        private IWebElement graduationYearDropDown;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;
        private IWebElement updateButton;


        public void renderAddComponents()
        {
            try
            {
                universityTextBox = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                degreeTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                countryDropDown = driver.FindElement(By.XPath("//select[@name='country']"));
                titleDropDown = driver.FindElement(By.XPath("//select[@name='title']"));
                graduationYearDropDown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void renderAddMessage()
        {
            try
            { 

                messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void renderUpdateComponents()
        {
            try
            {
                universityTextBox = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                degreeTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                countryDropDown = driver.FindElement(By.XPath("//select[@name='country']"));
                titleDropDown = driver.FindElement(By.XPath("//select[@name='title']"));
                graduationYearDropDown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));
                updateButton = driver.FindElement(By.XPath("//*[@value='Update']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void addEducation(EducationModel education)
        {
            renderAddComponents();

            //Enter record details
            universityTextBox.SendKeys(education.getUniversity());
            degreeTextBox.SendKeys(education.getDegree());
            SelectElement countryOption = new SelectElement(countryDropDown);
            countryOption.SelectByText(education.getCountry());
            SelectElement titleOption = new SelectElement(titleDropDown);
            titleOption.SelectByText(education.getTitle());
            SelectElement graduationYearOption = new SelectElement(graduationYearDropDown);
            graduationYearOption.SelectByText(education.getGraduationYear());

            //Click on "Add" button.
            addButton.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);


        }

        public String getSuccessMessage()
        {
            //Saving error or success message
            renderAddMessage();
            String message = messageWindow.Text;

            //If any message visible close it
            Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
            closeMessageIcon.Click();

            if (message == "Please enter all the fields")
            {
                cancelButton.Click();
            }

            return message;
        }


    }
}

