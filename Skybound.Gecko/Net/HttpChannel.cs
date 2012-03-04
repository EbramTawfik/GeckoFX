using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Gecko.Net
{
	public class HttpChannel
		:Channel,IDisposable
	{
		private nsIHttpChannel _httpChannel;
		private bool _decrement;

		internal HttpChannel(nsIHttpChannel httpChannel)
			:base(httpChannel)
		{
			_httpChannel = httpChannel;
		}

		~HttpChannel()
		{
			Release();
		}

		public void Dispose()
		{
			Release();
			GC.SuppressFinalize( this );
		}

		private void Release()
		{
			if (_decrement)
			{
				_decrement = false;
				Marshal.ReleaseComObject( _httpChannel );
			}
		}


		public string RequestMethod
		{
			get { return nsString.Get( _httpChannel.GetRequestMethodAttribute ); }
			set { nsString.Set( _httpChannel.SetRequestMethodAttribute,value ); }
		}
		
		public Uri Referrer
		{
			get { return nsURI.ToUri( _httpChannel.GetReferrerAttribute() ); }
			set { _httpChannel.SetReferrerAttribute(IOService.CreateNsIUri(value.ToString())); }
		}

		public string GetRequestHeader(string header)
		{
			string ret = null;
			try
			{
				ret= nsString.Get( _httpChannel.GetRequestHeader, header );
			}
			catch ( Exception )
			{

			}
			return ret;
		}

		public void SetRequestHeader(string header,string value,bool merge)
		{
			nsString.Set( ( x, y ) => _httpChannel.SetRequestHeader( x, y, merge ), header, value );
		}

		public Dictionary<string,string> GetRequestHeaders()
		{
			HttpHeaderVisitor visitor=new HttpHeaderVisitor();
			_httpChannel.VisitRequestHeaders(visitor);
			return visitor.Dictionary;
		}

		public bool AllowPipelining
		{
			get { return _httpChannel.GetAllowPipeliningAttribute(); }
			set{_httpChannel.SetAllowPipeliningAttribute( value );}
		}

		public uint RedirectionLimit
		{
			get { return _httpChannel.GetRedirectionLimitAttribute(); }
			set{_httpChannel.SetRedirectionLimitAttribute( value );}
		}

		public uint ResponseStatus
		{
			get { return _httpChannel.GetResponseStatusAttribute(); }
		}
		
		public string ResponseStatusText
		{
			get { return nsString.Get( _httpChannel.GetResponseStatusTextAttribute ); }
		}

		public bool RequestSucceeded
		{
			get { return _httpChannel.GetRequestSucceededAttribute(); }
		}

		public string GetResponseHeader(string header)
		{
			return nsString.Get(_httpChannel.GetResponseHeader, header);
		}

		public void SetResponseHeader(string header, string value, bool merge)
		{
			nsString.Set((x, y) => _httpChannel.SetResponseHeader(x, y, merge), header, value);
		}

		public Dictionary<string, string> GetResponseHeaders()
		{
			HttpHeaderVisitor visitor=new HttpHeaderVisitor();
			_httpChannel.VisitResponseHeaders(visitor);
			return visitor.Dictionary;
		}

		public bool IsNoStoreResponse
		{
			get { return _httpChannel.IsNoStoreResponse(); }
		}

		public bool IsNoCacheResponce
		{
			get { return _httpChannel.IsNoCacheResponse(); }
		}

		#region Casts
		#endregion
		public UploadChannel CastToUploadChannel()
		{
			var channel = Xpcom.QueryInterface<nsIUploadChannel>( _httpChannel );
			return channel == null ? null : new UploadChannel(channel);
		}

		public TraceableChannel CastToTraceableChannel()
		{
			var channel = Xpcom.QueryInterface<nsITraceableChannel>( _httpChannel );
			return channel == null ? null : new TraceableChannel(channel);
		}

		/// <summary>
		/// Creates HttpChannel directly from nsISupports
		/// </summary>
		/// <param name="supports"></param>
		/// <returns></returns>
		public static HttpChannel Create(nsISupports supports)
		{
			int count = Interop.ComDebug.GetRefCount(supports);
			var channel = Xpcom.QueryInterface<nsIHttpChannel>(supports);
			if (channel == null) return null;
			Marshal.ReleaseComObject( channel );
			var ret = new HttpChannel((nsIHttpChannel)supports);

			var count2=Interop.ComDebug.GetRefCount( supports );
			
			return ret;
		}

		public static HttpChannel Create(nsIHttpChannel httpChannel)
		{
			return new HttpChannel( httpChannel );
		}

		private sealed class HttpHeaderVisitor
			: nsIHttpHeaderVisitor
		{
			internal readonly Dictionary<string, string> Dictionary=new Dictionary<string, string>();  

			public void VisitHeader( nsACStringBase aHeader, nsACStringBase aValue )
			{
				Dictionary.Add( aHeader.ToString(), aValue.ToString() );
			}
		}

	
	}


	public sealed class TraceableChannel
	{
		private nsITraceableChannel _traceableChannel;
		internal TraceableChannel(nsITraceableChannel traceableChannel)
		{
			_traceableChannel = traceableChannel;
		}


		public void SetNewListener(StreamListenerTee streamListener)
		{
			var old = _traceableChannel.SetNewListener( streamListener._streamListenerTee );
			streamListener.IntInit( old );
		}
	}
}