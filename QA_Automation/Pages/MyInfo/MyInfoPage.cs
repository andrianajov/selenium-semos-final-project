using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using QA_Automation.Pages;

namespace QA_Automation.Pages.MyInfo
{

    class MyInfoPage
    {
        private readonly IWebDriver Driver;
        private const string MyInfoXpath = "//span[normalize-space()='My Info']";
        public MyInfoPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement MyInfoMenuItem
        {
            get
            {
                return Driver.FindElement(By.XPath(MyInfoXpath));
            }
        }

        public IWebElement EmergencyContactMenuItem
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[normalize-space()='Emergency Contacts']"));
            }
        }

        public IWebElement DependentsMenuItem
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[normalize-space()='Dependents']"));
            }
        }


        public void WaitUntilLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
            wait.Until(ExpectedConditions.ElementToBeClickable((By.XPath(MyInfoXpath))));
        }

    }
}
