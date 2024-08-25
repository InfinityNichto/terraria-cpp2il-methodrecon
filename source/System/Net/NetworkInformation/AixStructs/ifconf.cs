using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002D1 RID: 721
	[StructLayout(2, Pack = 1, Size = 16)]
	internal struct ifconf
	{
		// Token: 0x04000F37 RID: 3895
		public int ifc_len;

		// Token: 0x04000F38 RID: 3896
		public IntPtr ifc_buf;
	}
}
