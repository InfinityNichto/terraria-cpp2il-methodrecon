using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Achievements
{
	// Token: 0x0200069A RID: 1690
	public class ConditionsCompletedTracker : ConditionIntTracker
	{
		// Token: 0x0600386D RID: 14445 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddCondition(AchievementCondition condition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00225C20 File Offset: 0x00223E20
		private void OnConditionCompleted(AchievementCondition condition)
		{
			if (!true)
			{
			}
			int num = Math.Min(0, 0);
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00225C38 File Offset: 0x00223E38
		protected override void Load()
		{
			int size = this._conditions._size;
			if (size != 0)
			{
			}
			int size2 = this._conditions._size;
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00225C64 File Offset: 0x00223E64
		public ConditionsCompletedTracker()
		{
		}

		// Token: 0x04007933 RID: 31027
		private List<AchievementCondition> _conditions;
	}
}
