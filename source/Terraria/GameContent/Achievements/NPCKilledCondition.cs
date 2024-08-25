using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009AF RID: 2479
	public class NPCKilledCondition : AchievementCondition
	{
		// Token: 0x0600495B RID: 18779 RVA: 0x002621A0 File Offset: 0x002603A0
		private NPCKilledCondition(LocalUser user, short npcId)
		{
			string text2;
			string text = "NPC_KILLED_" + text2;
			base..ctor(text);
			this._user = user;
			if ("NPC_KILLED_" == null)
			{
			}
			NPCKilledCondition.ListenForPickup(this);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x002621D4 File Offset: 0x002603D4
		private NPCKilledCondition(LocalUser user, short[] npcIds)
		{
			string text2;
			string text = "NPC_KILLED_" + text2;
			base..ctor(text);
			this._user = user;
			this._npcIds = npcIds;
			if ("NPC_KILLED_" == null)
			{
			}
			NPCKilledCondition.ListenForPickup(this);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00262210 File Offset: 0x00260410
		public override void Shutdown()
		{
			short[] npcIds = this._npcIds;
			short[] npcIds2 = this._npcIds;
			short[] npcIds3 = this._npcIds;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00262234 File Offset: 0x00260434
		private static void ListenForPickup(NPCKilledCondition condition)
		{
			int num2;
			do
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					num2 = 1;
				}
				short[] npcIds = condition._npcIds;
			}
			while (num2 != 0);
			if (condition._npcIds == null)
			{
			}
			short[] npcIds2 = condition._npcIds;
			short[] npcIds3 = condition._npcIds;
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x0026227C File Offset: 0x0026047C
		private static void NPCKilledListener(Player player, short npcId)
		{
			if (!true)
			{
			}
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, params short[] npcIds)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, short npcId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x002622AC File Offset: 0x002604AC
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] npcs)
		{
			FilterManager filterManager = user.FilterManager;
			FilterManager filterManager2 = user.FilterManager;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x002622D0 File Offset: 0x002604D0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCKilledCondition()
		{
		}

		// Token: 0x04008446 RID: 33862
		private const string Identifier = "NPC_KILLED";

		// Token: 0x04008447 RID: 33863
		private static Dictionary<short, List<NPCKilledCondition>> _listeners;

		// Token: 0x04008448 RID: 33864
		private static bool _isListenerHooked;

		// Token: 0x04008449 RID: 33865
		private readonly LocalUser _user;

		// Token: 0x0400844A RID: 33866
		private short[] _npcIds;
	}
}
