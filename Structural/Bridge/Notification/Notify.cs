using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
	public abstract class Notify
	{
		public INotifier Notifier { get; set; }
		public abstract void Send();
		public abstract List<Subscriber> GetSubscribers();
	}
}
