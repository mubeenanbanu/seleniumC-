using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Utilities;

namespace TestProject1.Pages
{
    public class BasePage
    {
        public IWebDriver driver;
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);

        }
    }
}
