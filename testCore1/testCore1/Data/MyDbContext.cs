using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using testCore1.Models;

namespace testCore1.Data
{
    internal class MyDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:dongtestcore.database.windows.net,1433;Initial Catalog=testCore;Persist Security Info=False;User ID=dhkoo;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Employee>(b =>
			{
				b.ToTable("Employee").HasKey(e => e.Id);
			});

		}

		public DbSet<Employee> Employee { get; set; }

    }
}
