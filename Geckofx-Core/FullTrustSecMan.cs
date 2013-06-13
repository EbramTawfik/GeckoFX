using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	class FullTrustSecMan : nsIXPCSecurityManager, nsIScriptSecurityManager, IDisposable
	{
		private nsIXPConnect _xpConnect;
		private IntPtr _context;
		private nsIXPCSecurityManager _originalSecurityManager;
		private nsIScriptSecurityManager _ssm;
		private ushort _originalFlags;


		public FullTrustSecMan(nsIXPConnect xpConnect, IntPtr context)
		{
			_xpConnect = xpConnect;


			_originalSecurityManager = null;
			_originalFlags = 0;

			if (context != IntPtr.Zero)
			{
				_context = context;
				xpConnect.GetSecurityManagerForJSContext(context, ref _originalSecurityManager, ref _originalFlags);
				_ssm = (nsIScriptSecurityManager)_originalSecurityManager;
				xpConnect.SetSecurityManagerForJSContext(context, this, 0xFFFF);
			}
			else
			{
				xpConnect.GetDefaultSecurityManager(ref _originalSecurityManager, ref _originalFlags);
				_ssm = (nsIScriptSecurityManager)_originalSecurityManager;
				xpConnect.SetDefaultSecurityManager(this, 0xFFFF);
			}
		}

		public void CanCreateWrapper(IntPtr aJSContext, ref Guid aIID, nsISupports aObj, nsIClassInfo aClassInfo, ref IntPtr aPolicy)
		{

		}

		public void CanCreateInstance(IntPtr aJSContext, ref Guid aCID)
		{

		}

		public void CanGetService(IntPtr aJSContext, ref Guid aCID)
		{

		}

		public void CanAccess(uint aAction, IntPtr aCallContext, IntPtr aJSContext, IntPtr aJSObject, nsISupports aObj, nsIClassInfo aClassInfo, IntPtr aName, ref IntPtr aPolicy)
		{

		}

		public void CheckPropertyAccess(IntPtr aJSContext, IntPtr aJSObject, string aClassName, IntPtr aProperty, uint aAction)
		{

		}

		public void CheckLoadURIFromScript(IntPtr cx, nsIURI uri)
		{

		}

		public void CheckLoadURIWithPrincipal(nsIPrincipal aPrincipal, nsIURI uri, uint flags)
		{

		}

		public void CheckLoadURIStrWithPrincipal(nsIPrincipal aPrincipal, nsAUTF8StringBase uri, uint flags)
		{

		}

		public void CheckFunctionAccess(IntPtr cx, IntPtr funObj, IntPtr targetObj)
		{

		}

		public bool CanExecuteScripts(IntPtr cx, nsIPrincipal principal)
		{
			return true;
		}

		public nsIPrincipal GetSubjectPrincipal()
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetSystemPrincipal()
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetSimpleCodebasePrincipal(nsIURI aURI)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetAppCodebasePrincipal(nsIURI uri, uint appId, bool inMozBrowser)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetDocShellCodebasePrincipal(nsIURI uri, nsIDocShell docShell)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetNoAppCodebasePrincipal(nsIURI uri)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetCodebasePrincipal(nsIURI uri)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetObjectPrincipal(IntPtr cx, IntPtr obj)
		{
			return _ssm.GetSystemPrincipal();
		}

		public bool SubjectPrincipalIsSystem()
		{
			return true;
		}

		public void CheckSameOrigin(IntPtr aJSContext, nsIURI aTargetURI)
		{
		}

		public void CheckSameOriginURI(nsIURI aSourceURI, nsIURI aTargetURI, bool reportError)
		{
		}

		public nsIPrincipal GetPrincipalFromContext(IntPtr cx)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetChannelPrincipal(nsIChannel aChannel)
		{
			return _ssm.GetSystemPrincipal();
		}

		public bool IsSystemPrincipal(nsIPrincipal aPrincipal)
		{
			return true;
		}

		public nsIPrincipal GetCxSubjectPrincipal(IntPtr cx)
		{
			return _ssm.GetSystemPrincipal();
		}

		public nsIPrincipal GetCxSubjectPrincipalAndFrame(IntPtr cx, ref IntPtr fp)
		{
			fp = IntPtr.Zero;
			return _ssm.GetSystemPrincipal();
		}

		public void GetExtendedOrigin(nsIURI uri, uint appId, bool inMozBrowser, nsAUTF8StringBase retval)
		{
			retval.SetData(string.Empty);
		}

		public void Dispose()
		{
			if (_context != IntPtr.Zero)
			{
				_xpConnect.SetSecurityManagerForJSContext(_context, _originalSecurityManager, _originalFlags);
			}
			else
			{
				_xpConnect.SetDefaultSecurityManager(_originalSecurityManager, _originalFlags);
			}
		}
	}
}
