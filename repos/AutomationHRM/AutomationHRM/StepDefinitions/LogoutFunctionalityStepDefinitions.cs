using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class LogoutFunctionalityStepDefinitions
    {
        Logout logout = new Logout();

        [Given(@"Go to Home Page")]
        public void GivenGoToHomePage()
        {
            logout.DriverInitialize();
            logout.OpenBrowser();
            logout.OpenURL();
        }

        [When(@"Enter Valid username and Password")]
        public void WhenEnterValidUsernameAndPassword()
        {
            logout.Login("Admin", "admin123");
        }

        [When(@"Click on Profile")]
        public void WhenClickOnProfile()
        {
            logout.ClickOnProfile();
        }

        [When(@"Click on Logout")]
        public void WhenClickOnLogout()
        {
            logout.ClickOnLogout();
        }

        [Then(@"Validate Logout")]
        public void ThenValidateLogout()
        {
            logout.HomePageImg();
            logout.DriverQuit();
        }
    }
}
