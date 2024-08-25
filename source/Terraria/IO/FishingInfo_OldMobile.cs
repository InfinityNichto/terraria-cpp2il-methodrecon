using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO
{
	// Token: 0x02000569 RID: 1385
	public class FishingInfo_OldMobile
	{
		// Token: 0x060033C8 RID: 13256 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Load(BinaryReader reader, int release)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x002006F0 File Offset: 0x001FE8F0
		public FishingInfo_OldMobile()
		{
		}

		// Token: 0x04003C68 RID: 15464
		private short currentQuest;

		// Token: 0x04003C69 RID: 15465
		private bool questCompletedToday;

		// Token: 0x04003C6A RID: 15466
		private List<string> playersCompleted;
	}
}
