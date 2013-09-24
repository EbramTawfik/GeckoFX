using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Gecko.Listeners;
using Gecko.Windows;

// PLZ keep all Windows Forms related code here
namespace Gecko
{
	partial class GeckoWebBrowser
		: Control
	{
		#region Overridden Properties

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override Color BackColor
		{
			get { return base.BackColor; }
			set { base.BackColor = value; }
		}

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override Image BackgroundImage
		{
			get { return base.BackgroundImage; }
			set { base.BackgroundImage = value; }
		}

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override ImageLayout BackgroundImageLayout
		{
			get { return base.BackgroundImageLayout; }
			set { base.BackgroundImageLayout = value; }
		}

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override Color ForeColor
		{
			get { return base.ForeColor; }
			set { base.ForeColor = value; }
		}

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override Font Font
		{
			get { return base.Font; }
			set { base.Font = value; }
		}

		[Browsable( false ), DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public override string Text
		{
			get { return base.Text; }
			set { base.Text = value; }
		}

		#endregion

		#region Overriden WinForms functions

		private nsIDOMEventTarget _target;

		protected override void OnHandleCreated( EventArgs e )
		{
#if GTK	
			if (Xpcom.IsMono)
			{
				base.OnHandleCreated(e);
				m_wrapper.Init();
			}
#endif
			if ( !this.DesignMode )
			{
				Xpcom.Initialize();
				WindowCreator.Register();
#if !GTK
				LauncherDialogFactory.Register();
#endif

				WebBrowser = Xpcom.CreateInstance<nsIWebBrowser>(Contracts.WebBrowser);
				WebBrowserFocus = ( nsIWebBrowserFocus ) WebBrowser;
				BaseWindow = ( nsIBaseWindow ) WebBrowser;
				WebNav = ( nsIWebNavigation ) WebBrowser;

				WebBrowser.SetContainerWindowAttribute( this );
#if GTK
				if (Xpcom.IsMono)
					BaseWindow.InitWindow(m_wrapper.BrowserWindow.Handle, IntPtr.Zero, 0, 0, this.Width, this.Height);
				else
#endif
				BaseWindow.InitWindow( this.Handle, IntPtr.Zero, 0, 0, this.Width, this.Height );

				
				BaseWindow.Create();

				Guid nsIWebProgressListenerGUID = typeof (nsIWebProgressListener).GUID;
				Guid nsIWebProgressListener2GUID = typeof (nsIWebProgressListener2).GUID;
				WebBrowser.AddWebBrowserListener( this.GetWeakReference(), ref nsIWebProgressListenerGUID );
				WebBrowser.AddWebBrowserListener( this.GetWeakReference(), ref nsIWebProgressListener2GUID );

				if ( UseHttpActivityObserver )
				{
					ObserverService.AddObserver( this, ObserverNotifications.HttpRequests.HttpOnModifyRequest, false );
					Net.HttpActivityDistributor.AddObserver(this);
				}

				// var domEventListener = new GeckoDOMEventListener(this);

				{
					var domWindow = WebBrowser.GetContentDOMWindowAttribute();
					_target = domWindow.GetWindowRootAttribute();
					Marshal.ReleaseComObject(domWindow);
				}


				_target.AddEventListener( new nsAString( "submit" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "keydown" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "keyup" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "keypress" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "mousemove" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "mouseover" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "mouseout" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "mousedown" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "mouseup" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "click" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "dblclick" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "compositionstart" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "compositionend" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "contextmenu" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "DOMMouseScroll" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "focus" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "blur" ), this, true, true, 2 );
				// Load event added here rather than DOMDocument as DOMDocument recreated when navigating
				// ths losing attached listener.
				_target.AddEventListener( new nsAString( "load" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "DOMContentLoaded" ), this, true, true, 2 );
				_target.AddEventListener(new nsAString("readystatechange"), this, true, true, 2);
				_target.AddEventListener( new nsAString( "change" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "hashchange" ), this, false, true, 2 );
				_target.AddEventListener( new nsAString( "dragstart" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "dragleave" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "drag" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "drop" ), this, true, true, 2 );
				_target.AddEventListener( new nsAString( "dragend" ), this, true, true, 2 );

				// history
				{
					var sessionHistory = WebNav.GetSessionHistoryAttribute();
					if ( sessionHistory != null ) sessionHistory.AddSHistoryListener( this );
				}

				BaseWindow.SetVisibilityAttribute( true );

				// this fix prevents the browser from crashing if the first page loaded is invalid (missing file, invalid URL, etc)
				if ( Document != null )
				{
					// only for html documents
					Document.Cookie = "";
				}
			}

			base.OnHandleCreated( e );
		}

		protected override void OnHandleDestroyed( EventArgs e )
		{
			if ( _target != null )
			{
				//Remove Event Listener			
				_target.RemoveEventListener( new nsAString( "submit" ), this, true );
				_target.RemoveEventListener( new nsAString( "keydown" ), this, true );
				_target.RemoveEventListener( new nsAString( "keyup" ), this, true );
				_target.RemoveEventListener( new nsAString( "keypress" ), this, true );
				_target.RemoveEventListener( new nsAString( "mousemove" ), this, true );
				_target.RemoveEventListener( new nsAString( "mouseover" ), this, true );
				_target.RemoveEventListener( new nsAString( "mouseout" ), this, true );
				_target.RemoveEventListener( new nsAString( "mousedown" ), this, true );
				_target.RemoveEventListener( new nsAString( "mouseup" ), this, true );
				_target.RemoveEventListener( new nsAString( "click" ), this, true );
				_target.RemoveEventListener( new nsAString( "dblclick" ), this, true );
				_target.RemoveEventListener( new nsAString( "compositionstart" ), this, true );
				_target.RemoveEventListener( new nsAString( "compositionend" ), this, true );
				_target.RemoveEventListener( new nsAString( "contextmenu" ), this, true );
				_target.RemoveEventListener( new nsAString( "DOMMouseScroll" ), this, true );
				_target.RemoveEventListener( new nsAString( "focus" ), this, true );
				_target.RemoveEventListener( new nsAString( "blur" ), this, true );
				_target.RemoveEventListener( new nsAString( "load" ), this, true );
				_target.RemoveEventListener( new nsAString( "DOMContentLoaded" ), this, true );
				_target.RemoveEventListener(new nsAString("readystatechange"), this, true);
				_target.RemoveEventListener( new nsAString( "change" ), this, true );
				_target.RemoveEventListener( new nsAString( "hashchange" ), this, false );
				_target.RemoveEventListener( new nsAString( "dragstart" ), this, true );
				_target.RemoveEventListener( new nsAString( "dragenter" ), this, true );
				_target.RemoveEventListener( new nsAString( "dragover" ), this, true );
				_target.RemoveEventListener( new nsAString( "dragleave" ), this, true );
				_target.RemoveEventListener( new nsAString( "drag" ), this, true );
				_target.RemoveEventListener( new nsAString( "drop" ), this, true );
				_target.RemoveEventListener( new nsAString( "dragend" ), this, true );
				Xpcom.FreeComObject( ref _target );
			}
			base.OnHandleDestroyed( e );
		}

		protected override void OnEnter( EventArgs e )
		{
			if ( WebBrowserFocus != null )
				WebBrowserFocus.Activate();
#if GTK
			m_wrapper.SetInputFocus();		
#endif
			base.OnEnter( e );
		}

		protected override void OnLeave( EventArgs e )
		{
			if ( WebBrowserFocus != null && !IsBusy )
				WebBrowserFocus.Deactivate();
#if GTK
			m_wrapper.RemoveInputFocus();		
#endif
			base.OnLeave( e );
		}

		protected override void OnSizeChanged( EventArgs e )
		{
			if ( BaseWindow != null )
			{
				BaseWindow.SetPositionAndSize( 0, 0, ClientSize.Width, ClientSize.Height, true );
			}

			base.OnSizeChanged( e );
		}

		#region protected override void WndProc(ref Message m)

		protected override void WndProc( ref Message m )
		{
			const int WM_GETDLGCODE = 0x87;
			const int DLGC_WANTALLKEYS = 0x4;
			const int WM_MOUSEACTIVATE = 0x21;
			const int MA_ACTIVATE = 0x1;
			const int WM_IME_SETCONTEXT = 0x0281;
			const int WM_PAINT = 0x000F;
			const int WM_SETFOCUS = 0x0007;
			const int WM_KILLFOCUS = 0x0008;


			const int ISC_SHOWUICOMPOSITIONWINDOW = unchecked ((int)0x80000000);
			if ( !DesignMode )
			{
				IntPtr focus;
				switch ( m.Msg )
				{
					case WM_GETDLGCODE:
						m.Result = ( IntPtr ) DLGC_WANTALLKEYS;
						return;
					case WM_SETFOCUS:
						break;
					case WM_MOUSEACTIVATE:
						// TODO FIXME: port for Linux
						if ( Xpcom.IsWindows )
						{
							m.Result = ( IntPtr ) MA_ACTIVATE;
							focus = User32.GetFocus();
							Console.WriteLine( "focus {0:X8}, Handle {1:X8}", focus.ToInt32(), Handle.ToInt32() );
							if ( !IsSubWindow( Handle, focus ) )
							{
							//	var str = string.Format( "+WM_MOUSEACTIVATE {0:X8} lastfocus", focus.ToInt32() );
							//	System.Diagnostics.Debug.WriteLine( str );
								Console.WriteLine("Activating");
								if ( WebBrowserFocus != null )
								{
									WebBrowserFocus.Activate();
									Services.WindowWatcher.ActiveWindow = this.Window;
								}
							}
							else
							{
							//	var str = string.Format( "-WM_MOUSEACTIVATE {0:X8} lastfocus", focus.ToInt32() );
							//	System.Diagnostics.Debug.WriteLine( str );
							}
							if ( !this.Window.Equals(Services.WindowWatcher.ActiveWindow) )
							{
								if ( WebBrowserFocus != null )
								{
									WebBrowserFocus.Activate();
									Services.WindowWatcher.ActiveWindow = this.Window;
								}
							}
							return;
						}
						return;
						
					//http://msdn.microsoft.com/en-US/library/windows/desktop/dd374142%28v=vs.85%29.aspx
					case WM_IME_SETCONTEXT:
						focus = User32.GetFocus();
						if ( User32.IsChild( Handle, focus ) )
						{
							break;
						}

						if ( WebBrowserFocus != null )
						{
						//	var str = string.Format( "WM_IME_SETCONTEXT {0} {1} {2} (focus on {3})", m.HWnd.ToString( "X8" ), m.WParam, m.LParam.ToString( "X8" ), focus.ToString( "X8" ) );
						//	System.Diagnostics.Debug.WriteLine( str );


							var param = m.LParam.ToInt32();
							if ( ( param & ISC_SHOWUICOMPOSITIONWINDOW ) != 0 )
							{

							}
							if ( m.WParam == IntPtr.Zero )
							{
								// zero
								RemoveInputFocus();
								WebBrowserFocus.Deactivate();
							}
							else
							{
								// non-zero (1)
								WebBrowserFocus.Activate();
								SetInputFocus();
							}
							return;
						}

						break;
					case WM_PAINT:
						break;
				}
			}
			
			// Firefox 17+ can crash when handing this windows message so we just ignore it.
			if (m.Msg == 0x128 /*WM_UPDATEUISTATE*/)
				return;

			base.WndProc( ref m );
		}

		private bool IsSubWindow( IntPtr window, IntPtr candidate )
		{
			// search parent until desktop (flash window is owned by other process)
			while ( candidate!=IntPtr.Zero )
			{
				candidate = User32.GetParent( candidate );
				if ( window == candidate )
				{
					return true;
				}
			}
			return false;
		}

		#endregion

		protected override void OnPaint( PaintEventArgs e )
		{
			if ( this.DesignMode )
			{
				string versionString =
					( ( AssemblyFileVersionAttribute )
					  Attribute.GetCustomAttribute( GetType().Assembly, typeof (AssemblyFileVersionAttribute) ) ).Version;

				using (
					Brush brush = new System.Drawing.Drawing2D.HatchBrush( System.Drawing.Drawing2D.HatchStyle.SolidDiamond,
					                                                       Color.FromArgb( 240, 240, 240 ), Color.White ) )
					e.Graphics.FillRectangle( brush, this.ClientRectangle );

				e.Graphics.DrawString(
					string.Format( "GeckoFX v{0}\r\n" + "http://bitbucket.org/geckofx/", versionString ),
					SystemFonts.MessageBoxFont,
					Brushes.Black,
					new RectangleF( 2, 2, this.Width - 4, this.Height - 4 ) );
				e.Graphics.DrawRectangle( SystemPens.ControlDark, 0, 0, Width - 1, Height - 1 );
			}
			base.OnPaint( e );
		}

		#endregion

		#region Internal classes

		#region class ToolTipWindow

		/// <summary>
		/// A window to contain a tool tip.
		/// </summary>
		private class ToolTipWindow : ToolTip
		{
		}

		#endregion

		#endregion


		public void ForceRedraw()
		{
			BaseWindow.Repaint( true );
		}


		#region UserInterfaceThreadInvoke
		/// <summary>
		/// UI platform independent call function from UI thread
		/// </summary>
		/// <param name="action"></param>
		public void UserInterfaceThreadInvoke( Action action )
		{
			if ( InvokeRequired )
			{
				Invoke( new Action( () => SafeAction( action ) ) );
			}
			else
			{
				SafeAction( action );
			}
		}

		/// <summary>
		/// Exception handler for action
		/// </summary>
		/// <param name="action"></param>
		private void SafeAction( Action action )
		{
			try
			{
				action();
			}
			catch ( Exception e )
			{
				System.Diagnostics.Debug.WriteLine( string.Format( "Invoking exception" ) );
			}
		}

		/// <summary>
		/// UI platform independent call function from UI thread
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <returns></returns>
		public T UserInterfaceThreadInvoke<T>( Func<T> func )
		{
			if ( InvokeRequired )
			{
				return ( T ) Invoke( new Func<T>( () => SafeFunc( func ) ) );
			}
			return SafeFunc( func );
		}

		/// <summary>
		/// exception handler for function
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <returns></returns>
		private T SafeFunc<T>( Func<T> func )
		{
			T ret = default( T );
			try
			{
				ret = func();
			}
			catch ( Exception e )
			{
				System.Diagnostics.Debug.WriteLine( string.Format( "Invoking exception" ) );
			}
			return ret;
		}
		#endregion
	}
}
