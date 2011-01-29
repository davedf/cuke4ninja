using NUnit.Framework;
using WatiN.Core;

namespace WatiNinja.test
{
    [TestFixture]
    public class SmokeTest
    {
        [Test]
        public void RunSmokeTest()
        {
            using (var browser = new IE("http://www.google.com"))
            {
                const string search = "WatiN";
                browser.TextField(Find.ByName("q")).TypeText(search);
                browser.Button(Find.ByName("btnG")).Click();
                Assert.IsTrue(browser.ContainsText(search));
            }
        } 
    }
}