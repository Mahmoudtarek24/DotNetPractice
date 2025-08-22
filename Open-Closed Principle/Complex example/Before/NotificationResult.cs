using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Complex_example.Before
{
	public class NotificationResult
	{
		public bool IsSuccess { get; set; }
		public string Message { get; set; }
		public string TrackingId { get; set; }
		public DateTime SentAt { get; set; }
	}
}
