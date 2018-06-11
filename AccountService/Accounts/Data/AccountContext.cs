using System;
using System.IO;
using Accounts.Models;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Accounts.Data
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AccountContext()
        { }

        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(CoreSettings.ConnectionString);
        }
    }
}
