using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        private const string DLLNAME = "libui.dll";

        [StructLayout(LayoutKind.Sequential)]
        public struct uiInitOptions
        {
            // size_t Size;
            UIntPtr Size;
        }

        // _UI_EXTERN const char *uiInit(uiInitOptions *options);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiInit(ref uiInitOptions options);

        // _UI_EXTERN void uiUninit(void);
        [DllImport(DLLNAME)]
        public static extern void uiUninit();

        // _UI_EXTERN void uiFreeInitError(const char *err);
        [DllImport(DLLNAME)]
        public static extern void uiFreeInitError(IntPtr err);

        // _UI_EXTERN void uiMain(void);
        [DllImport(DLLNAME)]
        public static extern void uiMain();

        // _UI_EXTERN void uiQuit(void);
        [DllImport(DLLNAME)]
        public static extern void uiQuit();

        public delegate void uiQueueMainDelegate(IntPtr data);

        // _UI_EXTERN void uiQueueMain(void (*f)(void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiQueueMain(uiQueueMainDelegate f, IntPtr data);

        public delegate int uiOnShouldQuitDelegate(IntPtr data);

        // _UI_EXTERN void uiOnShouldQuit(int (*f)(void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiOnShouldQuit(uiOnShouldQuitDelegate f, IntPtr data);

        // _UI_EXTERN void uiFreeText(char *text);
        [DllImport(DLLNAME)]
        public static extern void uiFreeText(IntPtr text);
    }
}
