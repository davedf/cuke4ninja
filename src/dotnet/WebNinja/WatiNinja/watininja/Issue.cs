namespace WatiNinja.watininja
{
    public class Issue
    {
//START:class
public Issue(string title, string severity) {
    Title = title;
    Severity = severity;
}
public string Title { get; private set; }
public string Severity { get; private set; }
public bool Equals(Issue other) {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return Equals(other.Title, Title) && Equals(other.Severity, Severity);
}
public override bool Equals(object obj) {
    if (ReferenceEquals(null, obj)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != typeof(Issue)) return false;
    return Equals((Issue)obj);
}
public override int GetHashCode() {
    unchecked {
        return ((Title != null ? Title.GetHashCode() : 0) * 397) ^ 
				(Severity != null ? Severity.GetHashCode() : 0);
    }
}
//END:class

    }

}
