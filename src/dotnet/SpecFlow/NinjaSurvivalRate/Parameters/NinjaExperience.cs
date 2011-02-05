using NinjaSurvivalRate.StepArgumentTransformations;

namespace NinjaSurvivalRate.Parameters
{
    public class NinjaExperience
    {
        public string BeltLevel { private get; set; }
        public string Katana { get; set; }
        public string Sake { get; set; }
        public string Magic { get; set; }
        public string Fought { get; set; }

        public BeltLevel GetNinjaBeltLevel()
        {
            var transformer = new BeltLevelTransformer();
            return transformer.BeltLevelOf(BeltLevel);
        }
    }
}