package ninjasurvivalrate;

import cuke4duke.annotation.I18n.EN.Given;
import cuke4duke.annotation.I18n.EN.Then;
import cuke4duke.annotation.I18n.EN.When;
import java.util.Map;
import java.util.List;
import java.util.Collection;

import static junit.framework.Assert.assertEquals;

public class SplitSteps {
 private NinjaContext ninjaContext;
 private String opponent;
 private String weapon; 
 public SplitSteps(NinjaContext ninjaContext){
 	this.ninjaContext=ninjaContext;
 }
 @When ("^hit on the head by [a ]*([A-z ]*) with a ([A-z]*)$")
 public void hitOnTheHead(String opponent, String weapon) {
  this.opponent=opponent;
  this.weapon=weapon;
 }
 @Then ("^the ninja's ([A-z]*) should not be harmed$")
 public void shouldNotBeHarmed(String target) {
   expectImpact(target,"not harmed");
 }
 @Then ("^the ninja's ([A-z]*) should ([A-z]*)$")
 public void expectImpact(String target, String expectedImpact) {
  String actualImpact=ninjaContext.getNinja().impact(target,opponent,weapon);
  assertEquals(expectedImpact,actualImpact); 
 }
}
