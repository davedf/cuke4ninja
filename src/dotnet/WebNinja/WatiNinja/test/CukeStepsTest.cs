using NUnit.Framework;
using WatiNinja.watininja.business;

namespace WatiNinja.test
{
    [TestFixture]
    public class CukeStepsTest
    {
        [Test]
        public void SmokeTest()
        {
            new SmokeTestSteps().HelloWatin("WatiN"); 
        } 


    }
}