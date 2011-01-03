using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebNinja.webninja
{
    public class AssignedIssuesReport
    {
        public AssignedIssuesReport(IList<Issue> issues)
        {
            Issues = issues;
        }

        public IList<Issue> Issues { get; private set; }

        public int NumberOfIssues
        {
            get { return Issues == null ? 0 : Issues.Count; }
        }
    }
}
