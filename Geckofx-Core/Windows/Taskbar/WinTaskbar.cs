using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Windows
{
	/// <summary>
	/// Class for controling Windows 7 taskbar behavior
	/// ONLY Windows 7+
	/// </summary>
	public sealed class WinTaskbar
	{
		private readonly nsIWinTaskbar _winTaskbar;

		public WinTaskbar()
		{
			// may be throwing exception is not good and we shall use GetAvailableAttribute()?
			//if (Xpcom.IsLinux)
			//{
			//    throw new ApplicationException("Windows 7 Taskbar is not avaliable in Linux :)"); 
			//}
			var winTaskbar = Xpcom.CreateInstance<nsIWinTaskbar>( "@mozilla.org/windows-taskbar;1" );
			_winTaskbar = Xpcom.QueryInterface<nsIWinTaskbar>( winTaskbar );


		}

		public bool Available
		{
			get { return _winTaskbar.GetAvailableAttribute(); }
		}

		public string DefaultGroupId
		{
			get { return nsString.Get( _winTaskbar.GetDefaultGroupIdAttribute ); }
		}

		public JumpListBuilder CreateJumpListBuilder()
		{
			return new JumpListBuilder( _winTaskbar.CreateJumpListBuilder() );
		}

		//_winTaskbar.CreateTaskbarTabPreview(  )

		//_winTaskbar.GetTaskbarProgress(  )

		//_winTaskbar.GetTaskbarWindowPreview(  )

		//_winTaskbar.PrepareFullScreen(  );

		public void PrepareFullScreenHWND( IntPtr aWindow, bool aFullScreen )
		{
			_winTaskbar.PrepareFullScreenHWND( aWindow, aFullScreen );
		}

		public void SetGroupIdForWindow(GeckoWindow aParent, string aIdentifier)
		{
			nsString.Set( x => _winTaskbar.SetGroupIdForWindow( aParent.DomWindow, x ), aIdentifier );
		}

	}
}
