using System;
using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace Cuke4NukeExample
{
    public class HelloWorldSteps
    {
        //START:fields
        private string _action;
        private string _subject;
        //END:fields

        //START:action
        [Given("^The Action is (.*)$") ]
        public void ActionIs(string action)
        {
            _action = action;
        }
        //END:action

        //START:subject
        [Then("^The Subject is (.*)$")]
        public void SubjectIs(string subject)
        {
            _subject = subject;
        }
        //END:subject

        //START:then
        [Then("^The Greeting is (.*)$")]
        public void CheckGreeting(string greeting)
        {
            Assert.AreEqual(greeting, 
              String.Format("{0}, {1}", _action, _subject));
        }
        //END:then
    }
}
