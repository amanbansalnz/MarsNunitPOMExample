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
    public class LoginTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;

        public LoginTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();

        }



        [Test]
        public void givenLoginCreds_whenDoLogin_thenIsLoggedIn()
        {
            loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();

        }


    }

}

