using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        public delegate void uiControlDestroyDelegate(IntPtr c);
        public delegate IntPtr uiControlHandleDelegate(IntPtr c);
        public delegate IntPtr uiControlParentDelegate(IntPtr c);
        public delegate void uiControlSetParentDelegate(IntPtr c1, IntPtr c2);
        public delegate int uiControlTopLevelDelegate(IntPtr c);
        public delegate int uiControlVisibleDelegate(IntPtr c);
        public delegate void uiControlShowDelegate(IntPtr c);
        public delegate void uiControlHideDelegate(IntPtr c);
        public delegate int uiControlEnabledDelegate(IntPtr c);
        public delegate void uiControlEnableDelegate(IntPtr c);
        public delegate void uiControlDisableDelegate(IntPtr c);

        [StructLayout(LayoutKind.Sequential)]
        public struct uiControl
        {
            // uint32_t Signature;
            public UInt32 Signature;
            // uint32_t OSSignature;
            public UInt32 OSSignature;
            // uint32_t TypeSignature;
            public UInt32 TypeSignature;
            // void (*Destroy)(uiControl *);
            public uiControlDestroyDelegate Destroy;
            // uintptr_t (*Handle)(uiControl *);
            public uiControlHandleDelegate Handle;
            // uiControl *(*Parent)(uiControl *);
            public uiControlParentDelegate Parent;
            // void (*SetParent)(uiControl *, uiControl *);
            public uiControlSetParentDelegate SetParent;
            // int (*Toplevel)(uiControl *);
            public uiControlTopLevelDelegate TopLevel;
            // int (*Visible)(uiControl *);
            public uiControlVisibleDelegate Visible;
            // void (*Show)(uiControl *);
            public uiControlShowDelegate Show;
            // void (*Hide)(uiControl *);
            public uiControlHideDelegate Hide;
            // int (*Enabled)(uiControl *);
            public uiControlEnabledDelegate Enabled;
            // void (*Enable)(uiControl *);
            public uiControlEnableDelegate Enable;
            // void (*Disable)(uiControl *);
            public uiControlDisableDelegate Disable;
        }

        // _UI_EXTERN void uiControlDestroy(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlDestroy(IntPtr c);

        // _UI_EXTERN uintptr_t uiControlHandle(uiControl *);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiControlHandle(IntPtr c);

        // _UI_EXTERN uiControl *uiControlParent(uiControl *);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiControlParent(IntPtr c);

        // _UI_EXTERN void uiControlSetParent(uiControl *, uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlSetParent(IntPtr c1, IntPtr c2);

        // _UI_EXTERN int uiControlToplevel(uiControl *);
        [DllImport(DLLNAME)]
        public static extern int uiControlTopLevel(IntPtr c);

        // _UI_EXTERN int uiControlVisible(uiControl *);
        [DllImport(DLLNAME)]
        public static extern int uiControlVisible(IntPtr c);

        // _UI_EXTERN void uiControlShow(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlShow(IntPtr c);

        // _UI_EXTERN void uiControlHide(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlHide(IntPtr c);

        // _UI_EXTERN int uiControlEnabled(uiControl *);
        [DllImport(DLLNAME)]
        public static extern int uiControlEnabled(IntPtr c);

        // _UI_EXTERN void uiControlEnable(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlEnable(IntPtr c);

        // _UI_EXTERN void uiControlDisable(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlDisable(IntPtr c);

        // _UI_EXTERN uiControl *uiAllocControl(size_t n, uint32_t OSsig, uint32_t typesig, const char *typenamestr);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiAllocControl(UIntPtr n, UInt32 OSsig, UInt32 typesig, IntPtr typenamestr);

        // _UI_EXTERN void uiFreeControl(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiFreeControl(IntPtr c);

        // _UI_EXTERN void uiControlVerifyDestroy(uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlVerifyDestroy(IntPtr c);

        // _UI_EXTERN void uiControlVerifySetParent(uiControl *, uiControl *);
        [DllImport(DLLNAME)]
        public static extern void uiControlVerifySetParent(IntPtr c1, IntPtr c2);

        // _UI_EXTERN int uiControlEnabledToUser(uiControl *);
        [DllImport(DLLNAME)]
        public static extern int uiControlEnabledToUser(IntPtr c);
    }
}
