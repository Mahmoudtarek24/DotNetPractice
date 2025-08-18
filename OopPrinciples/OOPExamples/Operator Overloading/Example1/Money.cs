
namespace OopPrinciples.OOPExamples.operator_overloading
{
	public class Money 
	{
		public decimal Amount { get; private set; }
		public string Currency { get; private set; }

		public Money(decimal amount, string currency = "EGP")
		{
			Amount = amount;
			Currency = currency;
		}

		public static Money operator +(Money left, Money right)
		{
			if (left.Currency != right.Currency)
				throw new InvalidOperationException($"Cannot add {left.Currency} to {right.Currency}");

			return new Money(left.Amount + right.Amount, left.Currency);
		}
		public static Money operator -(Money left, Money right)
		{
			if (left.Currency != right.Currency)
				throw new InvalidOperationException($"Cannot subtract {left.Currency} to {right.Currency}");

			return new Money(left.Amount - right.Amount, left.Currency);
		}

		public static Money operator *(Money money, int quantity)
		{
			return new Money(money.Amount * quantity, money.Currency);
		}

		public static Money operator *(int quantity, Money money) /// this overload to work method on two side
		{
			return money * quantity;
		}
		public static bool operator >(Money left, Money right)
		{
			if (left.Currency != right.Currency)
				throw new InvalidOperationException($"Cannot compare {left.Currency} with {right.Currency}");

			return left.Amount > right.Amount;
		}

		public static bool operator <(Money left, Money right)
		{
			if (left.Currency != right.Currency)
				throw new InvalidOperationException($"Cannot compare {left.Currency} with {right.Currency}");

			return left.Amount < right.Amount;
		}
		public static bool operator >=(Money left, Money right) => left.Amount >= right.Amount;
		public static bool operator <=(Money left, Money right) => left.Amount <= right.Amount;

		public static bool operator ==(Money left, Money right)
		{
			if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
				return true;

			if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
				return false;

			return left.Amount == right.Amount && left.Currency == right.Currency;
		}

		public static bool operator !=(Money left, Money right) =>  !(left == right);

		public override bool Equals(object obj)
		{
			if (obj is Money money)
				return this == money;
			return false;
		}

		public override int GetHashCode() =>  HashCode.Combine(Amount, Currency);

		public override string ToString() =>  $"{Amount:N2} {Currency}";
	
	}
}
