using EF_Core_Inheritance.TablePerHierarchy;
using EF_Core_Inheritance.TablePerType;
using System.Threading.Tasks;

namespace EF_Core_Inheritance
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			//EmployeeService employeeService = new EmployeeService();
			//await employeeService.AddEmployees();

			PersonServices personServices = new PersonServices();
			await personServices.AddPersons();
		}


	}
}
