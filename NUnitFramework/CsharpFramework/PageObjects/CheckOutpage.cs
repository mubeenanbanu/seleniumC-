using CsharpFramework.AbstractComponent;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace CsharpFramework.PageObjects
{
    public class CheckOutpage : AbstractComponentClass

    {
        public IWebDriver driver;
        public CheckOutpage(IWebDriver driver) : base(driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "country")]
        public IWebElement country;

        [FindsBy(How = How.CssSelector, Using = "[class='suggestions'] a")]
        public IList<IWebElement> countries;

        [FindsBy(How = How.CssSelector, Using = "[for='checkbox2']")]
        public IWebElement checkBox;

        [FindsBy(How = How.CssSelector, Using = "[value='Purchase']")]
        public IWebElement purchase;

        [FindsBy(How = How.CssSelector, Using = "[class*='alert-success']")]
        public IWebElement successEle;

        By suggestions = By.CssSelector("[class='suggestions'] a");

        public void FillCheckoutDetails(string countryName)
        {
            country.Click();
            country.SendKeys(countryName);
            WaitForAllElementsToLocate(suggestions);
            IList<IWebElement> countries1 = countries;
            foreach (IWebElement i in countries1)
            {
                if (i.Text.Equals("India"))
                {
                    i.Click();
                    break;
                }
            }
            checkBox.Click();
            purchase.Click();
            String successmsg = successEle.Text;
            TestContext.Progress.WriteLine(successmsg);
        }

    }
}
