using Microsoft.AspNetCore.Mvc;
using Accounts.Logic;
using Core.Logic;

namespace Accounts.Controllers.Api
{
    [Route("api")]
    public class AuthenticationController
    {
        private readonly string _username = "niels";
        private readonly string _password = "niels";

        [HttpPost("LogOn")]
        public string LogOn(string username, string password)
        {
            if (_username != username || _password != password)
                return null;

            return Tokens.GenerateToken(username);
        }

        [HttpPost("Validate")]
        public bool Validate(string token)
        {
            string username;
            return TokenValidator.ValidateToken(token, out username);
        }
    }
}
