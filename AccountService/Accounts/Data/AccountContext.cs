using System;
using System.IO;
using Accounts.Models;
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
            // TODO: Move this to a settings file
            var sqlitePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                      @"../Documents/Databases/Accounts.db");

            optionsBuilder.UseSqlite("Data source =" + sqlitePath);
        }
    }
}
