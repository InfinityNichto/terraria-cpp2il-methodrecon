using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Terraria;

// Token: 0x0200015F RID: 351
[JsonObject(MemberSerialization.OptIn)]
[Serializable]
public class GUIPageIconGrouping
{
	// Token: 0x060009A2 RID: 2466 RVA: 0x0002D29C File Offset: 0x0002B49C
	public void LoadPageAnchor()
	{
		RightSideHUDAnchorUpdator.Update();
		ControlAnchor.ControlId anchorControl = this.AnchorControl;
		Vector2 location = this.Location;
		float x = this.Location.X;
		float y = this.Location.Y;
		if (!true)
		{
		}
		LayoutCalculator.AnchorType anchor = this.Anchor;
		this.LoadPageRegion();
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
	public Rectangle GetRegion()
	{
		/*
An exception occurred when decompiling this method (060009A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIPageIconGrouping::GetRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUIPageIconGrouping::LoadPageAnchor, ldloc:GUIPageIconGrouping(this))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_1_0C, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(this)))
	stloc:Category(var_2_13, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this)))
	stloc:InterfaceProfile_Layout(var_4_1B, callgetter:InterfaceProfile_Layout(InterfaceStyles_Layout::get_Active))
	stloc:Category(var_5_23, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this)))
	stloc:bool(var_6_30, call:bool(GUIPageIconGrouping::CanCollapse, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this))))
	stloc:Category(var_7_38, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this)))
	stloc:bool(var_8_43, call:bool(InterfaceProfile_Layout::IsCollapsed, ldloc:InterfaceProfile_Layout(var_4_1B), ldloc:Category(var_7_38)))
	stloc:InterfaceProfile_Layout(var_10_4D, callgetter:InterfaceProfile_Layout(InterfaceStyles_Layout::get_Active))
	stloc:Category(var_11_55, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this)))
	stloc:bool(var_12_62, call:bool(GUIPageIconGrouping::CanCollapse, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this))))
	stloc:Category(var_13_6A, callgetter:Category(GUIPageIconGrouping::get_SelectedCategory, ldloc:GUIPageIconGrouping(this)))
	stloc:bool(var_14_75, call:bool(InterfaceProfile_Layout::IsCollapsed, ldloc:InterfaceProfile_Layout(var_10_4D), ldloc:Category(var_13_6A)))
	stloc:ControlId(var_15_7D, ldfld:ControlId(GUIPageIconGrouping::AnchorControl, ldloc:GUIPageIconGrouping(this)))
	stloc:Vector2(var_16_85, ldfld:Vector2(GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this)))
	stloc:float32(var_17_92, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this))))
	stloc:float32(var_18_9F, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this))))
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

	// Token: 0x060009A4 RID: 2468 RVA: 0x0002D398 File Offset: 0x0002B598
	public Rectangle GetUIScaleRegion()
	{
		/*
An exception occurred when decompiling this method (060009A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIPageIconGrouping::GetUIScaleRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUIPageIconGrouping::LoadPageAnchor, ldloc:GUIPageIconGrouping(this))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_1_0C, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(this)))
	stloc:ControlId(var_2_13, ldfld:ControlId(GUIPageIconGrouping::AnchorControl, ldloc:GUIPageIconGrouping(this)))
	stloc:Vector2(var_3_1A, ldfld:Vector2(GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this)))
	stloc:float32(var_4_26, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this))))
	stloc:float32(var_5_33, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(this))))
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

	// Token: 0x060009A5 RID: 2469 RVA: 0x0002D3DC File Offset: 0x0002B5DC
	public void LoadSettingAnchor(GUIPageIconGrouping.SettingCategory category)
	{
		this.LoadPageAnchor();
		int num = 1;
		this.LoadColourState(num != 0);
		List<GUIPageIconGrouping.SettingCategory> settings = this._settings;
		float x = this.pageButtonRegionSize.X;
		float y = this.pageButtonRegionSize.Y;
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x0002D418 File Offset: 0x0002B618
	public GUIControllerItem GetControllerNavigateController(int row, int column)
	{
		/*
An exception occurred when decompiling this method (060009A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPageIconGrouping::GetControllerNavigateController(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006B:
	stfld:int32(GUIControllerPageGroup::MenuRow, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, ldloc:GUIPageIconGrouping(this)), ldloc:int32(var_11))
	stloc:GUIControllerPageGroup(var_24_7E, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, ldloc:GUIPageIconGrouping(this)))
	stloc:int32(var_25_81, ldc.i4:int32(1))
	call:void(GUIControllerPageGroup::ClampMenuItem, ldloc:GUIControllerPageGroup(var_24_7E), ldloc:int32[exp:bool](var_25_81))
	stloc:GUIControllerPageGroup(var_26_92, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, ldloc:GUIPageIconGrouping(this)))
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

	// Token: 0x060009A7 RID: 2471 RVA: 0x0002D4B8 File Offset: 0x0002B6B8
	private void LoadPageRegion()
	{
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
	public bool LeftSideGrouping
	{
		get
		{
			/*
An exception occurred when decompiling this method (060009A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageIconGrouping::get_LeftSideGrouping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AnchorType(var_0_06, ldfld:AnchorType(GUIPageIconGrouping::Anchor, ldloc:GUIPageIconGrouping(this)))
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

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
	public List<GUIPageIconGrouping.SettingCategory> SettingList
	{
		get
		{
			return this._settings;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002D50C File Offset: 0x0002B70C
	public GUIControllerPageGroup MenuController
	{
		get
		{
			/*
An exception occurred when decompiling this method (060009AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerPageGroup GUIPageIconGrouping::get_MenuController()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerPageGroup[exp:bool](GUIPageIconGrouping::_menuController, ldloc:GUIPageIconGrouping(this)))
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
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0002D520 File Offset: 0x0002B720
	public GUIControllerItem NavigateRight(int row)
	{
		if (!true)
		{
		}
		return InterfaceStyles_Layout.Active.GetGroupRight(this, row);
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0002D540 File Offset: 0x0002B740
	public GUIControllerItem NavigateLeft(int row)
	{
		if (!true)
		{
		}
		return InterfaceStyles_Layout.Active.GetGroupLeft(this, row);
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0002D560 File Offset: 0x0002B760
	public GUIControllerItem NavigateUp(int row)
	{
		if (!true)
		{
		}
		return InterfaceStyles_Layout.Active.GetGroupUp(this, row);
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0002D580 File Offset: 0x0002B780
	public GUIControllerItem NavigateDown(int row)
	{
		if (!true)
		{
		}
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002D59C File Offset: 0x0002B79C
	public List<GUIPageIcons.Category> Options
	{
		get
		{
			return this._options;
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
	public GUIPageIcons.Category LastSelectedCategory
	{
		get
		{
			/*
An exception occurred when decompiling this method (060009B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIPageIcons/Category GUIPageIconGrouping::get_LastSelectedCategory()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_2_23, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::_options, ldloc:GUIPageIconGrouping(this)))
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
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0002D5E0 File Offset: 0x0002B7E0
	// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0002D608 File Offset: 0x0002B808
	public GUIPageIcons.Category SelectedCategory
	{
		get
		{
			GUIPageIcons.Category selectedCategory = this._selectedCategory;
			GUIPageIcons.Category selectedCategory2 = this._selectedCategory;
			return GUIPageIcons.Category.Housing;
		}
		set
		{
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			GUIPageIconGrouping guipageIconGrouping;
			GUIPageIcons.Category preHousingCategory = guipageIconGrouping._preHousingCategory;
			GUIPageIcons.Category selectedCategory = this._selectedCategory;
			GUIPageIcons.Category selectedCategory2 = this._selectedCategory;
			this._preHousingCategory = selectedCategory2;
			if (selectedCategory2 == GUIPageIcons.Category.Crafting)
			{
				return;
			}
			long num = 0L;
			if (!this.ignoreShutdown)
			{
			}
			GUIPageIcons.Category selectedCategory3 = this._selectedCategory;
			this._selectedCategory = value;
			if (!this.ignoreClose)
			{
			}
			if (this.ignoreShutdown)
			{
				if (num == 0L)
				{
					return;
				}
			}
			else if (num == 0L)
			{
				return;
			}
			if (this._selectedCategory == GUIPageIcons.Category.Crafting)
			{
				return;
			}
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0002D69C File Offset: 0x0002B89C
	public Vector2 PageButtonSize
	{
		get
		{
			float x = this.pageButtonRegionSize.X;
			float y = this.pageButtonRegionSize.Y;
			Vector2 vector;
			return vector;
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
	public static GUIPageIcons.Category GetCategoryFromActiveController()
	{
		GUIPageIcons.Category category;
		return category;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
	public void ActivateController(bool pageContent = false)
	{
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
		GUIControllerPageGroup menuController = this.MenuController;
		GUIControllerPageGroup menuController2 = this.MenuController;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0002D730 File Offset: 0x0002B930
	private void LoadColourState(bool pageContent = true)
	{
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000021DB File Offset: 0x000003DB
	public void DrawClosed()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0002D76C File Offset: 0x0002B96C
	public void Draw()
	{
		this.LoadPageAnchor();
		Rectangle rectangle;
		Vector2 vector = rectangle.Size();
		long num = 0L;
		this.LoadColourState(num != 0L);
		this.DrawPageIcons();
		this.LoadPageAnchor();
		this.LoadColourState(true);
		this.DrawPageContent();
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0002D7B4 File Offset: 0x0002B9B4
	public void DrawEdit()
	{
		List<GUIPageIcons.Category> options = this._options;
		int version = options._version;
		options._syncRoot = version;
		List<GUIPageIcons.Category> allowedCategories = this.AllowedCategories;
		List<GUIPageIconGrouping.SettingCategory> settings = this._settings;
		int version2 = settings._version;
		settings._syncRoot = version2;
		List<GUIPageIconGrouping.SettingCategory> settingEntries = this.SettingEntries;
		int size = this._options._size;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0002D850 File Offset: 0x0002BA50
	public GUIControllerItem NavigateFromMenuIntoPage(int MenuRow)
	{
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
		GUIControllerItem guicontrollerItem;
		if (guicontrollerItem != null)
		{
		}
		return guicontrollerItem;
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x000021DB File Offset: 0x000003DB
	private float PageScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0002D868 File Offset: 0x0002BA68
	public static bool CanCollapse(GUIPageIcons.Category category)
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0002D878 File Offset: 0x0002BA78
	private void PageOver(int index)
	{
		List<GUIPageIcons.Category> options = this._options;
		this.HoverCategory = options;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
		List<GUIPageIcons.Category> options2 = this._options;
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIPageIcons.Category selectedCategory2 = this.SelectedCategory;
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		GUIPageIcons.Category selectedCategory3 = this.SelectedCategory;
		bool flag = GUIPageIconGrouping.CanCollapse(this.SelectedCategory);
		GUIPageIcons.Category selectedCategory4 = this.SelectedCategory;
		bool flag2 = active.IsCollapsed(selectedCategory4);
		GUIPageIcons.Category selectedCategory5 = this.SelectedCategory;
		active.SetCollapsed(selectedCategory5, true);
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x0002D998 File Offset: 0x0002BB98
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		List<GUIPageIcons.Category> options = this._options;
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
		List<GUIPageIcons.Category> options2 = this._options;
		List<GUIPageIcons.Category> options3 = this._options;
		GUIPageIcons.Category hoverCategory = this.HoverCategory;
		float x = this.pageButtonRegionSize.X;
		float y = this.pageButtonRegionSize.Y;
		GUIPageIcons.Category selectedCategory2 = this.SelectedCategory;
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x0002DA1C File Offset: 0x0002BC1C
	private string GetPageString(GUIPageIcons.Category category)
	{
		return "NPCName.Guide";
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0002DAD8 File Offset: 0x0002BCD8
	private void DrawPageIcons()
	{
		List<GUIPageIcons.Category> options = this._options;
		this.HoverCategory = GUIPageIcons.Category.None;
		int size = options._size;
		List<GUIPageIcons.Category> options2 = this._options;
		float x = this.pageButtonRegionSize.X;
		float y = this.pageButtonRegionSize.Y;
		int size2 = options2._size;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x0002DB24 File Offset: 0x0002BD24
	private void DrawPageContent()
	{
		if (!true)
		{
		}
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0002DB50 File Offset: 0x0002BD50
	public static bool InteractionCategory(GUIPageIcons.Category cat)
	{
		return true;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0002DB60 File Offset: 0x0002BD60
	private int SortCategory(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		List<GUIPageIcons.Category> allowedCategories = this.AllowedCategories;
		if (3 == 0)
		{
			List<GUIPageIcons.Category> allowedCategories2 = this.AllowedCategories;
			List<GUIPageIcons.Category> allowedCategories3 = this.AllowedCategories;
		}
		List<GUIPageIcons.Category> allowedCategories4 = this.AllowedCategories;
		if (3 == 0)
		{
			List<GUIPageIcons.Category> allowedCategories5 = this.AllowedCategories;
			List<GUIPageIcons.Category> allowedCategories6 = this.AllowedCategories;
		}
		int num;
		return num;
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
	public void SortOptionsAndRefresh()
	{
		if (this.Sorter == null)
		{
		}
		List<GUIPageIcons.Category> options = this._options;
		List<GUIPageIcons.Category> options2 = this._options;
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
		GUIPageIcons.Category selectedCategory2 = this.SelectedCategory;
		GUIPageIcons.Category selectedCategory3 = this.SelectedCategory;
		int size = this._options._size;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0002DC08 File Offset: 0x0002BE08
	public void DrawOptions()
	{
		int num = 1;
		this.LoadColourState(num != 0);
		this.LoadPageAnchor();
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0002DD64 File Offset: 0x0002BF64
	private void LoadTransactionButtonColour(TransactionButton_Layout layout, Color Normal, Color Pressed, Color Disabled)
	{
		layout.Color = Normal;
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x0002DD78 File Offset: 0x0002BF78
	public void DrawEditOptions()
	{
		int num = 1;
		this.LoadColourState(num != 0);
		this.LoadPageAnchor();
		GUIPageIcons.Category selectedCategory = this.SelectedCategory;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0002DE80 File Offset: 0x0002C080
	public GUIPageIconGrouping()
	{
	}

	// Token: 0x04000966 RID: 2406
	[JsonProperty]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000967 RID: 2407
	[JsonProperty]
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04000968 RID: 2408
	[JsonProperty]
	public Vector2 Location = 9;

	// Token: 0x04000969 RID: 2409
	[JsonProperty]
	public List<GUIPageIcons.Category> AllowedCategories;

	// Token: 0x0400096A RID: 2410
	[JsonProperty]
	public List<GUIPageIconGrouping.SettingCategory> SettingEntries;

	// Token: 0x0400096B RID: 2411
	private List<GUIPageIconGrouping.SettingCategory> _settings;

	// Token: 0x0400096C RID: 2412
	private GUIControllerPageGroup _menuController;

	// Token: 0x0400096D RID: 2413
	private List<GUIPageIcons.Category> _options;

	// Token: 0x0400096E RID: 2414
	private GUIPageIcons.Category _selectedCategory = GUIPageIcons.Category.None;

	// Token: 0x0400096F RID: 2415
	[JsonProperty("LastSelectedSet")]
	public bool _lastSelectedSet;

	// Token: 0x04000970 RID: 2416
	[JsonProperty("LastSelectedCategory")]
	public GUIPageIcons.Category _lastSelectedCategory;

	// Token: 0x04000971 RID: 2417
	private GUIPageIcons.Category _preHousingCategory;

	// Token: 0x04000972 RID: 2418
	public bool ignoreClose;

	// Token: 0x04000973 RID: 2419
	public bool ignoreShutdown;

	// Token: 0x04000974 RID: 2420
	private GUIPageIcons.Category HoverCategory = GUIPageIcons.Category.None;

	// Token: 0x04000975 RID: 2421
	private Vector2 pageButtonRegionSize;

	// Token: 0x04000976 RID: 2422
	private bool drawEdit;

	// Token: 0x04000977 RID: 2423
	private Comparison<GUIPageIcons.Category> Sorter;

	// Token: 0x02000160 RID: 352
	public enum SettingCategory
	{
		// Token: 0x04000979 RID: 2425
		Settings,
		// Token: 0x0400097A RID: 2426
		JM,
		// Token: 0x0400097B RID: 2427
		Invalid,
		// Token: 0x0400097C RID: 2428
		InfoAccessories,
		// Token: 0x0400097D RID: 2429
		Bestiary,
		// Token: 0x0400097E RID: 2430
		Map,
		// Token: 0x0400097F RID: 2431
		HousingMenu,
		// Token: 0x04000980 RID: 2432
		Chat,
		// Token: 0x04000981 RID: 2433
		Emotes,
		// Token: 0x04000982 RID: 2434
		None
	}
}
