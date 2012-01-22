using System;

namespace Gecko.Cache
{
	public sealed class CacheEntryDescriptor
		: CacheEntryInfo
	{
		private nsICacheEntryDescriptor _cacheEntryDescriptor;

		public CacheEntryDescriptor( nsICacheEntryDescriptor cacheEntryDescriptor )
			: base( cacheEntryDescriptor )
		{
			_cacheEntryDescriptor = cacheEntryDescriptor;
		}

		public void Close()
		{
			_cacheEntryDescriptor.Close();
		}

		public void Doom()
		{
			_cacheEntryDescriptor.Doom();


		}

		public void DoomAndFailPendingRequests( int status )
		{
			_cacheEntryDescriptor.DoomAndFailPendingRequests( status );

		}

		public IntPtr AccessGranted
		{
			get { return _cacheEntryDescriptor.GetAccessGrantedAttribute(); }
		}

		public nsISupports CacheElement
		{
			get { return _cacheEntryDescriptor.GetCacheElementAttribute(); }
			set { _cacheEntryDescriptor.SetCacheElementAttribute( value ); }
		}

		public new uint ExpirationTime
		{
			get { return _cacheEntryDescriptor.GetExpirationTimeAttribute(); }
			set { _cacheEntryDescriptor.SetExpirationTime( value ); }
		}

		public new uint DataSize
		{
			get { return _cacheEntryDescriptor.GetDataSizeAttribute(); }
			set { _cacheEntryDescriptor.SetDataSize( value ); }
		}

		public nsIInputStream OpenInputStream( uint offset )
		{
			return _cacheEntryDescriptor.OpenInputStream( offset );
		}

		public nsIOutputStream OpenOutputStream( uint offset )
		{
			return _cacheEntryDescriptor.OpenOutputStream( offset );
		}

		public long PredictedDataSize
		{
			get { return _cacheEntryDescriptor.GetPredictedDataSizeAttribute(); }
			set { _cacheEntryDescriptor.SetPredictedDataSizeAttribute( value ); }
		}

		public IntPtr StoragePolicy
		{
			get { return _cacheEntryDescriptor.GetStoragePolicyAttribute(); }
			set { _cacheEntryDescriptor.SetStoragePolicyAttribute( value ); }
		}

		public nsIFile File
		{
			get { return _cacheEntryDescriptor.GetFileAttribute(); }
		}

		public nsISupports SecurityInfo
		{
			get { return _cacheEntryDescriptor.GetSecurityInfoAttribute(); }
			set { _cacheEntryDescriptor.SetSecurityInfoAttribute( value ); }
		}

		public void MarkValid()
		{
			_cacheEntryDescriptor.MarkValid();
		}


		public string GetMetaDataElement( string key )
		{
			return _cacheEntryDescriptor.GetMetaDataElement( key );
		}

		public void SetMetaDataElement( string key, string value )
		{
			_cacheEntryDescriptor.SetMetaDataElement( key, value );
		}

		// void VisitMetaData([MarshalAs(UnmanagedType.Interface)] nsICacheMetaDataVisitor visitor);

	}
}