using System;

namespace GeckoFxTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// TODO: make better way of finding libxul.so etc.
			Skybound.Gecko.Xpcom.Initialize("/usr/lib/xulrunner/");
		}
	}
}

