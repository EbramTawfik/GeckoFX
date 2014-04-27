namespace Gecko
{

	// Implement nsIXULWindow interface on GeckoWebBrowser, so that nsIWindowMediator can find GeckoWebBrowser.
	// It seems that only GetDocShellAttribute() is required by nsIWindowMediator, so we leave other method not implemented.
	public partial class GeckoWebBrowser : nsIXULWindow
	{

		public nsIDocShell GetDocShellAttribute()
		{
			return Xpcom.QueryInterface<nsIDocShell>(this.WebBrowser);
		}

		public bool GetIntrinsicallySizedAttribute()
		{
			throw new System.NotImplementedException();
		}

		public void SetIntrinsicallySizedAttribute(bool aIntrinsicallySized)
		{
			throw new System.NotImplementedException();
		}

		public nsIDocShellTreeItem GetPrimaryContentShellAttribute()
		{
			throw new System.NotImplementedException();
		}

		public nsIDocShellTreeItem GetContentShellById(string ID)
		{
			throw new System.NotImplementedException();
		}

		public void AddChildWindow(nsIXULWindow aChild)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveChildWindow(nsIXULWindow aChild)
		{
			throw new System.NotImplementedException();
		}

		public void Center(nsIXULWindow aRelative, bool aScreen, bool aAlert)
		{
			throw new System.NotImplementedException();
		}

		public void ShowModal()
		{
			throw new System.NotImplementedException();
		}

		public uint GetZLevelAttribute()
		{
			throw new System.NotImplementedException();
		}

		public void SetZLevelAttribute(uint aZLevel)
		{
			throw new System.NotImplementedException();
		}

		public uint GetContextFlagsAttribute()
		{
			throw new System.NotImplementedException();
		}

		public void SetContextFlagsAttribute(uint aContextFlags)
		{
			throw new System.NotImplementedException();
		}

		uint nsIXULWindow.GetChromeFlagsAttribute()
		{
			throw new System.NotImplementedException();
		}

		void nsIXULWindow.SetChromeFlagsAttribute(uint aChromeFlags)
		{
			throw new System.NotImplementedException();
		}

		public void AssumeChromeFlagsAreFrozen()
		{
			throw new System.NotImplementedException();
		}

		public nsIXULWindow CreateNewWindow(int aChromeFlags)
		{
			throw new System.NotImplementedException();
		}

		public nsIXULBrowserWindow GetXULBrowserWindowAttribute()
		{
			throw new System.NotImplementedException();
		}

		public void SetXULBrowserWindowAttribute(nsIXULBrowserWindow aXULBrowserWindow)
		{
			throw new System.NotImplementedException();
		}

		public void ApplyChromeFlags()
		{
			throw new System.NotImplementedException();
		}
	}
}