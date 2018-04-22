using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts.Data;
using Accounts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Controllers
{
    [Route("Accounts")]
    public class AccountsController : Controller
    {
        [HttpGet]
        public IEnumerable<Account> GetAll()
        {
            using (var context = new AccountContext())
            {
                return context.Accounts.ToList();
            }
        }
    }
}
