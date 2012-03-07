using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	/// <summary>
	/// By default Xulrunner DOES NOT IMPLEMENT PrivateBrowsingService
	/// YOU MUST REGISTER YOUR OWN IMPLEMENTATION BEFORE USE THIS WRAPPER!!!
	/// </summary>
	public static class PrivateBrowsingService
	{
		private static ServiceWrapper<nsIPrivateBrowsingService> _privateBrowsingService;
		static PrivateBrowsingService()
		{
			_privateBrowsingService = new ServiceWrapper<nsIPrivateBrowsingService>(Contracts.PrivateBrowsing);
		}

		public static bool AutoStarted
		{
			get { return _privateBrowsingService.Instance.GetAutoStartedAttribute(); }
		}

		public static bool LastChangedByCommandLine
		{
			get { return _privateBrowsingService.Instance.GetLastChangedByCommandLineAttribute(); }
		}

		public static bool PrivateBrowsingEnabled
		{
			get { return _privateBrowsingService.Instance.GetPrivateBrowsingEnabledAttribute(); }
			set { _privateBrowsingService.Instance.SetPrivateBrowsingEnabledAttribute(value); }
		}

		public static void RemoveDataFromDomain(string domain)
		{
			nsString.Set(_privateBrowsingService.Instance.RemoveDataFromDomain, domain);
		}
	}
}
