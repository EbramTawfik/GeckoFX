using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public sealed class JSAutoCompartment : IDisposable
	{
		private IntPtr _oldCompartment;
		private IntPtr _cx;
		private bool _isDisposed;


		public JSAutoCompartment(IntPtr context, IntPtr obj)
		{
			if (context == IntPtr.Zero)
				throw new ArgumentNullException("context");
			if (context == IntPtr.Zero)
				throw new ArgumentNullException("obj");

			_oldCompartment = SpiderMonkey.JS_EnterCompartment(context, obj);
			_cx = context;
		}

		public void Dispose()
		{
			if (!_isDisposed)
			{
				_isDisposed = true;
				if (_cx != IntPtr.Zero)
				{
					SpiderMonkey.JS_LeaveCompartment(_cx, _oldCompartment);
				}
				GC.SuppressFinalize(this);
			}
		}
	}
}
