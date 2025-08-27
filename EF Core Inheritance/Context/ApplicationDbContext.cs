using EF_Core_Inheritance.TablePerConcrete.Models;
using EF_Core_Inheritance.TablePerHierarchy.Models;
using EF_Core_Inheritance.TablePerType.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

			/// Table Per Hierarchy
			modelBuilder.Entity<Employee>().HasDiscriminator<string>("EmployeeType")
						.HasValue<FullTimeEmployee>("FullTime")
						.HasValue<PartTimeEmployee>("PartTime")
						.HasValue<Contractor>("Contractor");

			/// Table Per Type
			modelBuilder.Entity<Person>().ToTable("People");
			modelBuilder.Entity<Teacher>().ToTable("Teachers");
			modelBuilder.Entity<Student>().ToTable("Students");

			/// Table Per Concrete
			modelBuilder.Entity<Vehicle>().UseTpcMappingStrategy();

			modelBuilder.Entity<Car>().ToTable("Cars");
			modelBuilder.Entity<Motorcycle>().ToTable("Motorcycles");

		}

		/// Table Per Hierarchy
		public DbSet<Employee> Employees { get; set; }	
		public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }	
		public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }	
		public DbSet<Contractor> Contractors { get; set; }

		/// Table Per Type
		public DbSet<Person> People { get; set; }
		public DbSet<Teacher> Teachers { get; set; }	
		public DbSet<Student> Students { get; set; }

		/// Table Per Concrete
		public DbSet<Vehicle> Vehicles { get; set; }	
		public DbSet<Car> Cars { get; set; }
		public DbSet<Motorcycle> Motorcycles { get; set; }

	}
}
