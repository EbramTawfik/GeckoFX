using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Gecko
{
	public static class GlobalJSContextHolder
	{
		//static IntPtr _jsContext;

		private static bool _isInitialized = false;
		private static readonly SpiderMonkey.JSContextCallback _globalContextCallback = GlobalContextCallback;
		private static SpiderMonkey.JSContextCallback _originalContextCallback;
		private static readonly Dictionary<IntPtr, IntPtr> _windowContexts = new Dictionary<IntPtr, IntPtr>();
		private static readonly List<IntPtr> _unknownContexts = new List<IntPtr>();
		private static IntPtr _backstageContext;



		//public static IntPtr JSContext 
		//{
		//    get
		//    {
		//        if (_jsContext == IntPtr.Zero && Initalize != null)
		//            _jsContext = Initalize();

		//        return _jsContext;
		//    }			
		//}

		//public static Func<IntPtr> Initalize;

		public static IntPtr BackstageJSContext
		{
			get
			{
				if (_backstageContext == IntPtr.Zero)
				{
					Xpcom.AssertCorrectThread();

					foreach (IntPtr cx in _unknownContexts)
					{
						IntPtr global = SpiderMonkey.JS_GetGlobalObject(cx);
						if (global != IntPtr.Zero)
						{
							global = SpiderMonkey.JS_GetClass(global);
							// get class name
							if (Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(global)) == "BackstagePass")
							{
								_backstageContext = cx;
								_unknownContexts.Remove(cx);
								break;
							}
						}
					}
					if (_backstageContext == IntPtr.Zero)
						throw new InvalidOperationException();
				}
				return _backstageContext;
			}
		}

		/// <summary>
		/// Add hooks to listen for new JSContext creation and store the context for later use.
		/// </summary>
		public static void Initialize()
		{
			Xpcom.AssertCorrectThread();

			if(!_isInitialized)
			{
				_isInitialized = true;

				using (var runtimeService = new Gecko.Interop.ServiceWrapper<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1"))
				{
					_originalContextCallback = SpiderMonkey.JS_SetContextCallback(runtimeService.Instance.GetRuntimeAttribute(), _globalContextCallback);
				}
			}
		}

		private static JSBool GlobalContextCallback(IntPtr cx, uint contextOp)
		{
			JSBool result = (_originalContextCallback != null) ? _originalContextCallback(cx, contextOp) : JSBool.JS_TRUE;
			if (result == JSBool.JS_TRUE)
			{
				switch (contextOp)
				{
					case 0: // JSCONTEXT_NEW
						_unknownContexts.Insert(0, cx);
						//_unknownContexts.Add(cx);
						break;
					case 1: // JSCONTEXT_DESTROY
						_unknownContexts.Remove(cx);

						foreach (var kwp in _windowContexts)
						{
							if (kwp.Value == cx)
							{
								_windowContexts.Remove(kwp.Key);
								break;
							}
						}
						break;
				}
			}
			return result;
		}



		public static IntPtr GetJSContextForDomWindow(nsIDOMWindow window)
		{
			Xpcom.AssertCorrectThread();

			IntPtr pUnk = Marshal.GetIUnknownForObject(window);
			Marshal.Release(pUnk);

			IntPtr context;
			if (!_windowContexts.TryGetValue(pUnk, out context))
			{
				context = IntPtr.Zero;

				foreach (IntPtr cx in _unknownContexts)
				{
					IntPtr pGlobal = SpiderMonkey.JS_GetGlobalObject(cx);
					if (pGlobal != IntPtr.Zero)
					{
						using (var auto = new AutoJSContext(cx))
						{
							nsISupports global = auto.GetGlobalNsObject();
							if (global != null)
							{
								var domWindow = Xpcom.QueryInterface<nsIDOMWindow>(global);
								if (domWindow != null)
								{
									try
									{
										IntPtr pUnkTest = Marshal.GetIUnknownForObject(domWindow.GetWindowAttribute());
										Marshal.Release(pUnkTest);
										
										if (pUnk == pUnkTest)
										{
											_windowContexts.Add(pUnk, cx);											
											_unknownContexts.Remove(cx);
											context = cx;
											break;
										}
									}
									finally
									{
										Marshal.ReleaseComObject(domWindow);
									}
								}
							}
						}
					}
				}
			}
			return context;
		}

	}
}
