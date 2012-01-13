using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
		internal string ReadGeckoMIMEInputStreamAsUTF8(GeckoMIMEInputStream stream)
		{
			IntPtr buffer = Marshal.AllocCoTaskMem(2048);
			var count = stream.InputStream.Read(buffer, 2048);
			byte[] temp = new byte[2048];
			for (int i = 0; i < count; ++i)
			{
				temp[i] = Marshal.ReadByte(buffer, i);
			}

			return System.Text.UTF8Encoding.UTF8.GetString(temp).Trim();
		}

		[Test]
		public void SetData_SimpleData_HeaderContainsSimpleData()
		{
			GeckoMIMEInputStream stream = new GeckoMIMEInputStream();
			string simpleData = "id=hello";
			stream.SetData(simpleData);

			Assert.IsTrue(ReadGeckoMIMEInputStreamAsUTF8(stream).Contains(simpleData));			
		}

		[Test]
		public void AddContentLength_ToTrue_HeaderContainsContentLength()
		{
			GeckoMIMEInputStream stream = new GeckoMIMEInputStream();			
			stream.AddContentLength = true;

			Assert.IsTrue(ReadGeckoMIMEInputStreamAsUTF8(stream).Contains("Content-Length"));
		}

		[Test]
		public void AddHeader_AddValidHeaderEntry_HeaderContainsHeaderEntry()
		{
			GeckoMIMEInputStream stream = new GeckoMIMEInputStream();
			stream.AddHeader("Content-Type", "application/x-www-form-urlencoded");

			string header = ReadGeckoMIMEInputStreamAsUTF8(stream);
			Assert.IsTrue(header.Contains("Content-Type"));
			Assert.IsTrue(header.Contains("application/x-www-form-urlencoded"));
		}
	}
}