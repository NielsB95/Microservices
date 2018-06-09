using System.Collections.Generic;
using System.Linq;
using Accounts.Data;
using Accounts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Controllers.Api
{
    [Route("api/accounts")]
    public class AccountsController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            using (var context = new AccountContext())
            {
                return context.Accounts
                              .Select(x => x.Username)
                              .ToList();
            }
        }
    }
}