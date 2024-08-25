using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AAE RID: 2734
	public class UICreativeInfiniteItemsDisplay : UIElement
	{
		// Token: 0x06005083 RID: 20611 RVA: 0x0027D808 File Offset: 0x0027BA08
		public UICreativeInfiniteItemsDisplay(UIState uiStateThatHoldsThis)
		{
			int num = 1;
			this._lastCheckedVersionForEdits = num;
			base..ctor();
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x0027D84C File Offset: 0x0027BA4C
		private void BuildPage()
		{
			this._lastCheckedVersionForEdits = 1;
			base.RemoveAllChildren();
			if (!true)
			{
			}
			this.UpdateContents();
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x0027D870 File Offset: 0x0027BA70
		private void Hover_OnUpdate(UIElement affectedElement)
		{
			if (this._hovered)
			{
				Main.LocalPlayer.mouseInterface = true;
			}
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x0027D894 File Offset: 0x0027BA94
		private void Hover_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x0027D8A4 File Offset: 0x0027BAA4
		private void Hover_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			this._hovered = true;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x0027D8B8 File Offset: 0x0027BAB8
		private static UIPanel CreateBasicPanel()
		{
			/*
An exception occurred when decompiling this method (06005088)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.UI.Elements.UIPanel Terraria.GameContent.UI.Elements.UICreativeInfiniteItemsDisplay::CreateBasicPanel()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x0027D8C8 File Offset: 0x0027BAC8
		private static void SetBasicSizesForCreativeSacrificeOrInfinitesPanel(UIElement element)
		{
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x0027D8D8 File Offset: 0x0027BAD8
		private void BuildInfinitesMenuContents(UIElement totalContainer)
		{
			UIPanel uipanel = UICreativeInfiniteItemsDisplay.CreateBasicPanel();
			totalContainer.Append(uipanel);
			UISearchBar searchBar = this._searchBar;
			EntryFilterer<Item, IItemEntryFilter> filterer = this._filterer;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x0027D900 File Offset: 0x0027BB00
		private void BuildSacrificeMenuContents(UIElement totalContainer)
		{
			UIPanel uipanel = UICreativeInfiniteItemsDisplay.CreateBasicPanel();
			int num = 16128;
			uipanel.VAlign = (float)num;
			int num2 = 17194;
			totalContainer.Append(uipanel);
			this.AddCogsForSacrificeMenu(uipanel);
			if (num2 == 0)
			{
			}
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x0027D960 File Offset: 0x0027BB60
		private void research_OnUpdate(UIElement affectedElement)
		{
			bool <IsMouseHovering>k__BackingField = affectedElement.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string textValue = Language.GetTextValue("CreativePowers.ResearchButtonTooltip");
			}
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x0027D988 File Offset: 0x0027BB88
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			if (target != null)
			{
			}
			if (evt.Target != null)
			{
			}
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x0027D9C4 File Offset: 0x0027BBC4
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			int num = 1;
			UIElement target = evt.Target;
			if (num == 0)
			{
			}
			if (target != null)
			{
			}
			if (evt.Target != null)
			{
			}
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x0027D9FC File Offset: 0x0027BBFC
		private void AddCogsForSacrificeMenu(UIElement sacrificesContainer)
		{
			if (17292 == 0)
			{
			}
			List<UIImage> sacrificeCogsSmall = this._sacrificeCogsSmall;
			List<UIImage> sacrificeCogsMedium = this._sacrificeCogsMedium;
			List<UIImage> sacrificeCogsBig = this._sacrificeCogsBig;
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x0027DA30 File Offset: 0x0027BC30
		private void sacrificeWindow_OnUpdate(UIElement affectedElement)
		{
			this.UpdateVisualFrame();
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x0027DA44 File Offset: 0x0027BC44
		private void UpdateVisualFrame()
		{
			float sacrificeAnimationProgress = this.GetSacrificeAnimationProgress();
			if (!true)
			{
			}
			List<UIImage> sacrificeCogsSmall = this._sacrificeCogsSmall;
			float num;
			UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs(num, sacrificeCogsSmall);
			List<UIImage> sacrificeCogsMedium = this._sacrificeCogsMedium;
			UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs(num, sacrificeCogsMedium);
			List<UIImage> sacrificeCogsBig = this._sacrificeCogsBig;
			UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs(num, sacrificeCogsBig);
			if (this._sacrificeAnimationTimeLeft != 0)
			{
				return;
			}
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x0027DAE0 File Offset: 0x0027BCE0
		private static void OffsetRotationsForCogs(float rotationOffset, List<UIImage> cogsList)
		{
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x0027DAF0 File Offset: 0x0027BCF0
		private void AddSymetricalCogsPair(UIElement sacrificesContainer, Vector2 cogOFfsetsInPixels, string assetPath, List<UIImage> imagesList)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x0027DB30 File Offset: 0x0027BD30
		private void descriptionText_OnUpdate(UIElement affectedElement)
		{
			if (affectedElement != null)
			{
				return;
			}
			bool isAir = Main.mouseItem.IsAir;
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x0027DB5C File Offset: 0x0027BD5C
		private void sacrificeButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			this.SacrificeWhatYouCan();
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x0027DB70 File Offset: 0x0027BD70
		public void SacrificeWhatYouCan()
		{
			if (!true)
			{
			}
			int num = 1;
			int num2 = 60;
			this._researchComplete = num != 0;
			this._sacrificeAnimationTimeLeft = num2;
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x0027DBB0 File Offset: 0x0027BDB0
		public void StopPlayingAnimation()
		{
			this._pistonParticleSystem.ClearParticles();
			this.UpdateVisualFrame();
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0027DBD0 File Offset: 0x0027BDD0
		private void RememberItemSacrifice(int itemId, int amountWeHave, int amountWeNeedTotal)
		{
			this._lastItemIdSacrificed = itemId;
			this._lastItemAmountWeHad = amountWeHave;
			this._lastItemAmountWeNeededTotal = amountWeNeedTotal;
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x0027DBF4 File Offset: 0x0027BDF4
		private void ForgetItemSacrifice()
		{
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x0027DC04 File Offset: 0x0027BE04
		private void BeginSacrificeAnimation()
		{
			this._sacrificeAnimationTimeLeft = 60;
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x0027DC1C File Offset: 0x0027BE1C
		private void UpdateSacrificeAnimation()
		{
			int sacrificeAnimationTimeLeft = this._sacrificeAnimationTimeLeft;
			this._sacrificeAnimationTimeLeft = sacrificeAnimationTimeLeft;
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x0027DC38 File Offset: 0x0027BE38
		private float GetSacrificeAnimationProgress()
		{
			int sacrificeAnimationTimeLeft = this._sacrificeAnimationTimeLeft;
			if (!true)
			{
			}
			return float.Epsilon;
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x0027DC54 File Offset: 0x0027BE54
		public void SetPageTypeToShow(UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage page)
		{
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x0027DC64 File Offset: 0x0027BE64
		private void UICreativeInfiniteItemsDisplay_OnUpdate(UIElement affectedElement)
		{
			base.RemoveAllChildren();
			if (!true)
			{
			}
			CreativeUnlocksTracker localPlayerCreativeTracker = Main.LocalPlayerCreativeTracker;
			CreativeUnlocksTracker lastTrackerCheckedForEdits = this._lastTrackerCheckedForEdits;
			this._lastTrackerCheckedForEdits = localPlayerCreativeTracker;
			this._lastCheckedVersionForEdits = lastTrackerCheckedForEdits;
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x0027DCC0 File Offset: 0x0027BEC0
		private void filtersHelper_OnClickingOption()
		{
			this.UpdateContents();
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x0027DCD4 File Offset: 0x0027BED4
		private void UpdateContents()
		{
			List<int> itemIdsAvailableTotal = this._itemIdsAvailableTotal;
			int version = itemIdsAvailableTotal._version;
			itemIdsAvailableTotal._syncRoot = version;
			if (itemIdsAvailableTotal == null)
			{
			}
			ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
			List<int> itemIdsAvailableTotal2 = this._itemIdsAvailableTotal;
			itemSacrifices.FillListOfItemsThatCanBeObtainedInfinitely(itemIdsAvailableTotal2);
			List<int> itemIdsAvailableToShow = this._itemIdsAvailableToShow;
			int version2 = itemIdsAvailableToShow._version;
			itemIdsAvailableToShow._syncRoot = version2;
			List<int> itemIdsAvailableTotal3 = this._itemIdsAvailableTotal;
			List<int> itemIdsAvailableToShow2 = this._itemIdsAvailableToShow;
			EntrySorter<int, ICreativeItemSortStep> sorter = this._sorter;
			UIDynamicItemCollection itemGrid = this._itemGrid;
			List<int> itemIdsAvailableToShow3 = this._itemIdsAvailableToShow;
			itemGrid.SetContentsToShow(itemIdsAvailableToShow3);
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x0027DD64 File Offset: 0x0027BF64
		private void AddSearchBar(UIElement searchArea)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x0027DDA0 File Offset: 0x0027BFA0
		private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			bool hasContents = this._searchBar.HasContents;
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x0027DDBC File Offset: 0x0027BFBC
		private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x0027DDCC File Offset: 0x0027BFCC
		private void OnCanceledInput()
		{
			if (!true)
			{
			}
			Main.LocalPlayer.ToggleInv();
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x0027DDE8 File Offset: 0x0027BFE8
		private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			UIPanel searchBoxPanel = this._searchBoxPanel;
			UIElement <Parent>k__BackingField = target.<Parent>k__BackingField;
			this._searchBar.ToggleTakingText();
			this._didClickSearchBar = true;
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x0027DE1C File Offset: 0x0027C01C
		public override void LeftClick(UIMouseEvent evt)
		{
			base.LeftClick(evt);
			this._didClickSomething = true;
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x0027DE38 File Offset: 0x0027C038
		public override void RightClick(UIMouseEvent evt)
		{
			base.RightClick(evt);
			this._didClickSomething = true;
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x0027DE54 File Offset: 0x0027C054
		private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
		{
			this._didClickSomething = true;
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x0027DE68 File Offset: 0x0027C068
		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (this._didClickSomething && !this._didClickSearchBar)
			{
				UISearchBar searchBar = this._searchBar;
				if (searchBar.isWritingText)
				{
					searchBar.ToggleTakingText();
				}
			}
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x0027DEA4 File Offset: 0x0027C0A4
		private void OnSearchContentsChanged(string contents)
		{
			this._searchString = contents;
			this._filterer.SetSearchFilter(contents);
			this.UpdateContents();
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x0027DECC File Offset: 0x0027C0CC
		private void OnStartTakingInput()
		{
			UIPanel searchBoxPanel = this._searchBoxPanel;
			if (!true)
			{
			}
			searchBoxPanel.BorderColor = 1;
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x0027DEEC File Offset: 0x0027C0EC
		private void OnEndTakingInput()
		{
			UIPanel searchBoxPanel = this._searchBoxPanel;
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x0027DF00 File Offset: 0x0027C100
		private void OpenVirtualKeyboardWhenNeeded()
		{
			string <Value>k__BackingField = Language.GetText("UI.PlayerNameSlot").<Value>k__BackingField;
			string searchString = this._searchString;
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x0027DF24 File Offset: 0x0027C124
		private bool EscapeVirtualKeyboard()
		{
			IngameFancyUI.Close();
			if (!true)
			{
			}
			Main.playerInventory = true;
			UISearchBar searchBar = this._searchBar;
			bool isWritingText = searchBar.isWritingText;
			if (isWritingText)
			{
				searchBar.ToggleTakingText();
			}
			if (!isWritingText)
			{
			}
			return true;
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x0027DF5C File Offset: 0x0027C15C
		private static UserInterface GetCurrentInterface()
		{
			/*
An exception occurred when decompiling this method (060050AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UserInterface Terraria.GameContent.UI.Elements.UICreativeInfiniteItemsDisplay::GetCurrentInterface()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:bool(var_1_0D, callgetter:bool(Main::get_gameMenu))
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

		// Token: 0x060050B0 RID: 20656 RVA: 0x0027DF78 File Offset: 0x0027C178
		private void OnFinishedSettingName(string name)
		{
			string text = name.Trim();
			UISearchBar searchBar = this._searchBar;
			long num = 0L;
			searchBar.SetContents(text, num != 0L);
			this.GoBackHere();
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x0027DFA4 File Offset: 0x0027C1A4
		private void GoBackHere()
		{
			IngameFancyUI.Close();
			if (!true)
			{
			}
			this._searchBar.ToggleTakingText();
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x0027DFC8 File Offset: 0x0027C1C8
		public int GetItemsPerLine()
		{
			return this._itemGrid._itemsPerLine;
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x0027DFE0 File Offset: 0x0027C1E0
		[CompilerGenerated]
		private bool <UpdateContents>b__63_0(int x)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0400894D RID: 35149
		private List<int> _itemIdsAvailableTotal;

		// Token: 0x0400894E RID: 35150
		private List<int> _itemIdsAvailableToShow;

		// Token: 0x0400894F RID: 35151
		private CreativeUnlocksTracker _lastTrackerCheckedForEdits;

		// Token: 0x04008950 RID: 35152
		private int _lastCheckedVersionForEdits;

		// Token: 0x04008951 RID: 35153
		private UISearchBar _searchBar;

		// Token: 0x04008952 RID: 35154
		private UIPanel _searchBoxPanel;

		// Token: 0x04008953 RID: 35155
		private UIState _parentUIState;

		// Token: 0x04008954 RID: 35156
		private string _searchString;

		// Token: 0x04008955 RID: 35157
		private UIDynamicItemCollection _itemGrid;

		// Token: 0x04008956 RID: 35158
		private EntryFilterer<Item, IItemEntryFilter> _filterer;

		// Token: 0x04008957 RID: 35159
		private EntrySorter<int, ICreativeItemSortStep> _sorter;

		// Token: 0x04008958 RID: 35160
		private UIElement _containerInfinites;

		// Token: 0x04008959 RID: 35161
		private UIElement _containerSacrifice;

		// Token: 0x0400895A RID: 35162
		private bool _showSacrificesInsteadOfInfinites;

		// Token: 0x0400895B RID: 35163
		public const string SnapPointName_SacrificeSlot = "CreativeSacrificeSlot";

		// Token: 0x0400895C RID: 35164
		public const string SnapPointName_SacrificeConfirmButton = "CreativeSacrificeConfirm";

		// Token: 0x0400895D RID: 35165
		public const string SnapPointName_InfinitesFilter = "CreativeInfinitesFilter";

		// Token: 0x0400895E RID: 35166
		public const string SnapPointName_InfinitesSearch = "CreativeInfinitesSearch";

		// Token: 0x0400895F RID: 35167
		public const string SnapPointName_InfinitesItemSlot = "CreativeInfinitesSlot";

		// Token: 0x04008960 RID: 35168
		private List<UIImage> _sacrificeCogsSmall;

		// Token: 0x04008961 RID: 35169
		private List<UIImage> _sacrificeCogsMedium;

		// Token: 0x04008962 RID: 35170
		private List<UIImage> _sacrificeCogsBig;

		// Token: 0x04008963 RID: 35171
		private UIImageFramed _sacrificePistons;

		// Token: 0x04008964 RID: 35172
		private UIParticleLayer _pistonParticleSystem;

		// Token: 0x04008965 RID: 35173
		private Asset<Texture2D> _pistonParticleAsset;

		// Token: 0x04008966 RID: 35174
		private int _sacrificeAnimationTimeLeft;

		// Token: 0x04008967 RID: 35175
		private bool _researchComplete;

		// Token: 0x04008968 RID: 35176
		private bool _hovered;

		// Token: 0x04008969 RID: 35177
		private int _lastItemIdSacrificed;

		// Token: 0x0400896A RID: 35178
		private int _lastItemAmountWeHad;

		// Token: 0x0400896B RID: 35179
		private int _lastItemAmountWeNeededTotal;

		// Token: 0x0400896C RID: 35180
		private bool _didClickSomething;

		// Token: 0x0400896D RID: 35181
		private bool _didClickSearchBar;

		// Token: 0x02000AAF RID: 2735
		public enum InfiniteItemsDisplayPage
		{
			// Token: 0x0400896F RID: 35183
			InfiniteItemsPickup,
			// Token: 0x04008970 RID: 35184
			InfiniteItemsResearch
		}
	}
}
