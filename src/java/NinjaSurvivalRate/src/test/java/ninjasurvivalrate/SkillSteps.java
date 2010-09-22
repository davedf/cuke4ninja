package ninjasurvivalrate;

import cuke4duke.annotation.I18n.EN.Given;
import cuke4duke.annotation.I18n.EN.Then;
import cuke4duke.annotation.I18n.EN.When;
import java.util.Map;
import java.util.HashMap;
import java.util.List;
import java.util.ArrayList;
import java.util.Collection;

import static junit.framework.Assert.assertTrue;

public class SkillSteps {
 List<Skill> skills;
 String opponent;
 //START:raw
 @Given ("^the following skills are allowed$")
 public void setAllowedSkills(cuke4duke.Table table) {
	 skills=new ArrayList<Skill>();
	 for (List<String> rows:table.raw()){
		 skills.add(new Skill(rows.get(0)));
	 }
 }
 //END:raw
 @When ("^a ninja faces [a\\s]*(.*)$")
 public void setOpponent(String opponent) {
	 this.opponent=opponent;
 }
 //START:diff
 @Then ("^he should expect the following attack techniques$")
 public void checkExpectedTechniques(cuke4duke.Table table) {
	 List<Map<String,String>> actualTechniques=
		   new ArrayList<Map<String,String>>();
	 for (Skill skill:skills){
		 if (skill.availableTo(opponent)){
			 actualTechniques.add(toHash(skill,opponent));
		 }
	 }	 
	 table.diffHashes(actualTechniques);
 }
 private Map<String,String> toHash(Skill skill,String opponent){
	 Map<String,String> map=new HashMap<String,String>();
	 map.put("technique",skill.getName());
	 map.put("danger",skill.getDanger(opponent));
	 return map;
 }
 //END:diff

}
