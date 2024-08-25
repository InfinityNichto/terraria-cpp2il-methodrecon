using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000573 RID: 1395
	public class SignInfo_OldMobile
	{
		// Token: 0x060033E1 RID: 13281 RVA: 0x00200EAC File Offset: 0x001FF0AC
		public bool Load(BinaryReader reader, int release)
		{
			string text = reader.ReadNetString();
			Tile tile;
			bool flag = tile.active();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00200ED4 File Offset: 0x001FF0D4
		private string UserString(BinaryReader reader, int release)
		{
			return reader.ReadOldNetString();
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00200EF0 File Offset: 0x001FF0F0
		public SignInfo_OldMobile()
		{
		}
	}
}
