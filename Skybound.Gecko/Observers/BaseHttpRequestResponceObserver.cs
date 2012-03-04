using System;
using System.Runtime.InteropServices;
using Gecko.Net;

namespace Gecko.Observers
{
	public class BaseHttpRequestResponceObserver
		: nsIObserver, nsISupports
	{
		internal bool _isRegistered;

		void nsIObserver.Observe( nsISupports aSubject, string aTopic, string aData )
		{
			switch (aTopic)
			{
				case ObserverNotifications.HttpRequests.HttpOnModifyRequest:
					using (var req = HttpChannel.Create( aSubject ))
					{
						Request( req );
					}
					break;
				case ObserverNotifications.HttpRequests.HttpOnExamineResponse:
					using (var res = HttpChannel.Create( aSubject ))
					{
						Responce( res );
					}
					break;
			}
		}

		protected virtual void Request(HttpChannel channel)
		{

		}

		protected virtual void Responce(HttpChannel channel)
		{

		}

		#region nsISupports
		IntPtr nsISupports.QueryInterface( ref Guid uuid )
		{
			var pUnk = Marshal.GetIUnknownForObject( this );
			IntPtr ppv;

			Marshal.QueryInterface( pUnk, ref uuid, out ppv );

			Marshal.Release( pUnk );

			if ( ppv != IntPtr.Zero )
			{
				Marshal.Release( ppv );
			}

			return ppv;
		}

		int nsISupports.AddRef()
		{
			return Marshal.AddRef( Marshal.GetIUnknownForObject( this ) );
		}

		int nsISupports.Release()
		{
			return Marshal.Release( Marshal.GetIUnknownForObject( this ) );
		}
		#endregion
	}
}