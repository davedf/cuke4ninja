using System;

namespace NinjaSurvivalRate
{
    public class ImpactCalculator
    {
        public string CalculateImpact(Ninja ninja, string opponent)
        {
            if (ninja == null)
                throw new Exception("Ninja is not defined");
            if (ninja.Belt != "third")
                return "split";
            if (opponent == "chuck Norris")
                return "split";
            return "not harmed";
        }
    }
}