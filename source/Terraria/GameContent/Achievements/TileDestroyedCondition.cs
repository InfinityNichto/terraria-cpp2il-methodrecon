using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009B1 RID: 2481
	public class TileDestroyedCondition : AchievementCondition
	{
		// Token: 0x0600496D RID: 18797 RVA: 0x002623FC File Offset: 0x002605FC
		private TileDestroyedCondition(LocalUser user, ushort[] tileIds)
		{
			string text2;
			string text = "TILE_DESTROYED_" + text2;
			base..ctor(text);
			this._user = user;
			this._tileIds = tileIds;
			if ("TILE_DESTROYED_" == null)
			{
			}
			TileDestroyedCondition.ListenForDestruction(this);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00262438 File Offset: 0x00260638
		public override void Shutdown()
		{
			ushort[] tileIds = this._tileIds;
			ushort[] tileIds2 = this._tileIds;
			ushort[] tileIds3 = this._tileIds;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x0026245C File Offset: 0x0026065C
		private static void ListenForDestruction(TileDestroyedCondition condition)
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
			ushort[] tileIds = condition._tileIds;
			ushort[] tileIds2;
			if (num2 == 0)
			{
				tileIds2 = condition._tileIds;
			}
			if (tileIds2 == null)
			{
			}
			ushort[] tileIds3 = condition._tileIds;
			if (tileIds2 == null)
			{
			}
			ushort[] tileIds4 = condition._tileIds;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x002624AC File Offset: 0x002606AC
		private static void TileDestroyedListener(Player player, ushort tileId)
		{
			if (!true)
			{
			}
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, params ushort[] tileIds)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x002624DC File Offset: 0x002606DC
		// Note: this type is marked as 'beforefieldinit'.
		static TileDestroyedCondition()
		{
		}

		// Token: 0x0400844F RID: 33871
		public const string Identifier = "TILE_DESTROYED";

		// Token: 0x04008450 RID: 33872
		private static Dictionary<ushort, List<TileDestroyedCondition>> _listeners;

		// Token: 0x04008451 RID: 33873
		private static bool _isListenerHooked;

		// Token: 0x04008452 RID: 33874
		private readonly LocalUser _user;

		// Token: 0x04008453 RID: 33875
		private ushort[] _tileIds;
	}
}
