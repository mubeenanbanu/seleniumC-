using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace CsharpFramework.PageObjects
{
    public class CartPage
    {
        public IWebDriver driver;
        public CheckOutpage chkoutPage;
        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "h4 a")]
        public IList<IWebElement> productsInCart;

        [FindsBy(How = How.CssSelector, Using = "button[class*='btn-success']")]
        public IWebElement checkoutButton;

        public string[] GetCartproducts(string[] actualProducts)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            ////wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("container")));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='ProtoCommerce Home']")));
            //// wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//tr//td//div//div//h4")));
            IList<IWebElement> p = productsInCart;
            for (int i = 0; i < p.Count; i++)
            {
                actualProducts[i] = p[i].Text;

            }
            return actualProducts;

        }
        public CheckOutpage Checkout()
        {
            checkoutButton.Click();
            return chkoutPage = new CheckOutpage(driver);
        }
    }
}
