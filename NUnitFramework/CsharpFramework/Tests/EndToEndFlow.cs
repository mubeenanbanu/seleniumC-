using CsharpFramework.PageObjects;
using CsharpFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CsharpFramework.Tests
{
    [TestFixture]
    // [Parallelizable(ParallelScope.Children)]
    public class EndToEndFlow : Base
    {

        //[Test,Order(1)]
        [Parallelizable(ParallelScope.All)]
        [Test, TestCaseSource("AddTestDataConfigAddProduct"), Category("Smoke")]
        public void AddProductToCart(String username, String password, string[] expectedprods)
        {
            //String[] expectedprods = { "Nokia Edge", "Samsung Note 8" };
            //String[] expectedprods = product;
            string[] actualProds = new string[2];
            //LoginPage lp = new LoginPage(driver);
            LoginPage loginpage = GoTo();
            ProductCataloguePage p = loginpage.Login(username, password);
            CartPage c = p.AddProductToCart(expectedprods);
            actualProds = c.GetCartproducts(actualProds);

            for (int i = 0; i < actualProds.Length; i++)
            {

                //TestContext.Progress.WriteLine(actualProds[i]) --displays in tests pane of output 
                Console.WriteLine(actualProds[i]);//displays in test explorer
            }

            //Assert.AreEqual(expectedprods, actualProds);
            CheckOutpage chk = c.Checkout();
            chk.FillCheckoutDetails("Ind");


        }
        // [Test,Order(2)]
        //[TestCase("rahulshetty", "learning")]
        //[TestCase("rahulshettyacademy", "learning")]
        [Parallelizable(ParallelScope.All)]
        [Test, TestCaseSource("AddTestDataConfigLogin"), Category("Regression")]
        public void InValidLogin(String username, String password)
        {
            // IWebDriver driver;
            // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver.Value.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Value.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(10));
            driver.Value.FindElement(By.Id("username")).SendKeys(username);
            driver.Value.FindElement(By.Name("password")).SendKeys(password);
            //driver.FindElement(By.CssSelector("[class='form-group']:nth-child(6) label span input")).Click();
            IList<IWebElement> radios = driver.Value.FindElements(By.XPath("//*[@type='radio']"));
            foreach (WebElement i in radios)
            {
                if (i.GetAttribute("value").Equals("user"))
                {
                    i.Click();
                }
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("modal-body")));
            driver.Value.FindElement(By.Id("okayBtn")).Click();

            IWebElement select = driver.Value.FindElement(By.CssSelector("select[class='form-control']"));
            SelectElement s = new SelectElement(select);
            s.SelectByIndex(0);

            driver.Value.FindElement(By.Id("terms")).Click();

            driver.Value.FindElement(By.CssSelector("[id='signInBtn']")).Click();
            Thread.Sleep(3000);
            String errormsg = driver.Value.FindElement(By.CssSelector("[class*='alert-danger']")).Text;
            Console.WriteLine(errormsg);
            //driver.Value.Quit();

        }

        public static IEnumerable<TestCaseData> AddTestDataConfigLogin()
        {
            yield return new TestCaseData(GetDataParser().extractData("username"), GetDataParser().extractData("password"));
            yield return new TestCaseData(GetDataParser().extractData("username_wrong"), GetDataParser().extractData("password_wrong"));
            yield return new TestCaseData(GetDataParser().extractData("username_wrong"), GetDataParser().extractData("password_wrong"));
        }
        public static JsonReader GetDataParser()
        {
            return new JsonReader();
        }
        public static IEnumerable<TestCaseData> AddTestDataConfigAddProduct()
        {
            yield return new TestCaseData(GetDataParser().extractData("username"), GetDataParser().extractData("password"), GetDataParser().ExtractDataArray("products"));
        }
    }
}
