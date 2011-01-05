package ninjasurvivalrate;

import cuke4duke.annotation.I18n.EN.Given;
import cuke4duke.annotation.I18n.EN.Then;
import cuke4duke.annotation.I18n.EN.When;
import java.util.Map;
import java.util.List;
import java.util.Collection;

import static junit.framework.Assert.assertTrue;

//START:constructor
public class NinjaSurvivalSteps {
 private NinjaContext ninjaContext; 
 public NinjaSurvivalSteps(NinjaContext ninjaContext){
 	this.ninjaContext=ninjaContext;
 }
//END:constructor
 Collection<String> actions;
 //START:belt
 @Given ("^the ninja has a ([a-z]*) level black\\-belt$")
 public void theNinjaHasABlackbelt(String level) {
	ninjaContext.setNinja(new Ninja(level));
 }
 //END:belt
 //START:attacked
 @When ("^attacked by [a\\s]*(.*)$")
 public void attackedBy(String opponent) {
	actions=ninjaContext.getNinja().attackedBy(opponent);
 }
 //END:attacked
 //START:actions
 @Then ("^the ninja should (.*)$")
 public void theNinjaShould(String action) {
	assertTrue(actions.contains(action));
 }
 //END:actions
 //START:singletable
 @Given ("^a ninja with the following experience$")
 public void ninjaWithExperience(cuke4duke.Table table) {
	List<Map<String,String>> hashes=table.hashes();
	Map<String,String> ninjaProperties=hashes.get(0);
	ninjaContext.setNinja(new Ninja(ninjaProperties.get("belt_level")));
 }
 //END:singletable
}
