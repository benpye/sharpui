using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiTabAppend(uiTab *t, const char *name, uiControl *c);
        [DllImport(DLLNAME)]
        public static extern void uiTabAppend(IntPtr t, IntPtr name, IntPtr c);

        // _UI_EXTERN void uiTabInsertAt(uiTab *t, const char *name, uintmax_t before, uiControl *c);
        [DllImport(DLLNAME)]
        public static extern void uiTabInsertAt(IntPtr t, IntPtr name, UInt64 before, IntPtr c);

        // _UI_EXTERN void uiTabDelete(uiTab *t, uintmax_t index);
        [DllImport(DLLNAME)]
        public static extern void uiTabDelete(IntPtr t, UInt64 index);

        // _UI_EXTERN uintmax_t uiTabNumPages(uiTab *t);
        [DllImport(DLLNAME)]
        public static extern UInt64 uiTabNumPages(IntPtr t);

        // _UI_EXTERN int uiTabMargined(uiTab *t, uintmax_t page);
        [DllImport(DLLNAME)]
        public static extern int uiTabMargined(IntPtr t, UInt64 page);

        // _UI_EXTERN void uiTabSetMargined(uiTab *t, uintmax_t page, int margined);
        [DllImport(DLLNAME)]
        public static extern void uiTabSetMargined(IntPtr t, UInt64 page, int margined);

        // _UI_EXTERN uiTab *uiNewTab(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewTab();
    }
}
