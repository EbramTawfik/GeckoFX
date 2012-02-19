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
		private nsIPrivateBrowsingService _privateBrowsingService;
		public PrivateBrowsingService()
		{
			var privateBrowsingService = Xpcom.CreateInstance<nsIPrivateBrowsingService>( Contracts.PrivateBrowsing );
			_privateBrowsingService = Xpcom.QueryInterface<nsIPrivateBrowsingService>(privateBrowsingService);
		}

		public bool AutoStarted
		{
			get { return _privateBrowsingService.GetAutoStartedAttribute(); }
		}

		public bool LastChangedByCommandLine
		{
			get { return _privateBrowsingService.GetLastChangedByCommandLineAttribute(); }
		}

		public bool PrivateBrowsingEnabled
		{
			get { return _privateBrowsingService.GetPrivateBrowsingEnabledAttribute(); }
			set { _privateBrowsingService.SetPrivateBrowsingEnabledAttribute( value ); }
		}

		public void RemoveDataFromDomain(string domain)
		{
			nsString.Set( _privateBrowsingService.RemoveDataFromDomain, domain );
		}
	}
}
