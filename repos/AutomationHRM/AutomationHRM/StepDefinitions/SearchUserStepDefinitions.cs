using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class SearchUserStepDefinitions
    {

        SearchUser searchuser = new SearchUser();

        [Given(@"Go the the website URL")]
        public void GivenGoTheTheWebsiteURL()
        {
            searchuser.DriverInitialize();
            searchuser.OpenBrowser();
            searchuser.OpenURL();
        }

        [When(@"Enter your usernam and password")]
        public void WhenEnterYourUsernamAndPassword()
        {
            searchuser.Login("Admin", "admin123");
        }

        [When(@"Click on Admin")]
        public void WhenClickOnAdmin()
        {
            searchuser.ClickOnAdmin();
        }

        [Then(@"Verify if you are on the system user page")]
        public void ThenVerifyIfYouAreOnTheSystemUserPage()
        {
            searchuser.IsSystemUser();
        }

        [Then(@"Enter username")]
        public void ThenEnterUsername()
        {
            searchuser.EnterUserName("Sajjad123");
        }

        [Then(@"Enter User role")]
        public void ThenEnterUserRole()
        {
            searchuser.EnterUserRole();
        }

        [Then(@"Enter Employee name")]
        public void ThenEnterEmployeeName()
        {
            searchuser.EnterEmployeeName();
        }

        [Then(@"Enter employee status")]
        public void ThenEnterEmployeeStatus()
        {
            searchuser.EnterStatus();
        }

        [When(@"Click on search button")]
        public void WhenClickOnSearchButton()
        {
            searchuser.ClickSearchBTN();
        }

        [Then(@"Show records")]
        public void ThenShowRecords()
        {
            searchuser.IsRecordavailable();
            searchuser.DriverQuit();
        }
    }
}
