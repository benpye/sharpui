using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiMenuItemEnable(uiMenuItem *m);
        [DllImport(DLLNAME)]
        public static extern void uiMenuItemEnable(IntPtr m);

        // _UI_EXTERN void uiMenuItemDisable(uiMenuItem *m);
        [DllImport(DLLNAME)]
        public static extern void uiMenuItemDisable(IntPtr m);

        public delegate void uiMenuItemOnClickedDelegate(IntPtr sender, IntPtr window, IntPtr data);

        // _UI_EXTERN void uiMenuItemOnClicked(uiMenuItem *m, void (*f)(uiMenuItem *sender, uiWindow *window, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiMenuItemOnClicked(IntPtr m, uiMenuItemOnClickedDelegate f, IntPtr data);

        // _UI_EXTERN int uiMenuItemChecked(uiMenuItem *m);
        [DllImport(DLLNAME)]
        public static extern int uiMenuItemChecked(IntPtr m);

        // _UI_EXTERN void uiMenuItemSetChecked(uiMenuItem *m, int checked);
        [DllImport(DLLNAME)]
        public static extern void uiMenuItemSetChecked(IntPtr m, int @checked);
    }
}
