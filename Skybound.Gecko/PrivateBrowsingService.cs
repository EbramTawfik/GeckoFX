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
	public sealed class PrivateBrowsingService
	{
		private ServiceWrapper<nsIPrivateBrowsingService> _privateBrowsingService;
		public PrivateBrowsingService()
		{
			_privateBrowsingService = new ServiceWrapper<nsIPrivateBrowsingService>(Contracts.PrivateBrowsing);
		}

		public bool AutoStarted
		{
			get { return _privateBrowsingService.Instance.GetAutoStartedAttribute(); }
		}

		public bool LastChangedByCommandLine
		{
			get { return _privateBrowsingService.Instance.GetLastChangedByCommandLineAttribute(); }
		}

		public bool PrivateBrowsingEnabled
		{
			get { return _privateBrowsingService.Instance.GetPrivateBrowsingEnabledAttribute(); }
			set { _privateBrowsingService.Instance.SetPrivateBrowsingEnabledAttribute(value); }
		}

		public void RemoveDataFromDomain(string domain)
		{
			nsString.Set(_privateBrowsingService.Instance.RemoveDataFromDomain, domain);
		}
	}
}
