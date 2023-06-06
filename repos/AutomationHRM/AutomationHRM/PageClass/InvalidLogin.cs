using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM.PageClass
{
    public class InvalidLogin : BaseClass
    {
        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");

        public void Login(String username, String password)
        {
            Thread.Sleep(9000);
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginBTN).Click();
        }

        public void ValidLoginMessage()
        {
            Thread.Sleep(9000);
            String invalidText = driver.FindElement(By.XPath("//p[@class = 'oxd-text oxd-text--p oxd-alert-content-text']")).Text;
            Assert.AreEqual("Invalid credentials", invalidText);
        }
    }
}