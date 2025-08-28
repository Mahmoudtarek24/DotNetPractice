using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.Tight_Coupling.Inheritance_Coupling
{
	public abstract class BaseRepository
	{
		protected string connectionString = "Server=localhost;Database=MyDB";
		protected SqlConnection connection;

		public BaseRepository()
		{
			connection = new SqlConnection(connectionString);
		}

		// If this method signature changes, ALL derived classes break
		public abstract void Save(object entity);
		public abstract void Delete(int id);


		public virtual void ValidateEntity(object entity)
		{
			if (entity == null) throw new ArgumentNullException();
			// If we add more validation rules, all subclasses are affected
		}
	}
}
