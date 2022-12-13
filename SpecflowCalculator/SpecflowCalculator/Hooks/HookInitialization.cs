using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ToDoApp.Drivers;

namespace ToDoApp.Hooks
{
    [Binding]
    public sealed class HookInitialization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly ScenarioContext _scenariocontext;

        public HookInitialization(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            SeleniumDriver selenium = new SeleniumDriver(_scenariocontext);
            _scenariocontext.Set(selenium, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
