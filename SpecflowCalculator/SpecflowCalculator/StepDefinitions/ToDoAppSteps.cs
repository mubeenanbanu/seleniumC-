using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using ToDoApp.Drivers;

namespace ToDoApp.StepDefinitions
{
    [Binding]
    public class ToDoAppSteps
    {
        String test_url = "https://lambdatest.github.io/sample-todo-app/";
        String itemName = "sixth item";
        IWebDriver driver;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenariocontext;

        public ToDoAppSteps(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }
       [Given(@"that I am on the LambdaTest Sample app")]
       public void GivenThatIAmOnTheLambaTestSampleApp()
        {
            driver = _scenariocontext.Get<SeleniumDriver>("SeleniumDriver").SetUp();
            driver.Url = test_url;
            
        }
        
        [Then(@"select the first item")]
        public void ThenSelectTheFirstItem()
        {
            IWebElement first=driver.FindElement(By.Name("li1"));
            first.Click();
        }
        
        [Then(@"select the second item")]
        public void ThenSelectTheSecondItem()
        {
            IWebElement second = driver.FindElement(By.Name("li2"));
            second.Click();
        }
        
        [Then(@"find the text box to enter the new value")]
        public void ThenFindTheTextBoxToEnterTheNewValue()
        {
            IWebElement textBox = driver.FindElement(By.Id("sampletodotext"));
            textBox.SendKeys(itemName);
        }
        
        [Then(@"click the Submit button")]
        public void ThenClickTheSubmitButton()
        {
            IWebElement submit=driver.FindElement(By.Id("addbutton"));
            submit.Submit();
        }
        
        [Then(@"verify whether the item is added to the list")]
        public void ThenVerifyWhetherTheItemIsAddedToTheList()
        {
            IWebElement item = driver.FindElement(By.XPath("//div[@class='container']/div/ul/li[6]/span"));
            string text = item.Text;
            Assert.That(text.Contains(itemName), Is.True);
        }
        
        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            driver.Quit();
        }
    }
}
