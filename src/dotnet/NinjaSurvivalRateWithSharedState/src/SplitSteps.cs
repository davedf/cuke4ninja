using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace NinjaSurvivalRate
{
    public class SplitSteps
    {
        private string _opponent;
        private string _weapon;
        private readonly NinjaContext _ninjaContext;

        public SplitSteps(NinjaContext ninjaContext)
        {
            _ninjaContext = ninjaContext;
        }

        [When(@"^hit on the head by [a ]*([A-z ]*) with a ([A-z]*)$")]
        public void HitOnHead(string opponent, string weapon)
        {
            _opponent = opponent;
            _weapon = weapon;
        }

        [Then(@"^the ninja's ([A-z]*) should ([A-z]*)$")]
        public void ExpectImpact(string target, string expectedmpact)
        {
            string actualImpact = _ninjaContext.Ninja.CalculateImpact(_opponent);
            Assert.AreEqual(expectedmpact, actualImpact);            
        }

        [Then(@"^the ninja's ([A-z]*) should not be harmed$")]
        public void NinjaNotHarmed(string target)
        {
            ExpectImpact(target, "not harmed");
        }
    }
}