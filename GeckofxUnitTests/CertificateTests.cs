using System.Linq;
using Gecko;
using Gecko.Certificates;
using Gecko.IO.Native;
using GeckofxUnitTests.Common;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class CertificateTests
		: BaseXulrunnerTest
	{
		private const string CertificateTestsCategory = "Certificate";

		[Test]
		[Category(CertificateTestsCategory)]
		public void CertificateDatabase_GetCerts()
		{
			var certs=CertificateDatabase.GetCerts();

			Assert.NotNull( certs );
		}
		[Test]
		[Category(CertificateTestsCategory)]
		public void CertificateDatabase_EnumCerts()
		{
			var certs = CertificateDatabase.GetCerts();
			var array=certs.ToArray();

			Assert.NotNull( array );
			Assert.IsTrue( array.Length > 0 );
		}

		[Test]
		[Category(CertificateTestsCategory)]
		public void CertificateDatabase_GoogleCerts()
		{
			var googleCerts = CertificateDatabase.GetCerts().Where( x => x.Nickname.Contains( "Google" ) ).ToArray();

			Assert.NotNull(googleCerts);
		}
	}
}