using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitFramework
{
    public class LocatorsIdentification
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void StartDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            TestContext.Progress.WriteLine(driver.Title);
        }
        [Test, Category("Module1")]
        public void Login()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("username")).SendKeys("rahulshetty");
            driver.FindElement(By.Name("password")).SendKeys("learning");
            driver.FindElement(By.CssSelector("[class='form-group']:nth-child(6) label span input")).Click();
            IList<IWebElement> radios = driver.FindElements(By.XPath("//*[@type='radio']"));
            foreach (WebElement i in radios)
            {
                if (i.GetAttribute("value").Equals("user"))
                {
                    i.Click();


                }
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("modal-body")));
            driver.FindElement(By.Id("okayBtn")).Click();

            IWebElement select = driver.FindElement(By.CssSelector("select[class='form-control']"));
            SelectElement s = new SelectElement(select);
            s.SelectByIndex(0);

            driver.FindElement(By.Id("terms")).Click();

            driver.FindElement(By.CssSelector("[id='signInBtn']")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("alert-danger")));

            TestContext.Progress.WriteLine(driver.FindElement(By.ClassName("alert-danger")).Text);
            //Console.WriteLine(driver.FindElement(By.XPath("//div/strong")).Text);

            string blinlkingText = driver.FindElement(By.CssSelector(".blinkingText")).Text;
            Console.WriteLine(blinlkingText);
            Assert.AreEqual(blinlkingText, "Free Access to InterviewQues/ResumeAssistance/Material");


        }
        [TearDown]
        public void TearDown()
        {

        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
