using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class AboutScenariosSteps
    {
        [When(@"i enter all the details")]
        public void WhenIEnterAllTheDetails(Table table)
        {
            //EmployeeDetails emp = table.CreateInstance<EmployeeDetails>();
            //Console.WriteLine(emp.phone);
            //Console.WriteLine(emp.name);
            //Console.WriteLine(emp.experience);
            //Console.WriteLine(emp.title);

            var details = table.CreateSet<EmployeeDetails>();
            int n = 1;
            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The details of employee " + n + " are ");
                Console.WriteLine(emp.phone);
                Console.WriteLine(emp.name);
                Console.WriteLine(emp.experience);
                Console.WriteLine(emp.title);
                n++;
            }
        }

        [When(@"I enter all the details in form (.*),(.*),(.*),(.*)")]
        public void WhenIEnterAllTheDetailsInFormSoftwareEngineer(string name, Decimal experience, long phone, string title)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("experience " + experience);
            Console.WriteLine("Title: "+title);

        }
    }
}
    
  

