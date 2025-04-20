using System;
using Acadmy_Reletional_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Acadmy_Reletional_EF.Data
{
	public class AppDbContext:DbContext
	{
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var constr = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        }


    }
}

