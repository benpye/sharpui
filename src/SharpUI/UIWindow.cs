using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIWindow : UIControl
    {
        private UIControl child;

        public UIWindow(string title, int width, int height, bool hasMenuBar)
            : base(CreateWindow(title, width, height, hasMenuBar), true)
        {
            onClosingDelegate = InternalOnClosing;
            uiWindowOnClosing(handle, onClosingDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateWindow(string title, int width, int height, bool hasMenuBar)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(title);
            IntPtr handle = uiNewWindow(ptr, width, height, hasMenuBar == true ? 1 : 0);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public string Title
        {
            get
            {
                IntPtr ptr = uiWindowTitle(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiWindowSetTitle(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public void SetChild(UIControl child)
        {
            uiWindowSetChild(handle, child.handle);
            this.child = child;
        }

        public bool Margined
        {
            get { return uiWindowMargined(handle) == 0 ? false : true; }
            set { uiWindowSetMargined(handle, value ? 1 : 0); }
        }

        private uiWindowOnClosingDelegate onClosingDelegate;

        private int InternalOnClosing(IntPtr w, IntPtr data)
        {
            if(OnClosing != null)
            {
                return OnClosing(this);
            }

            return 0;
        }

        public event Func<UIWindow, int> OnClosing;

        public string OpenFile()
        {
            IntPtr ptr = uiOpenFile(handle);
            string str = MarshalHelper.StringFromUTF8(ptr);
            if(ptr != IntPtr.Zero)
                uiFreeText(ptr);
            return str;
        }

        public string SaveFile()
        {
            IntPtr ptr = uiOpenFile(handle);
            string str = MarshalHelper.StringFromUTF8(ptr);
            if (ptr != IntPtr.Zero)
                uiFreeText(ptr);
            return str;
        }

        public void MessageBox(string title, string description, bool error = false)
        {
            IntPtr titlePtr = MarshalHelper.StringToUTF8(title);
            IntPtr descriptionPtr = MarshalHelper.StringToUTF8(description);
            if(error)
                uiMsgBoxError(handle, titlePtr, descriptionPtr);
            else
                uiMsgBox(handle, titlePtr, descriptionPtr);
            Marshal.FreeHGlobal(titlePtr);
            Marshal.FreeHGlobal(descriptionPtr);
        }
    }
}
