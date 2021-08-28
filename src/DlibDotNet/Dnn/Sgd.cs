#if !LITE
using System;

namespace DlibDotNet.Dnn
{

    public sealed class Sgd : DlibObject
    {

        #region Constructors

        public Sgd():
            this(0.0005f, 0.9f)
        {
        }

        public Sgd(float weightDecay, float momentum = 0.9f)
        {
            this.NativePtr = NativeMethods.sgd_new(weightDecay, momentum);
        }

        #endregion

        #region Methods

        #region Overrids

        /// <summary>
        /// Releases all unmanaged resources.
        /// </summary>
        protected override void DisposeUnmanaged()
        {
            base.DisposeUnmanaged();

            if (this.NativePtr == IntPtr.Zero)
                return;

            NativeMethods.sgd_delete(this.NativePtr);
        }

        #endregion

        #endregion

    }

}
#endif
