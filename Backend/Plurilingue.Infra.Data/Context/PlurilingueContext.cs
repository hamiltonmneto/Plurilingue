using Microsoft.EntityFrameworkCore;
using Plurilingue.Domain.Entities;
using Plurilingue.Infra.Data.Mapping;
using System;
using System.Linq;

namespace Plurilingue.Infra.Data.Context
{
    public class PlurilingueContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Topic> Topic { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S1GAE1H\SQLEXPRESS;Initial Catalog=Plurilinguedb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Topic>().HasOne(t => t.User).WithMany(u => u.Questions).HasForeignKey(u => u.Id);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
