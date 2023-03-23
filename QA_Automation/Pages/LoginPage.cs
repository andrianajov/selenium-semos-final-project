using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace QA_Automation.Pages
{ 
  class LoginPage
  {
    private readonly IWebDriver Driver;
    private const string PageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

    //[FindsBy(How = How.Name, Using = "username")]
    //private IWebElement 

    public LoginPage(IWebDriver driver)
    {
        Driver = driver;
    }
    public IWebElement Username
    {
        get
        {
            return Driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        }
    }
    public IWebElement Password
    {
        get
        {
            return Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        }
    }
    public IWebElement SubmitBtn
    {
        get
        {
            return Driver.FindElement(By.XPath("//button[@type='submit']"));
        }
    }
    public void NavigateTo()
    {
        Driver.Navigate().GoToUrl(PageUrl);
    }
    public void MaximizeWindow()
    {
        Driver.Manage().Window.Maximize();
    }
    public void WaitUntilLoaded()
    {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
        wait.Until(ExpectedConditions.ElementExists((By.XPath("//input[@placeholder='Username']"))));
    }
  }
}