using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class DomParserTests
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

		[Test]
		public void ParseFromString_AValidDocumentString_CreatesNavigatableDOM()
		{
			var parser = new DomParser();

			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span></body></html>");

			var span = doc.GetElementById("myspan");
			Assert.NotNull(span);
			Assert.AreEqual("hello world", span.TextContent);
		}


		[Test]
		public void SelectSingleTest()
		{
			var parser = new DomParser();
			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span></body></html>");
			var span = doc.SelectSingle( @".//*[@id='myspan']" );
			Assert.NotNull(span);
			Assert.AreEqual("hello world", span.TextContent);
		}


		[Test]
		public void SelectSingleTest_MultiResult()
		{
			var parser = new DomParser();
			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span><span id='myspan'>hello world</span><span id='myspan'>hello world</span></body></html>");

			GeckoNode span = null;
			Assert.Throws<GeckoDomException>( delegate
			{
				span = doc.SelectSingle( @".//*[@id='myspan']" );
			} );

		}

		[Test]
		public void SelectFirstTest()
		{
			var parser = new DomParser();
			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span></body></html>");
			var span = doc.SelectFirst(@".//*[@id='myspan']");
			Assert.NotNull(span);
			Assert.AreEqual("hello world", span.TextContent);
		}

		[Test]
		public void SelectFirstTest_MultiResult()
		{
			var parser = new DomParser();
			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span><span id='myspan'>hello world</span><span id='myspan'>hello world</span></body></html>");

			GeckoNode span = doc.SelectFirst( @".//*[@id='myspan']" );
			Assert.AreEqual( "hello world", span.TextContent );

		}
	}
}