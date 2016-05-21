using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiGroupTitle(uiGroup *g);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiGroupTitle(IntPtr g);

        // _UI_EXTERN void uiGroupSetTitle(uiGroup *g, const char *title);
        [DllImport(DLLNAME)]
        public static extern void uiGroupSetTitle(IntPtr g, IntPtr title);

        // _UI_EXTERN void uiGroupSetChild(uiGroup *g, uiControl *c);
        [DllImport(DLLNAME)]
        public static extern void uiGroupSetChild(IntPtr g, IntPtr c);

        // _UI_EXTERN int uiGroupMargined(uiGroup *g);
        [DllImport(DLLNAME)]
        public static extern int uiGroupMargined(IntPtr g);

        // _UI_EXTERN void uiGroupSetMargined(uiGroup *g, int margined);
        [DllImport(DLLNAME)]
        public static extern void uiGroupSetMargined(IntPtr g, int margined);

        // _UI_EXTERN uiGroup *uiNewGroup(const char *title);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewGroup(IntPtr title);
    }
}
