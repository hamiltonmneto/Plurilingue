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
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=plurilingue01.database.windows.net;Initial Catalog=Plurilingue.Application_db;User ID=hamilton;Password=Marcela01;Trusted_Connection=false;Encrypt=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Question>(new QuestionMap().Configure);
            modelBuilder.Entity<Answer>(new AnswerMap().Configure);
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
