using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace NUnitFramework.PageObjects
{
    public class SearchPage
    {
        public IWebDriver driver;
        ResultPage r;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement searchTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        public IWebElement serchButton { get; set; }

        public void SearchBox(string input)
        {
            //driver.SwitchTo().Frame(driver.FindElement(searchTextBox);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("search")));
            //Actions a = new Actions(driver);
            //  a.MoveToElement(searchTextBox).Click().Perform();
            //a.MoveToElement(searchTextBox).SendKeys(input).Perform();
            searchTextBox.Click();
            searchTextBox.SendKeys(input);
            serchButton.Click();
            //r = new ResultPage(driver);
            //return r;

        }
    }
}
