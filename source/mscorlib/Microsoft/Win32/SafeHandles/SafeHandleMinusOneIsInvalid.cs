using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005E RID: 94
	public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00008218 File Offset: 0x00006418
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandleMinusOneIsInvalid(bool ownsHandle)
		{
			long num = 0L;
			base..ctor(ownsHandle, num != 0L);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00008230 File Offset: 0x00006430
		public override bool IsInvalid
		{
			get
			{
				IntPtr handle = this.handle;
				bool flag;
				return flag;
			}
		}
	}
}
