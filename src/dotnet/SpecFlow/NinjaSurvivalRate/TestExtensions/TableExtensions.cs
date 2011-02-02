using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Linq;

namespace NinjaSurvivalRate.TestExtensions
{
    public static class TableExtensions
    {
        public static void ShouldBeSameAs(this Table actual, Table expected)
        {
            Assert.AreEqual(actual.RowCount,expected.RowCount);
            Assert.AreEqual(actual.Header.Count(), expected.Header.Count());

            int index = 0;
            foreach (var tableRow in actual.Rows)
            {
                foreach (var header in actual.Header)
                {
                    Assert.AreEqual(tableRow[header],expected.Rows[index][header]);
                }

                index++;
            }
        }
    }
}