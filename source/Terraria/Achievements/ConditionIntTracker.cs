using System;

namespace Terraria.Achievements
{
	// Token: 0x02000699 RID: 1689
	public class ConditionIntTracker : AchievementTracker<int>
	{
		// Token: 0x06003869 RID: 14441 RVA: 0x00225BD8 File Offset: 0x00223DD8
		public ConditionIntTracker()
			: base(TrackerType.Int)
		{
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00225BEC File Offset: 0x00223DEC
		public ConditionIntTracker(int maxValue)
			: base(TrackerType.Int)
		{
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00225C00 File Offset: 0x00223E00
		public override void ReportUpdate()
		{
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x00225C10 File Offset: 0x00223E10
		protected override void Load()
		{
		}
	}
}
