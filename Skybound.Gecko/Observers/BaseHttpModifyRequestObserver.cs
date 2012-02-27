using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Net;

namespace Gecko.Observers
{
	public class BaseBaseHttpModifyRequestObserver
		:nsIObserver
	{
		void nsIObserver.Observe(nsISupports aSubject, string aTopic, string aData)
		{
			if (aTopic != ObserverNotifications.HttpRequests.HttpOnModifyRequest) return;
			var channel=HttpChannel.Create( aSubject );
			ObserveRequest( channel );
		}

		public virtual void ObserveRequest(HttpChannel channel)
		{
			
		}
	}
}
