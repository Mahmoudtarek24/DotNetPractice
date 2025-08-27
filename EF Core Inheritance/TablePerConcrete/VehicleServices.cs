using EF_Core_Inheritance.Context;
using EF_Core_Inheritance.TablePerConcrete.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Inheritance.TablePerConcrete
{
	public class VehicleServices
	{
		private readonly ApplicationDbContext context;
		public VehicleServices()
		{
			context = new ApplicationDbContext();		
		}
		public async Task AddCar(string brand, string model,int doors)
		{
			var car = new Car
			{
				Brand = brand,
				Model = model,
				NumberOfDoors = doors,
			};

			context.Cars.Add(car);
			await context.SaveChangesAsync();
		}

		public async Task AddMotorcycle(string brand, string model)
		{
			var motorcycle = new Motorcycle
			{
				Brand = brand,
				Model = model,
				HasBasket = true,	
			};

			context.Motorcycles.Add(motorcycle);
			await context.SaveChangesAsync();
		}

		/// her will get all data of inherited class then make UNION  all type
		public async Task<List<Vehicle>> GetAllVehicles() => await context.Vehicles.ToListAsync();
		public async Task<List<Car>> GetAllCars() =>
			                               await context.Cars.OrderBy(c => c.Brand).ToListAsync();

		public async Task<List<Vehicle>> SearchByBrand(string brand)
		{
			return await context.Vehicles
				.Where(v => v.Brand.ToLower().Contains(brand.ToLower()))
				.ToListAsync();
		}

		///on update to convert car to motorcycle i need first to remove car then add new motorcycle
	}
}
