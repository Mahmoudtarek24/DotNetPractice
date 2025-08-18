using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExamples.operator_overloading.Example2
{
	public class Temperature
	{
		public double Value { get; private set; }
		public string Unit { get; private set; }

		public Temperature(double value, string unit)
		{
			Value = value;	
			this.Unit = unit.ToUpper();	
		}
		private double ToCelsius()
		{
			return Unit switch
			{
				"C" => Value,
				"F" => (Value - 32) * 5 / 9,
				"K" => Value - 273.15,
				_ => throw new ArgumentException("Invalid temperature unit") 
			};
		}
		private static double FromCelsius(double celsius, string targetUnit)
		{
			return targetUnit switch
			{
				"C" => celsius,
				"F" => celsius * 9 / 5 + 32,
				"K" => celsius + 273.15,
				_ => throw new ArgumentException("Invalid temperature unit")
			};
		}
		public override string ToString()
		{
			return $"{Value:F1}°{Unit}";
		}

		public static Temperature operator +(Temperature left, Temperature right) 
		{
			var leftCelsius = left.ToCelsius();
			var rightCelsius = right.ToCelsius();
			var averageCelsius = (leftCelsius + rightCelsius) / 2;

			var result = FromCelsius(averageCelsius, left.Unit);
			return new Temperature(result, left.Unit);
		}
		public static Temperature operator -(Temperature left, Temperature right)
		{
			var leftCelsius = left.ToCelsius();
			var rightCelsius = right.ToCelsius();
			var subtractCelsius = leftCelsius - rightCelsius;

			var result = FromCelsius(subtractCelsius, left.Unit);
			return new Temperature(result, left.Unit);
		}

		public static bool operator >(Temperature left, Temperature right)
		{
			var leftCelsius = left.ToCelsius();
			var rightCelsius = right.ToCelsius();

			return leftCelsius > rightCelsius;
		}
		public static bool operator <(Temperature left, Temperature right)
		{
			var leftCelsius = left.ToCelsius();
			var rightCelsius = right.ToCelsius();

			return leftCelsius < rightCelsius;
		}

		public static bool operator == (Temperature left, Temperature right)
		{
			if(ReferenceEquals(left, null) && ReferenceEquals(right,null)) return true;	
			if(ReferenceEquals(left, null) || ReferenceEquals(right,null)) return false;

			return left ==right;
		}

		public static bool operator !=(Temperature left, Temperature right) => !(left == right);	

		public override bool Equals(object? obj)
		{
			if(obj is Temperature temp)
					return this.ToCelsius()==temp.ToCelsius();	
			return false;	
		}
		public static Temperature operator *(Temperature temperature, int value)
		{
			var celsius = temperature.ToCelsius() * value;
			var result = FromCelsius(celsius, temperature.Unit);
			return new Temperature(result, temperature.Unit);
		}
	}
}
