using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    public class SamplePage
    {
        public IWebDriver driver;
        public SamplePage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public IWebElement Name => driver.FindElement(By.Name("g2599-name"));

        public IWebElement Email => driver.FindElement(By.Name("g2599-email"));

        public IWebElement Dropdown => driver.FindElement(By.Id("g2599-experienceinyears"));

        public IWebElement Comment => driver.FindElement(By.Name("g2599-comment"));

        public IWebElement Submit => driver.FindElement(By.ClassName("pushbutton-wide"));
        public void SendName()
        {
            Name.Click();
            Name.SendKeys("mubeena");
        }

        public void SendEmail()
        {
            Email.Click();
            Email.SendKeys("mubeena@gmail.com");
        }
        public void SelectExperience()
        {
            SelectElement  s = new SelectElement(Dropdown);
            s.SelectByIndex(1);

        }

        public void EnterComment()
        {
            Comment.SendKeys("sample page test");
            Thread.Sleep(1000);
        }
        public void ClickOnSubmit()
        {
            Submit.Click();
        }
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
