using System;
using Domains.Conversation;
using Microsoft.EntityFrameworkCore;

namespace MyCoreTest.Dal.EFCore
{
    public class ConversationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Source> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=devdb;Username=;Password=");
        }
    }
}
