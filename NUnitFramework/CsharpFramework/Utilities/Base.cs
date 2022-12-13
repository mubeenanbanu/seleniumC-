using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CsharpFramework.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.IO;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace CsharpFramework.Utilities
{
    public class Base
    {
        //public IWebDriver driver;
        public LoginPage loginpage;
        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public ExtentReports report;
        public ExtentTest test;

        [OneTimeSetUp]
        public void SetUp()
        {
            var currentDirectory = Environment.CurrentDirectory;
            var workDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            String path = workDirectory + "//index.html";
            var htmlreporter = new ExtentHtmlReporter(path);
            report = new ExtentReports();
            report.AttachReporter(htmlreporter);
            report.AddSystemInfo("Tester", "Mubeena");
            report.AddSystemInfo("HostInfo", "LocalHost");
            report.AddSystemInfo("Environment", "QA");


        }
        [SetUp]
        public void StartDriver()
        {
            test = report.CreateTest(TestContext.CurrentContext.Test.Name);
            var browserName = TestContext.Parameters["browserName"];
            if (browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }
            InitBrowser(browserName);
        }
        public void InitBrowser(string browserName)
        {

            switch (browserName)
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver.Value = new ChromeDriver();
                    break;
                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver.Value = new FirefoxDriver();
                    break;
                case "edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver.Value = new EdgeDriver();
                    break;
            }
            //return driver.value;
        }
        [TearDown]
        public void CleanUp()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;
            var message = TestContext.CurrentContext.Result.Message;
            DateTime time = DateTime.Now;
            string screenshot = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            if (status.Equals(TestStatus.Failed))
            {
                test.Fail("Test failed", CaptureScreenshot(driver.Value, screenshot));
                test.Log(Status.Fail, "test failed with stacktrace" + stackTrace);
                TestContext.Progress.WriteLine(message);
            }
            else if (status.Equals(TestStatus.Passed))
            {

                test.Log(Status.Pass, "Test is passed");
            }
            report.Flush();
            driver.Value.Quit();
        }
        public LoginPage GoTo()
        {

            driver.Value.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Value.Manage().Window.Maximize();
            loginpage = new LoginPage(driver.Value);
            return loginpage;
        }
        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string screenshotName)
        {
            ITakesScreenshot t = (ITakesScreenshot)driver;
            var screenshot = t.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
        }
    }
}
