using Domain.Entities;
using Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;

namespace Infra.Data.Context
{
    public class ContextDB: DbContext
    {
        public ContextDB(string connectionString)
        {
            _connectionString = "Data Source=FERRETTOHOME\\SQLEXPRESS;Initial Catalog=ProjetoEstudo;Timeout=60;Persist Security Info=True;";
        }

        private readonly string _connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                var connString = _connectionString;
                optionsBuilder
                    .EnableSensitiveDataLogging(false)
                    .UseSqlServer(connString, options => options.MaxBatchSize(150));
            }

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TBUsuario> TBUsuario { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TBUsuarioMap());
        }

        public string ConnectionString => _connectionString;

        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            var validationResults = new List<ValidationResult>();
            foreach (var entity in entities)
            {
                if (!Validator.TryValidateObject(entity, new ValidationContext(entity), validationResults))
                {
                    // throw new ValidationException() or do whatever you want
                }
            }

            return base.SaveChanges();
        }
    }

}
