using System;
using System.Runtime.InteropServices;

namespace Gecko
{
    public static class MemoryService
    {
        public static void MinimizeHeap(bool immeadiate)
        {
            var memoryService = Xpcom.GetService<nsIMemory>("@mozilla.org/xpcom/memory-service;1");
            try
            {
                memoryService.HeapMinimize(immeadiate);
            }
            catch (Exception)
            {
                //Ignore
            }
            finally
            {
                Marshal.ReleaseComObject(memoryService);
            }
        }
    }
}
