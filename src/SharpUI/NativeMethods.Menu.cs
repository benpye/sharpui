using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN uiMenuItem *uiMenuAppendItem(uiMenu *m, const char *name);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMenuAppendItem(IntPtr m, IntPtr name);

        // _UI_EXTERN uiMenuItem *uiMenuAppendCheckItem(uiMenu *m, const char *name);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMenuAppendCheckItem(IntPtr m, IntPtr name);

        // _UI_EXTERN uiMenuItem *uiMenuAppendQuitItem(uiMenu *m);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMenuAppendQuitItem(IntPtr m);

        // _UI_EXTERN uiMenuItem *uiMenuAppendPreferencesItem(uiMenu *m);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMenuAppendPreferencesItem(IntPtr m);

        // _UI_EXTERN uiMenuItem *uiMenuAppendAboutItem(uiMenu *m);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMenuAppendAboutItem(IntPtr m);

        // _UI_EXTERN void uiMenuAppendSeparator(uiMenu *m);
        [DllImport(DLLNAME)]
        public static extern void uiMenuAppendSeparator(IntPtr m);

        // _UI_EXTERN uiMenu *uiNewMenu(const char *name);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewMenu(IntPtr name);
    }
}
