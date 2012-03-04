using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.Net;

namespace Gecko.Observers
{
	public class BaseHttpModifyRequestObserver
		: nsIObserver, nsISupports
	{
		internal bool _isRegistered;

		void nsIObserver.Observe(nsISupports aSubject, string aTopic, string aData)
		{
			if (aTopic != ObserverNotifications.HttpRequests.HttpOnModifyRequest) return;
			using (var channel = HttpChannel.Create(aSubject))
			{
				ObserveRequest(channel);
			}
			
		}

		protected virtual void ObserveRequest(HttpChannel channel)
		{
			
		}

		#region nsISupports
		IntPtr nsISupports.QueryInterface(ref Guid uuid)
		{
			var pUnk = Marshal.GetIUnknownForObject(this);
			IntPtr ppv;

			Marshal.QueryInterface(pUnk, ref uuid, out ppv);

			Marshal.Release(pUnk);

			if (ppv != IntPtr.Zero)
			{
				Marshal.Release(ppv);
			}

			return ppv;
		}

		int nsISupports.AddRef()
		{
			return Marshal.AddRef(Marshal.GetIUnknownForObject(this));
		}

		int nsISupports.Release()
		{
			return Marshal.Release(Marshal.GetIUnknownForObject(this));
		}
		#endregion
	}
}
