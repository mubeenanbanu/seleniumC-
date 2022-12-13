using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitFramework
{
    [TestFixture]
    public class UnitTest2
    {
        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void StartDriver()
        {
            //new WebDriverManager.DriverManager().SetupDriver(new ChromeConfig());
            driver.Url = "https://www.rahulshettyacademy.com/angularpractice/";
        }

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            //System.Console.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Title);
        }
        [Test, NUnit.Framework.Category("Module1")]
        public void Test()
        {

            String heading = driver.FindElement(By.CssSelector("[class='jumbotron'] h1")).Text;
            TestContext.Progress.WriteLine("heading " + heading);
        }
        [Test, NUnit.Framework.Category("Module1")]
        public void Test1()
        {
            driver.FindElement(By.Name("name")).SendKeys("Mubeena");
            TestContext.Progress.WriteLine(driver.FindElement(By.CssSelector("[class='container'] p")).Text);

        }
        [TearDown]
        public void Teardown()
        {
            TestContext.Progress.WriteLine(" teardown- Test done");

        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
