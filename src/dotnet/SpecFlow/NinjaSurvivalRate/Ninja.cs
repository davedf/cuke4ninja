using System;
using System.Collections.Generic;

namespace NinjaSurvivalRate
{
    public class Ninja
    {
        private readonly string _beltLevel;

        public Ninja(String beltLevel)
        {
            _beltLevel = beltLevel;
        }

        public List<String> AttackedBy(String opponent)
        {
            if ("Chuck Norris" == opponent)
                return new List<string>(
                    new[] {"run for his life"});

            if (opponent != "Chuck Norris" && _beltLevel != "third")
                return new List<string>(
                    new[] {"run for his life"});

            return new List<string>(
                new[] {"engage the opponent"});
        }
    }
}