using App.ApplicationCore.Domain;
using App.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Chaine> Chaines { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Visionnage> Visionnages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseLazyLoadingProxies().
                UseSqlServer(this.GetJsonConnectionString("appsettings.json"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApiConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
