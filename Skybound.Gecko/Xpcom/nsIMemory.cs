using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.XpCom
{
	/// <summary>
	/// XpCom access to memory services.
	/// same services can be accessed via PInvoke months Xpcom static class.
	/// Implementing service "@mozilla.org/xpcom/memory-service;1"
	/// </summary>
	[Guid("59e7e77a-38e4-11d4-8cf5-0060b0fc14a3"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIMemory
	{
		/** Allocates a block of memory of a particular size. If the memory 
		* cannot be allocated (because of an out-of-memory condition), null
		* is returned.
		*
		* @param size - the size of the block to allocate
		* @result the block of memory
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr Alloc(UInt32 size);
  
		/**
		* Reallocates a block of memory to a new size.
		*
		* @param ptr - the block of memory to reallocate
		* @param size - the new size
		* @result the reallocated block of memory
		*
		* If ptr is null, this function behaves like malloc.
		* If s is the size of the block to which ptr points, the first
		* min(s, size) bytes of ptr's block are copied to the new block.
		* If the allocation succeeds, ptr is freed and a pointer to the 
		* new block returned.  If the allocation fails, ptr is not freed
		* and null is returned. The returned value may be the same as ptr.
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr Realloc(IntPtr ptr, UInt32 newSize);
  
		/**
		* Frees a block of memory. Null is a permissible value, in which case
		* nothing happens. 
		*
		* @param ptr - the block of memory to free
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Free(IntPtr ptr);
  
		/**
		* Attempts to shrink the heap.
		* @param immediate - if true, heap minimization will occur
		*   immediately if the call was made on the main thread. If
		*   false, the flush will be scheduled to happen when the app is
		*   idle.
		* @return NS_ERROR_FAILURE if 'immediate' is set an the call
		*   was not on the application's main thread.
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void HeapMinimize(bool immediate);
  
		/**
		* This predicate can be used to determine if we're in a low-memory
		* situation (what constitutes low-memory is platform dependent). This
		* can be used to trigger the memory pressure observers.
		*
		* DEPRECATED - Always returns false.  See bug 592308.
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool isLowMemory();
	}
}

