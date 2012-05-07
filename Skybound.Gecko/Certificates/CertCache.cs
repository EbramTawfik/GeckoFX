namespace Gecko.Certificates
{
	public sealed class CertCache
	{
		internal nsINSSCertCache _certCache;

		internal CertCache(nsINSSCertCache certCache)
		{
			_certCache = certCache;
		}

		/// <summary>
		/// cacheAllCerts
		///
		/// Creates a cache of all certificates currently known to NSS.
		/// </summary>
		public void CacheAllCerts()
		{
			_certCache.CacheAllCerts();
		}

		/// <summary>Member CacheCertList </summary>
		/// <param name='list'> </param>
		public void CacheCertList(CertificateList list)
		{
			_certCache.CacheCertList( list._list );
		}

		/// <summary>
		/// get an X509CertList
		/// </summary>
		public CertificateList GetX509CachedCerts()
		{
			return new CertificateList( _certCache.GetX509CachedCerts() );
		}

		/// <summary>
		/// getCachedCerts
		///
		/// Returns the cached CERTCertList*
		/// </summary>
		//[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		//System.IntPtr GetCachedCerts();
	}
}