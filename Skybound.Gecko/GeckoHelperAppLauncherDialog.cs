using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Gecko
{
    static class nsIHelperAppLauncherConstants
    {
        public const int NS_BINDING_ABORTED = unchecked((int)0x804b0002);
    }

    public class LauncherDialogEvent : EventArgs
    {
        public string Url
        {
            get
            {
                nsIURI uri = HelperAppLauncher.GetSourceAttribute();
                return nsString.Get(uri.GetSpecAttribute);
            }
        }
        public string Filename
        {
            get
            {
                nsAString o = new nsAString();
                HelperAppLauncher.GetSuggestedFileNameAttribute(o);
                return o.ToString();
            }
        }
        public nsIMIMEInfo Mime
        {
            get
            {
                return HelperAppLauncher.GetMIMEInfoAttribute();
            }
        }

        public void Cancel()
        {
            HelperAppLauncher.Cancel(nsIHelperAppLauncherConstants.NS_BINDING_ABORTED);
        }
        public void Navigate(string Url)
        {
            WebNavigation.LoadURI(Url, 0, null, null, null);
        }

        public nsIWebNavigation WebNavigation { get; private set; }
        public nsIHelperAppLauncher HelperAppLauncher { get; private set; }

        public LauncherDialogEvent(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, uint aReason)
        {
            HelperAppLauncher = aLauncher;
            WebNavigation = (nsIWebNavigation)aWindowContext;
        }
    }

    public class LauncherDialog : nsIHelperAppLauncherDialog
    {
        public static event EventHandler<LauncherDialogEvent> Download;

        [DllImport("xpcom", CharSet = CharSet.Ansi)]
        private static extern int NS_NewNativeLocalFile(nsACString path, bool followLinks, [MarshalAs(UnmanagedType.IUnknown)] out object result);
        public nsILocalFile PromptForSaveToFile(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, string aDefaultFileName, string aSuggestedFileExtension, bool aForcePrompt)
        {
            aLauncher.Cancel(nsIHelperAppLauncherConstants.NS_BINDING_ABORTED);
            return null;
        }

        public void Show(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, uint aReason)
        {
            if (Download != null)
            {
                Download(this, new LauncherDialogEvent(aLauncher, aWindowContext, aReason));
            }
            else
            {
                aLauncher.Cancel(nsIHelperAppLauncherConstants.NS_BINDING_ABORTED);
            }
        }
    }

    internal class LauncherDialogFactory : nsIFactory
    {
        private static bool _IsRegistered;

        public static void Register()
        {
            if (!_IsRegistered)
            {
                Xpcom.RegisterFactory(typeof(LauncherDialogFactory).GUID, "Skybound.Gecko.LauncherDialog", "@mozilla.org/helperapplauncherdialog;1", new LauncherDialogFactory());
                _IsRegistered = true;
            }
        }

        IntPtr nsIFactory.CreateInstance(nsISupports aOuter, ref Guid iid)
        {
            IntPtr result = IntPtr.Zero;
            IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(new LauncherDialog());
            Marshal.QueryInterface(iUnknownForObject, ref iid, out result);
            Marshal.Release(iUnknownForObject);
            return result;
        }

        void nsIFactory.LockFactory(bool @lock)
        {
        }
    }
}