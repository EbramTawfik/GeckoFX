using System;
using Gecko.IO;
using Gecko.IO.Native;

namespace Gecko.Net
{
	public class StreamListenerTee
	{
		internal nsIStreamListenerTee _streamListenerTee;
		private RequestObserver _requestObserver=new RequestObserver();

		private byte[] _capturedData;
		private NativeOutputStream _nativeOutputStream = new NativeOutputStream( 1024 * 1024 );

		public StreamListenerTee()
		{
			var streamListenerTee = Xpcom.GetService<nsIStreamListenerTee>( Contracts.StreamListenerTee );
			_streamListenerTee = Xpcom.QueryInterface<nsIStreamListenerTee>( streamListenerTee );
			_requestObserver.Stopped += OnStopped;
		}

		internal void IntInit(nsIStreamListener streamListener)
		{
			_streamListenerTee.Init(streamListener, _nativeOutputStream, _requestObserver);
		}

		private void OnStopped(object sender, EventArgs e)
		{
			var completed = Completed; 
			_capturedData = _nativeOutputStream.ReadData();
			if (completed != null)
			{
				completed(this, EventArgs.Empty);
			}
		}

		public byte[] GetCapturedData()
		{
			return _capturedData;
		}
		

		public event EventHandler Completed;
	}
}