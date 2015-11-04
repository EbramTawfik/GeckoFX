using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Certificates
{
	public static class CertificateDatabase
	{
		private static ComPtr<nsIX509CertDB> _certDb;		

		static CertificateDatabase()
		{
			_certDb = Xpcom.GetService2<nsIX509CertDB>(Contracts.X509CertDb);			
		}


		public static Certificate ConstructX509FromBase64(string base64)
		{
			return Certificate.Create(  (nsIX509Cert) _certDb.Instance.ConstructX509FromBase64( base64 ) );
		}


		#region nsIX509CertDB2
		public static CertificateList GetCerts()
		{
            return new CertificateList(_certDb.Instance.GetCerts());
		}

		public static void AddCertFromBase64(string base64, string trust, string name)
		{
            _certDb.Instance.AddCertFromBase64(base64, trust, name);
		}
		#endregion
	}
}
