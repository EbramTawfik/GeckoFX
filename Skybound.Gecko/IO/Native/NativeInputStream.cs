using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// This file will contain BaseNativeInputStream implementations, that DIFF'ers by memory allocation routines

namespace Gecko.IO.Native
{
	/// <summary>
	/// Replacement for ByteArrayInputStream
	/// Native memory will be faster then managed byte[] (ByteArrayInputStream)
	/// We must check what is faster NativeInputStream or NativeInputStream2
	/// </summary>
	public sealed class NativeInputStream
		: BaseNativeInputStream, IDisposable
	{
		
		#region ctor & dtor
		private NativeInputStream(byte[] array)
		{
			Init( AllocateBufferCopy( array ), array.Length );
		}

		private static IntPtr AllocateBufferCopy(byte[] array)
		{
			if (array.Length ==0) return IntPtr.Zero;
			var ret = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, ret, array.Length);
			return ret;
		}

		~NativeInputStream()
		{
			Close();
		}

		public void Dispose()
		{
			Close();
			GC.SuppressFinalize( this );
		}
		#endregion

		public override void Close()
		{
			if (Buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(Buffer);
				Init( IntPtr.Zero, 0 );
			}
		}

		public static NativeInputStream Create(byte[] buffer)
		{
			return buffer == null ? null : new NativeInputStream( buffer );
		}
	}

	public sealed class NativeInputStream2
		: BaseNativeInputStream, IDisposable
	{
		private GCHandle _handle;

		#region ctor & dtor
		private NativeInputStream2(byte[] array)
		{
			_handle = GCHandle.Alloc(array, GCHandleType.Pinned);
		}


		~NativeInputStream2()
		{
			Close();
		}

		public void Dispose()
		{
			Close();
			GC.SuppressFinalize( this );
		}
		#endregion

		public override void Close()
		{
			if (_handle.IsAllocated)
			{
				_handle.Free();
			}
		}

		

		public static NativeInputStream2 Create(byte[] buffer)
		{
			return buffer == null ? null : new NativeInputStream2( buffer );
		}
	}
}
