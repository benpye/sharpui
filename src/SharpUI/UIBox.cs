using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIBox : UIControl
    {
        private List<UIControl> children;

        public UIBox(bool vertical = false)
            : base(CreateBox(vertical), true)
        {
            children = new List<UIControl>();
        }

        private static IntPtr CreateBox(bool vertical)
        {
            if (vertical)
                return uiNewVerticalBox();
            else
                return uiNewHorizontalBox();
        }

        public void Append(UIControl child, bool stretchy)
        {
            uiBoxAppend(handle, child.handle, stretchy ? 1 : 0);
            children.Add(child);
        }

        public void Delete(UInt64 index)
        {
            children.RemoveAt((int)index);
            uiBoxDelete(handle, index);
        }

        public bool Padded
        {
            get { return uiBoxPadded(handle) == 0 ? false : true; }
            set { uiBoxSetPadded(handle, value ? 1 : 0); }
        }
    }
}
