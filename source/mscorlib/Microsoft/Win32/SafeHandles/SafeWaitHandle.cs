using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005C RID: 92
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600021D RID: 541 RVA: 0x000081B8 File Offset: 0x000063B8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
			: base(existingHandle != null)
		{
			this.handle = existingHandle;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000081D4 File Offset: 0x000063D4
		protected override bool ReleaseHandle()
		{
			NativeEventCalls.CloseEvent_internal(this.handle);
			return true;
		}
	}
}
