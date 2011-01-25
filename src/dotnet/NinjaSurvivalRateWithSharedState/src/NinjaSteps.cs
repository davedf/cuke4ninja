using System;
using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace NinjaSurvivalRate
{
    public class NinjaSteps
    {
        private readonly NinjaContext _ninjaContext;
        private List<String> _actions;

        //START:constructor
        public NinjaSteps(NinjaContext ninjaContext)
        {
            _ninjaContext = ninjaContext;
        }
        //END:constructor

        //START:belt
        [Given(@"^the ninja has a ([a-z]*) level black-belt$")]
        public void TheNinjaHasABlackBelt(String level)
        {
            _ninjaContext.Ninja = new Ninja(level);
        }

        //END:belt
        //START:attacked
        [When(@"^attacked by [a\s]*(.*)$")]
        public void AttackedBy(String opponent)
        {
            _actions = _ninjaContext.Ninja.AttackedBy(opponent);
        }

        //END:attacked
        //START:actions
        [Then("^the ninja should (.*)$")]
        public void TheNinjaShould(String action)
        {
            Assert.IsTrue(_actions.Contains(action));
        }

        //END:actions
        //START:singletable
        [Given("^a ninja with the following experience$")]
        public void NinjaWithExperience(Table table)
        {
            List<Dictionary<string, string>> hashes = table.Hashes();
            Dictionary<String, String> ninjaProperties = hashes[0];
            _ninjaContext.Ninja = new Ninja(ninjaProperties["belt_level"]);
        }

        //END:singletable
    }
}