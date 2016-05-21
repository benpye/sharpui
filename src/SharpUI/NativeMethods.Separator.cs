using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN uiSeparator *uiNewHorizontalSeparator(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewHorizontalSeparator();
    }
}
