
using System;
using test.Model;
using test.Pages;
using test.Pages.Components.SignIn;
using test.Utils;

namespace test.Steps
{
    public class LoginSteps
    {
        SplashPage loginPage;
        LoginComponent loginComponent;

        public LoginSteps()
        {
            loginPage = new SplashPage();
            loginComponent = new LoginComponent();
        }


        public void doLogin()
        {
            UserInformation userInformation = new UserInformation();
            userInformation.setEmail("tokas.preeti@gmail.com");
            userInformation.setPassword("tokas1");

            loginPage.clickSignInButton();
            loginComponent.doSignIn(userInformation);
        }

    }
}

