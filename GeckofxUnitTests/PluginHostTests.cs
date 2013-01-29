using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;
using Gecko.Plugins;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class PluginHostTests
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
		public void GetPluginTags()
		{
			var tagsArray = PluginHost.GetPluginTags();
			Assert.NotNull(tagsArray);
			foreach (var a in tagsArray)
			{
				Assert.NotNull(a.Fullpath);				
				Assert.NotNull(a.Name);				
			}
		}
	}
}