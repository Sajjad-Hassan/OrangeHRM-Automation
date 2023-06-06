using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class ResetEmployeeInformationStepDefinitions
    {
        ResetPIM resetpim = new ResetPIM();

        [Given(@"go To The Url\.")]
        public void GivenGoToTheUrl_()
        {
            resetpim.DriverInitialize();
            resetpim.OpenBrowser();
            resetpim.OpenURL();
        }

        [When(@"enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            resetpim.Login("Admin", "admin123");
        }

        [When(@"click on PIM")]
        public void WhenClickOnPIM()
        {
            resetpim.ClickOnPIM();
        }

        [When(@"enter employee information")]
        public void WhenEnterEmployeeInformation()
        {
            resetpim.EMPinfo();
        }

        [Then(@"velidate reset button")]
        public void ThenVelidateResetButton()
        {
            resetpim.checkResetRecord();
            resetpim.DriverQuit();
        }
    }
}
