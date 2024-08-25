using System;

namespace Terraria.Achievements
{
	// Token: 0x0200069C RID: 1692
	public interface IAchievementTracker
	{
		// Token: 0x06003871 RID: 14449
		void ReportAs(string name);

		// Token: 0x06003872 RID: 14450
		TrackerType GetTrackerType();

		// Token: 0x06003873 RID: 14451
		void Load();

		// Token: 0x06003874 RID: 14452
		void Clear();
	}
}
