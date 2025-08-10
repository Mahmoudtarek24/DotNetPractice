using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OopPrinciples.NewFolder1
{
	public class EncapsulationExamples
	{

		private double balance;
		private List<Transaction> transactionHistory;
		private bool hasChanged = false;

		/// 1- Computed property
		public string BalanceFormatted  //readonly
		{
			get { return $"${balance:F2}"; }
		}


		/// 2- lazy loading  / cashing data 
		/// we cash value and execute it only for first time when her value equal null  
		public List<Transaction> TransactionHistory
		{ 
			get { return transactionHistory; }
			set
			{
				if (transactionHistory is null)
					transactionHistory = value;
			}
		}

		public double Balance
		{
			get { return balance; }
			set
			{
				balance = value;
				hasChanged = true;  ///Change Track
			}
		}
		public bool HasChanges()
		{
			hasChanged=false;
			return !hasChanged;	

		}
		public void SaveToDataBase()
		{
			if(HasChanges())
				Console.WriteLine("Saved Successfully on Database");
		}




		#region Why can't you assign one property directly to another property 

		/// 1- can lead to infinite loop "stackoverflow error" 

		private string firstName;
		private string lastName;

		public string FirstName
		{
			get { return firstName; }
			set
			{
				firstName=value;
				FullName = FirstName + " " + LastName;
			}
		}
		public string LastName
		{
			get { return lastName; }
			set
			{
				lastName = value;
				FullName = FirstName + " " + LastName; ////FullName her will call Setter of FullName
			}
		}
		private string fullName;
		public string FullName 
		{
			get { return fullName; }
			set
			{
				fullName = value;
				var names = value.Split(' ');
				FirstName = names[0];   
				LastName = names[1];    
			}
		}

		/// 2- the order of properties is also reason  

		#endregion


		private string name;
		public string Name
		{
			get { return name; }
			set
			{
				if(name != value)
				{
					if (name.Length < 2)
						throw new ArgumentException("");

					name = value;	
				}
			}
		}

	}
}
