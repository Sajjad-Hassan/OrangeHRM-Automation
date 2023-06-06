using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class InvalidLoginFuctionalityStepDefinitions
    {
        InvalidLogin InvalidLogin = new InvalidLogin();

        [Given(@"Go To The Url")]
        public void GivenGoToTheUrl()
        {
            InvalidLogin.DriverInitialize();
            InvalidLogin.OpenBrowser();
            InvalidLogin.OpenURL();
        }

        [When(@"Enter Invalid username and password")]
        public void WhenEnterInvalidUsernameAndPassword()
        {
            InvalidLogin.Login("Admin", "admin321");
        }

        [Then(@"Validate Invalid login")]
        public void ThenValidateInvalidLogin()
        {
            InvalidLogin.ValidLoginMessage();
            InvalidLogin.DriverQuit();
        }
    }
}