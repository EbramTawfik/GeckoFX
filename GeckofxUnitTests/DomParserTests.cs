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
	internal class DomParaserTests
	{
		[Test]
		public void ParseFromString_AValidDocumentString_CreatesNavigatableDOM()
		{
			var parser = new DomParser();

			GeckoDomDocument doc = parser.ParseFromString("<html><body><span id='myspan'>hello world</span></body></html>");

			var span = doc.GetElementById("myspan");
			Assert.NotNull(span);
			Assert.AreEqual("hello world", span.TextContent);
		}
	}
}