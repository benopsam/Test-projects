using System.Threading.Tasks;
using CrawfordClaims.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrawfordClaims
{
    public class AccessController : BaseApiController
    {
        private readonly ITokenService _tokenService;

        public AccessController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginData user)
        {
            //var user = await _context.Users.SingleOrDefaultAsync(x => x.UserId == user.Username);
            User loggedInUser;
            if (!MockData.MockUsers.UserList.TryGetValue(user.UserId, out loggedInUser))
            {
                return Unauthorized("Invalid Username.");
            }

            if (loggedInUser.Password != user.Password)
            {
                return Unauthorized("Incorrect Password.");
            }

            if (!loggedInUser.IsActive)
            {
                return Unauthorized("User is not Acive.");
            }

            //using var hmac = new HMACSHA512(user.PasswordSalt);
            //var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            //for (int i = 0; i < computeHash.Length; i++)
            //{
            //    if (computeHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid Password");
            //}

            return new LoginResponse
            {
                UserId = loggedInUser.UserId,
                Token = _tokenService.CreateToken(user)
            };
        }
    }
}
