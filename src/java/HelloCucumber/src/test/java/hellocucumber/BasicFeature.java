package hellocucumber;

//START:imports
import cuke4duke.annotation.I18n.EN.Given;
import cuke4duke.annotation.I18n.EN.Then;
import cuke4duke.annotation.I18n.EN.When;
import static junit.framework.Assert.assertEquals;
//END:imports

@SuppressWarnings({"UnusedDeclaration"})
public class BasicFeature {
//START:fields
    private String action;
    private String subject;
//END:fields
//START:given
    @Given("^The Action is ([A-z]*)$")
    public void theActionIs(String action) {
        this.action = action;
    }
//END:given
//START:when
    @When("^The Subject is ([A-z]*)$")
    public void theSubjectIs(String subject) {
        this.subject = subject;
    }
//END:when
//START:then
    @Then("^The Greeting is ([^\\.]*).$")
    public void theGreetingIs(String greeting) {
        assertEquals(String.format("%s, %s", action, subject), greeting);
    }
//END:then
}
