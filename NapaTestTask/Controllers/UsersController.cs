using Database.Contexts;
using Database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NapaTestTask.Controllers;

namespace DatingApp.Controllers
{
    [Authorize]
    public sealed class UsersController : BaseApiController
    {
        private readonly ApplicationContext _applicationContext;

        public UsersController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _applicationContext.AppUsers.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _applicationContext.AppUsers.FindAsync(id);
        }
    }
}
