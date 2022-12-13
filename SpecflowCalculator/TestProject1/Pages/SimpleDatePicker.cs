using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    public class SimpleDatePicker
    {
        public IWebDriver driver;
        public SimpleDatePicker(IWebDriver driverI)
        {
            driver = driverI;

        }
        public IWebElement DateField => driver.FindElement(By.Id("datepicker"));

        public IWebElement ActualMonth => driver.FindElement(By.ClassName("ui-datepicker-month"));

        public IWebElement ActualYear => driver.FindElement(By.ClassName("ui-datepicker-year"));

        public IWebElement NextButton => driver.FindElement(By.XPath("//span[text()='Next']"));

        public IWebElement Actualdate => driver.FindElement(By.XPath("//table[@class='ui-datepicker-calendar']/tbody/tr[4]"));

        public void ClickonDate()
        {
            IWebElement frame = driver.FindElement(By.XPath("//iframe[contains(@class,'demo-frame')]"));
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(4000);
            DateField.Click();
        }

        public void SelectMonthYear(string month,string year)
        {
            //,string date)
            string actualmonth = ActualMonth.Text;
            string actualyear = ActualYear.Text;
            Console.WriteLine(actualmonth+ " "+actualyear);
            while(!(actualmonth.Equals(month) && actualyear.Equals(year)))
            {

                NextButton.Click();
                actualmonth = ActualMonth.Text;
                actualyear = ActualYear.Text;
            }
            
            Console.WriteLine(actualmonth + " " + actualyear);


        }
        public void SelectDate()
        {
            Actualdate.Click();
            Thread.Sleep(1000);
            //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            //ss.SaveAsFile("C:/Image.png",
            //ScreenshotImageFormat.Png);
        }
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
