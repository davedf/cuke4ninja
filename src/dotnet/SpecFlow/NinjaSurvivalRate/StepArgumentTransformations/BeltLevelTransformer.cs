using TechTalk.SpecFlow;

namespace NinjaSurvivalRate.StepArgumentTransformations
{
    [Binding]
    public class BeltLevelTransformer
    {
        [StepArgumentTransformation("([a-z]*) level black-belt")]
        public BeltLevel BeltLevelOf(string beltlevel)
        {
            BeltLevel beltLevelEnum;
            BeltLevel.TryParse(beltlevel, true, out beltLevelEnum);

            return beltLevelEnum;
        }
    }
}