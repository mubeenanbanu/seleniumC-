using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace nunitproject
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:/Users/mubeena/Downloads");
            driver.Url = "https://demoqa.com/buttons";
            driver.Manage().Window.Maximize();
            try
            {
                Actions action = new Actions(driver);
                IWebElement rightClick = driver.FindElement(By.Id("rightClickBtn"));
                
                action.ContextClick(rightClick);
                action.Perform();
                //Console.WriteLine("element is clicked");
                IWebElement msg = driver.FindElement(By.Id("rightClickMessage"));
                Console.WriteLine(msg.Text);
                Assert.AreEqual(msg.Text, "You have done a right click", "element is not clickable");

            }
            catch(Exception ex)
            {
                System.Console.WriteLine("element not clickable");
            }
            finally
            {
                driver.Close();
            }
            
           


        }
    }
}