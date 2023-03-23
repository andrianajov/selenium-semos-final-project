using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation.Pages
{
    class BuzzPage
    {
        private readonly IWebDriver Driver;
        private const string DependentsXpath = "//a[normalize-space()='Dependents']";
        public BuzzPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement BuzzMenuItem
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-main-menu-item-wrapper"))[10];
            }
        }

        public IWebElement BuzzNewPostInput
        {
            get
            {
                return Driver.FindElement(By.XPath("//textarea[@placeholder=\"What's on your mind?\"]"));
            }
        }
        public IWebElement BuzzPostBtn
        {
            get
            {
                return Driver.FindElement(By.XPath("//button[@type='submit']"));
            }
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

    }
}