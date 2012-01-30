using System;

namespace Gecko.Net
{
	public class HttpChannel
		:Channel
	{
		private nsIHttpChannel _httpChannel;

		internal HttpChannel (nsIHttpChannel  httpChannel)
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
			return nsString.Get( _httpChannel.GetRequestHeader, header );
		}

		public void SetRequestHeader(string header,string value,bool merge)
		{
			nsString.Pass( ( x, y ) => _httpChannel.SetRequestHeader( x, y, merge ), header, value );
		}

		public void VisitRequestHeaders(nsIHttpHeaderVisitor visitor)
		{
			_httpChannel.VisitRequestHeaders(visitor);
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
			nsString.Pass((x, y) => _httpChannel.SetResponseHeader(x, y, merge), header, value);
		}

		public void VisitResponseHeaders(nsIHttpHeaderVisitor visitor)
		{
			_httpChannel.VisitResponseHeaders(visitor);
		}

		public bool IsNoStoreResponse
		{
			get { return _httpChannel.IsNoStoreResponse(); }
		}

		public bool IsNoCacheResponce
		{
			get { return _httpChannel.IsNoCacheResponse(); }
		}

	}
}