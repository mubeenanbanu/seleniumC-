using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace ToDoApp.Drivers
{
    public class SeleniumDriver
    {
        public IWebDriver driver;

        private readonly ScenarioContext _scenariocontext;

        public SeleniumDriver(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }
        public IWebDriver SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            _scenariocontext.Set(driver, "webdriver");
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
