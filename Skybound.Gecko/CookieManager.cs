using System.Collections.Generic;

namespace Gecko
{
	public sealed class CookieManager
	{
		private nsICookieManager2 _cookieManager;

		public CookieManager()
		{
			var manager = Xpcom.GetService<nsICookieManager2>("@mozilla.org/cookiemanager;1");
			_cookieManager = Xpcom.QueryInterface<nsICookieManager2>( manager );
			
		}

		public void Add(string host,string path,string name,string value,bool isSecure,bool isHttpOnly,bool isSession,long expiry)
		{
			_cookieManager.Add(
				new nsAUTF8String( host ),
				new nsAUTF8String( path ),
				new nsACString( name ),
				new nsACString( value ),
				isSecure,
				isHttpOnly,
				isSession,
				expiry );
		}

		public bool CookieExists(Cookie cookie)
		{
			return _cookieManager.CookieExists(cookie._cookie);
		}

		public int CountCookiesFromHost(string host)
		{
			// int is big for cookie count :)
			return (int)_cookieManager.CountCookiesFromHost(new nsAUTF8String(host));
		}

		public IEnumerator<Cookie> GetCookiesFromHost(string host)
		{
			return new Collections.GeckoEnumerator<Cookie, nsICookie2>(_cookieManager.GetCookiesFromHost(new nsAUTF8String(host)),
																	   x => new Cookie(x));
		}

		public IEnumerator<Cookie> GetEnumerator()
		{
			return new Collections.GeckoEnumerator<Cookie, nsICookie2>(_cookieManager.GetEnumeratorAttribute(),
																	   x => new Cookie(x));
		}

		public void ImportCookies(string filename)
		{
			_cookieManager.ImportCookies((nsIFile)Xpcom.NewNativeLocalFile(filename));
		}

		public void Remove(string host,string name,string path,bool blocked)
		{
			_cookieManager.Remove( new nsAUTF8String( host ),
			                       new nsACString( name ),
			                       new nsAUTF8String( path ),
			                       blocked );
		}

		public void RemoveAll()
		{
			_cookieManager.RemoveAll();
		}
	}


	public sealed class Cookie
	{
		internal nsICookie2 _cookie;

		internal Cookie(nsICookie2 cookie)
		{
			_cookie = cookie;
		}

		public long CreationTime
		{
			get { return _cookie.GetCreationTimeAttribute(); }
		}

		public long Expiry
		{
			get { return _cookie.GetExpiryAttribute(); }
		}

		public string Host
		{
			get { return nsString.Get( _cookie.GetHostAttribute ); }
		}

		public bool IsDomain
		{
			get { return _cookie.GetIsDomainAttribute(); }
		}

		public bool IsHttpOnly
		{
			get { return _cookie.GetIsHttpOnlyAttribute(); }
		}

		public bool IsSecure
		{
			get { return _cookie.GetIsSecureAttribute(); }
		}

		public bool IsSession
		{
			get { return _cookie.GetIsSessionAttribute(); }
		}

		public long LastAccessed
		{
			get { return _cookie.GetLastAccessedAttribute(); }
		}

		public string Name
		{
			get { return nsString.Get(_cookie.GetNameAttribute); }
		}

		public string Path
		{
			get { return nsString.Get(_cookie.GetPathAttribute); }
		}

		public string RawHost
		{
			get { return nsString.Get(_cookie.GetRawHostAttribute); }
		}

		public string Value
		{
			get { return nsString.Get(_cookie.GetValueAttribute); }
		}
	}
}
