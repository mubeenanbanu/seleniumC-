using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("setup");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}