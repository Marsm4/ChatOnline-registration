namespace ChatOnline.Data
{
    public class User
    {
        public User(string fullName, string login, string password)
        {
            Id = Guid.NewGuid().ToString();
            FullName = fullName;
            Login = login;
            Password = password;
        }

        public string Id { get; private set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
