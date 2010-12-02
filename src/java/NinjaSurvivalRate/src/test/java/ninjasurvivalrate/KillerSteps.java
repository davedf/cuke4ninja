package ninjasurvivalrate;

import cuke4duke.annotation.I18n.EN.*;
import cuke4duke.annotation.*;
import java.util.Map;
import java.util.List;
import java.util.Collection;
import static junit.framework.Assert.assertEquals;

public class KillerSteps {

 //START:steps 
 private static int killed=0;
 private static int remaining=3;

 @Before 
 public void killNinjaBeforeEachScenario(){
   killed++;
 }
 @After
 public void expectLessNinjasAfterScenario(){
   remaining--;
 }
 @When ("^this scenario is executed$")
 public void thisScenarioIsExecuted() {
  // do absolutely nothing
 }
 @Then ("^Chuck Norris should expect ([0-9]+)* ninjas$")
 public void chuckNorrisShouldExpectNinjas(int expected) {
   assertEquals(expected, remaining);
 }
 @Then ("^Chuck Norris should kill one ninja$")
 public void chuckNorrisShouldKillOneNinja() {
   heShouldKillNinjas(1);
 }
 @Then ("^he should kill ([0-9]+)* ninjas$")
 public void heShouldKillNinjas(int expected) {
   assertEquals(expected, killed);
 }
 //END:steps
}
