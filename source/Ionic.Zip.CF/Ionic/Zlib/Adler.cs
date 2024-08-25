using System;

namespace Ionic.Zlib
{
	// Token: 0x02000055 RID: 85
	public sealed class Adler
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			int num = 1;
			if (adler == 0U)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (buf == null)
			{
				return;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000E600 File Offset: 0x0000C800
		public Adler()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000E614 File Offset: 0x0000C814
		// Note: this type is marked as 'beforefieldinit'.
		static Adler()
		{
		}

		// Token: 0x040002E4 RID: 740
		private static readonly uint BASE;

		// Token: 0x040002E5 RID: 741
		private static readonly int NMAX;
	}
}
