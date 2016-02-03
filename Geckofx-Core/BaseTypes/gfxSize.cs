using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko
{
    // TODO: make this class binary marshalable from struct gfxSize
    [StructLayout(LayoutKind.Sequential)]
    public class gfxSize
    {
        public double Width;
        public double Height;
    }
}