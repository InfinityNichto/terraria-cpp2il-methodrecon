using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009AD RID: 2477
	public class ItemCraftCondition : AchievementCondition
	{
		// Token: 0x06004949 RID: 18761 RVA: 0x00261F18 File Offset: 0x00260118
		private ItemCraftCondition(LocalUser user, short itemId)
		{
			string text2;
			string text = "ITEM_PICKUP_" + text2;
			base..ctor(text);
			this._user = user;
			if ("ITEM_PICKUP_" == null)
			{
			}
			ItemCraftCondition.ListenForCraft(this);
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00261F4C File Offset: 0x0026014C
		private ItemCraftCondition(LocalUser user, short[] itemIds)
		{
			string text2;
			string text = "ITEM_PICKUP_" + text2;
			base..ctor(text);
			this._itemIds = itemIds;
			this._user = user;
			if ("ITEM_PICKUP_" == null)
			{
			}
			ItemCraftCondition.ListenForCraft(this);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00261F88 File Offset: 0x00260188
		public override void Shutdown()
		{
			short[] itemIds = this._itemIds;
			short[] itemIds2 = this._itemIds;
			short[] itemIds3 = this._itemIds;
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00261FAC File Offset: 0x002601AC
		private static void ListenForCraft(ItemCraftCondition condition)
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

		// Token: 0x0600494D RID: 18765 RVA: 0x00261FFC File Offset: 0x002601FC
		private static void ItemCraftListener(Player player, short itemId, int count)
		{
			if (!true)
			{
			}
			int whoAmI = player.whoAmI;
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, params short[] items)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x000021DB File Offset: 0x000003DB
		public static AchievementCondition Create(LocalUser user, short item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x0026202C File Offset: 0x0026022C
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
		{
			FilterManager filterManager = user.FilterManager;
			FilterManager filterManager2 = user.FilterManager;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00262050 File Offset: 0x00260250
		// Note: this type is marked as 'beforefieldinit'.
		static ItemCraftCondition()
		{
		}

		// Token: 0x0400843C RID: 33852
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x0400843D RID: 33853
		private static Dictionary<short, List<ItemCraftCondition>> _listeners;

		// Token: 0x0400843E RID: 33854
		private static bool _isListenerHooked;

		// Token: 0x0400843F RID: 33855
		private short[] _itemIds;

		// Token: 0x04008440 RID: 33856
		private readonly LocalUser _user;
	}
}
