using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using ToDoApp.Drivers;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class LoginSteps
        
    {
        IWebDriver driver;
        LoginHRMPage loginPage = null;
        string url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        private readonly ScenarioContext _scenarioContext;
        public LoginSteps(ScenarioContext scenariocontext)
        {
            _scenarioContext = scenariocontext;

        }
        [Given(@"OrangeHRM testApp")]
        public void GivenOrangeHRMTestApp()
        {
           driver= _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").SetUp();
            driver.Url = url;
            loginPage = new LoginHRMPage(driver);
        }
        
        [Then(@"enter Username")]
        public void ThenEnterUsername()
        {
            loginPage.SendUsername();
        }
        
        [Then(@"enter Password")]
        public void ThenEnterPassword()
        {
            loginPage.SendPassword();
        }
        
        [Then(@"click on Login button")]
        public void ThenClickOnLoginButton()
        {
            loginPage.ClickOnLogin();
        }
        
        [Then(@"verify whether login is successfull")]
        public void ThenVerifyWhetherLoginIsSuccessfull()
        {
            loginPage.VerifyLogin();
            
        }

        [Then(@"close the Driver instance for Login")]
        public void ClosetheDriverInstanceForLogin()
        {
            loginPage.Close();
        }

    }
}
