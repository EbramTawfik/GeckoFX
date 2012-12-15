namespace Gecko.DOM
{
	public sealed class Location
	{
		private nsIDOMLocation _location;

		internal Location( nsIDOMLocation location )
		{
			_location = location;
		}


		public string Hash
		{
			get { return nsString.Get( _location.GetHashAttribute ); }
			set { nsString.Set( _location.SetHashAttribute, value ); }
		}

		public string Host
		{
			get { return nsString.Get(_location.GetHostAttribute); }
			set { nsString.Set(_location.SetHostAttribute, value); }
		}

		public string Hostname
		{
			get { return nsString.Get(_location.GetHostnameAttribute); }
			set { nsString.Set(_location.GetHostnameAttribute, value); }
		}

		public string Href
		{
			get { return nsString.Get(_location.GetHrefAttribute); }
			set { nsString.Set(_location.SetHrefAttribute, value); }
		}

		public string Pathname
		{
			get { return nsString.Get(_location.GetPathnameAttribute); }
			set { nsString.Set(_location.SetPathnameAttribute, value); }
		}

		public string Port
		{
			get { return nsString.Get(_location.GetPortAttribute); }
			set { nsString.Set(_location.SetPortAttribute, value); }
		}

		public string Protocol
		{
			get { return nsString.Get(_location.GetProtocolAttribute); }
			set { nsString.Set(_location.SetProtocolAttribute, value); }
		}

		public string Search
		{
			get { return nsString.Get(_location.GetSearchAttribute); }
			set { nsString.Set(_location.SetSearchAttribute, value); }
		}

		public void Reload(bool forceget)
		{
			_location.Reload( forceget );
		}

		
		public void Replace(string url)
		{
			nsString.Set(_location.Replace, url);
		}

		public void Assign(string url)
		{
			nsString.Set(_location.Assign, url);
		}

		public override string ToString()
		{
			return nsString.Get( _location.ToString );
		}
	}
}
