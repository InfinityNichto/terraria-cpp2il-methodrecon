using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000A6F RID: 2671
	public class UIBestiaryTest : UIState
	{
		// Token: 0x06004EB9 RID: 20153 RVA: 0x00277CA0 File Offset: 0x00275EA0
		public UIBestiaryTest(BestiaryDatabase database)
		{
			EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer = this._filterer;
			List<BestiaryEntry> entries = database._entries;
			EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer2 = this._filterer;
			List<IBestiaryEntryFilter> filters = database._filters;
			filterer2.AddFilters(filters);
			EntrySorter<BestiaryEntry, IBestiarySortStep> sorter = this._sorter;
			this.BuildPage();
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00277CE4 File Offset: 0x00275EE4
		public void OnOpenPage()
		{
			this.UpdateBestiaryContents();
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x00277CF8 File Offset: 0x00275EF8
		private void BuildPage()
		{
			int num = 1;
			base.RemoveAllChildren();
			if (num == 0)
			{
			}
			int num2 = true.ToInt();
			if (49844 == 0)
			{
			}
			List<BestiaryEntry> workingSetEntries = this._workingSetEntries;
			EntrySorter<BestiaryEntry, IBestiarySortStep> sorter = this._sorter;
			UIBestiarySortingOptionsGrid sortingGrid = this._sortingGrid;
			EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer = this._filterer;
			UIBestiaryFilteringOptionsGrid filteringGrid = this._filteringGrid;
			UIBestiaryFilteringOptionsGrid filteringGrid2 = this._filteringGrid;
			List<BestiaryEntry> originalEntriesList = this._originalEntriesList;
			filteringGrid2.SetupAvailabilityTest(originalEntriesList);
			UISearchBar searchBar = this._searchBar;
			this.UpdateBestiaryContents();
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00277D7C File Offset: 0x00275F7C
		private void FillProgressBottomBar(UIElement container)
		{
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00277D8C File Offset: 0x00275F8C
		private void ShowStats_Completion(UIElement element)
		{
			if (element.<IsMouseHovering>k__BackingField)
			{
				string completionPercentText = this.GetCompletionPercentText();
				if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
				{
				}
			}
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00277DB0 File Offset: 0x00275FB0
		private string GetCompletionPercentText()
		{
			if (!true)
			{
			}
			float num;
			string text = Utils.PrettifyPercentDisplay(num, "P2");
			string text2;
			return text2;
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x000021DB File Offset: 0x000003DB
		private float GetProgressPercent()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00277DD0 File Offset: 0x00275FD0
		private void EmptyInteraction(float input)
		{
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00277DE0 File Offset: 0x00275FE0
		private void EmptyInteraction2()
		{
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00277DF0 File Offset: 0x00275FF0
		private Color GetColorAtBlip(float percentile)
		{
			Color color;
			return color;
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x00277E0C File Offset: 0x0027600C
		private void AddBackAndForwardButtons(UIElement innerTopContainer)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00277E48 File Offset: 0x00276048
		private void AddSortAndFilterButtons(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x00277E88 File Offset: 0x00276088
		private void AddSearchBar(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x00277EF0 File Offset: 0x002760F0
		private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			bool hasContents = this._searchBar.HasContents;
			UISearchBar searchBar = this._searchBar;
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00277F14 File Offset: 0x00276114
		private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00277F24 File Offset: 0x00276124
		private void OpenVirtualKeyboardWhenNeeded()
		{
			string <Value>k__BackingField = Language.GetText("UI.PlayerNameSlot").<Value>k__BackingField;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00277F44 File Offset: 0x00276144
		private void OnFinishedSettingName(string name)
		{
			string text = name.Trim();
			UISearchBar searchBar = this._searchBar;
			long num = 0L;
			searchBar.SetContents(text, num != 0L);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x00277F6C File Offset: 0x0027616C
		private void GoBackHere()
		{
			if (!true)
			{
			}
			this._searchBar.ToggleTakingText();
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00277F88 File Offset: 0x00276188
		private void OnStartTakingInput()
		{
			UIPanel searchBoxPanel = this._searchBoxPanel;
			if (!true)
			{
			}
			searchBoxPanel.BorderColor = 1;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00277FA8 File Offset: 0x002761A8
		private void OnEndTakingInput()
		{
			UIPanel searchBoxPanel = this._searchBoxPanel;
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00277FBC File Offset: 0x002761BC
		private void OnSearchContentsChanged(string contents)
		{
			this._searchString = contents;
			this._filterer.SetSearchFilter(contents);
			this.UpdateBestiaryContents();
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x00277FE4 File Offset: 0x002761E4
		private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			UIPanel searchBoxPanel = this._searchBoxPanel;
			UIElement <Parent>k__BackingField = target.<Parent>k__BackingField;
			this._searchBar.ToggleTakingText();
			this._didClickSearchBar = true;
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x00278018 File Offset: 0x00276218
		public override void LeftClick(UIMouseEvent evt)
		{
			base.LeftClick(evt);
			this._didClickSomething = true;
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x00278034 File Offset: 0x00276234
		public override void RightClick(UIMouseEvent evt)
		{
			base.RightClick(evt);
			this._didClickSomething = true;
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x00278050 File Offset: 0x00276250
		private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
		{
			this._didClickSomething = true;
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x00278064 File Offset: 0x00276264
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

		// Token: 0x06004ED3 RID: 20179 RVA: 0x000021DB File Offset: 0x000003DB
		private void FilterEntries()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x002780A0 File Offset: 0x002762A0
		private void SortEntries()
		{
			while (this._workingSetEntries == null)
			{
			}
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x002780FC File Offset: 0x002762FC
		private void FillBestiarySpaceWithEntries()
		{
			UIBestiaryEntryGrid entryGrid = this._entryGrid;
			if (entryGrid != null && entryGrid.<Parent>k__BackingField != null)
			{
				UIBestiaryEntryInfoPage infoSpace = this._infoSpace;
				BestiaryUnlockProgressReport unlockProgress = this.GetUnlockProgress();
				UIBestiaryEntryGrid entryGrid2 = this._entryGrid;
				this._progressReport = unlockProgress;
				entryGrid2.FillBestiarySpaceWithEntries();
				return;
			}
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x00278140 File Offset: 0x00276340
		public void UpdateBestiaryGridRange()
		{
			UIText indexesRangeText = this._indexesRangeText;
			string rangeText = this._entryGrid.GetRangeText();
			indexesRangeText.SetText(rangeText);
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x00278168 File Offset: 0x00276368
		public override void Recalculate()
		{
			base.Recalculate();
			this.FillBestiarySpaceWithEntries();
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x00278184 File Offset: 0x00276384
		private void GetEntriesToShow([Out] int maxEntriesWidth, [Out] int maxEntriesHeight, [Out] int maxEntriesToHave)
		{
			float x = this._bestiarySpace._dimensions.X;
			int num = 36409;
			maxEntriesHeight.m_value = num;
			maxEntriesToHave.m_value = num;
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x002781B8 File Offset: 0x002763B8
		private void MakeExitButton(UIElement outerContainer)
		{
			LocalizedText text = Language.GetText("UI.Back");
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x002781D8 File Offset: 0x002763D8
		private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!true)
			{
			}
			Main.menuMode = 0;
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x00278204 File Offset: 0x00276404
		private void OpenOrCloseSortingOptions(UIMouseEvent evt, UIElement listeningElement)
		{
			UIBestiarySortingOptionsGrid sortingGrid;
			if (this._sortingGrid.<Parent>k__BackingField != null)
			{
				this.UpdateBestiaryContents();
				UIElement bestiarySpace = this._bestiarySpace;
				sortingGrid = this._sortingGrid;
				bestiarySpace.RemoveChild(sortingGrid);
				return;
			}
			this._bestiarySpace.RemoveChild(sortingGrid);
			UIElement bestiarySpace2 = this._bestiarySpace;
			UIBestiaryFilteringOptionsGrid filteringGrid = this._filteringGrid;
			bestiarySpace2.RemoveChild(filteringGrid);
			UIElement bestiarySpace3 = this._bestiarySpace;
			UIBestiarySortingOptionsGrid sortingGrid2 = this._sortingGrid;
			bestiarySpace3.Append(sortingGrid2);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x00278274 File Offset: 0x00276474
		private void OpenOrCloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			if (this._filteringGrid.<Parent>k__BackingField != null)
			{
				this.UpdateBestiaryContents();
				UIElement bestiarySpace = this._bestiarySpace;
				UIBestiaryFilteringOptionsGrid filteringGrid = this._filteringGrid;
				bestiarySpace.RemoveChild(filteringGrid);
				return;
			}
			UIElement bestiarySpace2 = this._bestiarySpace;
			UIBestiarySortingOptionsGrid sortingGrid = this._sortingGrid;
			bestiarySpace2.RemoveChild(sortingGrid);
			UIElement bestiarySpace3 = this._bestiarySpace;
			UIBestiaryFilteringOptionsGrid filteringGrid2 = this._filteringGrid;
			bestiarySpace3.RemoveChild(filteringGrid2);
			UIElement bestiarySpace4 = this._bestiarySpace;
			UIBestiaryFilteringOptionsGrid filteringGrid3 = this._filteringGrid;
			bestiarySpace4.Append(filteringGrid3);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x002782F4 File Offset: 0x002764F4
		private void Click_CloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			UIBestiaryFilteringOptionsGrid filteringGrid = this._filteringGrid;
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0027832C File Offset: 0x0027652C
		private void CloseFilteringGrid()
		{
			this.UpdateBestiaryContents();
			UIElement bestiarySpace = this._bestiarySpace;
			UIBestiaryFilteringOptionsGrid filteringGrid = this._filteringGrid;
			bestiarySpace.RemoveChild(filteringGrid);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x00278354 File Offset: 0x00276554
		private void UpdateBestiaryContents()
		{
			this._filteringGrid.UpdateAvailability();
			EntrySorter<BestiaryEntry, IBestiarySortStep> sorter = this._sorter;
			UIText sortingText = this._sortingText;
			EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer = this._filterer;
			UIText filteringText = this._filteringText;
			string displayName = filterer.GetDisplayName();
			filteringText.SetText(displayName);
			this.FilterEntries();
			this.SortEntries();
			this.FillBestiarySpaceWithEntries();
			BestiaryUnlockProgressReport unlockProgress = this.GetUnlockProgress();
			this._progressReport = unlockProgress;
			string completionPercentText = this.GetCompletionPercentText();
			this._progressPercentText.SetText(completionPercentText);
			UIColoredSliderSimple unlocksProgressBar = this._unlocksProgressBar;
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x002783D8 File Offset: 0x002765D8
		private void Click_CloseSortingGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			UIElement target = evt.Target;
			UIBestiarySortingOptionsGrid sortingGrid = this._sortingGrid;
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x00278410 File Offset: 0x00276610
		private void CloseSortingGrid()
		{
			this.UpdateBestiaryContents();
			UIElement bestiarySpace = this._bestiarySpace;
			UIBestiarySortingOptionsGrid sortingGrid = this._sortingGrid;
			bestiarySpace.RemoveChild(sortingGrid);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x00278438 File Offset: 0x00276638
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

		// Token: 0x06004EE3 RID: 20195 RVA: 0x00278474 File Offset: 0x00276674
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

		// Token: 0x06004EE4 RID: 20196 RVA: 0x002784AC File Offset: 0x002766AC
		private void Click_SelectEntryButton(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
				return;
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x002784C4 File Offset: 0x002766C4
		private void SelectEntryButton(UIBestiaryEntryButton button)
		{
			UIBestiaryEntryInfoPage infoSpace = this._infoSpace;
			this._selectedEntryButton = button;
			UIBestiaryEntryInfoPage infoSpace2 = this._infoSpace;
			BestiaryEntry <Entry>k__BackingField = button.<Entry>k__BackingField;
			BestiaryUnlockProgressReport progressReport = this._progressReport;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x002784F4 File Offset: 0x002766F4
		private void DeselectEntryButton()
		{
			UIBestiaryEntryInfoPage infoSpace = this._infoSpace;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00278508 File Offset: 0x00276708
		public BestiaryUnlockProgressReport GetUnlockProgress()
		{
			/*
An exception occurred when decompiling this method (06004EE7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.BestiaryUnlockProgressReport Terraria.GameContent.UI.States.UIBestiaryTest::GetUnlockProgress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.BestiaryEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.BestiaryEntry>(UIBestiaryTest::_originalEntriesList, ldloc:UIBestiaryTest(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.BestiaryEntry>[exp:List`1](var_0_06)))
	stloc:object(var_3_16, ldfld:object(List`1::_syncRoot, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.BestiaryEntry>[exp:List`1](var_0_06)))
	stloc:int32(var_4_1D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.BestiaryEntry>[exp:List`1](var_0_06)))
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

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00278534 File Offset: 0x00276734
		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		// Token: 0x040087CF RID: 34767
		private UIElement _bestiarySpace;

		// Token: 0x040087D0 RID: 34768
		private UIBestiaryEntryInfoPage _infoSpace;

		// Token: 0x040087D1 RID: 34769
		private UIBestiaryEntryButton _selectedEntryButton;

		// Token: 0x040087D2 RID: 34770
		private List<BestiaryEntry> _originalEntriesList;

		// Token: 0x040087D3 RID: 34771
		private List<BestiaryEntry> _workingSetEntries;

		// Token: 0x040087D4 RID: 34772
		private UIText _indexesRangeText;

		// Token: 0x040087D5 RID: 34773
		private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

		// Token: 0x040087D6 RID: 34774
		private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

		// Token: 0x040087D7 RID: 34775
		private UIBestiaryEntryGrid _entryGrid;

		// Token: 0x040087D8 RID: 34776
		private UIBestiarySortingOptionsGrid _sortingGrid;

		// Token: 0x040087D9 RID: 34777
		private UIBestiaryFilteringOptionsGrid _filteringGrid;

		// Token: 0x040087DA RID: 34778
		private UISearchBar _searchBar;

		// Token: 0x040087DB RID: 34779
		private UIPanel _searchBoxPanel;

		// Token: 0x040087DC RID: 34780
		private UIText _sortingText;

		// Token: 0x040087DD RID: 34781
		private UIText _filteringText;

		// Token: 0x040087DE RID: 34782
		private string _searchString;

		// Token: 0x040087DF RID: 34783
		private BestiaryUnlockProgressReport _progressReport;

		// Token: 0x040087E0 RID: 34784
		private UIText _progressPercentText;

		// Token: 0x040087E1 RID: 34785
		private UIColoredSliderSimple _unlocksProgressBar;

		// Token: 0x040087E2 RID: 34786
		private bool _didClickSomething;

		// Token: 0x040087E3 RID: 34787
		private bool _didClickSearchBar;
	}
}
