using Database.Models;

namespace Domain.Intefaces
{
    public interface ITokenService
    {
        public string CreateToken(User appUser);
    }
}
