using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitFramework.PageObjects
{
    public class ChannelDetailsPage
    {
        IWebDriver driver;
        public ChannelDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
