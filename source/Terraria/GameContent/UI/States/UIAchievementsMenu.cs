using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000A6D RID: 2669
	public class UIAchievementsMenu : UIState
	{
		// Token: 0x06004EAE RID: 20142 RVA: 0x000021DB File Offset: 0x000003DB
		public void InitializePage()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00277AC4 File Offset: 0x00275CC4
		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
			if (this._categoryButtons._size == 0)
			{
				int size = this._categoryButtons._size;
				return;
			}
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x00277B48 File Offset: 0x00275D48
		public void GotoAchievement(Achievement achievement)
		{
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x00277B58 File Offset: 0x00275D58
		private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
		{
			if (!true)
			{
			}
			Main.menuMode = 0;
			IngameFancyUI.Close();
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x00277B78 File Offset: 0x00275D78
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

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00277BB4 File Offset: 0x00275DB4
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

		// Token: 0x06004EB4 RID: 20148 RVA: 0x00277BEC File Offset: 0x00275DEC
		private void FilterList(UIMouseEvent evt, UIElement listeningElement)
		{
			UIList achievementsList = this._achievementsList;
			List<UIAchievementListItem> achievementElements = this._achievementElements;
			List<UIToggleImage> categoryButtons = this._categoryButtons;
			UIList achievementsList2 = this._achievementsList;
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00277C30 File Offset: 0x00275E30
		public override void OnActivate()
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			UIElement outerContainer = this._outerContainer;
			UIElement outerContainer2 = this._outerContainer;
			this._achievementsList.UpdateOrder();
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00277C60 File Offset: 0x00275E60
		public UIAchievementsMenu()
		{
		}

		// Token: 0x040087C9 RID: 34761
		private UIList _achievementsList;

		// Token: 0x040087CA RID: 34762
		private List<UIAchievementListItem> _achievementElements;

		// Token: 0x040087CB RID: 34763
		private List<UIToggleImage> _categoryButtons;

		// Token: 0x040087CC RID: 34764
		private UIElement _backpanel;

		// Token: 0x040087CD RID: 34765
		private UIElement _outerContainer;

		// Token: 0x02000A6E RID: 2670
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004EB7 RID: 20151 RVA: 0x00277C74 File Offset: 0x00275E74
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06004EB8 RID: 20152 RVA: 0x00277C88 File Offset: 0x00275E88
			internal bool <GotoAchievement>b__0(UIElement element)
			{
				/*
An exception occurred when decompiling this method (06004EB8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.States.UIAchievementsMenu/<>c__DisplayClass7_0::<GotoAchievement>b__0(Terraria.UI.UIElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Achievement(var_1_0B, ldfld:Achievement('<>c__DisplayClass7_0'::achievement, ldloc:'<>c__DisplayClass7_0'(this)))
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

			// Token: 0x040087CE RID: 34766
			public Achievement achievement;
		}
	}
}
