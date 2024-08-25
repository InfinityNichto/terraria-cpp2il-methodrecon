using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000A70 RID: 2672
	public class UICreativePowersMenu : UIState
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x00278548 File Offset: 0x00276748
		public bool IsShowingResearchMenu
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004EE9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.States.UICreativePowersMenu::get_IsShowingResearchMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(MenuTree`1::CurrentOption, ldfld:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/OpenMainSubCategory>[exp:MenuTree`1](UICreativePowersMenu::_mainCategory, ldloc:UICreativePowersMenu(this))))
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
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00278560 File Offset: 0x00276760
		public override void OnActivate()
		{
			this.InitializePage();
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00278574 File Offset: 0x00276774
		private void InitializePage()
		{
			List<UIElement> list = this.CreateMainPowerStrip();
			List<UIElement> list2 = this.CreateTimePowerStrip();
			List<UIElement> list3 = this.CreateWeatherPowerStrip();
			List<UIElement> list4 = this.CreatePersonalPowerStrip();
			this.RefreshElementsOrder();
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x002785A4 File Offset: 0x002767A4
		private List<UIElement> CreateMainPowerStrip()
		{
			/*
An exception occurred when decompiling this method (06004EEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.UI.UIElement> Terraria.GameContent.UI.States.UICreativePowersMenu::CreateMainPowerStrip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	call:void(UIElement::Append, ldloc:GroupOptionButton`1[exp:UIElement](var_4), ldloc:UIImageFramed[exp:UIElement](var_5))
	call:void(UIElement::Append, ldloc:GroupOptionButton`1[exp:UIElement](var_6), ldloc:UIImageFramed[exp:UIElement](var_7))
	call:void(UIElement::Append, ldloc:GroupOptionButton`1[exp:UIElement](var_8), ldloc:UIImageFramed[exp:UIElement](var_9))
	call:void(UIElement::Append, ldloc:GroupOptionButton`1[exp:UIElement](var_10), ldloc:UIImageFramed[exp:UIElement](var_11))
	call:void(UIElement::Append, ldloc:GroupOptionButton`1[exp:UIElement](var_12), ldloc:UIImageFramed[exp:UIElement](var_13))
	stloc:StopBiomeSpreadPower(var_15_4C, call:StopBiomeSpreadPower(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
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

		// Token: 0x06004EED RID: 20205 RVA: 0x00278600 File Offset: 0x00276800
		private static void CategoryButton_OnUpdate_DisplayTooltips(UIElement affectedElement, string categoryNameKey)
		{
			if (affectedElement != null)
			{
			}
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x00278620 File Offset: 0x00276820
		private void itemsWindowButton_OnUpdate(UIElement affectedElement)
		{
			UICreativePowersMenu.CategoryButton_OnUpdate_DisplayTooltips(affectedElement, "CreativePowers.InfiniteItemsCategory");
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x00278638 File Offset: 0x00276838
		private void researchWindowButton_OnUpdate(UIElement affectedElement)
		{
			UICreativePowersMenu.CategoryButton_OnUpdate_DisplayTooltips(affectedElement, "CreativePowers.ResearchItemsCategory");
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x00278650 File Offset: 0x00276850
		private void timeCategoryButton_OnUpdate(UIElement affectedElement)
		{
			UICreativePowersMenu.CategoryButton_OnUpdate_DisplayTooltips(affectedElement, "CreativePowers.TimeCategory");
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x00278668 File Offset: 0x00276868
		private void weatherCategoryButton_OnUpdate(UIElement affectedElement)
		{
			UICreativePowersMenu.CategoryButton_OnUpdate_DisplayTooltips(affectedElement, "CreativePowers.WeatherCategory");
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x00278680 File Offset: 0x00276880
		private void personalCategoryButton_OnUpdate(UIElement affectedElement)
		{
			UICreativePowersMenu.CategoryButton_OnUpdate_DisplayTooltips(affectedElement, "CreativePowers.PersonalCategory");
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x00278698 File Offset: 0x00276898
		private void UICreativePowersMenu_OnUpdate(UIElement affectedElement)
		{
			if (this._hovered)
			{
				Main.LocalPlayer.mouseInterface = true;
			}
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x002786BC File Offset: 0x002768BC
		private void strip_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x002786CC File Offset: 0x002768CC
		private void strip_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			this._hovered = true;
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x002786E0 File Offset: 0x002768E0
		private void MainCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			this.RefreshElementsOrder();
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x002786F4 File Offset: 0x002768F4
		private void ToggleMainCategory(int option)
		{
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.OpenMainSubCategory> mainCategory = this._mainCategory;
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x00278708 File Offset: 0x00276908
		private void ToggleWeatherCategory(int option)
		{
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.WeatherSubcategory> weatherCategory = this._weatherCategory;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0027871C File Offset: 0x0027691C
		private void ToggleTimeCategory(int option)
		{
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.TimeSubcategory> timeCategory = this._timeCategory;
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x00278730 File Offset: 0x00276930
		private void TogglePersonalCategory(int option)
		{
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.PersonalSubcategory> personalCategory = this._personalCategory;
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00278744 File Offset: 0x00276944
		public void SacrificeWhatsInResearchMenu()
		{
			this._infiniteItemsWindow.SacrificeWhatYouCan();
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x0027875C File Offset: 0x0027695C
		public void StopPlayingResearchAnimations()
		{
			this._infiniteItemsWindow.StopPlayingAnimation();
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00278774 File Offset: 0x00276974
		private void ToggleCategory<TEnum>(UICreativePowersMenu.MenuTree<TEnum> tree, int option, TEnum defaultOption) where TEnum : struct, IConvertible
		{
			int currentOption = tree.CurrentOption;
			int num;
			tree.CurrentOption = num;
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x002787A4 File Offset: 0x002769A4
		private List<UIElement> CreateTimePowerStrip()
		{
			/*
An exception occurred when decompiling this method (06004EFE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.UI.UIElement> Terraria.GameContent.UI.States.UICreativePowersMenu::CreateTimePowerStrip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/TimeSubcategory>(var_0_06, ldfld:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/TimeSubcategory>(UICreativePowersMenu::_timeCategory, ldloc:UICreativePowersMenu(this)))
	stloc:FreezeTime(var_2_13, call:FreezeTime(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:StartDayImmediately(var_4_20, call:StartDayImmediately(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:StartNoonImmediately(var_6_2F, call:StartNoonImmediately(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:StartNightImmediately(var_8_3E, call:StartNightImmediately(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:StartMidnightImmediately(var_10_4D, call:StartMidnightImmediately(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
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

		// Token: 0x06004EFF RID: 20223 RVA: 0x00278800 File Offset: 0x00276A00
		private List<UIElement> CreatePersonalPowerStrip()
		{
			/*
An exception occurred when decompiling this method (06004EFF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.UI.UIElement> Terraria.GameContent.UI.States.UICreativePowersMenu::CreatePersonalPowerStrip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/PersonalSubcategory>(var_0_06, ldfld:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/PersonalSubcategory>(UICreativePowersMenu::_personalCategory, ldloc:UICreativePowersMenu(this)))
	stloc:GodmodePower(var_2_13, call:GodmodePower(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:FarPlacementRangePower(var_4_20, call:FarPlacementRangePower(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
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

		// Token: 0x06004F00 RID: 20224 RVA: 0x00278830 File Offset: 0x00276A30
		private List<UIElement> CreateWeatherPowerStrip()
		{
			/*
An exception occurred when decompiling this method (06004F00)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.UI.UIElement> Terraria.GameContent.UI.States.UICreativePowersMenu::CreateWeatherPowerStrip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/WeatherSubcategory>(var_0_06, ldfld:class Terraria.GameContent.UI.States.UICreativePowersMenu/MenuTree`1<valuetype Terraria.GameContent.UI.States.UICreativePowersMenu/WeatherSubcategory>(UICreativePowersMenu::_weatherCategory, ldloc:UICreativePowersMenu(this)))
	stloc:FreezeWindDirectionAndStrength(var_3_13, call:FreezeWindDirectionAndStrength(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:FreezeRainPower(var_6_21, call:FreezeRainPower(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
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

		// Token: 0x06004F01 RID: 20225 RVA: 0x00278860 File Offset: 0x00276A60
		private GroupOptionButton<int> CreateSubcategoryButton<T>(CreativePowerUIElementRequestInfo request, int subcategoryDepth, string subcategoryName, int subcategoryIndex, int currentSelectedInSubcategory, Dictionary<int, GroupOptionButton<int>> subcategoryButtons, Dictionary<int, UIElement> slidersSet) where T : class, ICreativePower, IProvideSliderElement, IPowerSubcategoryElement
		{
			/*
An exception occurred when decompiling this method (06004F01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.UI.Elements.GroupOptionButton`1<System.Int32> Terraria.GameContent.UI.States.UICreativePowersMenu::CreateSubcategoryButton<T>(Terraria.GameContent.Creative.CreativePowerUIElementRequestInfo,System.Int32,System.String,System.Int32,System.Int32,System.Collections.Generic.Dictionary`2<System.Int32,Terraria.GameContent.UI.Elements.GroupOptionButton`1<System.Int32>>,System.Collections.Generic.Dictionary`2<System.Int32,Terraria.UI.UIElement>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CreativePowerManager(var_1_07, callgetter:CreativePowerManager(CreativePowerManager::get_Instance))
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

		// Token: 0x06004F02 RID: 20226 RVA: 0x00278874 File Offset: 0x00276A74
		private void WeatherCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
				return;
			}
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x0027889C File Offset: 0x00276A9C
		private void TimeCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
				return;
			}
			CreativePowers.ModifyTimeRate power = CreativePowerManager.Instance.GetPower<CreativePowers.ModifyTimeRate>();
			this.RefreshElementsOrder();
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x002788C4 File Offset: 0x00276AC4
		private void PersonalCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
				return;
			}
			CreativePowers.SpawnRateSliderPerPlayerPower power = CreativePowerManager.Instance.GetPower<CreativePowers.SpawnRateSliderPerPlayerPower>();
			this.RefreshElementsOrder();
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x002788EC File Offset: 0x00276AEC
		private void RefreshElementsOrder()
		{
			this._container.RemoveAllChildren();
			UIElement container = this._container;
			PowerStripUIElement mainPowerStrip = this._mainPowerStrip;
			container.Append(mainPowerStrip);
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.OpenMainSubCategory> mainCategory = this._mainCategory;
			int currentOption = mainCategory.CurrentOption;
			UIElement container2 = this._container;
			int currentOption2 = mainCategory.CurrentOption;
			UICreativeInfiniteItemsDisplay infiniteItemsWindow = this._infiniteItemsWindow;
			UICreativeInfiniteItemsDisplay infiniteItemsWindow2 = this._infiniteItemsWindow;
			this._container.Append(infiniteItemsWindow2);
			int currentOption3 = mainCategory.CurrentOption;
			this._infiniteItemsWindow.SetPageTypeToShow(UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage.InfiniteItemsResearch);
			UICreativeInfiniteItemsDisplay infiniteItemsWindow3 = this._infiniteItemsWindow;
			this._container.Append(infiniteItemsWindow3);
			int currentOption4 = mainCategory.CurrentOption;
			UIElement container3 = this._container;
			PowerStripUIElement timePowersStrip = this._timePowersStrip;
			container3.Append(timePowersStrip);
			int currentOption5 = this._timeCategory.CurrentOption;
			UIElement container4 = this._container;
			int currentOption6 = mainCategory.CurrentOption;
			UIElement container5 = this._container;
			PowerStripUIElement weatherPowersStrip = this._weatherPowersStrip;
			container5.Append(weatherPowersStrip);
			int currentOption7 = this._weatherCategory.CurrentOption;
			UIElement container6 = this._container;
			int currentOption8 = mainCategory.CurrentOption;
			UIElement container7 = this._container;
			PowerStripUIElement personalPowersStrip = this._personalPowersStrip;
			container7.Append(personalPowersStrip);
			UICreativePowersMenu.MenuTree<UICreativePowersMenu.PersonalSubcategory> personalCategory = this._personalCategory;
			this._container.Append(personalPowersStrip);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00278A20 File Offset: 0x00276C20
		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw(spriteBatch);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00278A34 File Offset: 0x00276C34
		public UICreativePowersMenu()
		{
		}

		// Token: 0x040087E4 RID: 34788
		private bool _hovered;

		// Token: 0x040087E5 RID: 34789
		private PowerStripUIElement _mainPowerStrip;

		// Token: 0x040087E6 RID: 34790
		private PowerStripUIElement _timePowersStrip;

		// Token: 0x040087E7 RID: 34791
		private PowerStripUIElement _weatherPowersStrip;

		// Token: 0x040087E8 RID: 34792
		private PowerStripUIElement _personalPowersStrip;

		// Token: 0x040087E9 RID: 34793
		private UICreativeInfiniteItemsDisplay _infiniteItemsWindow;

		// Token: 0x040087EA RID: 34794
		private UIElement _container;

		// Token: 0x040087EB RID: 34795
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.OpenMainSubCategory> _mainCategory;

		// Token: 0x040087EC RID: 34796
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.WeatherSubcategory> _weatherCategory;

		// Token: 0x040087ED RID: 34797
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.TimeSubcategory> _timeCategory;

		// Token: 0x040087EE RID: 34798
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.PersonalSubcategory> _personalCategory;

		// Token: 0x040087EF RID: 34799
		private const int INITIAL_LEFT_PIXELS = 20;

		// Token: 0x040087F0 RID: 34800
		private const int LEFT_PIXELS_PER_STRIP_DEPTH = 60;

		// Token: 0x040087F1 RID: 34801
		private const string STRIP_MAIN = "strip 0";

		// Token: 0x040087F2 RID: 34802
		private const string STRIP_DEPTH_1 = "strip 1";

		// Token: 0x040087F3 RID: 34803
		private const string STRIP_DEPTH_2 = "strip 2";

		// Token: 0x02000A71 RID: 2673
		private class MenuTree<TEnum> where TEnum : struct, IConvertible
		{
			// Token: 0x06004F08 RID: 20232 RVA: 0x00278A48 File Offset: 0x00276C48
			public MenuTree(TEnum defaultValue)
			{
				int num;
				this.CurrentOption = num;
			}

			// Token: 0x040087F4 RID: 34804
			public int CurrentOption;

			// Token: 0x040087F5 RID: 34805
			public Dictionary<int, GroupOptionButton<int>> Buttons;

			// Token: 0x040087F6 RID: 34806
			public Dictionary<int, UIElement> Sliders;
		}

		// Token: 0x02000A72 RID: 2674
		private enum OpenMainSubCategory
		{
			// Token: 0x040087F8 RID: 34808
			None,
			// Token: 0x040087F9 RID: 34809
			InfiniteItems,
			// Token: 0x040087FA RID: 34810
			ResearchWindow,
			// Token: 0x040087FB RID: 34811
			Time,
			// Token: 0x040087FC RID: 34812
			Weather,
			// Token: 0x040087FD RID: 34813
			EnemyStrengthSlider,
			// Token: 0x040087FE RID: 34814
			PersonalPowers
		}

		// Token: 0x02000A73 RID: 2675
		private enum WeatherSubcategory
		{
			// Token: 0x04008800 RID: 34816
			None,
			// Token: 0x04008801 RID: 34817
			WindSlider,
			// Token: 0x04008802 RID: 34818
			RainSlider
		}

		// Token: 0x02000A74 RID: 2676
		private enum TimeSubcategory
		{
			// Token: 0x04008804 RID: 34820
			None,
			// Token: 0x04008805 RID: 34821
			TimeRate
		}

		// Token: 0x02000A75 RID: 2677
		private enum PersonalSubcategory
		{
			// Token: 0x04008807 RID: 34823
			None,
			// Token: 0x04008808 RID: 34824
			EnemySpawnRateSlider
		}
	}
}
