Feature: Report on assigned problems
        In order to see the bugs that are assigned to me
        As a Ninja Developer
        I want to run a run a report to see the problems assigned to me

        Scenario: Assigned problem
            Given there are open issues with the properties
            |Title                  |Severity   |
            |Chuck Norris beat me   |Fatal      |
            When the issue "Chuck Norris beat me" is assigned to Ninja2
            Then Ninja2 sees the following issues in his report
            |Title                  |Severity   |
            |Chuck Norris beat me   |Fatal      |
            And Ninja1 sees no issues in his report
