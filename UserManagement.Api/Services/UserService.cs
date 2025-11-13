using UserManagement.Api.Data;
using UserManagement.Api.Models;

namespace UserManagement.Api.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? Get(int id)
        {
            return _context.Users.Find(id);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            var existingUser = _context.Users.Find(user.Id);
            if (existingUser is null)
                return;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user is null)
                return;

            _context.Users.Remove(user);

            _context.SaveChanges();
        }
    }
}