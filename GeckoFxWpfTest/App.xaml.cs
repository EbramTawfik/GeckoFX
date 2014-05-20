using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Gecko;

namespace GeckoFxWpfTest
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static App _current;
		[STAThread]
		public static void Main()
		{
			Xpcom.Initialize(XULRunnerLocator.GetXULRunnerLocation());

			_current=new App();
			_current.InitializeComponent();
			_current.Run();
		}
	}
}
