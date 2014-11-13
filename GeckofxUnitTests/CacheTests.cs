using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Gecko;
using Gecko.Cache;
using Gecko.Certificates;
using Gecko.Interop;
using GeckofxUnitTests.Common;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class CacheTests
		:BaseXulrunnerTest
	{
		public const string CacheTestsCategory = "Cache";
		
		[Test]
		[Category(CacheTestsCategory)]
		public void CacheServiceGet()
		{
			var session = CacheService.CreateSession( "HTTP", CacheStoragePolicy.InMemory, true );

			Assert.NotNull(session);
		}

		[Test]
		[Category(CacheTestsCategory)]
		public void EnumerateEntries()
		{
			var all = CacheService.Search( x => true );

			Assert.NotNull( all );
			// If it is first start we can get all.Length==0
		}

		
    }

	[TestFixture]
	public class CacheTestsWithWinformsBrowser
		:BaseXulrunnerTestWithWinFormsBrowser
	{
		protected override void BeforeEachTestSetup()
		{
			base.BeforeEachTestSetup();
			Browser.Navigate( "http://google.com" );
			bool pageNotLoaded = true;
			Browser.DocumentCompleted += delegate
			{
				pageNotLoaded = false;
			};
			// it is bad for real app but not for tests
			while (pageNotLoaded)
			{
				Application.DoEvents();
			}
		}

		[Test]
		[Category(CacheTests.CacheTestsCategory)]
		public void EnumerateEntriesRefCounter()
		{

			var all = CacheService.Search(x =>
			{
                return true;
			});

			Assert.NotNull(all);
			Assert.NotNull( all.Length > 0 );

			var session = CacheService.CreateSession("HTTP", CacheStoragePolicy.Anywhere, true);
			Assert.IsNotNull(session);

			CacheEntryDescriptor descriptor = null;
			// try to find any png image on google page
			var key = all.FirstOrDefault(x => x.EndsWith( "png", StringComparison.InvariantCultureIgnoreCase ));
			if (key == null)
			{
				//okay :-(
				return;
			}
			
			session.AsyncOpenCacheEntry(key, CacheAccessMode.Read, (x,y,z) =>
			{
				descriptor = x;
			} );
			while (null==descriptor)
			{
				Application.DoEvents();
			}
			Assert.IsNotNull( descriptor );
			var stream=descriptor.OpenInputStream( 0 );
			Assert.IsNotNull(stream);
			var len = stream.Available;
			var bytes = new byte[len];
			stream.Read( bytes, 0, bytes.Length );

			stream.Close();

        }
	}
}
