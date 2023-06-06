using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        SuccessfulLogin SuccessfulLogin = new SuccessfulLogin();

        [Given(@"Go to the Home Page")]
        public void GivenGoToTheHomePage()
        {
            SuccessfulLogin.DriverInitialize();
            SuccessfulLogin.OpenBrowser();
            SuccessfulLogin.OpenURL();
        }

        [When(@"Enter Valid username and password")]
        public void WhenEnterValidUsernameAndPassword()
        {
            SuccessfulLogin.Login("Admin", "admin123");
        }

        [Then(@"Validate successful login")]
        public void ThenValidateSuccessfulLogin()
        {
            SuccessfulLogin.ValidLoginMessage();
            SuccessfulLogin.DriverQuit();
        }
    }
}
