using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHRM
{
    public class BaseClass
    {
        public static WebDriver driver;
        public String URL = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        public void DriverInitialize()
        {
            driver = new ChromeDriver();
        }

        public void OpenBrowser()
        {
            driver.Manage().Window.Maximize();
        }

        public void OpenURL()
        {
            driver.Navigate().GoToUrl(URL);
        }

        public void DriverQuit()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
