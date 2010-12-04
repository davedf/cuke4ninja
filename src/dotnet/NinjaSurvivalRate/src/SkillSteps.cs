using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace NinjaSurvivalRate.src
{
 public class SkillSteps {
 List<Skill> skills;
 String opponent;
 //START:raw
 [Given (@"^the following skills are allowed$")]
 public void setAllowedSkills(Table table) {
	 skills=new List<Skill>();
	 foreach (List<String> rows in table.Data){
		 skills.Add(new Skill(rows[0]));
	 }
 }
 //END:raw
 [When (@"^a ninja faces [a\s]*(.*)$")]
 public void setOpponent(String opponent) {
	 this.opponent=opponent;
 }
 //START:diff
 [Then (@"^he should expect the following attack techniques$")]
 public void checkExpectedTechniques(Table table) {
  //   System.Diagnostics.Debugger.Break();
     Table actualTable = new Table();
     actualTable.Data.Add(ToList ( "technique", "danger" ));
	 foreach (Skill skill in skills){
		 if (skill.AvailableTo(opponent)){
           actualTable.Data.Add(
            ToList(skill.Name(), skill.Danger(opponent)));
		 }
	 }
     Console.WriteLine(actualTable.ToString());
     table.AssertSameAs(actualTable);
 }
 //END:diff
 public List<String> ToList(params String[] list)
 {
     return new List<String>(list);
 }
}

}
