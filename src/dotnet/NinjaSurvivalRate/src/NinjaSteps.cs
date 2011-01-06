using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cuke4Nuke.Framework;
using NUnit.Framework;
namespace NinjaSurvivalRate
{
  public class NinjaSteps
  	{
    Ninja ninja;
    List<String> actions;
    //START:belt
    [Given(@"^the ninja has a ([a-z]*) level black-belt$")]
    public void TheNinjaHasABlackBelt(String level)
    {
      ninja = new Ninja(level);
    }
    //END:belt
    //START:attacked
    [When(@"^attacked by [a\s]*(.*)$")]
    public void AttackedBy(String opponent)
    {
      actions = ninja.AttackedBy(opponent);
    }
    //END:attacked
    //START:actions
    [Then("^the ninja should (.*)$")]
    public void TheNinjaShould(String action)
    {
      Assert.IsTrue(actions.Contains(action));
    }
    //END:actions
    //START:singletable
    [Given("^a ninja with the following experience$")]
    public void NinjaWithExperience(Table table)
    {
      List<Dictionary<string, string>> hashes = table.Hashes();
      Dictionary<String, String> ninjaProperties = hashes[0];
      ninja = new Ninja(ninjaProperties["belt_level"]);
    }
    //END:singletable
  }
}
