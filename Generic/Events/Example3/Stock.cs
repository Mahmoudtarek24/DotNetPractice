using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Sharp.Events.Example3
{
	public delegate void PrintPrice();
	public class Stock
	{
		private string name;
		private decimal price;	
		public string Name =>this.name;
		public decimal Price { get => this.price; set => price = value; }
		public Stock(string name)
		{
			this.name = name;		
		}
	
		// 1- create event
		public event PrintPrice OnChangePrice;

		// 2- Raise Event
		protected virtual void OnPriceChanged()
		{
			OnChangePrice?.Invoke();
		}

		public void ChangesStockPriceBy(decimal percent)
		{
			this.price += Math.Round(this.price * percent, 2);

			// Raise الحدث مباشرة بعد التغيير
			OnPriceChanged();
		}

	}
	public class PrintStockPrice
	{
		public void Red()
		{
			Console.WriteLine("Price is down");
		}
		public void Green()
		{
			Console.WriteLine("Price is up");
		}
	}
}
