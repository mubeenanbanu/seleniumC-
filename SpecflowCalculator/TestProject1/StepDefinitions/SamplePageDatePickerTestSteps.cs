using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProject1.Pages;
using ToDoApp.Drivers;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class SamplePageDatePickerTestSteps
    {
        private readonly ScenarioContext _scenariocontext;
        public IWebDriver driver;
        string url = "https://www.globalsqa.com/demo-site/datepicker/";
        SimpleDatePicker picker = null;
        string month = "September";
        string year = "2022";
        public SamplePageDatePickerTestSteps(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }
        [Given(@"Date picker page in Sample page")]
        public void GivenDatePickerPageInSamplePage()
        {
            driver = _scenariocontext.Get<SeleniumDriver>("SeleniumDriver").SetUp();
            driver.Url = url;
            picker = new SimpleDatePicker(driver);
        }
        
        [Then(@"click on Date field")]
        public void ThenClickOnDateField()
        {
            picker.ClickonDate();
        }

        [Then(@"select Month and Year from table")]
        public void ThenSelectMonthAndYearFromTable()
        {

            picker.SelectMonthYear(month, year);
        }
        [Then(@"select Date")]
        public void ThenSelectDate()
        {
            picker.SelectDate();

        }
        [Then(@"Close the Driver instance")]
        public void ThenCloseTheDriverInstance()
        {
            picker.CleanUp();
        }


    }
}
