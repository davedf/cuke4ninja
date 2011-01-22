using System.Collections.Generic;

namespace WatiNinja.watininja
{
    public class UserRepository
    {
        private readonly Dictionary<string, User> _users;

        public UserRepository()
        {
            _users = new Dictionary<string, User>();
            Add(new User("Ninja 1", "Ninja1"));
            Add(new User("Ninja 2", "Ninja2"));
        }

        public void Add(User user)
        {
            _users.Add(user.UserId, user);
        }

        public User FindByUserId(string userId)
        {
            return _users[userId];
        }
    }
}
