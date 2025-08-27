using EF_Core_Inheritance.Context;
using EF_Core_Inheritance.TablePerHierarchy.Models;
using EF_Core_Inheritance.TablePerType.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerType
{
	public class PersonServices
	{
		private readonly ApplicationDbContext context;
		public PersonServices()
		{
			context = new ApplicationDbContext();		
		}
		public async Task AddPersons()
		{
			var teacher = new Teacher
			{
				Name = "John Doe",
				Subject="Math"
			};
			var student = new Student
			{
				Name = "Jane Smith",
				Grade=60
			};

			context.People.AddRange(teacher, student);
			await context.SaveChangesAsync();
		}

		//public async Task<List<Person>> GetAllEmployees() =>
		//									  await context.Employees.ToListAsync();
		public async Task<List<Teacher>> GetAllTeacher() =>
											  await context.Teachers.ToListAsync();

		public async Task<Person> GetStudentById(int id) => await context.Students.FindAsync(id);
		public async Task UpdateStudent(int studentId, int newGPA)
		{
			var student = await context.Students.FindAsync(studentId);
			if (student != null)
			{
				student.Grade = newGPA;

				await context.SaveChangesAsync();
			}
		}

		// Convert Student To Teacher
		public async Task ConvertStudentToTeacher(int studentId, string subject)
		{
			var student = await context.Students.FindAsync(studentId);
			if (student != null)
			{
				var commonData = new { student.Name };
				context.Students.Remove(student);	
				await context.SaveChangesAsync();

				var teacher = new Teacher
				{
					Name = commonData.Name,
					Subject = "History"
				};

				context.Teachers.Add(teacher);	
				context.SaveChanges();	
			}
		}
    }
}
