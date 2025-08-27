using EF_Core_Inheritance.Context;
using EF_Core_Inheritance.TablePerHierarchy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerHierarchy
{
	public class EmployeeService
	{
		private readonly ApplicationDbContext context;
		public EmployeeService()
		{
			this.context = new ApplicationDbContext();
		}
		public async Task AddEmployees()
		{
			var fullTime = new FullTimeEmployee
			{
				Name = "John Doe",
				Email = "john@company.com",
				HireDate = DateTime.Now,
				BaseSalary = 60000,
				AnnualBonus = 5000,
				VacationDays = 20
			};
			var partTime = new PartTimeEmployee
			{
				Name = "Jane Smith",
				Email = "jane@company.com",
				HireDate = DateTime.Now,
				BaseSalary = 30000,
				HoursPerWeek = 20,
				HourlyRate = 25
			};

			var contractor = new Contractor
			{
				Name = "Bob Wilson",
				Email = "bob@contractor.com",
				HireDate = DateTime.Now,
				BaseSalary = 80000,
				ContractEndDate = DateTime.Now.AddMonths(12),
				ContractCompany = "TechCorp"
			};

			context.Employees.AddRange(fullTime, partTime, contractor);
			await context.SaveChangesAsync();
		}

		public async Task<List<Employee>> GetAllEmployees() =>
			                                  await context.Employees.ToListAsync();
		public async Task<List<FullTimeEmployee>> GetFullTimeEmployees() =>
			                                  await context.FullTimeEmployees.ToListAsync();

		public async Task<List<Employee>> GetEmployeesByType(string employeeType)=>
			await context.Employees.Where(e=>EF.Property<string>(e, "EmployeeType") ==employeeType).ToListAsync();	
		
	}
}
