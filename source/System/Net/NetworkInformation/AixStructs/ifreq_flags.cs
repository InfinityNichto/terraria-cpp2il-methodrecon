using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002D4 RID: 724
	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct ifreq_flags
	{
		// Token: 0x04000F3C RID: 3900
		[FixedBuffer(typeof(byte), 16)]
		public ifreq_flags.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000F3D RID: 3901
		public uint ifru_flags;

		// Token: 0x020002D5 RID: 725
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x04000F3E RID: 3902
			public byte FixedElementField;
		}
	}
}
