using fin_application.Models;

namespace fin_application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}