using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Social.Base
{
	// Token: 0x02000528 RID: 1320
	public abstract class AWorkshopTagsCollection
	{
		// Token: 0x060031BE RID: 12734 RVA: 0x000021DB File Offset: 0x000003DB
		protected void AddWorldTag(string tagNameKey, string tagInternalName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000021DB File Offset: 0x000003DB
		protected void AddResourcePackTag(string tagNameKey, string tagInternalName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x001F8D44 File Offset: 0x001F6F44
		protected AWorkshopTagsCollection()
		{
		}

		// Token: 0x04003B5C RID: 15196
		public readonly List<WorkshopTagOption> WorldTags;

		// Token: 0x04003B5D RID: 15197
		public readonly List<WorkshopTagOption> ResourcePackTags;
	}
}
