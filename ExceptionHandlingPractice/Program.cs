using ExceptionHandlingPractice.InnerException;

namespace ExceptionHandlingPractice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Without Exception 
			// int num1 = 10;
			// int num2 = 0;
			// int num3;

			// Console.WriteLine($"num1 = {num1}");
			// Console.WriteLine($"num1 = {num2}");

			// num3 = num1 / num2;
			// Console.WriteLine(num3); 

			#endregion

			//HandleExceptionWithLogicalImplementation(10, 0);
			//HandleExceptionWithTryCatchImplementation(10, 0);
			//HandleExceptionWithExceptionProperty(10, 0);
			//HandleExceptionWithMultipleCatchBlocks(10, 0);
			//HandleExceptionWithFinallyBlock(10, 0);
			//HandleExceptionWithTryFinallyBlocks(10, 0);
			//HandleExceptionWithCustomException(10, 3);
			//SimpleInnerException();
			UsedInnerException();
		}


		public static void HandleExceptionWithLogicalImplementation(int num1, int num2)
		{

			if (num2 == 0)
			{
				Console.WriteLine("Second Number Should Not Be Zero");
				return;
			}
			Console.WriteLine(num1 / num2);
		}
		public static void HandleExceptionWithTryCatchImplementation(int num1, int num2)
		{
			try
			{
				Console.WriteLine(num1 / num2);
			}
			catch //the catch called generic Exception  , catch all Exception
			{
				Console.WriteLine("Second Number Should Not Be Zero");
			}
		}
		public static void HandleExceptionWithExceptionProperity(int num1, int num2)
		{
			try
			{
				Console.WriteLine(num1 / num2);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Source);// the class name response for error 
			}
		}
		public static void HandleExceptionWithMultipleCatchBlocks(int num1, int num2)
		{
			try
			{
				Console.WriteLine(num1 / num2);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (FormatException FE)
			{
				Console.WriteLine("Enter Only Integer Numbers");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			/// we need to write many catch block , to define the try of Exception "not genaric" and to handle Exception
			/// based on her type
		}
		public static void HandleExceptionWithFinallyBlock(int num1, int num2)
		{
			try
			{
				Console.WriteLine(num1 / num2);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("This code going to execute any way");
			}
		}
		public static void HandleExceptionWithTryFinallyBlocks(int num1, int num2)
		{
			try
			{
				Console.WriteLine(num1 / num2);
			}
			finally
			{
				Console.WriteLine("Second Number Should Not Be Zero");
			}
		}
		public static void HandleExceptionWithCustomException(int num1, int num2)
		{
			try
			{
				if (num2 % 2 > 0)
					throw new OddNumberException(); /// explicit calling for excepthion ;
			}
			catch (OddNumberException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}


		public static void DivideNumbers()
		{
			try
			{
				int num1 = 10;
				int num2 = 0;
				int result = num1 / num2;
			}
			catch (DivideByZeroException ex)
			{
				throw new InvalidOperationException("Can not divide on zero", ex);
			}
		}
		public static void SimpleInnerException()
		{
			try
			{
				DivideNumbers();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);	

				if(ex.InnerException is not null)
					Console.WriteLine(ex.InnerException.Message);
			}
		}

		public static void UsedInnerException()
		{
			var controller = new UserController();

			Console.WriteLine("=== Test 1: Valid Data ===");
			var response1 = controller.RegisterUser("Ahmed", "ahmed@email.com");
			PrintResponse(response1);

			//Console.WriteLine("\n=== Test 2: Invalid Data ===");
			//var response2 = controller.RegisterUser("", "invalid-email");
			//PrintResponse(response2);

			//Console.WriteLine("\n=== Test 3: Database Error Simulation ===");
			//var response3 = controller.RegisterUser("Sara", "sara@email.com");
			//PrintResponse(response3);
		}
		static void PrintResponse(ApiResponse response)
		{
			Console.WriteLine($"Success: {response.Success}");
			Console.WriteLine($"Message: {response.Message}");

			if (response.ErrorDetails.Count > 0)
			{
				Console.WriteLine("Error Detail ");
				for (int i = 0; i < response.ErrorDetails.Count; i++)
				{
					Console.WriteLine($"  {i + 1}. {response.ErrorDetails[i]}");
				}
			}
		}
	}
}
