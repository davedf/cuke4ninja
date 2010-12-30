namespace WebNinja.webninja
{
    public class User
    {
        public User(string name, string userId)
        {
            Name = name;
            UserId = userId;
        }
        public string Name { get; private set; }

        public string UserId { get; private set; }
    }
}
