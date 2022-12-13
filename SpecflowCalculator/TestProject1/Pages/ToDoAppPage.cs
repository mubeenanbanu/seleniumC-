using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    public class ToDoAppPage
    {
        public IWebDriver driver { get; set; }
        public ToDoAppPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        
        public IWebElement firstItem => driver.FindElement(By.Name("li1"));

        public IWebElement secondItem => driver.FindElement(By.Name("li2"));
        public IWebElement sampleText => driver.FindElement(By.Id("sampletodotext"));

        public IWebElement add => driver.FindElement(By.Id("addbutton"));
        public IWebElement item => driver.FindElement(By.XPath("//div[@class='container']/div/ul/li[6]/span"));
        string itemName="sixth item";

        public void ClickFirstItem()
        {
            firstItem.Click();
            Thread.Sleep(1000);
        }
        public void ClickSecondItem()
        {
            secondItem.Click();
            Thread.Sleep(1000);

        }
        public void SendText()
        {
            sampleText.SendKeys(itemName);
            Thread.Sleep(1000);
        }
        public void ClickAdd()
        {
            add.Click();
        }
        public void VerifyAdd()
        {
            
            string text = item.Text;
            Assert.That(text.Contains(itemName), Is.True);
            Thread.Sleep(1000);
        }
        public void CloseDriver()
        {
            driver.Quit();
        }


    }
}
