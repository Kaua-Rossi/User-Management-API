using Microsoft.AspNetCore.Mvc;
using UserManagement.Api.Models;

namespace UserManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "Daniel Ross", Email = "daniel67@domain.com" },
            new User { Id = 2, Name = "Alice Johnson", Email = "alice32@domain.com" },
            new User { Id = 3, Name = "John Doe", Email = "jdoe1900@domain.com" }
        };

        [HttpGet]
        public IActionResult GetUsers()
        {   
            return Ok(_users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user == null) {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User newUser)
        {
            if (newUser == null) {
                return BadRequest();
            }

            newUser.Id = _users.Max(u => u.Id) + 1;
            _users.Add(newUser);

            return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
        {
            if (updatedUser == null) {
                return BadRequest();
            }

            var userToUpdate = _users.FirstOrDefault(u => u.Id == id);

            if (userToUpdate == null) {
                return NotFound();
            }

            userToUpdate.Name = updatedUser.Name;
            userToUpdate.Email = updatedUser.Email;
            return NoContent();
        }   
    }
}
