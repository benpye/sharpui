using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiLabelText(uiLabel *l);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiLabelText(IntPtr l);

        // _UI_EXTERN void uiLabelSetText(uiLabel *l, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiLabelSetText(IntPtr l, IntPtr text);

        // _UI_EXTERN uiLabel *uiNewLabel(const char *text);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewLabel(IntPtr text);
    }
}
