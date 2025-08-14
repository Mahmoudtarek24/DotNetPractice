using OopPrinciples.OOPExanples.Why_used_has_a_over_Inheritance.Change_behaviour_on_runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopPrinciples.OOPExamples.Why_used_has_a_over_Inheritance.Change_behaviour_on_runtime
{
	public class Player
	{
		public string Name { get; }
		private IWeapon currentWeapon;
		public Player(IWeapon weapon, string name)
		{
			this.currentWeapon = weapon;
			Name = name;
		}
		public void Attack()
		{
			Console.WriteLine($"{Name} attacks:");
			currentWeapon.Attack();
			Console.WriteLine($"Damage dealt: {currentWeapon.Damage}");
		}
		public void EquipWeapon(IWeapon newWeapon)
		{
			var oldWeapon = currentWeapon.Name;
			currentWeapon = newWeapon;
			Console.WriteLine($"{Name} switched from {oldWeapon} to {newWeapon.Name}");
		}
	}
}
