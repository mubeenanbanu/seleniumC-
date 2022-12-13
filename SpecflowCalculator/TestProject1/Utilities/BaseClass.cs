using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Utilities
{
    public class BaseClass
    {
        public IWebDriver driver;
        

        [SetUp]
        public void StartDriver()
        {
           
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();

        }
    }
}
