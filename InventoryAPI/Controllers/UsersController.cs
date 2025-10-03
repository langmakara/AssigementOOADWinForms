using InventoryAPI.Data;
using InventoryAPI.DTOs;
using InventoryAPI.Model;  // or wherever your UserDto is
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InventoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users
                .Select(u => new UserDto
                {
                    UserID = u.UserID,
                    Username = u.Username,
                    Role = u.Role,
                    Email = u.Email,
                    IsActive = u.IsActive
                })
                .ToList();

            if (users.Count == 0)
                return NotFound("No users found.");

            return Ok(users);
        }
    }
}
