using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace NinjaSurvivalRate
{
    public class KillerSteps
    {
        //START:steps 
        private static int killed = 0;
        private static int remaining = 3;

        [Before]
        public void KillNinjaBeforeEachScenario()
        {
            killed++;
        }

        [After]
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

        [Then("^Chuck Norris should kill one ninja$")]
        public void ChuckNorrisShouldKillOneNinja()
        {
            HeShouldKillNinjas(1);
        }

        [Then("^he should kill ([0-9]+)* ninjas$")]
        public void HeShouldKillNinjas(int expected)
        {
            Assert.AreEqual(expected, killed);
        }

        //END:steps
    }
}