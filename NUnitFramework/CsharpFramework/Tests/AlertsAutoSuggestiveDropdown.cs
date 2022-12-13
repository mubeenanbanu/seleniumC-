using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace CsharpFramework.Tests
{
    public class AlertsAutoSuggestiveDropdown
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Alerts()
        {
            String name = "Mubeena";
            driver.FindElement(By.Name("enter-name")).SendKeys(name);
            driver.FindElement(By.Id("confirmbtn")).Click();
            IAlert a = driver.SwitchTo().Alert();
            string message = a.Text;
            TestContext.Progress.WriteLine(message);
            StringAssert.Contains(name, message);
            string m = message.Split(",")[0].Split(" ")[1];
            TestContext.Progress.WriteLine(m);
            a.Accept();
            Assert.AreEqual(name, m);
        }
        [Test]
        public void AutoSuggestion()
        {
            String country = "ind";
            driver.FindElement(By.Id("autocomplete")).SendKeys(country);
            IList<IWebElement> suggestions = driver.FindElements(By.CssSelector(".ui-menu-item div"));
            foreach (IWebElement i in suggestions)
            {
                if (i.Text.Equals(country))
                {
                    i.Click();
                    break;
                }
            }
        }
        [Test]
        public void Frames()
        {
            IWebElement scrollFrame = driver.FindElement(By.Id("courses-iframe"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", scrollFrame);

            //js.ExecuteScript("window.scrollBy(0,1000)");
            driver.SwitchTo().Frame(driver.FindElement(By.Id("courses-iframe")));
            // driver.SwitchTo().Frame(driver.FindElement(By.Name("google_esf")));
            //driver.FindElement(By.CssSelector("li[class='current'] a")).Click();
            driver.FindElement(By.XPath("//h3[text()='Mentorship']")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.XPath("//button[text()='Home']")).Click();
            IList<IWebElement> courses = driver.FindElements(By.XPath("//section[@class='welcome-section']/div[1]/div[1]/div//h3"));
            foreach (IWebElement i in courses)
            {
                Console.WriteLine(i.Text);
            }
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
