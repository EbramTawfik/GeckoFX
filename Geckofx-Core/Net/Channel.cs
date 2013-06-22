using System;
using Gecko.Interop;

namespace Gecko.Net
{
	public class Channel
		:Request
	{
		private nsIChannel _channel;

		protected Channel(nsIChannel channel)
			:base(channel)
		{
			_channel = channel;
		}

		public static Channel Create(nsIChannel channel)
		{
			if ( channel is nsIHttpChannel )
			{
				return HttpChannel.Create( ( nsIHttpChannel ) channel );
			}
			return new Channel( channel );
		}

		public Uri OriginalUri
		{
			get { return nsURI.ToUri( _channel.GetOriginalURIAttribute() ); }
			set { _channel.SetOriginalURIAttribute( IOService.CreateNsIUri( value.ToString() ) ); }
		}

		public Uri Uri
		{
			get { return nsURI.ToUri(_channel.GetURIAttribute()); }
		}

		public Interop.nsSupports Owner
		{
			get{return new nsSupports( _channel.GetOwnerAttribute() );}
			set{_channel.SetOwnerAttribute( value._nsISupports );}
		}

		public nsIInterfaceRequestor NotificationCallbacks
		{
			get { return _channel.GetNotificationCallbacksAttribute(); }
			set{_channel.SetNotificationCallbacksAttribute( value );}
		}

		public nsSupports SecurityInfo
		{
			get{return new nsSupports( _channel.GetSecurityInfoAttribute() );}
		}

		public string ContentType
		{
			get { return nsString.Get( _channel.GetContentTypeAttribute ); }
			set{nsString.Set( _channel.SetContentTypeAttribute,value );}
		}

		public string ContentCharset
		{
			get { return nsString.Get(_channel.GetContentCharsetAttribute); }
			set { nsString.Set(_channel.SetContentCharsetAttribute, value); }
		}

		public long ContentLength
		{
			get { return _channel.GetContentLengthAttribute(); }
			set { _channel.SetContentLengthAttribute( value ); }
		}

		public IO.InputStream Open()
		{
			return IO.InputStream.Create( _channel.Open() );
		}

		//void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

		public uint ContentDisposition
		{
			get { return _channel.GetContentDispositionAttribute(); }
		}

		public string ContentDispositionFilename
		{
			get { return nsString.Get( _channel.GetContentDispositionFilenameAttribute ); }
		}

		public string ContentDispositionHeader
		{
			get { return nsString.Get(_channel.GetContentDispositionHeaderAttribute); }
		}
	}
}