using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x020009A4 RID: 2468
	public class AchievementsHelper
	{
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06004905 RID: 18693 RVA: 0x0026100C File Offset: 0x0025F20C
		// (remove) Token: 0x06004906 RID: 18694 RVA: 0x00261024 File Offset: 0x0025F224
		public static event AchievementsHelper.ItemPickupEvent OnItemPickup
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06004907 RID: 18695 RVA: 0x0026103C File Offset: 0x0025F23C
		// (remove) Token: 0x06004908 RID: 18696 RVA: 0x00261054 File Offset: 0x0025F254
		public static event AchievementsHelper.ItemCraftEvent OnItemCraft
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06004909 RID: 18697 RVA: 0x0026106C File Offset: 0x0025F26C
		// (remove) Token: 0x0600490A RID: 18698 RVA: 0x00261084 File Offset: 0x0025F284
		public static event AchievementsHelper.TileDestroyedEvent OnTileDestroyed
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x0600490B RID: 18699 RVA: 0x0026109C File Offset: 0x0025F29C
		// (remove) Token: 0x0600490C RID: 18700 RVA: 0x002610B4 File Offset: 0x0025F2B4
		public static event AchievementsHelper.NPCKilledEvent OnNPCKilled
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x0600490D RID: 18701 RVA: 0x002610CC File Offset: 0x0025F2CC
		// (remove) Token: 0x0600490E RID: 18702 RVA: 0x002610E4 File Offset: 0x0025F2E4
		public static event AchievementsHelper.ProgressionEventEvent OnProgressionEvent
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x002610FC File Offset: 0x0025F2FC
		public static bool CurrentlyMining
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x0026110C File Offset: 0x0025F30C
		public static void NotifyTileDestroyed(Player player, ushort tile)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00261128 File Offset: 0x0025F328
		public static void NotifyItemPickup(Player player, Item item)
		{
			int netID = item.netID;
			int stack = item.stack;
			int netID2 = item.netID;
			PlatformAwardNotifierUtility.NoteItemPickedUpForPlayer(player, netID2);
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00261154 File Offset: 0x0025F354
		public static void NotifyItemPickup(Player player, Item item, int customStack)
		{
			int netID = item.netID;
			int netID2 = item.netID;
			PlatformAwardNotifierUtility.NoteItemPickedUpForPlayer(player, netID2);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00261178 File Offset: 0x0025F378
		public static void NotifyItemCraft(Recipe recipe)
		{
			int myPlayer = Main.myPlayer;
			Item createItem = recipe.createItem;
			int netID = createItem.netID;
			int stack = createItem.stack;
			Item createItem2 = recipe.createItem;
			bool flag = AchievementsHelper.IsMetalBar(createItem2.type);
			if (createItem2 == null)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (createItem == null)
			{
			}
			LocalUser localUser;
			uint totalBarsCrafted;
			if (localUser != null)
			{
				PersistentUserData persistentUserData = localUser.PersistentUserData;
				totalBarsCrafted = persistentUserData.TotalBarsCrafted;
				persistentUserData.TotalBarsCrafted = totalBarsCrafted;
				IPlatformAwardNotifier platformAwards = localUser.PlatformAwards;
				if (totalBarsCrafted != 0U)
				{
				}
				return;
			}
			if (recipe.requiredTile == null)
			{
			}
			int myPlayer3 = Main.myPlayer;
			if (totalBarsCrafted == 0U)
			{
			}
			LocalUser localUser2;
			uint totalAnvilCrafting;
			if (localUser2 != null)
			{
				PersistentUserData persistentUserData2 = localUser2.PersistentUserData;
				totalAnvilCrafting = persistentUserData2.TotalAnvilCrafting;
				persistentUserData2.TotalAnvilCrafting = totalAnvilCrafting;
				IPlatformAwardNotifier platformAwards2 = localUser2.PlatformAwards;
				if (totalAnvilCrafting != 0U)
				{
				}
				return;
			}
			if (recipe.requiredTile == null)
			{
			}
			int myPlayer4 = Main.myPlayer;
			if (totalAnvilCrafting == 0U)
			{
			}
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00261254 File Offset: 0x0025F454
		public static void Initialize()
		{
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00261264 File Offset: 0x0025F464
		internal static void OnPlayerEnteredWorld(Player player)
		{
			Item[] inventory = player.inventory;
			int type = inventory.type;
			int stack = inventory.stack;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x002615C8 File Offset: 0x0025F7C8
		public static void NotifyNPCKilled(NPC npc)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicClient = Main.LogicClient;
			bool[] playerInteraction = npc.playerInteraction;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int netID = npc.netID;
			}
			bool[] playerInteraction2 = npc.playerInteraction;
			if (playerInteraction2 != null)
			{
				int netID2 = npc.netID;
				if (playerInteraction2 == null)
				{
				}
			}
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00261630 File Offset: 0x0025F830
		public static void NotifyNPCKilledDirect(Player player, int npcNetID)
		{
			PlatformAwardNotifierUtility.NoteTriggerForPlayer(player, eTrigger.KilledGuideWithWeapon);
			eSlimeKillStatistics slimeStatIDFromNetID = PlatformAwardNotifierUtility.GetSlimeStatIDFromNetID(npcNetID);
			PlatformAwardNotifierUtility.NoteSlimeDefeatedForPlayer(player, slimeStatIDFromNetID);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x00261654 File Offset: 0x0025F854
		public static void NotifyProgressionEvent(int eventID)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x0026167C File Offset: 0x0025F87C
		public static void HandleOnEquip(Player player, Item item, int context)
		{
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00261754 File Offset: 0x0025F954
		public static void HandleSpecialEvent(Player player, int eventID)
		{
			int num = 1;
			int whoAmI = player.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x00261894 File Offset: 0x0025FA94
		public static void HandleNurseService(int coinsSpent)
		{
			if (!true)
			{
			}
			if (Main.Achievements.GetCondition("FREQUENT_FLYER", "Pay") != null)
			{
			}
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x002618C4 File Offset: 0x0025FAC4
		public static void HandleAnglerService()
		{
			if (!true)
			{
			}
			AchievementCondition condition = Main.Achievements.GetCondition("SERVANT_IN_TRAINING", "Finish");
			if (Main.Achievements.GetCondition("GOOD_LITTLE_SLAVE", "Finish") != null)
			{
			}
			if (Main.Achievements.GetCondition("TROUT_MONKEY", "Finish") != null)
			{
			}
			if (Main.Achievements.GetCondition("FAST_AND_FISHIOUS", "Finish") != null)
			{
			}
			if (Main.Achievements.GetCondition("SUPREME_HELPER_MINION", "Finish") != null)
			{
			}
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00261954 File Offset: 0x0025FB54
		public static void HandleRunning(Player player, float pixelsMoved)
		{
			if (!true)
			{
			}
			AchievementCondition condition = Main.Achievements.GetCondition("MARATHON_MEDALIST", "Move");
			if (condition != null)
			{
			}
			if (condition._isCompleted)
			{
				IPlatformAwardNotifier platformAwards = UserManagement.FindLocalUserByPlayer(player).PlatformAwards;
				return;
			}
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0026199C File Offset: 0x0025FB9C
		public static void HandleMining()
		{
			if (!true)
			{
			}
			if (Main.Achievements.GetCondition("BULLDOZER", "Pick") != null)
			{
			}
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x002619CC File Offset: 0x0025FBCC
		public static void CheckMechaMayhem(int justKilled = -1)
		{
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00261A54 File Offset: 0x0025FC54
		private static bool IsMetalBar(int itemType)
		{
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00261A64 File Offset: 0x0025FC64
		public AchievementsHelper()
		{
		}

		// Token: 0x0400842E RID: 33838
		[CompilerGenerated]
		private static AchievementsHelper.ItemPickupEvent OnItemPickup;

		// Token: 0x0400842F RID: 33839
		[CompilerGenerated]
		private static AchievementsHelper.ItemCraftEvent OnItemCraft;

		// Token: 0x04008430 RID: 33840
		[CompilerGenerated]
		private static AchievementsHelper.TileDestroyedEvent OnTileDestroyed;

		// Token: 0x04008431 RID: 33841
		[CompilerGenerated]
		private static AchievementsHelper.NPCKilledEvent OnNPCKilled;

		// Token: 0x04008432 RID: 33842
		[CompilerGenerated]
		private static AchievementsHelper.ProgressionEventEvent OnProgressionEvent;

		// Token: 0x04008433 RID: 33843
		private static bool _isMining;

		// Token: 0x04008434 RID: 33844
		private static bool mayhemOK;

		// Token: 0x04008435 RID: 33845
		private static bool mayhem1down;

		// Token: 0x04008436 RID: 33846
		private static bool mayhem2down;

		// Token: 0x04008437 RID: 33847
		private static bool mayhem3down;

		// Token: 0x020009A5 RID: 2469
		public sealed class ItemPickupEvent : MulticastDelegate
		{
			// Token: 0x06004923 RID: 18723 RVA: 0x00261A78 File Offset: 0x0025FC78
			public ItemPickupEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004924 RID: 18724 RVA: 0x00261AD8 File Offset: 0x0025FCD8
			public void Invoke(Player player, short itemId, int count)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004925 RID: 18725 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, short itemId, int count, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004926 RID: 18726 RVA: 0x00261AFC File Offset: 0x0025FCFC
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x020009A6 RID: 2470
		public sealed class ItemCraftEvent : MulticastDelegate
		{
			// Token: 0x06004927 RID: 18727 RVA: 0x00261B0C File Offset: 0x0025FD0C
			public ItemCraftEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.method = method;
			}

			// Token: 0x06004928 RID: 18728 RVA: 0x00261B5C File Offset: 0x0025FD5C
			public void Invoke(Player player, short itemId, int count)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004929 RID: 18729 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, short itemId, int count, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600492A RID: 18730 RVA: 0x00261B80 File Offset: 0x0025FD80
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x020009A7 RID: 2471
		public sealed class TileDestroyedEvent : MulticastDelegate
		{
			// Token: 0x0600492B RID: 18731 RVA: 0x00261B90 File Offset: 0x0025FD90
			public TileDestroyedEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600492C RID: 18732 RVA: 0x00261BF0 File Offset: 0x0025FDF0
			public void Invoke(Player player, ushort tileId)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x0600492D RID: 18733 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, ushort tileId, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600492E RID: 18734 RVA: 0x00261C14 File Offset: 0x0025FE14
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x020009A8 RID: 2472
		public sealed class NPCKilledEvent : MulticastDelegate
		{
			// Token: 0x0600492F RID: 18735 RVA: 0x00261C24 File Offset: 0x0025FE24
			public NPCKilledEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004930 RID: 18736 RVA: 0x00261C84 File Offset: 0x0025FE84
			public void Invoke(Player player, short npcId)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004931 RID: 18737 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, short npcId, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004932 RID: 18738 RVA: 0x00261CA8 File Offset: 0x0025FEA8
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x020009A9 RID: 2473
		public sealed class ProgressionEventEvent : MulticastDelegate
		{
			// Token: 0x06004933 RID: 18739 RVA: 0x00261CB8 File Offset: 0x0025FEB8
			public ProgressionEventEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004934 RID: 18740 RVA: 0x00261D0C File Offset: 0x0025FF0C
			public void Invoke(int eventID)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06004935 RID: 18741 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int eventID, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004936 RID: 18742 RVA: 0x00261D30 File Offset: 0x0025FF30
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
