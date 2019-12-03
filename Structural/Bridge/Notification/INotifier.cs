
using System.Collections.Generic;

namespace Bridge.Notification
{
	public interface INotifier
	{
		void NotifySender(List<Subscriber> subscribers);
	}
}
