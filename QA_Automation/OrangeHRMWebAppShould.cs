using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Xunit;
using QA_Automation.Pages;
using QA_Automation.Pages.MyInfo;

namespace QA_Automation
{


    public class OrangeHRMWebAppShould
    {
        //private const string LogIn = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";


        [Fact]
        public void CheckIfUserIsValid()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.NavigateTo();
                loginPage.MaximizeWindow();
                loginPage.WaitUntilLoaded();
                loginPage.Username.SendKeys("Admin");
                loginPage.Password.SendKeys("admin123");
                loginPage.SubmitBtn.Click();

                var dashboardHeaderTitleXPath = "//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']";

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                wait.Until(ExpectedConditions.ElementExists((By.XPath(dashboardHeaderTitleXPath))));

                Assert.Equal("Dashboard", driver.FindElement(By.XPath(dashboardHeaderTitleXPath)).Text);
            }
        }
        [Fact]
        public void AddEmergencyContacts()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.NavigateTo();
                loginPage.MaximizeWindow();
                loginPage.WaitUntilLoaded();
                loginPage.Username.SendKeys("Admin");
                loginPage.Password.SendKeys("admin123");
                loginPage.SubmitBtn.Click();

                var MyInfoPage = new MyInfoPage(driver);
                MyInfoPage.WaitUntilLoaded();
                MyInfoPage.MyInfoMenuItem.Click();

                var EmergencyContactsPage = new EmergencyContactsPage(driver);
                EmergencyContactsPage.WaitUntilLoaded();

                MyInfoPage.EmergencyContactMenuItem.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='app']/div[@class='oxd-layout']/div[@class='oxd-layout-container']/div[@class='oxd-layout-context']/div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']/div[@class='orangehrm-edit-employee']/div[@class='orangehrm-edit-employee-content']/div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']/div[@class='orangehrm-action-header']/button[1]")));
                EmergencyContactsPage.AssignedEmergencyAddBtn.Click();

                EmergencyContactsPage.InputName.SendKeys("Paul");
                EmergencyContactsPage.InputRelationship.SendKeys("Husband");
                EmergencyContactsPage.InputHomeTelephone.SendKeys("4546456");
                EmergencyContactsPage.InputMobile.SendKeys("123456798");
                EmergencyContactsPage.InputWorkTelephone.SendKeys("23232");
                EmergencyContactsPage.SaveEmergencyBtn.Click();

                var NameIs = "//div[contains(text(),'Paul')]";
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(NameIs)));

                Assert.Equal("Paul", driver.FindElement(By.XPath(NameIs)).Text);
                Assert.Equal("Husband", driver.FindElement(By.XPath("//div[contains(text(),'Husband')]")).Text);
                Assert.Equal("4546456", driver.FindElement(By.XPath("//div[contains(text(),'4546456')]")).Text);
                Assert.Equal("123456798", driver.FindElement(By.XPath("//div[contains(text(),'123456798')]")).Text);
                Assert.Equal("23232", driver.FindElement(By.XPath("//div[contains(text(),'23232')]")).Text);

            }
        }

        [Fact]
        public void AddEmergencyContactsWithoutRequiredFields()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.NavigateTo();
                loginPage.MaximizeWindow();
                loginPage.WaitUntilLoaded();
                loginPage.Username.SendKeys("Admin");
                loginPage.Password.SendKeys("admin123");
                loginPage.SubmitBtn.Click();

                var MyInfoPage = new MyInfoPage(driver);
                MyInfoPage.WaitUntilLoaded();
                MyInfoPage.MyInfoMenuItem.Click();

                var EmergencyContactsPage = new EmergencyContactsPage(driver);
                EmergencyContactsPage.WaitUntilLoaded();

                MyInfoPage.EmergencyContactMenuItem.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='app']/div[@class='oxd-layout']/div[@class='oxd-layout-container']/div[@class='oxd-layout-context']/div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']/div[@class='orangehrm-edit-employee']/div[@class='orangehrm-edit-employee-content']/div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']/div[@class='orangehrm-action-header']/button[1]")));
                EmergencyContactsPage.AssignedEmergencyAddBtn.Click();

                EmergencyContactsPage.InputHomeTelephone.SendKeys("4546456");
                EmergencyContactsPage.InputMobile.SendKeys("123456798");
                EmergencyContactsPage.InputWorkTelephone.SendKeys("23232");
                EmergencyContactsPage.SaveEmergencyBtn.Click();

                Assert.Equal("Required", driver.FindElement(By.XPath("//div[@class='oxd-grid-3 orangehrm-full-width-grid']//div[1]//div[1]//span[1]")).Text);
            }
        }

        [Fact]
        public void AddDependents()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.NavigateTo();
                loginPage.MaximizeWindow();
                loginPage.WaitUntilLoaded();
                loginPage.Username.SendKeys("Admin");
                loginPage.Password.SendKeys("admin123");
                loginPage.SubmitBtn.Click();

                var MyInfoPage = new MyInfoPage(driver);
                MyInfoPage.WaitUntilLoaded();
                MyInfoPage.MyInfoMenuItem.Click();

                var DependentsPage = new DependentsPage(driver);
                DependentsPage.WaitUntilLoaded();
                MyInfoPage.DependentsMenuItem.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='app']/div[@class='oxd-layout']/div[@class='oxd-layout-container']/div[@class='oxd-layout-context']/div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']/div[@class='orangehrm-edit-employee']/div[@class='orangehrm-edit-employee-content']/div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']/div[@class='orangehrm-action-header']/button[1]")));

                DependentsPage.AssignedDependentsAddBtn.Click();

                DependentsPage.InputName.SendKeys("Karla");
                DependentsPage.RelationshipDropDownMenu.Click();
                DependentsPage.SelectChildDropDownMenu.Click();
                DependentsPage.InputCalendar.SendKeys("1995-03-03");
                DependentsPage.SaveDependentsBtn.Click();

                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("oxd-table-cell")));

                Assert.Equal("Karla", driver.FindElements(By.ClassName("oxd-table-cell"))[1].Text);
                Assert.Equal("Child", driver.FindElements(By.ClassName("oxd-table-cell"))[2].Text);
                Assert.Equal("1995-03-03", driver.FindElements(By.ClassName("oxd-table-cell"))[3].Text);

            }
        }

        [Fact]
        public void BuzzFeedPost()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.NavigateTo();
                loginPage.MaximizeWindow();
                loginPage.WaitUntilLoaded();
                loginPage.Username.SendKeys("Admin");
                loginPage.Password.SendKeys("admin123");
                loginPage.SubmitBtn.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
                wait.Until(ExpectedConditions.ElementExists((By.XPath("//div[@class='oxd-sidepanel-body']"))));

                var BuzzPage = new BuzzPage(driver);
                BuzzPage.BuzzMenuItem.Click();

                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//textarea[@placeholder=\"What's on your mind?\"]")));
                BuzzPage.BuzzNewPostInput.SendKeys("Hi :)");
                BuzzPage.BuzzPostBtn.Click();

                BuzzPage.Refresh();
                var PostedPostXpath = "//p[normalize-space()='Hi :)']";
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PostedPostXpath)));

                Assert.Equal("Hi :)", driver.FindElement(By.XPath(PostedPostXpath)).Text);
            }
        }


