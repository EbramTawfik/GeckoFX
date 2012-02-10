using System;
using System.Collections.Generic;

namespace Gecko.Net
{
	public class HttpChannel
		:Channel
	{
		private nsIHttpChannel _httpChannel;

		public HttpChannel (nsIHttpChannel  httpChannel)
			:base(httpChannel)
		{
			_httpChannel = httpChannel;
		}


		public string RequestMethod
		{
			get { return nsString.Get( _httpChannel.GetRequestMethodAttribute ); }
			set { nsString.Set( _httpChannel.SetRequestMethodAttribute,value ); }
		}
		
		public Uri Referrer
		{
			get { return nsURI.ToUri( _httpChannel.GetReferrerAttribute() ); }
			set{_httpChannel.SetReferrerAttribute( nsURI.CreateInternal( value.ToString() ) );}
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


}