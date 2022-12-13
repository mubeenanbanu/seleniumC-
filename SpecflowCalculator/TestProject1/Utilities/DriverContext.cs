using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Utilities
{
    public static class DriverContext
    {
        private static IWebDriver driver;

        internal static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }

    }
}
