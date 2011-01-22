using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;
using WatiNinja.watininja.business;

namespace WatiNinja.test
{
    [TestFixture]
    public class ReportAssignedStepsTest
    {
        private ReportAssignedSteps _underTest;

        [SetUp]
        public void Setup()
        {
            _underTest = new ReportAssignedSteps();
        }
        [Test]
        public void ThereAreOpenIssuesWithThePropertiesWithTable()
        {
            var table = new Table();
            table.Data.Add(new List<string> { "Title", "Severity" });
            table.Data.Add(new List<string> { "Chuck Norris beat me", "Fatal" });
            _underTest.ThereAreOpenIssuesWithThePropertiesWithTable(table);
            _underTest.TheIssueWithTitleIsAssignedToUser("Chuck Norris beat me", "Ninja2");
            _underTest.UserSeesTheFollowingIssuesInHisReportWithTable("Ninja2", table);
            _underTest.UserSeesNoIssuesInHisReport("Ninja1");
        }

        [TearDown]
        public void CleanUp()
        {
            _underTest.Cleanup();
        }
    }
}
