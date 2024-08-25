using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mono
{
	// Token: 0x0200001F RID: 31
	internal struct MonoAssemblyName
	{
		// Token: 0x0400009D RID: 157
		internal IntPtr name;

		// Token: 0x0400009E RID: 158
		internal IntPtr culture;

		// Token: 0x0400009F RID: 159
		internal IntPtr hash_value;

		// Token: 0x040000A0 RID: 160
		internal IntPtr public_key;

		// Token: 0x040000A1 RID: 161
		[FixedBuffer(typeof(byte), 17)]
		internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token;

		// Token: 0x040000A2 RID: 162
		internal uint hash_alg;

		// Token: 0x040000A3 RID: 163
		internal uint hash_len;

		// Token: 0x040000A4 RID: 164
		internal uint flags;

		// Token: 0x040000A5 RID: 165
		internal ushort major;

		// Token: 0x040000A6 RID: 166
		internal ushort minor;

		// Token: 0x040000A7 RID: 167
		internal ushort build;

		// Token: 0x040000A8 RID: 168
		internal ushort revision;

		// Token: 0x040000A9 RID: 169
		internal ushort arch;

		// Token: 0x02000020 RID: 32
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(0, Size = 17)]
		public struct <public_key_token>e__FixedBuffer
		{
			// Token: 0x040000AA RID: 170
			public byte FixedElementField;
		}
	}
}
