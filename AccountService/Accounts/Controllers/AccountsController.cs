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
        private AccountContext _context { get; set; }

        public AccountsController(AccountContext context)
        {
            this._context = context;

            var niels = new Account()
            {
                Username = "Niels",
                PasswordHash = "$%^&*()"
            };
            this._context.Accounts.Add(niels);
            this._context.SaveChanges();
        }
    }
}
