using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA_Automation.Pages.MyInfo
{
    class LeavePage
    {
        private readonly IWebDriver Driver;

        public LeavePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement LeaveMenuItem
        {
            get
            {
                return Driver.FindElements(By.ClassName("oxd-main-menu-item-wrapper"))[1];
                    }
        }

        public IWebElement DropDown
        {
            get
            {
                return Driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[9]/div[1]/li[1]/button[1]"));
            }
        }

        public IWebElement AddComment
        {
            get 
            {
                return Driver.FindElement(By.XPath("//p[normalize-space()='Add Comment']"));
            }
        }


        public IWebElement CommentHere
        {
            get
            {
                return Driver.FindElement(By.XPath("//textarea[@placeholder='Comment here']"));
            }
        }
        public IWebElement SaveComment
        {
            get
            {
                return Driver.FindElement(By.XPath("//button[normalize-space()='Save']"));
            }
        }
        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

    }
}
