using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.OOPExanples.Why_used_has_a_over_Inheritance.Change_behaviour_on_runtime
{
	public interface IWeapon
	{
		void Attack();
		int Damage { get; }
		string Name { get; }
	}
}
