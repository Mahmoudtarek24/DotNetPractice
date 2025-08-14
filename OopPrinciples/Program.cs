using OopPrinciples.NewFolder1;

namespace OopPrinciples
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var encap = new EncapsulationExamples();
			//encap.FirstName="Test";


			var over = new MethodOverloadingExamples();

			//over.Test(10);

			over.Process(null);
		}
	}
}
