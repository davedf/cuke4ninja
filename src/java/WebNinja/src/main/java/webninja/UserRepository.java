package webninja;

import java.util.HashMap;
import java.util.Map;

public class UserRepository {

    private final Map<String, User> users;

    public UserRepository() {
        users = new HashMap<String, User>();
        add(new User("Ninja1","n 1"));
        add(new User("Ninja2","n2 n2"));
    }

    private void add(User user) {
        users.put(user.getUseId(), user);
    }

    public User getUserById(String userId) {
        return users.get(userId);
    }
}
