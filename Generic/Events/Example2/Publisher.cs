using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Sharp.Events.Example2
{
	public class Publisher
	{
		public event EventHandler SomethingHappened;
		protected virtual void OnSomethingHappened()=>
	         		SomethingHappened?.Invoke(this, EventArgs.Empty);
	
		public void DoSomething()
		{
			Console.WriteLine("Publisher: Doing some work...");
			OnSomethingHappened();
		}
	}
	public class Subscriber
	{
		public void HandleEvent(object sender, EventArgs e) =>
					  Console.WriteLine("Subscriber: I received the event!");
	}
}
/// EventHandler is delegate receive method have this structure (object sender, EventArgs e).
/// this event will not do any thing until external subscriber on this event 
/// 
/// this method "OnSomethingHappened" respond for Raise the event
/// first check "SomethingHappened?" not null have subscriber , then will invoke all method subscribe on this event 
/// "This" returned to the object that raised the event 'Publisher'."
///
/// "Subscriber" class represent Listener to event 
/// Response for receiving the event that was published.
/// The 'HandleEvent' method will be executed by default when the event have  been raised.
/// When the event occurs, it will be sent as a parameter to the method.
/// 

/// method "OnSomethingHappened" is protected and virtual to subclasses can override it 