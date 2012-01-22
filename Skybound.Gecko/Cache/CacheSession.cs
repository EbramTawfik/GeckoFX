using System;

namespace Gecko.Cache
{
	public sealed class CacheSession
	{
		private nsICacheSession _cacheSession;

		internal CacheSession(nsICacheSession cacheSession)
		{
			_cacheSession = cacheSession;
		}

		public bool DoomEntriesIfExpired
		{
			get { return _cacheSession.GetDoomEntriesIfExpiredAttribute(); }
			set { _cacheSession.SetDoomEntriesIfExpiredAttribute(value); }
		}

		public bool IsStorageEnabled
		{

			get { return _cacheSession.IsStorageEnabled(); }
		}


		public void EvictEntries()
		{
			_cacheSession.EvictEntries();
		}

		public CacheEntryDescriptor OpenCacheEntry(string key, IntPtr accessRequested, bool blockingMode)
		{
			return new CacheEntryDescriptor( _cacheSession.OpenCacheEntry( new nsACString( key ), accessRequested, blockingMode ) );
		}

		//_cacheSession.AsyncOpenCacheEntry(  );
		//_cacheSession.OpenCacheEntry(  )

	}
}