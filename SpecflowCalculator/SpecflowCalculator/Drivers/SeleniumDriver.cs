using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

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
            driver = new ChromeDriver(@"C:\Users\mubeena\Downloads");
            _scenariocontext.Set(driver, "webdriver");
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
