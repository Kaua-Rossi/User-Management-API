using UserManagement.Api.Models;

namespace UserManagement.Api.Services
{
    public static class UserService
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "Daniel Ross", Email = "daniel67@domain.com" },
            new User { Id = 2, Name = "Alice Johnson", Email = "alice32@domain.com" },
            new User { Id = 3, Name = "John Doe", Email = "jdoe1900@domain.com" }
        };

        public static List<User> GetAll() => _users;

        public static User? Get(int id) => _users.FirstOrDefault(u => u.Id == id);

        public static void Add(User user)
        {
            user.Id = _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(user);
        }

        public static void Update(User user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);
            if (index == -1)
                return;

            _users[index] = user;
        }

        public static void Delete(int id)
        {
            var user = Get(id);
            if (user is null)
                return;

            _users.Remove(user);
        }
    }
}