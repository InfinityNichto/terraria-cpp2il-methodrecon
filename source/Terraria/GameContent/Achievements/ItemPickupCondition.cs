using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009AE RID: 2478
	public class ItemPickupCondition : AchievementCondition
	{
		// Token: 0x06004952 RID: 18770 RVA: 0x00262060 File Offset: 0x00260260
		private ItemPickupCondition(LocalUser user, short itemId)
		{
			string text2;
			string text = "ITEM_PICKUP_" + text2;
			base..ctor(text);
			this._user = user;
			ItemPickupCondition.ListenForPickup(this);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00262090 File Offset: 0x00260290
		private ItemPickupCondition(LocalUser user, short[] itemIds)
		{
			string text2;
			string text = "ITEM_PICKUP_" + text2;
			base..ctor(text);
			this._user = user;
			this._itemIds = itemIds;
			if ("ITEM_PICKUP_" == null)
			{
			}
			ItemPickupCondition.ListenForPickup(this);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x002620CC File Offset: 0x002602CC
		public override void Shutdown()
		{
			short[] itemIds = this._itemIds;
			short[] itemIds2 = this._itemIds;
			short[] itemIds3 = this._itemIds;
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x002620F0 File Offset: 0x002602F0
		private static void ListenForPickup(ItemPickupCondition condition)
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
			short[] itemIds = condition._itemIds;
			short[] itemIds2;
			if (num2 == 0)
			{
				itemIds2 = condition._itemIds;
			}
			if (itemIds2 == null)
			{
			}
			short[] itemIds3 = condition._itemIds;
			if (itemIds2 == null)
			{
			}
			short[] itemIds4 = condition._itemIds;
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00262140 File Offset: 0x00260340
		private static void ItemPickupListener(Player player, short itemId, int count)
		{
			if (!true)
			{
			}
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, params short[] items)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, short item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00262170 File Offset: 0x00260370
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
		{
			FilterManager filterManager = user.FilterManager;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00262190 File Offset: 0x00260390
		// Note: this type is marked as 'beforefieldinit'.
		static ItemPickupCondition()
		{
		}

		// Token: 0x04008441 RID: 33857
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x04008442 RID: 33858
		private readonly LocalUser _user;

		// Token: 0x04008443 RID: 33859
		private static Dictionary<short, List<ItemPickupCondition>> _listeners;

		// Token: 0x04008444 RID: 33860
		private static bool _isListenerHooked;

		// Token: 0x04008445 RID: 33861
		private short[] _itemIds;
	}
}
