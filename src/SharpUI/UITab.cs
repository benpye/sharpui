using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UITab : UIControl
    {
        private List<UIControl> children;

        public UITab()
            : base(CreateTab(), true)
        {
            children = new List<UIControl>();
        }

        private static IntPtr CreateTab()
        {
            return uiNewTab();
        }

        public void Append(string name, UIControl c)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(name);
            uiTabAppend(handle, ptr, c.handle);
            Marshal.FreeHGlobal(ptr);
            children.Add(c);
        }

        public void InsertAt(string name, UInt64 before, UIControl c)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(name);
            uiTabInsertAt(handle, ptr, before, c.handle);
            Marshal.FreeHGlobal(ptr);
            children.Insert((int)before, c);
        }

        public void Delete(UInt64 index)
        {
            uiTabDelete(handle, index);
            children.RemoveAt((int)index);
        }

        public UInt64 NumPages => uiTabNumPages(handle);

        public bool Margined(UInt64 index)
        {
            return uiTabMargined(handle, index) == 0 ? false : true;
        }

        public void SetMargined(UInt64 index, bool margined)
        {
            uiTabSetMargined(handle, index, margined ? 1 : 0);
        }
    }
}
