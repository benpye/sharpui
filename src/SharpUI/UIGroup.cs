using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIGroup : UIControl
    {
        private UIControl child;

        public UIGroup(string title)
            : base(CreateGroup(title), true)
        { }

        private static IntPtr CreateGroup(string title)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(title);
            IntPtr handle = uiNewGroup(ptr);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public string Title
        {
            get
            {
                IntPtr ptr = uiGroupTitle(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiGroupSetTitle(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public void SetChild(UIControl child)
        {
            uiGroupSetChild(handle, child.handle);
            this.child = child;
        }

        public bool Margined
        {
            get { return uiGroupMargined(handle) == 0 ? false : true; }
            set { uiGroupSetMargined(handle, value ? 1 : 0); }
        }
    }
}
