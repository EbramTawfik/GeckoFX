using System;

namespace Gecko
{
    [Flags]
    public enum CertOverride
    {
        Mismatch = nsICertOverrideServiceConsts.ERROR_MISMATCH,
        Time = nsICertOverrideServiceConsts.ERROR_TIME,
        Untrusted = nsICertOverrideServiceConsts.ERROR_UNTRUSTED,
    }
}