using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CsharpFramework.AbstractComponent
{
    public class AbstractComponentClass
    {
        public IWebDriver driver;

        public AbstractComponentClass(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void WaitForAllElementsToLocate(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
        public void WaitForElementToVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
