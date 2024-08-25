using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009B0 RID: 2480
	public class ProgressionEventCondition : AchievementCondition
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x002622E0 File Offset: 0x002604E0
		private ProgressionEventCondition(int eventID)
		{
			string text2;
			string text = "PROGRESSION_EVENT_" + text2;
			base..ctor(text);
			if ("PROGRESSION_EVENT_" == null)
			{
			}
			ProgressionEventCondition.ListenForPickup(this);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00262310 File Offset: 0x00260510
		private ProgressionEventCondition(int[] eventIDs)
		{
			string text2;
			string text = "PROGRESSION_EVENT_" + text2;
			base..ctor(text);
			this._eventIDs = eventIDs;
			if ("PROGRESSION_EVENT_" == null)
			{
			}
			ProgressionEventCondition.ListenForPickup(this);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00262344 File Offset: 0x00260544
		public override void Shutdown()
		{
			int[] eventIDs = this._eventIDs;
			int[] eventIDs2 = this._eventIDs;
			int[] eventIDs3 = this._eventIDs;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00262368 File Offset: 0x00260568
		private static void ListenForPickup(ProgressionEventCondition condition)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			if (num == 0)
			{
				num2 = 1;
			}
			int[] eventIDs = condition._eventIDs;
			if (num2 == 0)
			{
			}
			if (eventIDs == null)
			{
			}
			int[] eventIDs2 = condition._eventIDs;
			int[] eventIDs3 = condition._eventIDs;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x002623A8 File Offset: 0x002605A8
		private static void ProgressionEventListener(int eventID)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x000021DB File Offset: 0x000003DB
		public static ProgressionEventCondition Create(params int[] eventIDs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x000021DB File Offset: 0x000003DB
		public static ProgressionEventCondition Create(int eventID)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x002623D4 File Offset: 0x002605D4
		public static ProgressionEventCondition[] CreateMany(params int[] eventIDs)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x002623EC File Offset: 0x002605EC
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressionEventCondition()
		{
		}

		// Token: 0x0400844B RID: 33867
		private const string Identifier = "PROGRESSION_EVENT";

		// Token: 0x0400844C RID: 33868
		private static Dictionary<int, List<ProgressionEventCondition>> _listeners;

		// Token: 0x0400844D RID: 33869
		private static bool _isListenerHooked;

		// Token: 0x0400844E RID: 33870
		private int[] _eventIDs;
	}
}
