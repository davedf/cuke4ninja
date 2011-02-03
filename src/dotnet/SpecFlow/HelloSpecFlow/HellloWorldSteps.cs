using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HelloSpecFlow
{
    [Binding]
    public class HelloWorldSteps
    {
        private string _action;
        private string _subject;

        //START:action
        [Given("^The Action is (.*)$")]
        public void ActionIs(string action)
        {
            _action = action;
        }

        [When("^The Subject is (.*)$")]
        public void SubjectIs(string subject)
        {
            _subject = subject;
        }

        [Then("^The Greeting is (.*)$")]
        public void CheckGreeting(string greeting)
        {
            Assert.AreEqual(greeting,
                            String.Format("{0}, {1}", _action, _subject));
        }
    }
}