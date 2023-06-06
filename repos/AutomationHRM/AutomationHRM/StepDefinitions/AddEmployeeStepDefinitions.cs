using AutomationHRM.PageClass;
using System;
using TechTalk.SpecFlow;

namespace AutomationHRM.StepDefinitions
{
    [Binding]
    public class AddEmployeeStepDefinitions
    {

        AddEmployee addemp = new AddEmployee(); 

        [Given(@"Go To the Url")]
        public void GivenGoToTheUrl()
        {
            addemp.DriverInitialize();
            addemp.OpenBrowser();
            addemp.OpenURL();
        }

        [When(@"enter your username and password")]
        public void WhenEnterYourUsernameAndPassword()
        {
            addemp.Login("Admin", "admin123");
        }

        [When(@"Click on PIM page")]
        public void WhenClickOnPIMPage()
        {
            addemp.ClickOnPIM();
        }

        [When(@"Click on Add Button")]
        public void WhenClickOnAddButton()
        {
            addemp.ClickAdd();
        }

        [Then(@"validate if you are on the Add employee page")]
        public void ThenValidateIfYouAreOnTheAddEmployeePage()
        {
            addemp.IsAddEmployeePage();
        }

        [Then(@"Enter First name")]
        public void ThenEnterFirstName()
        {
            addemp.EnterFirstName("Sajjad");   
        }

        [Then(@"Enter middle name")]
        public void ThenEnterMiddleName()
        {
            addemp.EnterMiddleName("Tahir");
        }

        [Then(@"EnterLastname")]
        public void ThenEnterLastname()
        {
            addemp.EnterLastName("Hassan");
        }

        [Then(@"Enter Employee ID")]
        public void ThenEnterEmployeeID()
        {
            addemp.EnterEmployeeID("0036");
        }

        [When(@"Click on Save button")]
        public void WhenClickOnSaveButton()
        {
            addemp.ClickSave();
        }

        [Then(@"Validate if your record is added")]
        public void ThenValidateIfYourRecordIsAdded()
        {
            addemp.IsDetailsPage();
            addemp.DriverQuit();
        }
    }
}
