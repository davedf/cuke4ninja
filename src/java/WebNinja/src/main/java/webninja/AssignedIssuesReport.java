package webninja;

import java.util.List;

public class AssignedIssuesReport {
    private final List<Issue> issues;

    public AssignedIssuesReport(List<Issue> issues) {
        this.issues = issues;
    }

    public List<Issue> geIssues() {
        return issues;
    }

    public int getNumberOfIssues() {
        return issues.size();
    }
}
