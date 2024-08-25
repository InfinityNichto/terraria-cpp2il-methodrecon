using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002D2 RID: 722
	[StructLayout(2, Pack = 1, Size = 18)]
	internal struct ifreq
	{
		// Token: 0x04000F39 RID: 3897
		[FixedBuffer(typeof(byte), 16)]
		public ifreq.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000F3A RID: 3898
		public sockaddr ifru_addr;

		// Token: 0x020002D3 RID: 723
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x04000F3B RID: 3899
			public byte FixedElementField;
		}
	}
}
