using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpFramework.PageObjects
{
    public class ProductCataloguePage
    {
        public IWebDriver driver;
        public CartPage cartpage;
        public ProductCataloguePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.TagName, Using = "app-card")]
        public IList<IWebElement> products;

        [FindsBy(How = How.CssSelector, Using = "[class*='btn btn-primary']")]
        public IWebElement checkoutButton;

        By cardTitle = By.ClassName("card-title");

        By cartButton = By.CssSelector("[class='card-footer'] button");



        public CartPage AddProductToCart(string[] expectedproducts)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));
            IList<IWebElement> cards = products;
            foreach (IWebElement product in cards)
            {
                String productName = product.FindElement(cardTitle).Text;
                if (expectedproducts.Contains(productName))
                {
                    product.FindElement(cartButton).Click();


                }
            }
            checkoutButton.Click();
            cartpage = new CartPage(driver);
            return cartpage;
        }

    }


}
