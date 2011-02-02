using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NinjaSurvivalRate
{
    [Binding]
    public class KillerSteps
    {
        private static int killed;
        private static int remaining = 3;

        [BeforeScenario("First_blood","Second_blood")]
        public void KillNinjaBeforeEachScenario()
        {
            killed++;
        }

        [AfterScenario("First_blood", "Second_blood")]
        public void ExpectLessNinjasAfterScenario()
        {
            remaining--;
        }

        [When(@"^this scenario is executed$")]
        public void ThisScenarioIsExecuted()
        {
            // do absolutely nothing
        }

        [Then("^Chuck Norris should expect ([0-9]+)* ninjas$")]
        public void ChuckNorrisShouldExpectNinjas(int expected)
        {
            Assert.AreEqual(expected, remaining);
        }

        [Then("^Chuck Norris will have killed one ninja$")]
        public void ChuckNorrisShouldKillOneNinja()
        {
            HeShouldKillNinjas(1);
        }

        [Then("^he will have killed ([0-9]+)* ninjas$")]
        public void HeShouldKillNinjas(int expected)
        {
            Assert.AreEqual(expected, killed);
        }

    }
}