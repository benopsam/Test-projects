using CrawfordClaims.Models;

namespace CrawfordClaims
{
    public interface ITokenService
    {
        string CreateToken(LoginData user);
    }
}
