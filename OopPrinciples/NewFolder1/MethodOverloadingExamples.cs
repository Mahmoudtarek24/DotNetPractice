using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.NewFolder1
{
	public class MethodOverloadingExamples
	{
		/// 1- basic with different number
		
		public void Print(string message)
		{
			Console.WriteLine($"Message: {message}");
		}

		public void Print(string message , int age)
		{
			Console.WriteLine($"Message: {message} ,age: {age}");
		}


		/// 2- different on data type

		public void add(int x, int y)
		{
			Console.WriteLine(x + y);
		}

		public void add(double x, double y)
		{
			Console.WriteLine(x + y);
		}

		/// 3- order of data type
		
		public void ProcessData(string name, int age)
		{
			Console.WriteLine($"Processing: {name}, Age: {age}");
		}

		public void ProcessData(int age, string name)
		{
			Console.WriteLine($"Processing: {name}, Age: {age}");
		}

		/// 4- ref ,out
		
		public void ProcessValue(int value)
		{
			value = value * 2;
			Console.WriteLine($"Inside method (by value): {value}");
		}
		public void ProcessValue(out int value)
		{
			value = 100;
			Console.WriteLine($"Inside method with out: {value}");
		}

		/// can not make overload between ref , out  


		/// 5- with Genaric
		
		public void Sum<T> (T value)
		{
			Console.WriteLine(value);
		}
		public void Sum(int value)
		{
			Console.WriteLine(value);
		}

		/// 6- compiler will execute method resolution to see with method more suitable to execute "Show(10) will call Show(int x)"
		public void Show(object x)
		{
			Console.WriteLine("object version");
		}
		public void Show(int x)
		{
			Console.WriteLine("int version"); 
		}

		/// 7- with nulable
		public void Process(int? value) { Console.WriteLine(value); }
		public void Process(int value) { Console.WriteLine(value); }

		/// 1- can not overload method with data type only

		//public int Calculate(int a, int b) { return a + b; }
		//public double Calculate(int a, int b) { return a + b; }

		/// 2- with different access modifier

		//public int Calculate(int a, int b) { return a + b; }
		//private double Calculate(int a, int b) { return a + b; }



		public void Test(int a, int b = 10) { Console.WriteLine(a + b); }///if i want to execute this with her default value
	    /// i will not access it because when execute this Test(10) =>" Test(int a, int b = 10)"
	    /// always execute "Test(int a)"   "Ambiguity "

		public void Test(int a) { Console.WriteLine(a); }
	}
}
