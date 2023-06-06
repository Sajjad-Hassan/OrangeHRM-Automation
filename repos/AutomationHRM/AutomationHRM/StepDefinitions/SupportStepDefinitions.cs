using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class SupportStepDefinitions
    {
        Support support = new Support();

        [Given(@"Go to Home page")]
        public void GivenGoToHomePage()
        {
            support.DriverInitialize();
            support.OpenBrowser();
            support.OpenURL();
        }

        [When(@"Enter valid username and password")]
        public void WhenEnterValidUsernameAndPassword()
        {
            support.Login("Admin", "admin123");
        }

        [When(@"Click on profile")]
        public void WhenClickOnProfile()
        {
            support.ClickOnProfile();
        }

        [When(@"Click on support")]
        public void WhenClickOnSupport()
        {
            support.ClickOnSupport();
        }

        [Then(@"Validate support page display")]
        public void ThenValidateSupportPageDisplay()
        {
            support.SupportPageTitle();
            support.DriverQuit();
        }
    }
}
