using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM.PageClass
{
    public class Logout : BaseClass
    {
        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");
        By Menu = By.XPath("//span[@class = 'oxd-userdropdown-tab']");
        By LogoutBTN = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul/li[4]/a");
        By img = By.XPath("//div[@id = 'app']/div[1]/div[1]/div[1]/div[1]/div[1]/img[1]");

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

        public void ClickOnLogout()
        {
            Thread.Sleep(5000);
            driver.FindElement(LogoutBTN).Click();
        }

        public void HomePageImg()
        {
            Thread.Sleep(5000);
            Boolean check = driver.FindElement(img).Displayed;
            Assert.IsTrue(check);
        }
    }


}
