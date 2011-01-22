using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace WatiNinja.watininja
{
    [TestFixture]
    public class CukeStepsTest
    {
        [Test]
        public void SmokeTest()
        {
            new SmokeTestSteps().HelloWatin("WatiN"); 
        } 
    }
}
