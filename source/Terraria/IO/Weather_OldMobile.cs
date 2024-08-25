using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000576 RID: 1398
	public class Weather_OldMobile
	{
		// Token: 0x060033F1 RID: 13297 RVA: 0x002011F8 File Offset: 0x001FF3F8
		public bool Load(BinaryReader reader, int release)
		{
			return true;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00201208 File Offset: 0x001FF408
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			return true;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00201218 File Offset: 0x001FF418
		public Weather_OldMobile()
		{
		}

		// Token: 0x04003E39 RID: 15929
		private float cloudBGActive;
	}
}
