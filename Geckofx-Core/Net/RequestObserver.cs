using System;

namespace Gecko.Net
{
	public sealed class RequestObserver
		:nsIRequestObserver
	{
		public void OnStartRequest( nsIRequest aRequest, nsISupports aContext )
		{
			var started = Started;
			if (started != null)
			{
				started(this, EventArgs.Empty);
			}
		}

		public void OnStopRequest( nsIRequest aRequest, nsISupports aContext, int aStatusCode )
		{
			var stopped = Stopped;
			if (stopped != null)
			{
				stopped( this, EventArgs.Empty );
			}
		}

		public event EventHandler Started;
		public event EventHandler Stopped;
	}
}