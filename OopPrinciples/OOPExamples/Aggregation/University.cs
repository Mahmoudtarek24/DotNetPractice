using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.NewFolder1.Aggregation
{
	public class University
	{
		private List<Student> students;
		public void AdmitStudent(Student student) 
		{
			students.Add(student);
			Console.WriteLine($"{student.Name} has been admitted to the university");
		}

		public void RemoveStudent(Student student)
		{
			students.Remove(student);
			Console.WriteLine($"{student.Name} has left the university");
		}

		public void ShowStudents()
		{
			Console.WriteLine("University students:");
			foreach (var student in students)
				Console.WriteLine($"- {student.Name} (ID: {student.Id})");
		}
	}
}
