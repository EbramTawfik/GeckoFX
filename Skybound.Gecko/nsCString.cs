namespace Gecko
{
	/// <summary>
	/// nsISupportsCString container (may be it can be merged with another strings?)
	/// </summary>
	public sealed class nsCString
	{
		private nsISupportsCString _nsISupportsCString;

		public nsCString(nsISupportsCString nsISupportsCString)
		{
			_nsISupportsCString = nsISupportsCString;
		}


		public ushort Type
		{
			get { return _nsISupportsCString.GetTypeAttribute(); }
		}

		public string Data
		{
			get { return nsString.Get(_nsISupportsCString.GetDataAttribute); }
			set { nsString.Set(_nsISupportsCString.SetDataAttribute, value); }
		}

		public override string ToString()
		{
			return Data;
		}
	}
}