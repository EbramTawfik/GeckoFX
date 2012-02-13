using System.Text;

namespace Gecko.IO
{
	public sealed class ScriptableInputStream
	{
		private nsIScriptableInputStream _scriptableInputStream;

		public ScriptableInputStream()
		{
			var stream = Xpcom.CreateInstance<nsIScriptableInputStream>( Contracts.ScriptableInputStream );
			_scriptableInputStream = Xpcom.QueryInterface<nsIScriptableInputStream>( stream );
		}

		public ScriptableInputStream(InputStream stream)
			:this()
		{
			Init( stream );
		}

		public int Available
		{
			get { return (int) _scriptableInputStream.Available(); }
		}

		public void Close()
		{
			_scriptableInputStream.Close();
		}

		public void Init(InputStream stream)
		{
			_scriptableInputStream.Init( stream._inputStream );
		}

		public string Read(int count)
		{
			return _scriptableInputStream.Read( (uint)count );
		}

		public string ReadBytes(int count)
		{
			return nsString.Get( _scriptableInputStream.ReadBytes, ( uint ) count );
		}
		
		/// <summary>
		/// Method is useful when reading headers
		/// </summary>
		/// <returns></returns>
		public string ReadLine()
		{
			StringBuilder ret = new StringBuilder(64 );
			var count = _scriptableInputStream.Available();
			for (var i=0;i<count;i++)
			{
				var str=_scriptableInputStream.Read( 1 );
				char test = str[ 0 ];
				if (test=='\r')
				{
					// nothing
				}
				else
				{
					if (test=='\n')
					{
						break;
					}
					ret.Append( test );
				}
			}
			return ret.ToString();
		}

	}
}