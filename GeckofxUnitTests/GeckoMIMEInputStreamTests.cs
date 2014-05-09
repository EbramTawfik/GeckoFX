using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.IO;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class GeckoMIMEInputStreamTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{

		}

		/// <summary>
		/// This is for unit tests only.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns></returns>
		internal string ReadGeckoMIMEInputStreamAsUTF8(MimeInputStream stream)
		{
			byte[] buffer = new byte[2048];
			var count = stream.Read(buffer,0, 2048);

			return System.Text.UTF8Encoding.UTF8.GetString(buffer).Trim();
		}

		[Test]
		public void SetData_SimpleData_HeaderContainsSimpleData()
		{
			MimeInputStream stream = MimeInputStream.Create();
			string simpleData = "id=hello";
			stream.SetData(simpleData);

			Assert.IsTrue(ReadGeckoMIMEInputStreamAsUTF8(stream).Contains(simpleData));			
		}

		[Test]
		public void AddContentLength_ToTrue_HeaderContainsContentLength()
		{
			MimeInputStream stream = MimeInputStream.Create();
			stream.AddContentLength = true;

			Assert.IsTrue(ReadGeckoMIMEInputStreamAsUTF8(stream).Contains("Content-Length"));
		}

		[Test]
		public void AddHeader_AddValidHeaderEntry_HeaderContainsHeaderEntry()
		{
			MimeInputStream stream = MimeInputStream.Create();
			stream.AddHeader("Content-Type", "application/x-www-form-urlencoded");

			string header = ReadGeckoMIMEInputStreamAsUTF8(stream);
			Assert.IsTrue(header.Contains("Content-Type"));
			Assert.IsTrue(header.Contains("application/x-www-form-urlencoded"));
		}
	}
}