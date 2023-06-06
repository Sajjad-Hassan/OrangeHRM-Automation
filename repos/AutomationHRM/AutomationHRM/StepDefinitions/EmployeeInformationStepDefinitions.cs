using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class EmployeeInformationStepDefinitions
    {
        PIM pim = new PIM();

        [Given(@"Go To The Url\.")]
        public void GivenGoToTheUrl_()
        {
            pim.DriverInitialize();
            pim.OpenBrowser();
            pim.OpenURL();
        }

        [When(@"Enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            pim.Login("Admin", "admin123");
        }

        [When(@"Click on PIM")]
        public void WhenClickOnPIM()
        {
            pim.ClickOnPIM();
        }

        [When(@"Enter employee information")]
        public void WhenEnterEmployeeInformation()
        {
            pim.EMPinfo();
        }

        [Then(@"validate if employee is present")]
        public void ThenValidateIfEmployeeIsPresent()
        {
            pim.checkRecord();
            pim.DriverQuit();
        }
    }
}
