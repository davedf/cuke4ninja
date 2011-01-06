using System;
using System.Collections.Generic;

namespace NinjaSurvivalRate
{
    public class Ninja
    {
        public Ninja(String beltLevel)
        {
            Belt = beltLevel;
        }

        public List<String> AttackedBy(String opponent)
        {
            if ("Chuck Norris" == opponent)
                return new List<string>(
                    new[] {"run for his life"});

            return new List<string>(
                new[] {"engage the opponent"});
        }

        public string Belt { get; set; }

        public string CalculateImpact(string opponent)
        {
            if (Belt != "third")
                return "split";
            return opponent == "Chuck Norris" ? "split" : "not harmed";
        }
 
    }
}