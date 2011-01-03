

using System.Collections.Generic;

namespace WebNinja.webninja
{    
    public class UserRepository
    {
        private Dictionary<string, User> users;

        public UserRepository ()
        {
            users = new Dictionary<string, User>();
            Add(new User("Ninja1","n1"));
            Add(new User("Ninja2", "n2"));
        }

        public void Add(User user)
        {
            users.Add(user.UserId, user);
        }

        public User FindByUserId(string userId)
        {
            return users[userId];
        }
    }
}
