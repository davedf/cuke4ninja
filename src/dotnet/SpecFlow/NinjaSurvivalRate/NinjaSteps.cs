using System;
using System.Collections.Generic;
using System.Linq;
using NinjaSurvivalRate.Parameters;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NinjaSurvivalRate
{
    [Binding]
    public class NinjaSteps
    {
        private List<String> actions;
        private Ninja ninja;

        [Given(@"^the ninja has a (.*)$")]
        public void TheNinjaHasABlackBelt(BeltLevel level)
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

            BeltLevel beltLevelEnum;
            Enum.TryParse(beltLevel, true, out beltLevelEnum);

            ninja = new Ninja( beltLevelEnum);
        }

        [Given("^a ninja with the following parameterized experience$")]
        public void NinjaWithParameterizedExperience(Table table)
        {
            var experience = table.CreateInstance<NinjaExperience>();

            ninja = new Ninja(experience.GetNinjaBeltLevel());
        }
    }
}