using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000180 RID: 384
	[StructLayout(0)]
	internal class MonoAsyncCall
	{
		// Token: 0x06000F0C RID: 3852 RVA: 0x000200C4 File Offset: 0x0001E2C4
		public MonoAsyncCall()
		{
		}

		// Token: 0x0400067D RID: 1661
		private object msg;

		// Token: 0x0400067E RID: 1662
		private IntPtr cb_method;

		// Token: 0x0400067F RID: 1663
		private object cb_target;

		// Token: 0x04000680 RID: 1664
		private object state;

		// Token: 0x04000681 RID: 1665
		private object res;

		// Token: 0x04000682 RID: 1666
		private object out_args;
	}
}
