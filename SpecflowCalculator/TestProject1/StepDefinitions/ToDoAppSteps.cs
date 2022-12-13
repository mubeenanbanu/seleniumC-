using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using ToDoApp.Drivers;
using TestProject1.Pages;

namespace ToDoApp.StepDefinitions
{
    [Binding]
    public class ToDoAppSteps
    {
        String test_url = "https://lambdatest.github.io/sample-todo-app/";
        String itemName = "sixth item";
        IWebDriver driver;
        ToDoAppPage page = null;

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
            page = new ToDoAppPage(driver);
            
        }
        
        [Then(@"select the first item")]
        public void ThenSelectTheFirstItem()
        {
            page.ClickFirstItem();
        }
        
        [Then(@"select the second item")]
        public void ThenSelectTheSecondItem()
        {
            page.ClickSecondItem();
        }
        
        [Then(@"find the text box to enter the new value")]
        public void ThenFindTheTextBoxToEnterTheNewValue()

        {
            page.SendText();
        }
        
        
        [Then(@"click the Submit button")]
        public void ThenClickTheSubmitButton()
        {
            page.ClickAdd();
        }
        
        [Then(@"verify whether the item is added to the list")]
        public void ThenVerifyWhetherTheItemIsAddedToTheList()
        {
            page.VerifyAdd();
        }
        
        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            page.CloseDriver();
        }
      
    }
}
