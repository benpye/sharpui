using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiProgressBarSetValue(uiProgressBar *p, int n);
        [DllImport(DLLNAME)]
        public static extern void uiProgressBarSetValue(IntPtr p, int n);

        // _UI_EXTERN uiProgressBar *uiNewProgressBar(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewProgressBar();
    }
}
