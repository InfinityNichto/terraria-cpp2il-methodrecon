using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B3 RID: 691
	[StructLayout(2)]
	internal struct ifa_ifu
	{
		// Token: 0x04000ED4 RID: 3796
		public IntPtr ifu_broadaddr;

		// Token: 0x04000ED5 RID: 3797
		public IntPtr ifu_dstaddr;
	}
}
