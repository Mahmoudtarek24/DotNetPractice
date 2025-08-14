using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrinciples.NewFolder1.Composition
{
	public class House
	{
		public List<Room> Rooms;

		public House()
		{
			Rooms = new List<Room>()
			{
				new Room("Living Room", 25.5),
				new Room("Bedroom", 18.0),
				new Room("Kitchen", 15.2)
			};	
		}

		public void ShowHouse()
		{
			foreach (Room room in Rooms)
				room.DisplayInfo();
		}
	}
}
/// when house demolishes all room also will demolishes 

