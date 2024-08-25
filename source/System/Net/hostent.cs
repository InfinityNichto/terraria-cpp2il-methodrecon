using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001BE RID: 446
	[StructLayout(0, CharSet = CharSet.Unicode)]
	internal struct hostent
	{
		// Token: 0x04000974 RID: 2420
		public IntPtr h_name;

		// Token: 0x04000975 RID: 2421
		public IntPtr h_aliases;

		// Token: 0x04000976 RID: 2422
		public short h_addrtype;

		// Token: 0x04000977 RID: 2423
		public short h_length;

		// Token: 0x04000978 RID: 2424
		public IntPtr h_addr_list;
	}
}
