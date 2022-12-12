using Database.Contexts;
using Database.Models;
using Domain.DTOs;
using Domain.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace NapaTestTask.Controllers
{
    public sealed class AccountController : BaseApiController
    {
        private readonly ApplicationContext _dataContext;
        private readonly ITokenService _tokenService;
        public AccountController(ApplicationContext dataContext, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _dataContext = dataContext;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
        {
            if (await UserExist(registerDTO.UserName))
            {
                return BadRequest("UserName is taken");
            }

            using var hmac = new HMACSHA512();

            var user = new User
            {
                Name = registerDTO.UserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password)),
                PasswordSalt = hmac.Key
            };

            _dataContext.Add(user);

            await _dataContext.SaveChangesAsync();

            return new UserDTO
            {
                UserName = user.Name,
                Token = _tokenService.CreateToken(user)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await _dataContext.AppUsers.SingleOrDefaultAsync(x => x.Name == loginDTO.UserName);

            if (user == null)
            {
                return Unauthorized("Invalid username");
            }

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid Password");
                }
            }

            return new UserDTO
            {
                UserName = user.Name,
                Token = _tokenService.CreateToken(user)
            };
        }

        private async Task<bool> UserExist(string username)
        {
            return await _dataContext.AppUsers.AnyAsync(x => x.Name == username.ToLower());
        }
    }
}
