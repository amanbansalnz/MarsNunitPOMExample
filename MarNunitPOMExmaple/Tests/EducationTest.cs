using System;
using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using test.Pages;
using test.Pages.components;
using test.Steps;
using test.Utils;

namespace test
{
    public class EducationTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        EducationSteps educationSteps;

        public EducationTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            educationSteps = new EducationSteps();

        }



        [Test]
        public void givenLoggedInAndAddingNewEductaion_whenAddEducation_thenEducationIsAdded()
        {
            loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();

            educationSteps.addEducation();
        }


    }

}

