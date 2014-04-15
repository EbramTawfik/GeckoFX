using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Certificates
{
	public static class CertificateDatabase
	{
		private static ServiceWrapper<nsIX509CertDB> _certDb;
		private static ServiceWrapper<nsIX509CertDB2> _certDb2;

		static CertificateDatabase()
		{
			_certDb = new ServiceWrapper<nsIX509CertDB>(Contracts.X509CertDb);
			_certDb2 = new ServiceWrapper<nsIX509CertDB2>(Contracts.X509CertDb);
		}


		public static Certificate ConstructX509FromBase64(string base64)
		{
			return Certificate.Create(  _certDb.Instance.ConstructX509FromBase64( base64 ) );
		}


		#region nsIX509CertDB2
		public static CertificateList GetCerts()
		{
			return new CertificateList(_certDb2.Instance.GetCerts());
		}

		public static void AddCertFromBase64(string base64, string trust, string name)
		{
			_certDb2.Instance.AddCertFromBase64(base64, trust, name);
		}
		#endregion
	}
}
