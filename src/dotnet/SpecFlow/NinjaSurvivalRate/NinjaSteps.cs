using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NinjaSurvivalRate
{
    [Binding]
    public class NinjaSteps
    {
        private List<String> actions;
        private Ninja ninja;

        [Given(@"^the ninja has a ([a-z]*) level black-belt$")]
        public void TheNinjaHasABlackBelt(String level)
        {
            ninja = new Ninja(level);
        }

        [When(@"^attacked by [a\s]*(.*)$")]
        public void AttackedBy(String opponent)
        {
            actions = ninja.AttackedBy(opponent);
        }

        [Then("^the ninja should (.*)$")]
        public void TheNinjaShould(String action)
        {
            Assert.IsTrue(actions.Contains(action));
        }


        [Given("^a ninja with the following experience$")]
        public void NinjaWithExperience(Table table)
        {
            string beltLevel = table.Rows.Select(r => r["belt_level"]).FirstOrDefault();
            ninja = new Ninja(beltLevel);
        }
    }
}