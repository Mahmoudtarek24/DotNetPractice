using OopPrinciples.OOPExanples.Why_used_has_a_over_Inheritance.Change_behaviour_on_runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExamples.Why_used_has_a_over_Inheritance.Change_behaviour_on_runtime
{
	public class Sword :IWeapon
	{
		public void Attack() => Console.WriteLine("Slashing with sword!");
		public int Damage => 25;
		public string Name => "Steel Sword";
	}
}
