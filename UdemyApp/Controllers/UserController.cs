using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyApp.Entities;
using UdemyApp.Data;


namespace UdemyApp.Controllers
{
    [ApiController]
    [Route("udemyapp/[controller]")]
    public class UserController(UserData context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUser()
        {
            var users = await context.Users.ToListAsync();
            return users;

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUsers>> GetUsers(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null) return NotFound();

            return user;
        }

    }
}
