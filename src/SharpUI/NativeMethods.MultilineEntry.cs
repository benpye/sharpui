using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiMultilineEntryText(uiMultilineEntry *e);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiMultilineEntryText(IntPtr e);

        // _UI_EXTERN void uiMultilineEntrySetText(uiMultilineEntry *e, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiMultilineEntrySetText(IntPtr e, IntPtr text);

        // _UI_EXTERN void uiMultilineEntryAppend(uiMultilineEntry *e, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiMultilineEntryAppend(IntPtr e, IntPtr text);

        public delegate void uiMultilineEntryOnChangedDelegate(IntPtr e, IntPtr data);

        // _UI_EXTERN void uiMultilineEntryOnChanged(uiMultilineEntry *e, void (*f)(uiMultilineEntry *e, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiMultilineEntryOnChanged(IntPtr e, uiMultilineEntryOnChangedDelegate f, IntPtr data);

        // _UI_EXTERN int uiMultilineEntryReadOnly(uiMultilineEntry *e);
        [DllImport(DLLNAME)]
        public static extern int uiMultilineEntryReadOnly(IntPtr e);

        // _UI_EXTERN void uiMultilineEntrySetReadOnly(uiMultilineEntry *e, int readonly);
        [DllImport(DLLNAME)]
        public static extern void uiMultilineEntrySetReadOnly(IntPtr e, int @readonly);

        // _UI_EXTERN uiMultilineEntry *uiNewMultilineEntry(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewMultilineEntry();
    }
}
