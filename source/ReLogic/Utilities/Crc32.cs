using System;

namespace ReLogic.Utilities
{
	// Token: 0x02000B02 RID: 2818
	public static class Crc32
	{
		// Token: 0x06005275 RID: 21109 RVA: 0x00282F34 File Offset: 0x00281134
		public static int Calculate(string value)
		{
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00282F48 File Offset: 0x00281148
		public static int Calculate(string value, int baseHash)
		{
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00282F58 File Offset: 0x00281158
		public static int Calculate(byte[] value)
		{
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00282F6C File Offset: 0x0028116C
		public unsafe static int Calculate(byte* value, long length)
		{
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x00282F7C File Offset: 0x0028117C
		public static int Calculate(byte[] value, int baseHash)
		{
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x00282F8C File Offset: 0x0028118C
		// Note: this type is marked as 'beforefieldinit'.
		static Crc32()
		{
		}

		// Token: 0x04008AC2 RID: 35522
		private static readonly uint[] Tabs;
	}
}
