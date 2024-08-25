using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000A76 RID: 2678
	public class UIEmotesMenu : UIState
	{
		// Token: 0x06004F09 RID: 20233 RVA: 0x00278A64 File Offset: 0x00276C64
		public override void OnActivate()
		{
			int num = 1;
			this.InitializePage();
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			UIElement outerContainer = this._outerContainer;
			UIElement outerContainer2 = this._outerContainer;
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x00278A94 File Offset: 0x00276C94
		public void InitializePage()
		{
			base.RemoveAllChildren();
			if (49884 == 0)
			{
			}
			LocalizedText text = Language.GetText("UI.Back");
			long num = 0L;
			LocalizedText text2 = Language.GetText("UI.EmoteCategoryGeneral");
			int num2 = 10;
			List<int> list;
			this.TryAddingList(text2, (int)num, num2, list);
			LocalizedText text3 = Language.GetText("UI.EmoteCategoryRPS");
			int num3 = 10;
			List<int> list2;
			this.TryAddingList(text3, (int)num, num3, list2);
			LocalizedText text4 = Language.GetText("UI.EmoteCategoryItems");
			int num4 = 11;
			List<int> list3;
			this.TryAddingList(text4, (int)num, num4, list3);
			LocalizedText text5 = Language.GetText("UI.EmoteCategoryBiomesAndEvents");
			int num5 = 8;
			List<int> list4;
			this.TryAddingList(text5, (int)num, num5, list4);
			LocalizedText text6 = Language.GetText("UI.EmoteCategoryTownNPCs");
			int num6 = 9;
			List<int> list5;
			this.TryAddingList(text6, (int)num, num6, list5);
			LocalizedText text7 = Language.GetText("UI.EmoteCategoryCritters");
			int num7 = 7;
			List<int> list6;
			this.TryAddingList(text7, (int)num, num7, list6);
			LocalizedText text8 = Language.GetText("UI.EmoteCategoryBosses");
			int num8 = 8;
			List<int> list7;
			this.TryAddingList(text8, (int)num, num8, list7);
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00278B9C File Offset: 0x00276D9C
		private void TryAddingList(LocalizedText title, int currentGroupIndex, int maxEmotesPerRow, List<int> emoteIds)
		{
			if (emoteIds != null && emoteIds._size != 0)
			{
				UIList list = this._list;
				return;
			}
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x000021DB File Offset: 0x000003DB
		private List<int> GetEmotesGeneral()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00278BC0 File Offset: 0x00276DC0
		private List<int> GetEmotesRPS()
		{
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x000021DB File Offset: 0x000003DB
		private List<int> GetEmotesItems()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x000021DB File Offset: 0x000003DB
		private List<int> GetEmotesBiomesAndEvents()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x000021DB File Offset: 0x000003DB
		private List<int> GetEmotesTownNPCs()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00278BD4 File Offset: 0x00276DD4
		private List<int> GetEmotesCritters()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00278C10 File Offset: 0x00276E10
		private List<int> GetEmotesBosses()
		{
			/*
An exception occurred when decompiling this method (06004F12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> Terraria.GameContent.UI.States.UIEmotesMenu::GetEmotesBosses()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F1:
	stloc:bool(var_25_F9, callgetter:bool(DD2Event::get_DownedInvasionAnyDifficulty))
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

		// Token: 0x06004F13 RID: 20243 RVA: 0x00278D20 File Offset: 0x00276F20
		public override void Recalculate()
		{
			UIScrollbar scrollBar = this._scrollBar;
			if (scrollBar != null)
			{
				if (this._isScrollbarAttached)
				{
					bool canScroll = scrollBar.CanScroll;
					if (this._isScrollbarAttached)
					{
						goto IL_0079;
					}
				}
				bool canScroll2 = this._scrollBar.CanScroll;
				UIElement container = this._container;
				UIScrollbar scrollBar2 = this._scrollBar;
				container.Append(scrollBar2);
				UIList list = this._list;
				int num = 1;
				this._isScrollbarAttached = num != 0;
				return;
			}
			IL_0079:
			base.Recalculate();
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00278DAC File Offset: 0x00276FAC
		private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
		{
			if (!true)
			{
			}
			Main.menuMode = 0;
			IngameFancyUI.Close();
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00278DCC File Offset: 0x00276FCC
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

		// Token: 0x06004F16 RID: 20246 RVA: 0x00278E08 File Offset: 0x00277008
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

		// Token: 0x06004F17 RID: 20247 RVA: 0x00278E40 File Offset: 0x00277040
		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00278E54 File Offset: 0x00277054
		public UIEmotesMenu()
		{
		}

		// Token: 0x04008809 RID: 34825
		private UIElement _outerContainer;

		// Token: 0x0400880A RID: 34826
		private UIElement _backPanel;

		// Token: 0x0400880B RID: 34827
		private UIElement _container;

		// Token: 0x0400880C RID: 34828
		private UIList _list;

		// Token: 0x0400880D RID: 34829
		private UIScrollbar _scrollBar;

		// Token: 0x0400880E RID: 34830
		private bool _isScrollbarAttached;
	}
}
