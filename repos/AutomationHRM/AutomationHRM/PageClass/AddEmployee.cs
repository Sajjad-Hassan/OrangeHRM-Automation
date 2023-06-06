using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM.PageClass
{
    public class AddEmployee : BaseClass
    {

        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");
        By PIMpage = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");
        By AddBTN = By.XPath("//div[@id = 'app']/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/button[1]");
        By EmployeeText = By.XPath("//div[@id = 'app']/div[1]/div[2]/div[2]/div[1]/div[1]/h6[1]");
        By FirstName = By.XPath("//input[@name = 'firstName' and @placeholder = 'First Name']");
        By MiddleName = By.XPath("//input[@name = 'middleName' and @placeholder = 'Middle Name']");
        By LastName = By.XPath("//input[@name = 'lastName' and @placeholder = 'Last Name']");
        By EmployeeID = By.XPath("//div[@class = 'oxd-grid-2 orangehrm-full-width-grid']/div[1]/div[1]/div[2]/input");
        By SaveBTN = By.XPath("//div[@class = 'oxd-form-actions']/button[2]");
        By InfoText = By.XPath("//div[@class = 'oxd-layout-context']/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h6[1]");

        public void Login(String username, String password)
        {
            Thread.Sleep(9000);
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginBTN).Click();
        }

        public void ClickOnPIM()
        {
            Thread.Sleep(5000);
            driver.FindElement(PIMpage).Click();
        }

        public void ClickAdd()
        {
            Thread.Sleep(3000);
            driver.FindElement(AddBTN).Click();
        }

        public void EnterFirstName(String firstname)
        {
            
            driver.FindElement(FirstName).SendKeys(firstname);
        }

        public void EnterMiddleName(String middlename)
        {
            driver.FindElement(MiddleName).SendKeys(middlename);
        }

        public void EnterLastName(String lastname)
        {
            driver.FindElement(LastName).SendKeys(lastname);
        }

        public void EnterEmployeeID(String empid)
        {
            driver.FindElement(EmployeeID).SendKeys(empid);
        }

        public void ClickSave()
        {
            driver.FindElement(SaveBTN).Click();
            Thread.Sleep(9000);
        }

        public void IsAddEmployeePage()
        {
            Thread.Sleep(5000);
            String AddEmployeeText = driver.FindElement(EmployeeText).Text;
            Assert.AreEqual("Add Employee", AddEmployeeText);
        }

        public void IsDetailsPage()
        {
            String DetailText = driver.FindElement(InfoText).Text;
            Assert.AreEqual("Sajjad Hassan", DetailText);
        }
    }
}
