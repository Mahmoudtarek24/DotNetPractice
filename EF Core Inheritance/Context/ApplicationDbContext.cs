using EF_Core_Inheritance.TablePerHierarchy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.Context
{
	public class ApplicationDbContext :DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=TestEF_Core_Inheritance;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Employee>().HasDiscriminator<string>("EmployeeType")
						.HasValue<FullTimeEmployee>("FullTime")
						.HasValue<PartTimeEmployee>("PartTime")
						.HasValue<Contractor>("Contractor");
		}
		public DbSet<Employee> Employees { get; set; }	
		public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }	
		public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }	
		public DbSet<Contractor> Contractors { get; set; }
	}
}
