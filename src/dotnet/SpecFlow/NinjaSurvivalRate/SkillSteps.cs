using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using NinjaSurvivalRate.TestExtensions;

namespace NinjaSurvivalRate
{
    [Binding]
    public class SkillSteps
    {
        private String opponent;
        private List<Skill> skills;

        [Given(@"^the following skills are allowed$")]
        public void setAllowedSkills(Table table)
        {
            skills = new List<Skill>();
            foreach (TableRow rows in table.Rows)
            {
                skills.Add(new Skill(rows[0]));
            }
        }

        [When(@"^a ninja faces [a\s]*(.*)$")]
        public void setOpponent(String opponent)
        {
            this.opponent = opponent;
        }

        [Then(@"^he should expect the following attack techniques$")]
        public void checkExpectedTechniques(Table table)
        {
            var actualTable = new Table("technique","danger");
            
            foreach (Skill skill in skills.Where(skill => skill.AvailableTo(opponent)))
            {
                actualTable.AddRow(skill.Name(), skill.Danger(opponent));
            }

            Console.WriteLine(actualTable.ToString());

            actualTable.ShouldBeSameAs(table);
        }


    }
}