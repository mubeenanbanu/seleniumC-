using CsharpFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace CsharpFramework.Tests
{
    public class ActionsClass : Base
    {

        // public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        // [SetUp]
        //public void setup()
        //{
        //    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
        //    driver = new EdgeDriver();


        //    driver.Manage().Window.Maximize();
        //}
        [Test, Category("Module1"), Order(1)]
        public void Practise()
        {
            driver.Value.Url = "https://rahulshettyacademy.com/";
            Actions a = new Actions(driver.Value);
            a.MoveToElement(driver.Value.FindElement(By.PartialLinkText("More"))).Perform();

            Thread.Sleep(1000);
            a.MoveToElement(driver.Value.FindElement(By.PartialLinkText("About"))).Click().Perform();


        }
        [Test, Category("Module1"), Order(2)]
        public void Droppable()
        {
            driver.Value.Url = "https://demoqa.com/droppable";
            Actions a = new Actions(driver.Value);
            a.DragAndDrop(driver.Value.FindElement(By.Id("draggable")), driver.Value.FindElement(By.Id("droppable"))).Perform();
            string msg = driver.Value.FindElement(By.CssSelector("div[id='droppable'] p")).Text;
            Thread.Sleep(1000);
            Console.WriteLine(msg);
        }
        //[TearDown]
        public void CleanUp()
        {
            driver.Value.Close();
        }
    }
}
