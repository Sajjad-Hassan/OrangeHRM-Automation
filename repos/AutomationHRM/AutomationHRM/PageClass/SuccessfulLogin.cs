using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationHRM
{
    public class SuccessfulLogin : BaseClass
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
            String Text = driver.FindElement(By.XPath("//div[@id='app']/div[1]/div[1]/header/div[1]/div[1]/span/h6")).Text;
            Assert.AreEqual("Dashboard", Text);
        }
    }
}
