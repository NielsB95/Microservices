using System;
using Accounts.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounts.Data
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {
        }
    }
}
