using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skybound.Gecko
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
			
			return new CookieEnumerator( _cookieManager.GetCookiesFromHost( new nsAUTF8String( host ) ) );
		}

		public IEnumerator<Cookie> GetEnumerator()
		{
			return new CookieEnumerator( _cookieManager.GetEnumeratorAttribute() );
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


		#region Cookie Enumerator
		private sealed class CookieEnumerator
			: IEnumerator<Cookie>
		{
			private nsISimpleEnumerator _enumerator;
			private nsICookie2 _currentCookie;

			internal CookieEnumerator(nsISimpleEnumerator enumerator)
			{
				_enumerator = enumerator;
			}

			public void Dispose()
			{
				_enumerator = null;
			}

			public bool MoveNext()
			{
				bool flag = _enumerator.HasMoreElements();
				if (flag)
				{
					_currentCookie =(nsICookie2) _enumerator.GetNext();
				}
				return flag;
			}

			public void Reset()
			{
				//There is no way to "reset" an enumerator, once you obtain one.
				throw new NotSupportedException("Reset is not supported for cookie enumeration");
			}

			public Cookie Current
			{
				get { return new Cookie( _currentCookie ); }
			}

			object IEnumerator.Current
			{
				get { return Current; }
			}
		}
		#endregion
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
