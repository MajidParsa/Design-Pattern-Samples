using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification.Methods
{
	public class SMS : Notify
	{
		public override List<Subscriber> GetSubscribers()
		{
			return new List<Subscriber>(); // Sample code
		}

		public override void Send()
		{
			var subscribers = GetSubscribers();
			Notifier.NotifySender(subscribers);
		}
	}
}
