using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko.Cache
{
	public sealed class CacheSession
	{
		private InstanceWrapper<nsICacheSession> _cacheSession;

		internal CacheSession(nsICacheSession cacheSession)
		{
			_cacheSession = new InstanceWrapper<nsICacheSession>(cacheSession);
		}

		public bool DoomEntriesIfExpired
		{
			get { return _cacheSession.Instance.GetDoomEntriesIfExpiredAttribute(); }
			set { _cacheSession.Instance.SetDoomEntriesIfExpiredAttribute(value); }
		}

		public bool IsStorageEnabled
		{

			get { return _cacheSession.Instance.IsStorageEnabled(); }
		}


		public void EvictEntries()
		{
			_cacheSession.Instance.EvictEntries();
		}

		public CacheEntryDescriptor OpenCacheEntry(string key, CacheAccessMode accessRequested, bool blockingMode)
		{
			nsICacheEntryDescriptor descriptor = null;
			try
			{
				descriptor = _cacheSession.Instance.OpenCacheEntry(new nsACString(key), (IntPtr)(int)accessRequested, blockingMode);
			}
			catch ( System.Runtime.InteropServices.COMException )
			{
				
			}
			catch ( Exception )
			{
				
			}
			return descriptor != null ? new CacheEntryDescriptor( descriptor ) : null;
		}


	}

	public enum CacheAccessMode
	{
		None=0,
		Read=1,
		Write=2,
		ReadWrite=3
	}
}