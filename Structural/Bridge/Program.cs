using Bridge.Notification;
using Bridge.Notification.Methods;
using Bridge.Notification.Services;
using System;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine(NotifyType.PushNotification.ToString());
			var rtnNotify = GetNotifyType(NotifyType.PushNotification);
			rtnNotify.Notifier = new GatewaySender1();
			rtnNotify.Send();
			rtnNotify.Notifier = new GatewaySender2();
			rtnNotify.Send();

			Console.WriteLine();
			Console.WriteLine(NotifyType.VoiceCall.ToString());
			rtnNotify = GetNotifyType(NotifyType.VoiceCall);
			rtnNotify.Notifier = new GatewaySender1();
			rtnNotify.Send();


			Console.WriteLine();
			Console.WriteLine(NotifyType.SMS.ToString());
			rtnNotify = GetNotifyType(NotifyType.SMS);
			rtnNotify.Notifier = new GatewaySender2();
			rtnNotify.Send();
			rtnNotify = GetNotifyType(NotifyType.SMS);
			rtnNotify.Notifier = new GatewaySender3();
			rtnNotify.Send();

			Console.ReadKey();
		}

		private static Notify GetNotifyType(NotifyType notifyType)
		{
			Notify rtnNotify;
			switch (notifyType)
			{
				case NotifyType.PushNotification:
					rtnNotify = new PushNotification();
					break;
				case NotifyType.VoiceCall:
					rtnNotify = new VoiceCall();
					break;
				default:
					rtnNotify = new SMS();
					break;
			}

			return rtnNotify;
		}
	}
}
