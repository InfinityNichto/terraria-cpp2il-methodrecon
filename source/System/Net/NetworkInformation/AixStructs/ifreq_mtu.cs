using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002D6 RID: 726
	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct ifreq_mtu
	{
		// Token: 0x04000F3F RID: 3903
		[FixedBuffer(typeof(byte), 16)]
		public ifreq_mtu.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000F40 RID: 3904
		public int ifru_mtu;

		// Token: 0x020002D7 RID: 727
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x04000F41 RID: 3905
			public byte FixedElementField;
		}
	}
}
