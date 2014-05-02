using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests
{
	[TestFixture]
	class ManagedServiceFactoriesTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize( XpComTests.XulRunnerLocation );
		}

		[Test]
		public void Unregister_ExistingFactoryExist_ExistingFactoryDetailsReturned()
		{
			var existingFactoryDetails = TestCookieServiceFactory.Unregister();
			Assert.NotNull(existingFactoryDetails);
			Assert.AreEqual(new Guid("c375fa80-150f-11d6-a618-0010a401eb10"), existingFactoryDetails.classID);
			Assert.NotNull(existingFactoryDetails.factoryInstance);

			// Reregister existing default cookie service.
			TestCookieServiceFactory.Register(existingFactoryDetails);
		}

		[Test]
		public void Unregister_ExistingFactoryThatHasBeenUnregisteredAndRegisterBefore_ExpectedFactoryDetailsReturned()
		{			
			// Setup the test
			var existingFactoryDetails = TestCookieServiceFactory.Unregister();
			Assert.NotNull(existingFactoryDetails);
			Assert.AreEqual(new Guid("c375fa80-150f-11d6-a618-0010a401eb10"), existingFactoryDetails.classID);
			Assert.NotNull(existingFactoryDetails.factoryInstance);
			TestCookieServiceFactory.Register(existingFactoryDetails);

			// Perform the test
			existingFactoryDetails = TestCookieServiceFactory.Unregister();
			Assert.NotNull(existingFactoryDetails);
			Assert.AreEqual(new Guid("c375fa80-150f-11d6-a618-0010a401eb10"), existingFactoryDetails.classID);
			Assert.NotNull(existingFactoryDetails.factoryInstance);

			// Reregister existing default cookie service.
			TestCookieServiceFactory.Register(existingFactoryDetails);
		}

		[Test]
		public void Unregister_FactoryNotCurrentlyRegistered_ThrowsCOMException()
		{
			Assert.Throws<COMException>(() => TestNewServiceFactory.Unregister());
		}

		[Test]
		public void Unregister_FactoryAlreadyUnregistered_ThrowsCOMException()
		{
			var existingFactoryDetails = TestCookieServiceFactory.Unregister();

			// Perform the test
			Assert.Throws<COMException>(() => TestCookieServiceFactory.Unregister());

			// Reregister existing default cookie service.
			TestCookieServiceFactory.Register(existingFactoryDetails);
		}

		[Test]
		public void Register_FactoryAlreadyRegistered_ThrowsCOMException()
		{
			Assert.Throws<COMException>(() => TestCookieServiceFactory.Register());
		}

		[Test, Explicit]
		public void Register_AfterDefaultFactoryHasBeenUnregistered_NewCookieServiceIsUsedInsteadOfDefaultOne()
		{
			FactoryDetails existingFactoryDetails = null;

			try
			{
				existingFactoryDetails = TestCookieServiceFactory.Unregister();
			}
			catch (Exception e)
			{
				throw e;
			}
			

			// Perform the test - register new factory.
			TestCookieServiceFactory.Register();

			// Test that the new cookies service is functioning correctly.
			Assert.AreEqual(0, TestCookieService.NumberOfTimesCreated);
			var browser = new GeckoWebBrowser();		
			browser.Navigate("www.google.com");
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			int numberOfTimeCookieCalledAfterFirstNavigate = TestCookieService.NumberOfTimesGetCookieCalled;
			browser.Navigate("www.google.com");
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			int numberOfTimeCookieCalledAfterSecondNavigate = TestCookieService.NumberOfTimesGetCookieCalled;
			Assert.Greater(numberOfTimeCookieCalledAfterSecondNavigate, numberOfTimeCookieCalledAfterFirstNavigate);
			Assert.AreEqual(1, TestCookieService.NumberOfTimesCreated);


			// Put back the original default factory.
			// Note due to internal caching GeckoWebBrowser will still use TestCookieServiceFactory rather than
			// the Original from firefox/xulrunner version. (This is why this unittest is marked Explicit)
			// So whatever cookies service is avaliable when the first navigate is called, is used for all subsequence naviagates.
			// This means that the cookie service ("@mozilla.org/cookieService;1") must be replaced before the first navigate is called
			// to have any effect.
			TestCookieServiceFactory.Unregister();
			TestCookieServiceFactory.Register(existingFactoryDetails);			
		}

		#region Test Factories and classes

		public class TestCookieService : nsICookieService
		{
			public static int NumberOfTimesCreated;
			public static int NumberOfTimesGetCookieCalled;

			public TestCookieService()
			{
				NumberOfTimesCreated++;
			}
			
			public string GetCookieString(nsIURI aURI, nsIChannel aChannel)
			{
				NumberOfTimesGetCookieCalled++;
				// Console.WriteLine("GetCookieString {0} {1}", aURI, aChannel);
				return null;
			}

			public string GetCookieStringFromHttp(nsIURI aURI, nsIURI aFirstURI, nsIChannel aChannel)
			{
				NumberOfTimesGetCookieCalled++;
				// Console.WriteLine("GetCookieStringFromHttp {0} {1} {2}", aURI, aFirstURI, aChannel);
				return null;
			}

			public void SetCookieString(nsIURI aURI, nsIPrompt aPrompt, string aCookie, nsIChannel aChannel)
			{
				// Console.WriteLine("SetCookieString {0} {1} {2} {3}", aURI, aPrompt, aCookie, aChannel);
			}

			public void SetCookieStringFromHttp(nsIURI aURI, nsIURI aFirstURI, nsIPrompt aPrompt, string aCookie, string aServerTime, nsIChannel aChannel)
			{
				// Console.WriteLine("SetCookieStringFromHttp {0} {1} {2} {3} {4} {5}", aURI, aFirstURI, aPrompt, aCookie, aServerTime, aChannel);
			}
		}

		[Guid("c375fa80-150f-11d6-a618-0010a401eb10")]
		[ContractID(TestCookieServiceFactory.ContractID)]
		public class TestCookieServiceFactory
			: GenericOneClassNsFactory<TestCookieServiceFactory, TestCookieService>
		{
			public const string ContractID = "@mozilla.org/cookieService;1";
		}

		public class TestNewService : nsISecureBrowserUI
		{			
			#region nsISecureBrowserUI Members

			public void  Init(nsIDOMWindow window)
			{
 				throw new NotImplementedException();
			}

			public void  SetDocShell(nsIDocShell docShell)
			{
 				throw new NotImplementedException();
			}

			public uint  GetStateAttribute()
			{
 				throw new NotImplementedException();
			}

			public void  GetTooltipTextAttribute(nsAStringBase aTooltipText)
			{
 				throw new NotImplementedException();
			}

			#endregion
		}

		[Guid("aaaaaaaa-bbbb-bbbb-bbbb-cccccccccccc")]
		[ContractID(TestNewServiceFactory.ContractID)]
		public class TestNewServiceFactory
			: GenericOneClassNsFactory<TestNewServiceFactory, TestNewService>
		{
			public const string ContractID = "@mozilla.org/MyNewService;1";
		}

		#endregion

	}
}
