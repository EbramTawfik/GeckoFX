using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	public static class RandomGenerator
	{
		private static ServiceWrapper<nsIRandomGenerator> _randomGenerator;

		static RandomGenerator()
		{
			_randomGenerator = new ServiceWrapper<nsIRandomGenerator>( Contracts.RandomGenerator );
		}

		/// <summary>
		/// Generate random bytes
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public static byte[] GenerateRandomBytes(int count)
		{
			IntPtr pointer;
			var ret = new byte[count];
			_randomGenerator.Instance.GenerateRandomBytes((uint)count, out pointer);
			Marshal.Copy( pointer, ret, 0, count );
			Xpcom.Free( pointer );
			return ret;
		}
	}
}