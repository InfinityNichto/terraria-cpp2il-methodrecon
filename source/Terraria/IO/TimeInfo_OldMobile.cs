using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000575 RID: 1397
	public class TimeInfo_OldMobile
	{
		// Token: 0x060033EE RID: 13294 RVA: 0x002011AC File Offset: 0x001FF3AC
		public bool Load(BinaryReader reader, int release)
		{
			this.totalDays = reader;
			this.moonType = reader;
			return true;
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x002011C8 File Offset: 0x001FF3C8
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			this.totalDays = reader;
			this.moonType = reader;
			return true;
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x002011E4 File Offset: 0x001FF3E4
		public TimeInfo_OldMobile()
		{
		}

		// Token: 0x04003E36 RID: 15926
		private short totalDays;

		// Token: 0x04003E37 RID: 15927
		private byte moonType;

		// Token: 0x04003E38 RID: 15928
		public short daysSinceHardmode;
	}
}
