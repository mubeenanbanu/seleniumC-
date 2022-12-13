using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using ToDoApp.Drivers;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class SamplePageTestSteps
    {
        private  readonly ScenarioContext _scenariocontext;
        public IWebDriver driver;
        string url = "https://www.globalsqa.com/samplepagetest/";
        SamplePage samplepage = null;
        public SamplePageTestSteps(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }
        [Given(@"Sample page in test")]
        public void GivenSamplePageInTest()
        {
            driver = _scenariocontext.Get<SeleniumDriver>("SeleniumDriver").SetUp();
            driver.Url = url;
            samplepage = new SamplePage(driver);
        }
        
        [Then(@"enter name in Name textbox")]
        public void ThenEnterNameInNameTextbox()
        {
            samplepage.SendName();
        }
        
        [Then(@"enter email in Email textbox")]
        public void ThenEnterEmailInEmailTextbox()
        {
            samplepage.SendEmail();
        }

        [Then(@"select experience in years from Dropown")]
        public void ThenSelectExperienceInYearsFromDropown()
        {
            samplepage.SelectExperience();
        }

        [Then(@"enter the comment in Comment field")]
        public void ThenEnterTheCommentInCommentField()
        {
            samplepage.EnterComment();
        }

        [Then(@"click on Submit button")]
        public void ThenClickOnSubmitButton()
        {
            samplepage.ClickOnSubmit();
            
        }

        [Then(@"close the Driver instance")]
        public void ThenCloseTheDriverInstance()
        {
            samplepage.CleanUp();
        }
    }
}
