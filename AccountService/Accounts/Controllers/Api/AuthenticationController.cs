using Microsoft.AspNetCore.Mvc;
using Core.Authentication.Tokens;
using Accounts.Data;
using System.Linq;

namespace Accounts.Controllers.Api
{
    [Route("api")]
    public class AuthenticationController : Controller
    {
        [HttpPost("LogOn")]
        public IActionResult LogOn(string username, string password)
        {
            // TODO: Extract database query.
            var isValid = ContextFactory.CreateContext()
                                        .Accounts
                                        .Where(x => x.Username == username)
                                        .Where(x => x.PasswordHash == password)
                                        .Any();
            if (isValid)
                return Ok(TokenGenerator.GenerateToken(username));
            else
                return Unauthorized();
        }

        [HttpPost("Validate")]
        public bool Validate(string token)
        {
            string username;
            return TokenValidator.ValidateToken(token, out username);
        }
    }
}
