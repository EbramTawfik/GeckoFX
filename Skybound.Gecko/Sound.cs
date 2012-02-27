namespace Gecko
{
	public sealed class Sound
	{
		private nsISound _sound;

		public Sound()
		{
			var sound = Xpcom.CreateInstance<nsISound>( Contracts.Sound );
			_sound=Xpcom.QueryInterface<nsISound>(sound);
			_sound.Init();
		}

		public void Beep()
		{
			_sound.Beep();
		}
		
		public void Play(string url)
		{
			var nsUrl = IOService.CreateNsIUrl( url );
			_sound.Play( nsUrl );
		}


		public void PlayEventSound(EventSound sound)
		{
			_sound.PlayEventSound( (uint)sound );
		}

		public enum EventSound
			:uint
		{
			/// <summary>
			/// The system receives email.
			/// </summary>
			NewMailReceived=0,
			/// <summary>
			/// An alert dialog is opened.
			/// </summary>
			AlertDialogOpen=1,
			/// <summary>
			/// A confirm dialog is opened.
			/// </summary>
			ConfirmDialogOpen=2,
			/// <summary>
			/// A prompt dialog (one that allows the user to enter data, such as an authentication dialog) is opened.
			/// </summary>
			PromptDialogOpen=3,
			/// <summary>
			/// A select dialog (one that contains a list box) is opened.
			/// </summary>
			SelectDialogOpen=4,
			/// <summary>
			/// A menu item is executed.
			/// </summary>
			MenuExecute=5,
			/// <summary>
			/// A popup menu is shown.
			/// </summary>
			MenuPopup=6,
			/// <summary>
			/// More characters than the maximum allowed are typed into a text field.
			/// </summary>
			EditorMaxLen=7
		}
	}
}
