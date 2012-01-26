using System.Linq;
using System.Text;

namespace Gecko.Certificates
{
	public sealed class CertificateDatabase
	{
		private nsIX509CertDB _certDb;
		private nsIX509CertDB2 _certDb2;
		public CertificateDatabase()
		{
			var certDb=Xpcom.CreateInstance<nsIX509CertDB>( "@mozilla.org/security/x509certdb;1" );
			_certDb = Xpcom.QueryInterface<nsIX509CertDB>(certDb);
			_certDb2 = Xpcom.QueryInterface<nsIX509CertDB2>(certDb);

			
		}

		public CertificateList GetCerts()
		{
			return new CertificateList( _certDb2.GetCerts() );
		}


		public Certificate ConstructX509FromBase64(string base64)
		{
			return Certificate.Create(  _certDb.ConstructX509FromBase64( base64 ) );
		}
	}
}
