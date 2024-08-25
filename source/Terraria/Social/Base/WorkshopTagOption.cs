using System;

namespace Terraria.Social.Base
{
	// Token: 0x02000539 RID: 1337
	public class WorkshopTagOption
	{
		// Token: 0x06003225 RID: 12837 RVA: 0x001F94F4 File Offset: 0x001F76F4
		public WorkshopTagOption(string nameKey, string internalName)
		{
			this.NameKey = nameKey;
			this.InternalNameForAPIs = internalName;
		}

		// Token: 0x04003B7D RID: 15229
		public readonly string NameKey;

		// Token: 0x04003B7E RID: 15230
		public readonly string InternalNameForAPIs;
	}
}
