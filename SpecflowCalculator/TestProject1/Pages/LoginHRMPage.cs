using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    public class LoginHRMPage
    {
        public IWebDriver driver { get; set; }
        public LoginHRMPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement username1;


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[text()=' Login ']")]
        public IWebElement login ;


        [FindsBy(How = How.XPath, Using = "//a[text()='Logout']")]
        public IWebElement logout ;


        [FindsBy(How = How.XPath, Using = "//span[@class='oxd-userdropdown-tab']/i")]
        public IWebElement dropdown ;
      


        public void SendUsername()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("oxd-form")));
            username1.Click();
            Thread.Sleep(1000);
            Console.WriteLine("admin entered");
            username1.SendKeys("Admin");
            
        }
        public void SendPassword()
        {
            password.Click();
            password.SendKeys("admin123");
        }
        public void ClickOnLogin()
        {
            login.Click();
            Thread.Sleep(1000);
        }
        public void VerifyLogin()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-userdropdown-tab']/i")));
            dropdown.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(logout.Enabled);
        }
        public void Close()
        {
            driver.Quit();
        }


    }
}
