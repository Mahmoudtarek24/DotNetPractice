using AdvancedC_Sharp.Events.Example1;
using AdvancedC_Sharp.Events.Example2;
using AdvancedC_Sharp.Events.Example3;

namespace Generic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ExecuteExample1();
			//ExecuteExample2();	
			//ExecuteExample3();	
			ExecuteExample4();
		}
		public static void ExecuteExample3(int x)
		{
			//var stock = new Stock("Amazon");
			//stock.Price = 100;
			//Console.WriteLine($"stock before changing: ${stock.Price}");
			//stock.ChangesStockPriceBy(0.05m);
			//Console.WriteLine($"stock before changing: ${stock.Price}");

			var stock = new Stock("Amazon");
			stock.Price = 100;
			var oldPrice = stock.Price;	
			stock.ChangesStockPriceBy(0.05m);

			var PrintStockPrice = new PrintStockPrice();

			if (oldPrice > stock.Price)
			{
				stock.OnChangePrice += PrintStockPrice.Red;
			}
			else
			{
				stock.OnChangePrice += PrintStockPrice.Green;	
			}

		}
		public static void ExecuteExample3()
		{
			var stock = new Stock("Amazon");
			stock.Price = 100;

			var printStockPrice = new PrintStockPrice();

			stock.OnChangePrice += () =>
			{
				if (stock.Price < 100)
					printStockPrice.Red();
				else
					printStockPrice.Green();
			};

			// غير السعر (ده هيعمل Raise للحدث تلقائيًا)
			stock.ChangesStockPriceBy(0.05m);
			stock.ChangesStockPriceBy(0.05m);
			stock.ChangesStockPriceBy(0.05m);
		}
		public static void ExecuteExample2()
		{
			var publisher = new Publisher();
			var subscriber = new Subscriber();	
			var subscriber1 = new Subscriber();	
			publisher.SomethingHappened += subscriber.HandleEvent;	
			publisher.SomethingHappened += subscriber1.HandleEvent;	
			publisher.DoSomething();	
		}

		public static void ExecuteExample1()
		{
			Worker worker = new Worker();

			worker.WorkPerformed += SomeMethod;

			worker.DoWork(5, "Coding");
		}

		public static void SomeMethod(int hours, string workType) =>
		        	Console.WriteLine($"{hours} hours of {workType} completed.");
		
		public static void printNumber(int number) => Console.WriteLine(number);
		public static void ExecuteExample4()
		{
			var returnNumber =new NumberProcessor();
			returnNumber.NumberFound += printNumber;

		}
	}
}
///                    Example 1
/// what happened  her we have event "WorkPerformed" 
/// and method "SomeMethod"  with same signature of delegate 
/// make subscribe on "worker.WorkPerformed += SomeMethod" 
/// when we going to execute "worker.DoWork(5, "Coding");"  , will call all method on subscribe
