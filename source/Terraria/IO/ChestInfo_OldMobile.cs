using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000568 RID: 1384
	public class ChestInfo_OldMobile
	{
		// Token: 0x060033C4 RID: 13252 RVA: 0x0020067C File Offset: 0x001FE87C
		public bool Load(BinaryReader reader, int release)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x0020069C File Offset: 0x001FE89C
		private void FixDresserChests()
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			long num3 = 0L;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int num4 = Chest.CreateChest((int)num2, (int)num3, (int)num3);
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x002006CC File Offset: 0x001FE8CC
		public ChestInfo_OldMobile()
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x002006E0 File Offset: 0x001FE8E0
		// Note: this type is marked as 'beforefieldinit'.
		static ChestInfo_OldMobile()
		{
		}

		// Token: 0x04003C67 RID: 15463
		private static byte[] bits;
	}
}
