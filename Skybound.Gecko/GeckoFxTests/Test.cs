using System;
using NUnit.Framework;
using System.Windows.Forms;
using System.Drawing;

namespace GeckoFxTests
{
	[TestFixture()]	
	public class Test
	{
		/// <summary>
		/// This test doesn't assert, but demonostrates reparenting concept that GeckoFx uses.
		/// </summary>
		[Test()]		
		public void TestReparenting_ShouldDrawALineInForm()					
		{
			Gtk.Application.Init();
			
			Form testForm = new Form();
			testForm.Show();
			Application.DoEvents();
			
			var containerWindow = new Gtk.Window(Gtk.WindowType.Popup);			
			containerWindow.ShowNow();			
			containerWindow.Move(-5000, -5000);						
			
			while (Gtk.Application.EventsPending()) {				
				Gtk.Application.RunIteration(false);
			}
						
			var gdkWrapperOfForm = Gdk.Window.ForeignNewForDisplay(Gdk.Display.Default, (uint)testForm.Handle);					
			containerWindow.GdkWindow.Reparent(gdkWrapperOfForm, 0, 0);									
			
			Gdk.GC color = containerWindow.Style.DarkGC (Gtk.StateType.Normal);
			containerWindow.GdkWindow.DrawLine(color, 0, 0, 100, 100);
									
			while (Gtk.Application.EventsPending()) {				
				Gtk.Application.RunIteration(false);
			}
									
			Application.DoEvents();
		}
	}
}

