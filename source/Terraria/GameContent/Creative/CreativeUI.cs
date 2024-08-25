using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Net;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A12 RID: 2578
	public class CreativeUI
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0027100C File Offset: 0x0026F20C
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x00271020 File Offset: 0x0026F220
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x00271030 File Offset: 0x0026F230
		public bool Blocked
		{
			get
			{
				if (!true)
				{
				}
				int talkNPC = Main.LocalPlayer.talkNPC;
				return true;
			}
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x00271060 File Offset: 0x0026F260
		public CreativeUI()
		{
			int num = 1;
			this.GamepadPointIdForInfiniteItemSearchHack = num;
			base..ctor();
			long entityId = this._itemSlotsForUI.entityId;
			Item[] itemSlotsForUI = this._itemSlotsForUI;
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x0027109C File Offset: 0x0026F29C
		public void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x002710D4 File Offset: 0x0026F2D4
		public void Update(GameTime gameTime)
		{
			if (this.<Enabled>k__BackingField)
			{
				bool playerInventory = Main.playerInventory;
				this._powersUI.Update(gameTime);
				return;
			}
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00271100 File Offset: 0x0026F300
		public void Draw(SpriteBatch spriteBatch)
		{
			bool initialized = this._initialized;
			if (!initialized)
			{
				this.Initialize();
			}
			if (!initialized)
			{
			}
			byte difficulty = Main.LocalPlayer.difficulty;
			if (16968 == 0)
			{
			}
			if (16968 == 0)
			{
			}
			int screenHeight = Main.screenHeight;
			bool flag = this.<Enabled>k__BackingField;
			if (flag)
			{
				if (!flag)
				{
				}
				float inventoryScale = Main.inventoryScale;
			}
			bool flag2 = this.<Enabled>k__BackingField;
			if (flag2)
			{
				UserInterface powersUI = this._powersUI;
				if (!flag2)
				{
				}
				return;
			}
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x0027117C File Offset: 0x0026F37C
		public UIElement ProvideItemSlotElement(int itemSlotContext)
		{
			/*
An exception occurred when decompiling this method (06004C1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Creative.CreativeUI::ProvideItemSlotElement(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class Terraria.Item[](var_0_09, ldfld:class Terraria.Item[](CreativeUI::_itemSlotsForUI, ldloc:CreativeUI(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00271194 File Offset: 0x0026F394
		public Item GetItemByIndex(int itemSlotContext)
		{
			while (itemSlotContext == 0)
			{
			}
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x002711A8 File Offset: 0x0026F3A8
		public void SetItembyIndex(Item item, int itemSlotContext)
		{
			if (itemSlotContext == 0)
			{
				Item[] itemSlotsForUI = this._itemSlotsForUI;
				if (item != null && item == null)
				{
					throw new ArrayTypeMismatchException();
				}
				itemSlotsForUI.position = item;
			}
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x002711D4 File Offset: 0x0026F3D4
		private void DrawToggleButton(SpriteBatch spritebatch, Vector2 location)
		{
			Asset<Texture2D> buttonTexture = this._buttonTexture;
			if (!true)
			{
			}
			Vector2 vector = Utils.Size(buttonTexture);
			if (!true)
			{
			}
			if (this._buttonTexture == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			Vector2 mouseScreen = Main.MouseScreen;
			if (!true)
			{
			}
			Main.LocalPlayer.creativeInterface = true;
			Main.LocalPlayer.mouseInterface = true;
			bool flag = this.<Enabled>k__BackingField;
			if (!true)
			{
			}
			if (this._buttonBorderTexture == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (!true)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			this.ToggleMenu();
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00271278 File Offset: 0x0026F478
		public void SwapItem(Item item)
		{
			int num = 1;
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			if (num == 0)
			{
			}
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00271294 File Offset: 0x0026F494
		public void CloseMenu()
		{
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			Vector2 position = itemSlotsForUI.position;
			Player localPlayer = Main.LocalPlayer;
			int myPlayer = Main.myPlayer;
			Vector2 position2 = this._itemSlotsForUI.position;
			Item item;
			if (item != null && item == null)
			{
				throw new ArrayTypeMismatchException();
			}
			itemSlotsForUI.position = item;
			UICreativePowersMenu uiState = this._uiState;
			if (uiState != null)
			{
				uiState.StopPlayingResearchAnimations();
				return;
			}
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x002712F8 File Offset: 0x0026F4F8
		public void ToggleMenu()
		{
			bool flag = this.<Enabled>k__BackingField;
			UserInterface powersUI = this._powersUI;
			this.<Enabled>k__BackingField = flag;
			powersUI.EscapeElements();
			UISliderBase.EscapeElements();
			if (this.<Enabled>k__BackingField)
			{
				Recipe.FindRecipes(false);
				Player localPlayer = Main.LocalPlayer;
				this.RefreshAvailableInfiniteItemsList();
				return;
			}
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			if (itemSlotsForUI.position == null)
			{
			}
			Player localPlayer2 = Main.LocalPlayer;
			int myPlayer = Main.myPlayer;
			Vector2 position = this._itemSlotsForUI.position;
			Item item;
			if (item != null && item == null)
			{
				throw new ArrayTypeMismatchException();
			}
			itemSlotsForUI.position = item;
			UICreativePowersMenu uiState = this._uiState;
			if (uiState != null)
			{
				uiState.StopPlayingResearchAnimations();
				return;
			}
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x002713A8 File Offset: 0x0026F5A8
		public bool IsShowingResearchMenu()
		{
			if (!this.<Enabled>k__BackingField)
			{
				return;
			}
			UICreativePowersMenu uiState = this._uiState;
			if (uiState != null)
			{
				return uiState.IsShowingResearchMenu;
			}
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x002713D0 File Offset: 0x0026F5D0
		public void SacrificeItemInSacrificeSlot()
		{
			UICreativePowersMenu uiState = this._uiState;
			if (uiState != null)
			{
				uiState.SacrificeWhatsInResearchMenu();
				return;
			}
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x002713F0 File Offset: 0x0026F5F0
		public void StopPlayingSacrificeAnimations()
		{
			UICreativePowersMenu uiState = this._uiState;
			if (uiState != null)
			{
				uiState.StopPlayingResearchAnimations();
				return;
			}
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00271410 File Offset: 0x0026F610
		public bool ShouldDrawSacrificeArea()
		{
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			Vector2 position = itemSlotsForUI.position;
			if (itemSlotsForUI == null)
			{
			}
			Item mouseItem = Main.mouseItem;
			bool isAir = mouseItem.IsAir;
			if (itemSlotsForUI == null)
			{
			}
			int type = mouseItem.type;
			if (itemSlotsForUI == null)
			{
			}
			ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
			int type2 = mouseItem.type;
			int sacrificeCount = itemSacrifices.GetSacrificeCount(type2);
			return true;
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00271478 File Offset: 0x0026F678
		public bool GetSacrificeNumbers([Out] int itemIdChecked, [Out] int amountWeHave, [Out] int amountNeededTotal)
		{
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			Vector2 position = itemSlotsForUI.position;
			if (itemSlotsForUI == null)
			{
			}
			return Main.LocalPlayerCreativeTracker.ItemSacrifices.TryGetSacrificeNumbers(itemIdChecked, amountWeHave, amountNeededTotal);
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x002714AC File Offset: 0x0026F6AC
		public CreativeUI.ItemSacrificeResult SacrificeItem([Out] int amountWeSacrificed)
		{
			Vector2 position = this._itemSlotsForUI.position;
			ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
			long num = 0L;
			int num2 = Math.Min(1073741824, (int)num);
			NetPacket netPacket = NetCreativeUnlocksPlayerReportModule.SerializeSacrificeRequest(int.MinValue, num2);
			if (-2147483648 == 0)
			{
			}
			return (CreativeUI.ItemSacrificeResult)(-2147483648);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00271570 File Offset: 0x0026F770
		private void RefreshAvailableInfiniteItemsList()
		{
			List<int> itemIdsAvailableInfinitely = this._itemIdsAvailableInfinitely;
			int version = itemIdsAvailableInfinitely._version;
			itemIdsAvailableInfinitely._syncRoot = version;
			if (itemIdsAvailableInfinitely == null)
			{
			}
			ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
			List<int> itemIdsAvailableInfinitely2 = this._itemIdsAvailableInfinitely;
			itemSacrifices.FillListOfItemsThatCanBeObtainedInfinitely(itemIdsAvailableInfinitely2);
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x002715B4 File Offset: 0x0026F7B4
		public void Reset()
		{
			Item[] itemSlotsForUI = this._itemSlotsForUI;
			long entityId = itemSlotsForUI.entityId;
			Vector2 position = itemSlotsForUI.position;
			Item[] itemSlotsForUI2 = this._itemSlotsForUI;
		}

		// Token: 0x0400863D RID: 34365
		public const int ItemSlotIndexes_SacrificeItem = 0;

		// Token: 0x0400863E RID: 34366
		public const int ItemSlotIndexes_Count = 1;

		// Token: 0x0400863F RID: 34367
		[CompilerGenerated]
		private bool <Enabled>k__BackingField;

		// Token: 0x04008640 RID: 34368
		private bool _initialized;

		// Token: 0x04008641 RID: 34369
		private Asset<Texture2D> _buttonTexture;

		// Token: 0x04008642 RID: 34370
		private Asset<Texture2D> _buttonBorderTexture;

		// Token: 0x04008643 RID: 34371
		private Item[] _itemSlotsForUI;

		// Token: 0x04008644 RID: 34372
		private List<int> _itemIdsAvailableInfinitely;

		// Token: 0x04008645 RID: 34373
		private UserInterface _powersUI;

		// Token: 0x04008646 RID: 34374
		public int GamepadPointIdForInfiniteItemSearchHack;

		// Token: 0x04008647 RID: 34375
		public bool GamepadMoveToSearchButtonHack;

		// Token: 0x04008648 RID: 34376
		private UICreativePowersMenu _uiState;

		// Token: 0x02000A13 RID: 2579
		public enum ItemSacrificeResult
		{
			// Token: 0x0400864A RID: 34378
			CannotSacrifice,
			// Token: 0x0400864B RID: 34379
			SacrificedButNotDone,
			// Token: 0x0400864C RID: 34380
			SacrificedAndDone
		}
	}
}
