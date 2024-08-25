using System;

namespace System.Runtime
{
	// Token: 0x02000336 RID: 822
	internal static class RuntimeImports
	{
		// Token: 0x06001BAA RID: 7082 RVA: 0x0003BAC4 File Offset: 0x00039CC4
		internal static void RhZeroMemory(byte b, ulong byteLength)
		{
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0003BAD4 File Offset: 0x00039CD4
		private unsafe static void ZeroMemory(void* p, uint byteLength)
		{
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		internal unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0003BAF4 File Offset: 0x00039CF4
		internal unsafe static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle)
		{
		}
	}
}
