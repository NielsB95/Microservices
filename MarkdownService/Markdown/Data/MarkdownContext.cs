using Core;
using Markdown.Models;
using Microsoft.EntityFrameworkCore;

namespace Markdown.Data
{
    public class MarkdownContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

        public MarkdownContext()
        { }

        public MarkdownContext(DbContextOptions<MarkdownContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(CoreSettings.ConnectionString);
        }
    }
}
