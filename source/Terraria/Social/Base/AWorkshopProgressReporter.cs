using System;
using System.Runtime.InteropServices;

namespace Terraria.Social.Base
{
	// Token: 0x02000535 RID: 1333
	public abstract class AWorkshopProgressReporter
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600321D RID: 12829
		public abstract bool HasOngoingTasks { get; }

		// Token: 0x0600321E RID: 12830
		public abstract bool TryGetProgress([Out] float progress);

		// Token: 0x0600321F RID: 12831 RVA: 0x001F9474 File Offset: 0x001F7674
		protected AWorkshopProgressReporter()
		{
		}
	}
}
