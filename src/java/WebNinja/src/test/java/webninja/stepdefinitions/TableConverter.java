package webninja.stepdefinitions;

import cuke4duke.Table;
import webninja.Issue;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

public class TableConverter {
    public List<Issue> toIssues(Table propertiesList) {
        List<Issue> list = new ArrayList<Issue>();
        for (Map<String, String> properties : propertiesList.hashes()) {

            Issue issue = new Issue(
                    properties.get("Severity").trim(),
                    properties.get("Title").trim());
            list.add(issue);
        }
        return list;
    }
}
