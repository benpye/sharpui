using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIMenuItem
    {
        IntPtr handle;

        internal UIMenuItem(IntPtr handle, bool onClicked = true)
        {
            this.handle = handle;
            onClickedDelegate = InternalOnClicked;
            if(onClicked)
                uiMenuItemOnClicked(handle, onClickedDelegate, IntPtr.Zero);
        }

        public bool Checked
        {
            get { return uiMenuItemChecked(handle) == 0 ? false : true; }
            set { uiMenuItemSetChecked(handle, value ? 1 : 0); }
        }

        public void Enable()
        {
            uiMenuItemEnable(handle);
        }

        public void Disable()
        {
            uiMenuItemDisable(handle);
        }

        private uiMenuItemOnClickedDelegate onClickedDelegate;

        private void InternalOnClicked(IntPtr sender, IntPtr window, IntPtr data)
        {
            OnClicked?.Invoke();
        }

        public event Action OnClicked;
    }
}
