using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitFramework
{
    [TestFixture]
    public class E2E
    {
        IWebDriver driver;

        [SetUp]
        public void StartDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }
        [Author("Mubeena", "mubeena@mail.com")]
        [Description("description")]
        [Test, NUnit.Framework.Category("Module1")]
        public void AddProductToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
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
            String[] expectedprods = { "Nokia Edge", "Samsung Note 8" };
            string[] actualProducts = new string[2];

            IList<IWebElement> cards = driver.FindElements(By.TagName("app-card"));
            foreach (IWebElement product in cards)
            {
                String productName = product.FindElement(By.ClassName("card-title")).Text;
                if (expectedprods.Contains(productName))
                {
                    product.FindElement(By.CssSelector("[class='card-footer'] button")).Click();

                }
            }
            driver.FindElement(By.CssSelector("[class*='btn btn-primary']")).Click();
            IList<IWebElement> productsInCart = driver.FindElements(By.XPath("//tr//td//div//div//h4"));
            for (int i = 0; i < productsInCart.Count; i++)
            {
                actualProducts[i] = productsInCart[i].Text;

            }
            //Assert.AreSame(actualProducts, expectedprods);
            driver.FindElement(By.CssSelector("button[class*='btn-success']")).Click();
            driver.FindElement(By.Id("country")).Click();
            driver.FindElement(By.Id("country")).SendKeys("Indi");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("[class='suggestions'] a")));
            IList<IWebElement> countries = driver.FindElements(By.CssSelector("[class='suggestions'] a"));
            foreach (IWebElement i in countries)
            {
                if (i.Text.Equals("India"))
                {
                    i.Click();
                }
            }
            driver.FindElement(By.CssSelector("[for='checkbox2']")).Click();
            driver.FindElement(By.CssSelector("[value='Purchase']")).Click();
            String successmsg = driver.FindElement(By.CssSelector("[class*='alert-success']")).Text;
            TestContext.Progress.WriteLine(successmsg);

        }
        //[Test,Order(1)]
        public void Login()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
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
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

    }
}
