using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public int FollowersCount { get; set; }

		public User(int id, string name, string email)
		{
			Id = id;
			Name = name;
			Email = email;
			FollowersCount = 0;
		}

		public User(User user)
		{
			this.Id = user.Id;	
			this.Name = user.Name;
			this.Email = user.Email;
			this.FollowersCount = user.FollowersCount;
		}
		public override string ToString() 
		{
			return $"{Name} ({FollowersCount} followers)";
		}
	}
}
