using NUnit.Framework;
using NUnitFramework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitFramework
{
    public class BaseTest
    {

        public IWebDriver driver;
        public SearchPage s;
        [SetUp]
        public void Open()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.youtube.com/";

        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
        //public SearchPage GoTo()
        //{
        //    driver.Url = "https://www.youtube.com/";
        //    s = new SearchPage(driver);

        //    return s;
        //}
    }
}
