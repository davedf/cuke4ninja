package webninja;

public class Issue {
    private final String title;
    private final String severity;

    public Issue(String severity, String title) {
        this.severity = severity;
        this.title = title;
    }

    public String getTitle() {
        return title;
    }

    public String getSeverity() {
        return severity;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Issue issue = (Issue) o;

        if (severity != null ? !severity.equals(issue.severity) : issue.severity != null) return false;
        if (title != null ? !title.equals(issue.title) : issue.title != null) return false;

        return true;
    }

    @Override
    public int hashCode() {
        int result = title != null ? title.hashCode() : 0;
        result = 31 * result + (severity != null ? severity.hashCode() : 0);
        return result;
    }
}
