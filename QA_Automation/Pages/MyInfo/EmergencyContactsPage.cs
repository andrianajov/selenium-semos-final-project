using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace QA_Automation.Pages.MyInfo
{
    class EmergencyContactsPage
    {
        private readonly IWebDriver Driver;
        private const string EmergencyContactXpath = "//a[normalize-space()='Emergency Contacts']";
        public EmergencyContactsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement AssignedEmergencyAddBtn
        {
            get
            {
                return Driver.FindElement(By.XPath("//body/div[@id='app']/div[@class='oxd-layout']/div[@class='oxd-layout-container']/div[@class='oxd-layout-context']/div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']/div[@class='orangehrm-edit-employee']/div[@class='orangehrm-edit-employee-content']/div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']/div[@class='orangehrm-action-header']/button[1]"));
            }
        }
        public IWebElement InputName
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-input"))[1];
            }
        }
        public IWebElement InputRelationship
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-input"))[2];
            }
        }
        public IWebElement InputHomeTelephone
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-input"))[3];
            }
        }
        public IWebElement InputMobile
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-input"))[4];
            }
        }
        public IWebElement InputWorkTelephone
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-input"))[5];
            }
        }
        public IWebElement SaveEmergencyBtn
        {
            get
            {
                return Driver.FindElement(By.XPath("//button[@type='submit']"));
            }
        }
        public void WaitUntilLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
            wait.Until(ExpectedConditions.ElementToBeClickable((By.XPath(EmergencyContactXpath))));
        }
    }
}
