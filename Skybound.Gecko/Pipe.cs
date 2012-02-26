namespace Gecko
{
	/// <summary>
	/// Pipe transfers data from nsIAsyncOutputStream to nsIAsyncInputStream
	/// Can be used for transfer data between threads
	/// WARNING it seems that this class can be created only one time :(
	/// </summary>
	public sealed class Pipe
	{
		internal nsIPipe _pipe;
		internal Pipe()
		{
			var pipe = Xpcom.CreateInstance<nsIPipe>(Contracts.Pipe);
			_pipe = Xpcom.QueryInterface<nsIPipe>(pipe);
			_pipe.Init(true, true,0, 0, null);
		}

		public Gecko.IO.InputStream InputStream
		{
			get { return IO.InputStream.Create(_pipe.GetInputStreamAttribute()); }
		}


		public Gecko.IO.OutputStream OutputStream
		{
			get { return IO.OutputStream.Create(_pipe.GetOutputStreamAttribute()); }
		}

	}
}