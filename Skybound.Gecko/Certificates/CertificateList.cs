using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko.Certificates
{
	public sealed class CertificateList
		:IEnumerable<Certificate>
	{
		private nsIX509CertList _list;

		internal CertificateList(nsIX509CertList list)
		{
			_list = list;
		}

		public IntPtr RawCertList
		{
			get { return _list.GetRawCertList(); }
		}

		public IEnumerator<Certificate> GetEnumerator()
		{
			return new GeckoEnumerator<Certificate, nsIX509Cert>( _list.GetEnumerator(), Certificate.Create );
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void AddCert(Certificate certificate)
		{
			_list.AddCert( certificate._cert1 );
		}

		public void DeleteCert(Certificate certificate)
		{
			_list.DeleteCert( certificate._cert1 );
		}
	}
}