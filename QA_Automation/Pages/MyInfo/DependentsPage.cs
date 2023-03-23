using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace QA_Automation.Pages.MyInfo
{
    class DependentsPage
    {
        private readonly IWebDriver Driver;
        private const string DependentsXpath = "//a[normalize-space()='Dependents']";
        public DependentsPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement AssignedDependentsAddBtn
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
        public IWebElement RelationshipDropDownMenu
        {
            get
            {
                return Driver.FindElement(By.XPath("//div[@class='oxd-select-text-input']"));
            }
        }

        public IWebElement SelectChildDropDownMenu
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-select-option"))[1];
            }
        }
        public IWebElement InputCalendar
        {
            get
            {
                return Driver.FindElement(By.XPath("//input[@placeholder='yyyy-mm-dd']"));
            }
        }
        public IWebElement SaveDependentsBtn
        {
            get
            {
                return Driver.FindElement(By.XPath("//button[@type='submit']"));
            }
        }

        public void WaitUntilLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
            wait.Until(ExpectedConditions.ElementToBeClickable((By.XPath(DependentsXpath))));
        }
    }
}