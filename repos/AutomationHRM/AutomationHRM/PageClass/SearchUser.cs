using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM.PageClass
{
    public class SearchUser : BaseClass
    {
        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");
        By Admin = By.XPath("//div[@id = 'app']/div[1]/div[1]/aside/nav/div[2]/ul/li/a");
        By SystemText = By.XPath("//div[@id = 'app']/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/h5");
        By SystemUserName = By.XPath("//div[@class = 'oxd-form-row']/div[1]/div[1]/div[1]/div[2]/input");
        By userrole = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[2]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By EMPname = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[3]/div[1]/div[2]/div[1]/div[1]/input");
        By Status = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[4]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By SearchBTN = By.XPath("//div[@class = 'oxd-form-actions']/button[2]");
        By Records = By.XPath("//div[@class = 'orangehrm-paper-container']/div[2]/div[1]/span");

        public void Login(String username, String password)
        {
            Thread.Sleep(9000);
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginBTN).Click();
        }

        public void ClickOnAdmin()
        {
            Thread.Sleep(5000);
            driver.FindElement(Admin).Click();
        }

        public void EnterUserName(String username) 
        {
            driver.FindElement(SystemUserName).SendKeys(username);
        }

        public void EnterUserRole()
        {
            driver.FindElement(userrole).Click();
            driver.FindElement(userrole).SendKeys(Keys.ArrowDown);
            driver.FindElement(userrole).SendKeys(Keys.Enter);
        }

        public void EnterEmployeeName()
        {
            driver.FindElement(EMPname).SendKeys("a");
            Thread.Sleep(5000);
            driver.FindElement(EMPname).SendKeys(Keys.ArrowDown);
            driver.FindElement(EMPname).SendKeys(Keys.Enter);
        }

        public void EnterStatus()
        {
            driver.FindElement(Status).Click();
            driver.FindElement(Status).SendKeys(Keys.ArrowDown);
            driver.FindElement(Status).SendKeys(Keys.Enter);
        }

        public void ClickSearchBTN()
        {
            driver.FindElement(SearchBTN).Click();
        }

   
        public void IsSystemUser()
        {
            Thread.Sleep(5000);
            String SUText = driver.FindElement(SystemText).Text;
            Assert.AreEqual("System Users", SUText);
        }

        public void IsRecordavailable()
        {
            Thread.Sleep(5000);
            String RecordText = driver.FindElement(Records).Text;
            Assert.AreEqual("No Records Found", RecordText);
        }

    }
}
