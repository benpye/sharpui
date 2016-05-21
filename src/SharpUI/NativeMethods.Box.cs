using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiBoxAppend(uiBox *b, uiControl *child, int stretchy);
        [DllImport(DLLNAME)]
        public static extern void uiBoxAppend(IntPtr b, IntPtr child, int stretchy);

        // _UI_EXTERN void uiBoxDelete(uiBox *b, uintmax_t index);
        [DllImport(DLLNAME)]
        public static extern void uiBoxDelete(IntPtr b, UInt64 index);

        // _UI_EXTERN int uiBoxPadded(uiBox *b);
        [DllImport(DLLNAME)]
        public static extern int uiBoxPadded(IntPtr b);

        // _UI_EXTERN void uiBoxSetPadded(uiBox *b, int padded);
        [DllImport(DLLNAME)]
        public static extern void uiBoxSetPadded(IntPtr b, int padded);

        // _UI_EXTERN uiBox *uiNewHorizontalBox(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewHorizontalBox();

        // _UI_EXTERN uiBox *uiNewVerticalBox(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewVerticalBox();
    }
}
