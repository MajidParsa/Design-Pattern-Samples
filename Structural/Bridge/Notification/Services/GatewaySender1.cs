using System;
using System.Collections.Generic;

namespace Bridge.Notification.Services
{
	public class GatewaySender1 : INotifier
	{
		public void NotifySender(List<Subscriber> subscribers)
		{
			Console.WriteLine("Send notify to subscribers from SERVICE 1");
		}
	}
}
