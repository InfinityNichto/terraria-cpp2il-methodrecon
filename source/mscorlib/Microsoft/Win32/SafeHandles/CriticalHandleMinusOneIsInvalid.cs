using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005F RID: 95
	public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00008248 File Offset: 0x00006448
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected CriticalHandleMinusOneIsInvalid()
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00008258 File Offset: 0x00006458
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
