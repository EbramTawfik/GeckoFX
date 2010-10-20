using Gdk;
using Gtk;
using System;
using System.Windows.Forms;

namespace GtkDotNet
{
	public class GtkWrapper
	{
		protected Gtk.Window m_gtkMainWindow;
		protected Gtk.Widget m_embededWidget;
		protected Gdk.Window m_gdkWrapperOfForm;
		protected System.Threading.Thread m_thread;

		protected Panel m_parent;
		protected bool idleRun = false;
		protected bool exiting = false;
		
		protected GLib.IdleHandler runIdleReparentDelegate;

		protected bool RunIdleReparent
		{
			set 
			{ 
				if (value)
				{
					idleRun = false;
					if (runIdleReparentDelegate == null)
						runIdleReparentDelegate = 		
							delegate {						
								idleRun = true;						
								return false;
							};
					GLib.Idle.Add(runIdleReparentDelegate);					
				}
				else
				{
					GLib.Idle.Remove(runIdleReparentDelegate);
				}
			}
		}
		

		protected GLib.IdleHandler IdleHandleRecreateWidgetDelegate;

		protected bool RunIdleRecreateWidget
		{
			set
			{
				if (value)
				{			
						if (IdleHandleRecreateWidgetDelegate == null)
							IdleHandleRecreateWidgetDelegate = 
								delegate {				
									CreateDummyGtkWindow(this);
									CreateAndEmbededWidget(this);																			
									return false;
								};
					
						GLib.Idle.Add(IdleHandleRecreateWidgetDelegate);					
					}
					else
					{
						GLib.Idle.Remove(IdleHandleRecreateWidgetDelegate);
					}
			}
		}
			

		/// <summary>
		/// Create your gtk widget, add it to the window, set the widget out parameter to your widget.
		/// </summary>
		public delegate void GtkWidgetCreationDelegate(Gtk.Window window, out Gtk.Widget widget);
		
		protected GtkWidgetCreationDelegate m_createWidgetDelegeate;

		/// <summary>
		/// Takes a delgate which creates the gtk widget to embeded onto a given form. This allows
		/// The Gtk Widget to be created after Gtk Thread is running, 
		/// </summary>		
		public GtkWrapper(GtkWidgetCreationDelegate createWidget, System.Windows.Forms.Panel parent)
		{
			m_parent = parent;
			m_createWidgetDelegeate = createWidget;
			
			parent.HandleCreated += HandleParentCreated;
			parent.HandleDestroyed += HandleParentDestroyed;
			parent.Resize += HandleParentResize;
		}
		
		/// <summary>
		/// Allow replacing widget in wrapper
		/// </summary>		
		public void ReplaceWidget(GtkWidgetCreationDelegate createWidget, System.Windows.Forms.Panel parent)
		{
			m_parent = parent;
			m_createWidgetDelegeate = createWidget;
			RunIdleRecreateWidget = true;
		}
		
		/// <summary>
		/// Allow replacing widget in wrapper using the same creation delegate
		/// </summary>	
		public void ReplaceWidget(System.Windows.Forms.Panel parent)
		{				
			m_parent = parent;			
			RunIdleRecreateWidget = true;
		}
				

		/// <summary>
		/// Call this method before Application shutdown to ensure Gtk Thread is closed down.
		/// </summary>
		public void Exit()
		{
			exiting = true;
			m_thread.Abort(); // hard exit the thread
		}

		void HandleParentResize(object sender, EventArgs e)
		{
			m_parent.Invalidate(true);
			
			if (m_embededWidget != null)
			{
				m_gtkMainWindow.Show();
				m_embededWidget.SetSizeRequest(m_parent.Width, m_parent.Height);
				m_embededWidget.QueueDraw();				
			}
		}

		void HandleParentDestroyed(object sender, EventArgs e)
		{
			m_gtkMainWindow.Show();
			m_embededWidget.GdkWindow.Reparent(m_gtkMainWindow.GdkWindow, 0, 0);
						
			WaitUntilReparentFinished ();
			
			////////////
			m_gtkMainWindow.Hide();
			
		}
		
