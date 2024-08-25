using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005D RID: 93
	public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x0600021F RID: 543 RVA: 0x000081F0 File Offset: 0x000063F0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00008200 File Offset: 0x00006400
		public override bool IsInvalid
		{
			get
			{
				long num = 0L;
				return 1 == num;
			}
		}
	}
}
