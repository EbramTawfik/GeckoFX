using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.Net
{
	public class HttpChannel
		:Channel,IDisposable
	{
		private nsIHttpChannel _httpChannel;
		private bool _decrement;

		private HttpChannel(nsIHttpChannel httpChannel)
			:base(httpChannel)
		{
			_httpChannel = httpChannel;
		}

		~HttpChannel()
		{
			Release();
		}

		public static HttpChannel Create(nsIHttpChannel httpChannel)
		{
			return httpChannel == null ? null : new HttpChannel( httpChannel );
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

		public List<KeyValuePair<string, string>> GetRequestHeaders()
		{
			HttpHeaderVisitor visitor = new HttpHeaderVisitor();
			_httpChannel.VisitRequestHeaders(visitor);
			return visitor.httpHeadersList;
		}

		public Dictionary<string, List<string>> GetRequestHeadersDict()
		{
			var headersList = GetRequestHeaders();
			var dictRes = new Dictionary<string, List<string>>();
			foreach (var header in headersList) {
				if (dictRes.ContainsKey(header.Key)) {
					var listVal = dictRes[header.Key];
					listVal.Add(header.Value);
					dictRes[header.Key] = listVal;
				}
				else {
					dictRes.Add(header.Key, new List<string> { header.Value });
				}
			}
			return dictRes;
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

		public List<KeyValuePair<string, string>> GetResponseHeaders() {
			HttpHeaderVisitor visitor = new HttpHeaderVisitor();
			_httpChannel.VisitResponseHeaders(visitor);
			return visitor.httpHeadersList;
		}

		public Dictionary<string, List<string>> GetResponseHeadersDict()
		{
			var headersList = GetResponseHeaders();
			var dictRes = new Dictionary<string, List<string>>();
			foreach (var header in headersList) {
				if (dictRes.ContainsKey(header.Key)) {
					var listVal = dictRes[header.Key];
					listVal.Add(header.Value);
					dictRes[header.Key] = listVal;
				}
				else {
					dictRes.Add(header.Key, new List<string> { header.Value });
				}
			}
			return dictRes;
		}

		public bool IsNoStoreResponse
		{
			get { return _httpChannel.IsNoStoreResponse(); }
		}

		public bool IsNoCacheResponse
		{
			get { return _httpChannel.IsNoCacheResponse(); }
		}

		#region Casts
		#endregion
		public UploadChannel CastToUploadChannel()
		{
			var channel = Xpcom.QueryInterface<nsIUploadChannel>( _httpChannel );
			return channel.Wrap( x => new UploadChannel( x ) );
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
			//int count = Interop.ComDebug.GetRcwRefCount(supports);

			var channel = Xpcom.QueryInterface<nsIHttpChannel>(supports);
			if (channel == null) return null;
			Marshal.ReleaseComObject(channel);
			var ret = new HttpChannel((nsIHttpChannel)supports);

			//var count2=Interop.ComDebug.GetRcwRefCount( supports );

			return ret;
		}


		private sealed class HttpHeaderVisitor
			: nsIHttpHeaderVisitor
		{
			internal readonly List<KeyValuePair<string, string>> httpHeadersList = new List<KeyValuePair<string, string>>();

			public void VisitHeader( nsACStringBase aHeader, nsACStringBase aValue )
			{
				httpHeadersList.Add(new KeyValuePair<string, string>(aHeader.ToString(), aValue.ToString()));
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
			var old = _traceableChannel.SetNewListener( streamListener._streamListenerTee.Instance );
			streamListener.IntInit( old );
		}
	}



}