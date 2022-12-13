using CsharpFramework.AbstractComponent;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace CsharpFramework.PageObjects
{
    public class LoginPage : AbstractComponentClass
    {
        public IWebDriver driver;
        public ProductCataloguePage p;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement user;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement pwd;

        [FindsBy(How = How.XPath, Using = "//*[@type='radio']")]
        public IList<IWebElement> radios;

        [FindsBy(How = How.Id, Using = "terms")]
        public IWebElement termsCheckBox;

        [FindsBy(How = How.CssSelector, Using = "[id='signInBtn']")]
        public IWebElement signInButton;

        By modal = By.ClassName("modal-body");

        [FindsBy(How = How.Id, Using = "okayBtn")]
        public IWebElement okay;

        [FindsBy(How = How.CssSelector, Using = "select[class='form-control']")]
        public IWebElement select;

        public ProductCataloguePage Login(string username, string password)
        {
            user.SendKeys(username);
            pwd.SendKeys(password);

            foreach (WebElement i in radios)
            {
                if (i.GetAttribute("value").Equals("user"))
                {
                    i.Click();


                }
            }

            WaitForElementToVisible(modal);
            okay.Click();
            SelectElement s = new SelectElement(select);
            s.SelectByIndex(0);
            termsCheckBox.Click();
            signInButton.Click();
            p = new ProductCataloguePage(driver);
            return p;

        }
    }
}
