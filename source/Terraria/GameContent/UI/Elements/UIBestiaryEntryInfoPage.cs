using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA0 RID: 2720
	public class UIBestiaryEntryInfoPage : UIPanel
	{
		// Token: 0x06005039 RID: 20537 RVA: 0x0027CAB0 File Offset: 0x0027ACB0
		public UIBestiaryEntryInfoPage()
		{
			int num = 17254;
			this.BorderColor = num;
			this.BackgroundColor = num;
			if (num == 0)
			{
			}
			UIList list = this._list;
			this.CheckScrollBar();
			this.AppendBorderOverEverything();
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x0027CB18 File Offset: 0x0027AD18
		public void UpdateScrollbar(int scrollWheelValue)
		{
			UIScrollbar scrollbar = this._scrollbar;
			if (scrollbar != null)
			{
				float viewPosition = scrollbar._viewPosition;
				return;
			}
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x0027CB38 File Offset: 0x0027AD38
		private void AppendBorderOverEverything()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x0027CB48 File Offset: 0x0027AD48
		private void ManualIfnoSortingMethod(List<UIElement> list)
		{
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x0027CB58 File Offset: 0x0027AD58
		public override void Recalculate()
		{
			base.Recalculate();
			this.CheckScrollBar();
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x0027CB74 File Offset: 0x0027AD74
		private void CheckScrollBar()
		{
			UIScrollbar scrollbar = this._scrollbar;
			if (scrollbar != null)
			{
				bool canScroll = scrollbar.CanScroll;
				if (!this._isScrollbarAttached)
				{
					UIScrollbar scrollbar2 = this._scrollbar;
					base.Append(scrollbar2);
					UIList list = this._list;
					int num = 1;
					this._isScrollbarAttached = num != 0;
					return;
				}
			}
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x0027CBBC File Offset: 0x0027ADBC
		public void FillInfoForEntry(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			UIList list = this._list;
			if (entry != null)
			{
				return;
			}
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x0027CBD4 File Offset: 0x0027ADD4
		private BestiaryUICollectionInfo GetUICollectionInfo(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			/*
An exception occurred when decompiling this method (06005040)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.BestiaryUICollectionInfo Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage::GetUICollectionInfo(Terraria.GameContent.Bestiary.BestiaryEntry,Terraria.GameContent.UI.Elements.ExtraBestiaryInfoPageInformation)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:IBestiaryUICollectionInfoProvider[exp:bool](BestiaryEntry::UIInfoProvider, ldloc:BestiaryEntry(entry))))
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

		// Token: 0x06005041 RID: 20545 RVA: 0x0027CBE8 File Offset: 0x0027ADE8
		private void AddInfoToList(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			List<IBestiaryInfoElement> <Info>k__BackingField = entry.<Info>k__BackingField;
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x0027CCA0 File Offset: 0x0027AEA0
		private float GetIndividualElementPriority(IBestiaryInfoElement element)
		{
			/*
An exception occurred when decompiling this method (06005042)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage::GetIndividualElementPriority(Terraria.GameContent.Bestiary.IBestiaryInfoElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:IBestiaryInfoElement[exp:bool](element)))
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

		// Token: 0x06005043 RID: 20547 RVA: 0x0027CCB0 File Offset: 0x0027AEB0
		private UIBestiaryEntryInfoPage.BestiaryInfoCategory GetBestiaryInfoCategory(IBestiaryInfoElement element)
		{
			if (element != null)
			{
				return;
			}
		}

		// Token: 0x0400890B RID: 35083
		private UIList _list;

		// Token: 0x0400890C RID: 35084
		private UIScrollbar _scrollbar;

		// Token: 0x0400890D RID: 35085
		private bool _isScrollbarAttached;

		// Token: 0x02000AA1 RID: 2721
		private enum BestiaryInfoCategory
		{
			// Token: 0x0400890F RID: 35087
			Nameplate,
			// Token: 0x04008910 RID: 35088
			Portrait,
			// Token: 0x04008911 RID: 35089
			FlavorText,
			// Token: 0x04008912 RID: 35090
			Stats,
			// Token: 0x04008913 RID: 35091
			ItemsFromCatchingNPC,
			// Token: 0x04008914 RID: 35092
			ItemsFromDrops,
			// Token: 0x04008915 RID: 35093
			Misc
		}

		// Token: 0x02000AA2 RID: 2722
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005044 RID: 20548 RVA: 0x0027CCD4 File Offset: 0x0027AED4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005045 RID: 20549 RVA: 0x0027CCE4 File Offset: 0x0027AEE4
			public <>c()
			{
			}

			// Token: 0x06005046 RID: 20550 RVA: 0x000021DB File Offset: 0x000003DB
			internal UIBestiaryEntryInfoPage.BestiaryInfoCategory <AddInfoToList>b__11_0(IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement> x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04008916 RID: 35094
			public static readonly UIBestiaryEntryInfoPage.<>c <>9;

			// Token: 0x04008917 RID: 35095
			public static Func<IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement>, UIBestiaryEntryInfoPage.BestiaryInfoCategory> <>9__11_0;
		}
	}
}
