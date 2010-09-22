using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSurvivalRate
{
  public class Ninja
  {
    public Ninja(String beltLevel)
    {

    }
    public List<String> AttackedBy(String opponent)
    {
      if ("Chuck Norris" == opponent)
        return new List<string>(
          new String[] { "run for his life" });
      else
        return new List<string>(
          new String[] { "engage the opponent" });
    }
  }
}
