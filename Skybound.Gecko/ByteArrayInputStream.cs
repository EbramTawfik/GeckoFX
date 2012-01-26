using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	/// <summary>
	/// Streams a byte array using nsIInputStream.
	/// </summary>
	#region class ByteArrayInputStream : nsIInputStream
	public class ByteArrayInputStream : nsIInputStream
	{
		private ByteArrayInputStream(byte[] data)
		{
			Data = data;
		}

		public static ByteArrayInputStream Create(byte[] data)
		{
			return (data == null) ? null : new ByteArrayInputStream(data);
		}

		byte[] Data;
		int Position;

		#region nsIInputStream Members

		public void Close()
		{
			// do nothing
		}

		public uint Available()
		{
			return (uint)(Data.Length - Position);
		}

		public uint Read(IntPtr aBuf, uint aCount)
		{
			uint count = Math.Min(aCount, Available());

			if (count > 0)
			{
				Marshal.Copy(Data, Position, aBuf, (int)count);

				for (int i = 0; i < count; ++i)
				{
					Console.WriteLine((char)Marshal.ReadByte(aBuf, i));
				}

				Position += (int)count;
			}

			return count;
		}

		public unsafe uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount)
		{
			int length = (int)Math.Min(aCount, Available());
			int writeCount = 0;

			if (length > 0)
			{
				nsWriteSegmentFun fun = aWriter;

				fixed (byte* data = &Data[Position])
				{
					fun(this, aClosure, (IntPtr)data, Position, length, out writeCount);
				}

				Position += writeCount;
			}

			return (uint)writeCount;
		}

		public bool IsNonBlocking()
		{
			return true;
		}

		#endregion
	}
	#endregion
	}