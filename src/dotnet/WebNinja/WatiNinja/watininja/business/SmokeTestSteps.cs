using Cuke4Nuke.Framework;
using NUnit.Framework;
using WatiN.Core;

namespace WatiNinja.watininja.business
{
    public class SmokeTestSteps
    {
        [When("^I search for \"(.*)\" on google$")]
        public void HelloWatin(string search)
        {
            using (var browser = new IE("http://www.google.com"))
            {
                browser.TextField(Find.ByName("q")).TypeText(search);
                browser.Button(Find.ByName("btnG")).Click();

                Assert.IsTrue(browser.ContainsText(search));
            }
        }
    }
}