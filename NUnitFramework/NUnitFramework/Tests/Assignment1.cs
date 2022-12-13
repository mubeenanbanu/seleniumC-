using NUnit.Framework;
using NUnitFramework.PageObjects;

namespace NUnitFramework
{
    [TestFixture]
    public class Assignment1 : BaseTest
    {

        [Test]
        public void Test1()
        {
            //SearchPage s = GoTo();
            //ResultPage r = s.SearchBox("selenium");
            //r.ClickonResult();

            var s=new SearchPage(driver);
            s.SearchBox("selenium");
        }


    }
}
