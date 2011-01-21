using System.Collections.Generic;
using Cuke4Nuke.Framework;
using WebNinja.webninja;

namespace WebNinja.features.step_definitions
{
    public static class TableConverter
    {
        public static IList<Issue> ToIssues(this Table propertiesList)
        {
            var list = new List<Issue>();
            foreach (var properties in propertiesList.Hashes())
            {
                var issue = new Issue(
                    properties["Title"].Trim(),
                    properties["Severity"].Trim());
                list.Add(issue);
            }
            return list;
        }
    }
}