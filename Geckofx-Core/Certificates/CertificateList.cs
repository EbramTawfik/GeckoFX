using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko.Certificates
{
	public sealed class CertificateList
		:IEnumerable<Certificate>
	{
		internal InstanceWrapper<nsIX509CertList> _list;

		internal CertificateList(nsIX509CertList list)
		{
			_list = new InstanceWrapper<nsIX509CertList>( list );
		}

		public IntPtr RawCertList
		{
			get { return _list.Instance.GetRawCertList(); }
		}

		public IEnumerator<Certificate> GetEnumerator()
		{
			return new GeckoEnumerator<Certificate, nsIX509Cert>( _list.Instance.GetEnumerator(), Certificate.Create );
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void AddCert(Certificate certificate)
		{
			_list.Instance.AddCert(certificate._cert1);
		}

		public void DeleteCert(Certificate certificate)
		{
			_list.Instance.DeleteCert(certificate._cert1);
		}
	}
}