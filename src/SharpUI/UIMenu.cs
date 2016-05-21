using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIMenu
    {
        List<UIMenuItem> items;
        IntPtr handle;

        public UIMenu(string text)
        {
            handle = CreateMenu(text);
            items = new List<UIMenuItem>();
        }

        private static IntPtr CreateMenu(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            IntPtr handle = uiNewMenu(ptr);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public UIMenuItem AppendItem(string name)
        {
            IntPtr namePtr = MarshalHelper.StringToUTF8(name);
            IntPtr ptr = uiMenuAppendItem(handle, namePtr);
            Marshal.FreeHGlobal(namePtr);
            UIMenuItem item = new UIMenuItem(ptr);
            items.Add(item);
            return item;
        }

        public UIMenuItem AppendCheckItem(string name)
        {
            IntPtr namePtr = MarshalHelper.StringToUTF8(name);
            IntPtr ptr = uiMenuAppendCheckItem(handle, namePtr);
            Marshal.FreeHGlobal(namePtr);
            UIMenuItem item = new UIMenuItem(ptr);
            items.Add(item);
            return item;
        }

        public UIMenuItem AppendQuitItem()
        {
            IntPtr ptr = uiMenuAppendQuitItem(handle);
            UIMenuItem item = new UIMenuItem(ptr, false);
            items.Add(item);
            return item;
        }

        public UIMenuItem AppendPreferencesItem()
        {
            IntPtr ptr = uiMenuAppendPreferencesItem(handle);
            UIMenuItem item = new UIMenuItem(ptr);
            items.Add(item);
            return item;
        }

        public UIMenuItem AppendAboutItem()
        {
            IntPtr ptr = uiMenuAppendAboutItem(handle);
            UIMenuItem item = new UIMenuItem(ptr);
            items.Add(item);
            return item;
        }

        public void AppendSeparator() => uiMenuAppendSeparator(handle);
    }
}
