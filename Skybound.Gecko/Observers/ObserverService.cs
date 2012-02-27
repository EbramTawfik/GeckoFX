using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	public static class ObserverService
	{
		private static ServiceWrapper<nsIObserverService> _observerService;

		static ObserverService()
		{
			_observerService = new ServiceWrapper<nsIObserverService>( Contracts.ObserverService );
		}

		public static void AddObserver(nsIObserver observer, string topic, bool ownsWeak)
		{
			_observerService.Instance.AddObserver(observer, topic, ownsWeak);
		}

		public static void RemoveObserver(nsIObserver observer, string topic)
		{
			_observerService.Instance.RemoveObserver(observer, topic);
		}

		public static void AddObserver(Observers.BaseBaseHttpModifyRequestObserver observer)
		{
			_observerService.Instance.AddObserver(observer, ObserverNotifications.HttpRequests.HttpOnModifyRequest, false);
		}

		public static void RemoveObserver(Observers.BaseBaseHttpModifyRequestObserver observer)
		{
			_observerService.Instance.RemoveObserver(observer, ObserverNotifications.HttpRequests.HttpOnModifyRequest);
		}
	}
}