using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIControl : IDisposable
    {
        internal IntPtr handle;
        private bool original;

        internal UIControl(IntPtr handle, bool original = false)
        {
            this.handle = handle;
            this.original = original;
        }

        public IntPtr OSHandle => uiControlHandle(handle);

        public UIControl Parent
        {
            get { return new UIControl(uiControlParent(handle)); }
            set { uiControlSetParent(handle, value.handle); }
        }

        public bool TopLevel => uiControlTopLevel(handle) == 0 ? false : true;

        public bool Visible => uiControlVisible(handle) == 0 ? false : true;

        public bool Shown
        {
            get { throw new NotImplementedException("libui lacks implementation for uiControlShown"); }
            set { if (value) uiControlShow(handle); else uiControlHide(handle); }
        }

        public bool Enabled
        {
            get { return uiControlEnabled(handle) == 0 ? false : true; }
            set { if (value) uiControlEnable(handle); else uiControlDisable(handle); }
        }

        public bool EnabledToUser => uiControlEnabledToUser(handle) == 0 ? false : true;

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // Only delete the native object if this is the original object
                if (original)
                {
                    uiControlDestroy(handle);
                    handle = IntPtr.Zero;
                }

                disposedValue = true;
            }
        }
        
        ~UIControl() {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
