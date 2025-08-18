using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExamples.operator_overloading
{
	public class ShoppingCartService
	{
		private List<CartItem> _items = new();

		public void AddItem(Product product, int quantity)
		{
			var existingItem = _items.FirstOrDefault(i => i.Product.Id == product.Id);

			if (existingItem is null) 
				_items.Add(new CartItem { Product = product, Quantity = quantity });
			else
				existingItem.Quantity += quantity;
		}
		public Money CalculateTotal()
		{
			if (!_items.Any())
				return new Money(0);

			Money total = null;
			foreach (var item in _items)
				total += total + item.TotalPrice;

			return total;
		}
		public Money ApplyDiscount(Money discountAmount)
		{
			var total = CalculateTotal();
			var finalAmount = total - discountAmount; 

			return finalAmount;
		}
	}
}
