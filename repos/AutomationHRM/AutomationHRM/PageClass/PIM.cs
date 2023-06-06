using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationHRM.PageClass
{
    public class PIM : BaseClass
    {


        //Locators
        By Username = By.XPath("//input[@name = 'username' and @placeholder = 'Username']");
        By Password = By.XPath("//input[@name = 'password' and @placeholder = 'Password']");
        By LoginBTN = By.ClassName("orangehrm-login-action");
        By PIMpage = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");
        By EMPname = By.XPath("//input[@placeholder = 'Type for hints...']");
        By EMPid = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/input");
        By Supervisor = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[5]/div[1]/div[2]/div[1]/div[1]/input");
        By EMPstatus = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[3]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By include = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[4]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By JobTitle = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[6]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By SubUnit = By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[7]/div[1]/div[2]/div[1]/div[1]/div[1]");
        By SubmitBTN = By.XPath("//div[@class = 'oxd-form-actions']//child::button[2]");
        By Records = By.XPath("//div[@class = 'orangehrm-paper-container']/div[2]/div[1]/span[1]");
        //IWebElement DropD = driver.FindElement(By.XPath("//div[@class = 'oxd-form-row']/div[1]//child::div[3]/div[1]/div[2]/div[1]/div[1]/div[1]"));
        //SelectElement se = new SelectElement(DropD);

   


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

        public void EMPinfo()
        {
            Thread.Sleep(5000);
            driver.FindElement(EMPname).SendKeys("Sajjad Hassan");
            driver.FindElement(EMPid).SendKeys("0036");
            driver.FindElement(EMPstatus).Click();
            driver.FindElement(EMPstatus).SendKeys(Keys.ArrowDown);
            driver.FindElement(EMPstatus).SendKeys(Keys.Enter);
            driver.FindElement(include).Click();
            driver.FindElement(include).SendKeys(Keys.ArrowDown);
            driver.FindElement(include).SendKeys(Keys.ArrowDown);
            driver.FindElement(include).SendKeys(Keys.Enter);
            driver.FindElement(Supervisor).SendKeys("H");
            Thread.Sleep(3000);
            driver.FindElement(Supervisor).SendKeys(Keys.ArrowDown);
            driver.FindElement(Supervisor).SendKeys(Keys.Enter);
            driver.FindElement(JobTitle).SendKeys(Keys.ArrowDown);
            driver.FindElement(JobTitle).SendKeys(Keys.ArrowDown);
            driver.FindElement(JobTitle).SendKeys(Keys.Enter);
            driver.FindElement(SubUnit).SendKeys(Keys.ArrowDown);
            driver.FindElement(SubUnit).SendKeys(Keys.ArrowDown);
            driver.FindElement(SubUnit).SendKeys(Keys.Enter);
            driver.FindElement(SubmitBTN).Click();
            Thread.Sleep(5000);
        }

        public void checkRecord()
        {
            Thread.Sleep(5000);
            String RecordText = driver.FindElement(Records).Text;
            Assert.AreEqual("No Records Found", RecordText);

        
        }
    }
}
