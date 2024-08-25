using System;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009AA RID: 2474
	public class CustomFlagCondition : AchievementCondition
	{
		// Token: 0x06004937 RID: 18743 RVA: 0x00261D40 File Offset: 0x0025FF40
		private CustomFlagCondition(string name)
			: base(name)
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
