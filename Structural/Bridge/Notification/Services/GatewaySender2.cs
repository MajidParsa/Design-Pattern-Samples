using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification.Services
{
	public class GatewaySender2 : INotifier
	{
		public void NotifySender(List<Subscriber> subscribers)
		{
			Console.WriteLine("Send notify to subscribers from SERVICE 2");
		}
	}
}
