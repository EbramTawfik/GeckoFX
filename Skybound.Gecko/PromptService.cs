#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Skybound.Gecko
{
	#if !NO_CUSTOM_PROMPT_SERVICE
	[Guid("8E4AABE2-B832-4cff-B213-2174DE2B818D")]
	class PromptServiceFactory : nsIFactory
	{
		public static void Register()
		{
			if (!_IsRegistered)
			{
				Xpcom.RegisterFactory(typeof(PromptServiceFactory).GUID, "Skybound.Gecko.PromptServiceFactory", "@mozilla.org/embedcomp/prompt-service;1", new PromptServiceFactory());
				_IsRegistered = true;
			}
		}
		static bool _IsRegistered;
		
		IntPtr nsIFactory.CreateInstance(nsISupports aOuter, ref Guid iid)
		{
			return  Marshal.GetIUnknownForObject(new PromptService());			
		}

		void nsIFactory.LockFactory(bool @lock)
		{
			
		}
	}
	

	class PromptService : nsIPromptService2
	{
		public void Alert(nsIDOMWindow aParent, string aDialogTitle, string aText)
		{
			bool checkState = false;
			AlertCheck(aParent, aDialogTitle, aText, null, ref checkState);
		}

		public void AlertCheck(nsIDOMWindow aParent, string aDialogTitle, string aText, string aCheckMsg, ref bool aCheckState)
		{
			ConfirmDialog dialog = new ConfirmDialog(aText, aDialogTitle, "OK", null, null, aCheckMsg);
			
			dialog.ShowDialog();
			
			aCheckState = dialog.CheckBoxChecked;
		}

		public bool Confirm(nsIDOMWindow aParent, string aDialogTitle, string aText)
		{
			bool checkState = false;
			return ConfirmCheck(aParent, aDialogTitle, aText, null, ref checkState);
		}

		public bool ConfirmCheck(nsIDOMWindow aParent, string aDialogTitle, string aText, string aCheckMsg, ref bool aCheckState)
		{
			ConfirmDialog dialog = new ConfirmDialog(aText, aDialogTitle, "OK", "Cancel", null, aCheckMsg);

			DialogResult result = dialog.ShowDialog();
			
			aCheckState = dialog.CheckBoxChecked;

			return (result == (DialogResult)1);
		}

		public int ConfirmEx(nsIDOMWindow aParent, string aDialogTitle, string aText, uint aButtonFlags, string aButton0Title, string aButton1Title, string aButton2Title, string aCheckMsg, ref bool aCheckState)
		{
			string [] buttons = new String[3];
			string [] titles = { aButton0Title, aButton1Title, aButton2Title };
			
			for (int i = 0; i < 3; i++)
			{
				uint flags = (aButtonFlags >> (i * 8)) & 0xFF;
				switch (flags)
				{
					case nsIPromptServiceConstants.BUTTON_TITLE_CANCEL: buttons[i] = "Cancel"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_DONT_SAVE: buttons[i] = "&Don't Save"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_NO: buttons[i] = "No"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_OK: buttons[i] = "OK"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_REVERT: buttons[i] = "&Revert"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_SAVE: buttons[i] = "&Save"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_YES: buttons[i] = "Yes"; break;
					case nsIPromptServiceConstants.BUTTON_TITLE_IS_STRING:
						buttons[i] = titles[i];
						break;
				}
			}
			
			ConfirmDialog dialog = new ConfirmDialog(aText, aDialogTitle, buttons[0], buttons[1], buttons[2], aCheckMsg);
			
			DialogResult result = dialog.ShowDialog();
			
			aCheckState = dialog.CheckBoxChecked;
			
			if (result == (DialogResult)1)
				return 0;
			else if (result == (DialogResult)2)
				return 1;
			else if (result == (DialogResult)3)
				return 2;
			
			return 0;
		}
		
		public bool Prompt(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aValue, string aCheckMsg, ref bool aCheckState)
		{
		      PromptDialog dialog = new PromptDialog(aDialogTitle, aText, aValue, aCheckMsg);
			
		      DialogResult result = dialog.ShowDialog();
		      if (result == DialogResult.OK)
		      {
		            aValue = dialog.Result;
		      }
			
#if false // Changes made when using autogenerated interfaces.
		      // passing aCheckState as an IntPtr instead of a bool [] fixes the prompts in about:config
		      if (aCheckState != IntPtr.Zero)
		            Marshal.WriteIntPtr(aCheckState, dialog.IsChecked ? new IntPtr(-1) : new IntPtr(0));
#else
			  aCheckState = dialog.IsChecked;
#endif
			
		      return (result == DialogResult.OK);
		}
		
		public bool PromptUsernameAndPassword(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aUsername, ref string aPassword, string aCheckMsg, ref bool aCheckState)
		{
			//test: http://tools.dynamicdrive.com/password/example/
			
#if false // Changes made when using autogenerated interfaces.
			bool checkState = (aCheckState == IntPtr.Zero) ? false : (Marshal.ReadIntPtr(aCheckState) != IntPtr.Zero);
#else
			bool checkState = aCheckState;
#endif
			
			PasswordDialog dialog = new PasswordDialog(aDialogTitle, aText, aUsername, aPassword, aCheckMsg, checkState);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
			      aUsername = dialog.UserName;
			      aPassword = dialog.Password;
				
#if false // Changes made when using autogenerated interfaces.
				// passing aCheckState as an IntPtr instead of a bool [] fixes the some prompts
				if (aCheckState != IntPtr.Zero)
					Marshal.WriteIntPtr(aCheckState, dialog.IsChecked ? new IntPtr(-1) : new IntPtr(0));
#else
				  aCheckState = dialog.IsChecked;
#endif
				
			      return true;
			}
			
			return false;
		}

		public bool PromptPassword(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aPassword, string aCheckMsg, ref System.Boolean aCheckState)
		{
#if false // Changes made when using autogenerated interfaces.
			bool checkState = (aCheckState == IntPtr.Zero) ? false : (Marshal.ReadIntPtr(aCheckState) != IntPtr.Zero);
#else
			bool checkState = aCheckState;
#endif
			
			PasswordDialog dialog = new PasswordDialog(aDialogTitle, aText, "", aPassword, aCheckMsg, checkState);
			dialog.DisableUserName();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				aPassword = dialog.Password;
#if false // Changes made when using autogenerated interfaces.
				if (aCheckState != IntPtr.Zero)
					Marshal.WriteIntPtr(aCheckState, dialog.IsChecked ? new IntPtr(-1) : new IntPtr(0));
#else
				aCheckState = dialog.IsChecked;
#endif
				return true;
			}
			
			return false;
		}
		
		public bool Select(nsIDOMWindow aParent, string aDialogTitle, string aText, uint aCount, string aSelectList, out int aOutSelection)
		{
			//throw new NotImplementedException();
			aOutSelection = 0;
			return false;
		}
		
		public void ShowNonBlockingAlert(nsIDOMWindow aParent, string aDialogTitle, string aText)
		{
		      ConfirmDialog dialog = new ConfirmDialog(aText, aDialogTitle, "OK", null, null, null);
		      dialog.Show();
        }

        #region nsIPromptService2 Members
		public bool PromptAuth(nsIDOMWindow aParent, nsIChannel aChannel, uint level, nsIAuthInformation authInfo, string checkboxLabel, ref System.Boolean aCheckValue)
        {
            string userName = nsString.Get(authInfo.GetUsernameAttribute);
			string password = nsString.Get(authInfo.GetPasswordAttribute);

			string realm = nsString.Get(authInfo.GetRealmAttribute);

            if (PromptUsernameAndPassword(aParent, "Server Authentication", "The server '" + realm + "' requires a user name and password.", ref userName, ref password, checkboxLabel, ref aCheckValue))
            {
				nsString.Set(authInfo.SetUsernameAttribute, userName);
				nsString.Set(authInfo.SetPasswordAttribute, password);
                return true;
            }

            return false;
        }

        public nsICancelable AsyncPromptAuth(nsIDOMWindow aParent, nsIChannel aChannel, nsIAuthPromptCallback aCallback, nsISupports aContext, uint level, nsIAuthInformation authInfo, string checkboxLabel, ref bool checkValue)
        {
            //throw new NotImplementedException();
            return null;
        }

        #endregion
    }
	#endif
}
