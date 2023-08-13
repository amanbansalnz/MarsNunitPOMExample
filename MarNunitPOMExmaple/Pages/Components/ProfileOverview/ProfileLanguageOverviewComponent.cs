using System;
using OpenQA.Selenium;
using test.Utils;

namespace test.Pages.components
{
    public class ProfileLanguageOverviewComponent : GobalHelper

    {

        private IWebElement languagesTitle;
        private IWebElement languagesSubHeading1;
        private IWebElement? languagesSubHeading2;
        private IReadOnlyList<IWebElement> languages;
        private IWebElement addLanguageButton;
        private IWebElement inputLanguageTextBox;
        private IWebElement chooseLanguage;
        private IWebElement addButton;
        private IWebElement cancelButton;


        public void renderComponents()
        {
            try
            {
                languagesTitle = driver.FindElement(By.XPath("(//h3[@class='alt'])[1]"));
                languagesSubHeading1 = driver.FindElement(By.XPath("(//div[@class='question'])[1]"));
                languagesSubHeading2 = driver.FindElement(By.XPath("(//div[@class='tooltip'])[1]"));
                languages = driver.FindElements(By.XPath("//table[contains(@class,'ui fixed')]/tbody"));
                addLanguageButton = driver.FindElement(By.XPath("//div[contains(@class,'ui teal')])[1]"));
                inputLanguageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                chooseLanguage = driver.FindElement(By.XPath(" //select[@class='ui dropdown']"));
                addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                cancelButton = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }




       
    }
}

