namespace WebNinja.webninja
{
    public class Issue
    {
        public Issue(string title, string severity)
        {
            Title = title;
            Severity = severity;
        }
        public string Title { get; private set; }
        public string Severity { get; private set; }

    }
}
