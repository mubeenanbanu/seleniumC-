using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitFramework.PageObjects
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='contents']//ytd-playlist-renderer/div/a[1]")]
        public IWebElement firstDisplay;

        public void ClickonResult()
        {
            firstDisplay.Click();
        }
    }
}
