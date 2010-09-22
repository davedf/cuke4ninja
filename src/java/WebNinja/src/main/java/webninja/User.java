package webninja;

public class User {
    private final String useId;
    private final String name;

    public User(String useId, String name) {
        this.useId = useId;
        this.name = name;
    }

    public String getUseId() {
        return useId;
    }

    public String getName() {
        return name;
    }
}