//        [Fact]
//        public void LeaveModuleAddComment()
//        {
//            using (IWebDriver driver = new ChromeDriver())
//            {
//                var loginPage = new LoginPage(driver);
//                loginPage.NavigateTo();
//                loginPage.MaximizeWindow();
//                loginPage.WaitUntilLoaded();
//                loginPage.Username.SendKeys("Admin");
//                loginPage.Password.SendKeys("admin123");
//                loginPage.SubmitBtn.Click();

//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

//                IWebElement LeaveModule = wait.Until(ExpectedConditions.ElementExists((By.XPath("//span[normalize-space()='Leave']"))));
//                LeaveModule.Click();

//                wait.Until(ExpectedConditions.ElementExists((By.XPath("//body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[9]/div[1]/li[1]/button[1]"))));

//                IWebElement DropDown = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[9]/div[1]/li[1]/button[1]"));
//                DropDown.Click();

//                wait.Until(ExpectedConditions.ElementExists((By.XPath("//ul[@role='menu']"))));

//                IWebElement AddComment = driver.FindElements(By.ClassName("oxd-table-dropdown-item"))[0];
//                AddComment.Click();

//                wait.Until(ExpectedConditions.ElementToBeClickable((By.XPath("//textarea[@placeholder='Comment here']"))));

//                driver.FindElement(By.XPath("//textarea[@placeholder='Comment here']")).SendKeys("Can you reschedule?");

//                IWebElement SaveComment = driver.FindElement(By.XPath("//button[normalize-space()='Save']"));
//                SaveComment.Click();

//                driver.Navigate().Refresh();

//                wait.Until(ExpectedConditions.ElementExists((By.XPath("//div[contains(text(),'Can you reschedule?')]"))));

//                Assert.Equal("Can you reschedule?", driver.FindElement(By.XPath("//div[contains(text(),'Can you reschedule?')]")).Text);

//            }
//        }

    }
}
