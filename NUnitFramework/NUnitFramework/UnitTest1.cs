using NUnit.Framework;

namespace NUnitFramework
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
            //WebDriver driver = new ChromeDriver();
            //driver.Url=""
            System.Console.WriteLine("setup");
        }

        [Test, NUnit.Framework.Category("Module1")]
        public void Test1()
        {
            System.Console.WriteLine("test1");
        }
        [Test, NUnit.Framework.Category("Module1"), Ignore("To test ignore attribute")]
        public void Test2()
        {
            System.Console.WriteLine("test2");
            TestContext.Progress.WriteLine("testcontext test2");
        }

        [TearDown]
        public void CleanUp()
        {
            System.Console.WriteLine("teardown");
        }
    }
}