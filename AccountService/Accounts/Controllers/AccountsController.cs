using System.Collections.Generic;
using System.Linq;
using Accounts.Data;
using Accounts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Controllers.Api
{
    [Route("[controller]")]
    public class AccountsController : Controller
    {
        [HttpGet]
        public IEnumerable<Account> GetAll()
        {
            using (var context = ContextFactory.CreateContext())
            {
                return context.Accounts
                              .ToList();
            }
        }
    }
}