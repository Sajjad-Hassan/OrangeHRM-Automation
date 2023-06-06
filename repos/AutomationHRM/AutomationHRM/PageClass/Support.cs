using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM.PageClass
{
    public class Support : BaseClass
    {
        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");
        By Menu = By.XPath("//span[@class = 'oxd-userdropdown-tab']");
        By SupportBTN = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul/li[2]/a");
        By SupportTitle = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[1]/div[1]/h6[1]");

        public void Login(String username, String password)
        {
            Thread.Sleep(9000);
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginBTN).Click();
        }

        public void ClickOnProfile()
        {
            Thread.Sleep(5000);
            driver.FindElement(Menu).Click();
        }

        public void ClickOnSupport() 
        {
            Thread.Sleep(5000);
            driver.FindElement(SupportBTN).Click();
        }

        public void SupportPageTitle() 
        {
            Thread.Sleep(5000);
            String Title = driver.FindElement(SupportTitle).Text;
            Assert.AreEqual("Getting Started with OrangeHRM", Title);
        }
    }
}
