using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace CsharpFramework.Tests
{
    [TestFixture]
    public class SortWebTableAndwindow
    {

        [Test]
        public void SortTable()
        {
            IWebDriver driver;
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            driver.Manage().Window.Maximize();
            SelectElement select = new SelectElement(driver.FindElement(By.Id("page-menu")));
            select.SelectByValue("20");
            IList<IWebElement> veggies = driver.FindElements(By.XPath("//td[1]"));
            ArrayList array = new ArrayList();
            ArrayList sortArray = new ArrayList();
            foreach (IWebElement veg in veggies)
            {
                array.Add(veg.Text);
            }
            array.Sort();
            //foreach (string i in array)
            //{
            //    TestContext.Progress.WriteLine(i);
            //}
            driver.FindElement(By.CssSelector("th span")).Click();
            IList<IWebElement> sortVeggies = driver.FindElements(By.CssSelector("tr td:nth-child(1)"));
            foreach (IWebElement sortveg in sortVeggies)
            {
                sortArray.Add(sortveg.Text);

            }
            Assert.AreEqual(array, sortArray);
            driver.Close();
        }
        [Test]
        public void SwitchWindow()
        {
            IWebDriver driver;
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector(".blinkingText")).Click();
            IReadOnlyCollection<string> handles = driver.WindowHandles;
            Assert.AreEqual(2, handles.Count);
            string currentWindow = driver.CurrentWindowHandle;
            foreach (string i in handles)
            {
                if (currentWindow != i)
                {
                    driver.SwitchTo().Window(i);
                    break;
                }
            }
            //String message=driver.FindElement(By.CssSelector("strong a")).Text;
            string message = driver.FindElement(By.CssSelector("p[class*='red']")).Text;
            Console.WriteLine(message);
            string email = message.Split("at")[1].Trim().Split(" ")[0];
            Console.WriteLine(email);
            driver.SwitchTo().Window(currentWindow);
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).SendKeys(email);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
