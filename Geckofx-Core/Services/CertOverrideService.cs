using System;
using Gecko.Interop;
using System.Runtime.InteropServices;
using Gecko.Certificates;
using Gecko.Events;

namespace Gecko
{
	public sealed class CertOverrideService : ComPtr<nsICertOverrideService>, nsICertOverrideService
	{
		#region Static members & internal classes

		sealed class CertOverrideServiceFactory : nsIFactory
		{
			private CertOverrideService _instance;
			
			public CertOverrideServiceFactory(CertOverrideService instance)
			{
				_instance = instance;
			}

			public IntPtr CreateInstance(nsISupports aOuter, ref Guid iid)
			{
				if (aOuter != null)
					Marshal.ThrowExceptionForHR(GeckoError.NS_ERROR_NO_AGGREGATION);

				IntPtr pvv;
				IntPtr pUnk = Marshal.GetIUnknownForObject(_instance);
				try
				{
					Marshal.ThrowExceptionForHR(Marshal.QueryInterface(pUnk, ref iid, out pvv));
				}
				finally
				{
					Marshal.Release(pUnk);
				}
				return pvv;
			}

			public void LockFactory(bool @lock)
			{
				throw new NotImplementedException();
			}
		}

		public static CertOverrideService GetService()
		{
			var svc = Xpcom.GetService<nsICertOverrideService>(Contracts.CertOverride);
			var certSvc = svc as CertOverrideService;
			if(certSvc != null)
			{
				Marshal.Release(certSvc._pUnknown);
				return certSvc;
			}
			return svc.Wrap(CertOverrideService.Create);
		}

		private static CertOverrideService Create(nsICertOverrideService instance)
		{
			return new CertOverrideService(instance);
		}

		#endregion

		#region Instance members

		#region Instance fields

		private EventHandler<CertOverrideEventArgs> validityOverrideEvent;
		private IntPtr _pUnknown;
		private CertOverrideServiceFactory _factory;

		#endregion Instance fields
		
		private CertOverrideService(nsICertOverrideService instance)
			: base(instance)
		{
			_pUnknown = Marshal.GetIUnknownForObject(this);
			Marshal.Release(_pUnknown);
		}

		public event EventHandler<CertOverrideEventArgs> ValidityOverride
		{
			add
			{
				if (_factory == null)
				{
					_factory = new CertOverrideServiceFactory(this);
					Xpcom.RegisterFactory(typeof(nsICertOverrideService).GUID, this.GetType().Name, Contracts.CertOverride, _factory);
				}
				validityOverrideEvent += value;
			}
			remove
			{
				validityOverrideEvent -= value;
			}
		}

		[Obsolete("RememberRecentBadCert is deprecated, please use RememberValidityOverride instead.")]
		public bool RememberRecentBadCert(Uri url, SSLStatus sslStatus)
		{
			if (url == null)
				throw new ArgumentNullException("url");
			if (sslStatus == null)
				throw new ArgumentNullException("sslStatus");

			Certificate cert = sslStatus.ServerCert;
			if (HasMatchingOverride(url, cert))
				return false;

			CertOverride flags = 0;
			if (sslStatus.IsUntrusted)
				flags |= CertOverride.Untrusted;
			if (sslStatus.IsDomainMismatch)
				flags |= CertOverride.Mismatch;
			if (sslStatus.IsNotValidAtThisTime)
				flags |= CertOverride.Time;

			RememberValidityOverride(url, cert, flags, true);
			return true;
		}

		public bool HasMatchingOverride(Uri url, Certificate cert)
		{
			if (url == null)
				throw new ArgumentNullException("url");

			var mapping = new System.Globalization.IdnMapping();
			using (var aHostName = new nsACString(mapping.GetAscii(url.Host)))
			{
				uint flags = 0;
				bool isTemp = false;
				return Instance.HasMatchingOverride(aHostName, url.Port, cert._cert.Instance, ref flags, ref isTemp);
			}
		}

		/// <summary>
		///  The given cert should always be accepted for the given hostname:port,
		///  regardless of errors verifying the cert.
		///  Host:Port is a primary key, only one entry per host:port can exist.
		/// </summary>
		/// <param name="url"></param>
		/// <param name="cert">The cert that should always be accepted</param>
		/// <param name="flags">The errors we want to be overriden.</param>
		public void RememberValidityOverride(Uri url, Certificate cert, CertOverride flags, bool temporary)
		{
			if (url == null)
				throw new ArgumentNullException("url");
			if (cert == null)
				throw new ArgumentNullException("cert");

			var mapping = new System.Globalization.IdnMapping();
			using (var aHostName = new nsACString(mapping.GetAscii(url.Host)))
			{
				Instance.RememberValidityOverride(aHostName, url.Port, cert._cert.Instance, (uint)flags, true);
			}
		}

		/// <summary>
		/// Remove a override for the given hostname:port.
		/// </summary>
		/// <param name="url"></param>
		public void ClearValidityOverride(Uri url)
		{
			if (url == null)
				throw new ArgumentNullException("url");

			var mapping = new System.Globalization.IdnMapping();
			using (var aHostName = new nsACString(url.Scheme != "all" ? mapping.GetAscii(url.Host) : url.OriginalString))
			{
				Instance.ClearValidityOverride(aHostName, url.Port);
			}
		}

		#endregion

		#region nsICertOverrideService

		void nsICertOverrideService.RememberValidityOverride(nsACStringBase aHostName, int aPort, nsIX509Cert aCert, uint aOverrideBits, bool aTemporary)
		{
			Instance.RememberValidityOverride(aHostName, aPort, aCert, aOverrideBits, aTemporary);
		}

		bool nsICertOverrideService.HasMatchingOverride(nsACStringBase aHostName, int aPort, nsIX509Cert aCert, ref uint aOverrideBits, ref bool aIsTemporary)
		{
			if (validityOverrideEvent != null)
			{
				var ea = new CertOverrideEventArgs(
					aHostName.ToString(),
					aPort,
					Xpcom.QueryInterface<nsIX509Cert>(aCert).Wrap(Certificate.Create) // addref
				);
				validityOverrideEvent(this, ea);
				if(ea.Handled)
				{
					aOverrideBits = (uint)ea.OverrideResult;
					aIsTemporary = ea.Temporary;
					return true;
				}
			}
			return Instance.HasMatchingOverride(aHostName, aPort, aCert, ref aOverrideBits, ref aIsTemporary);
		}

		bool nsICertOverrideService.GetValidityOverride(nsACStringBase aHostName, int aPort, nsACStringBase aHashAlg, nsACStringBase aFingerprint, ref uint aOverrideBits, ref bool aIsTemporary)
		{
			return Instance.GetValidityOverride(aHostName, aPort, aHashAlg, aFingerprint, ref aOverrideBits, ref aIsTemporary);
		}

		void nsICertOverrideService.ClearValidityOverride(nsACStringBase aHostName, int aPort)
		{
			Instance.ClearValidityOverride(aHostName, aPort);
		}

		void nsICertOverrideService.GetAllOverrideHostsWithPorts(ref uint aCount, ref IntPtr aHostsWithPortsArray)
		{
			Instance.GetAllOverrideHostsWithPorts(ref aCount, ref aHostsWithPortsArray);
		}

		uint nsICertOverrideService.IsCertUsedForOverrides(nsIX509Cert aCert, bool aCheckTemporaries, bool aCheckPermanents)
		{
			return Instance.IsCertUsedForOverrides(aCert, aCheckTemporaries, aCheckPermanents);
		}

		#endregion

	}
}