		/// <summary>
		///  Wait until the reparenting has been completed
		///  other wise the webbrowser window can be destroyed
		/// </summary>
		public void WaitUntilReparentFinished ()
		{
			RunIdleReparent = true;
			while (!idleRun)
				System.Threading.Thread.Sleep(0);
			RunIdleReparent = false;
		}

		void HandleParentCreated(object sender, EventArgs e)
		{
			GtkWrapper wrapper = this;
			
			if (wrapper.m_thread == null) {
				wrapper.m_thread = new System.Threading.Thread(GtkThread);
				wrapper.m_thread.Start(wrapper);
			} else {
				// Web Browser already exists so just reparent it
				wrapper.m_embededWidget.SetSizeRequest(m_parent.Width, m_parent.Height);
				wrapper.m_embededWidget.Show();
				
				wrapper.m_gtkMainWindow.Show();
				Reparent(m_parent, wrapper.m_embededWidget);
				
				WaitUntilReparentFinished ();

				
				wrapper.m_gtkMainWindow.Hide();				
			}
		}

		/// <summary>
		/// Wrapps the Form native (X) window in a GdkWrapper then embebeds widget on to the form
		/// </summary>		
		protected void Reparent(Panel f, Gtk.Widget embededWidget)
		{
			m_gdkWrapperOfForm = Gdk.Window.ForeignNewForDisplay(Gdk.Display.Default, (uint)f.Handle);
Console.WriteLine("embededWidget = {0}", embededWidget);
Console.WriteLine("embededWidget.Handle = {0}", embededWidget.Handle);
Console.WriteLine("embededWidget.GdkWindow = {0}", embededWidget.GdkWindow);			
			embededWidget.GdkWindow.Reparent(m_gdkWrapperOfForm, 0, 0);
		}
		
		protected static void CreateDummyGtkWindow(GtkDotNet.GtkWrapper gtkWrapper)
		{
			
			if (gtkWrapper.m_gtkMainWindow != null)
			{
				gtkWrapper.m_gtkMainWindow.Destroy();
				gtkWrapper.m_gtkMainWindow.Dispose();
			}
			
			gtkWrapper.m_gtkMainWindow = new Gtk.Window(Gtk.WindowType.Popup);
//			gtkWrapper.m_gtkMainWindow.Move(-5000, -5000);	
			gtkWrapper.m_gtkMainWindow.Move(1, 1);	
		}
		
		protected static void CreateAndEmbededWidget(GtkDotNet.GtkWrapper gtkWrapper)
		{
			gtkWrapper.m_createWidgetDelegeate(gtkWrapper.m_gtkMainWindow, out gtkWrapper.m_embededWidget);
			gtkWrapper.HandleParentResize(gtkWrapper.m_parent, null);
			gtkWrapper.m_gtkMainWindow.Show();
			
			gtkWrapper.Reparent(gtkWrapper.m_parent, gtkWrapper.m_embededWidget);			
		}
		
		/// <summary>
		/// Main Gtk Thread
		/// </summary>
		protected static void GtkThread(object gtkWrapperParam)
		{							
			GtkWrapper gtkWrapper = gtkWrapperParam as GtkWrapper;						
			
			gtkWrapper.m_parent.Invoke((MethodInvoker)(() => 
		    {
					Gtk.Application.Init();
				
					CreateDummyGtkWindow(gtkWrapper);
					CreateAndEmbededWidget(gtkWrapper);
			}));
												
			gtkWrapper.exiting = false;
					
			while (!gtkWrapper.exiting) {
				gtkWrapper.m_parent.Invoke((MethodInvoker)(() => 
				{
					while (Gtk.Application.EventsPending()) {					
						Gtk.Application.RunIteration(false);
					}
										
					//Gtk.Application.RunIteration(true); // block until event is received.
				}));
				
				if (gtkWrapper.exiting)
						break;
			}
		}
	}
}

