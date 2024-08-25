using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria;
using Terraria.DataStructures;

// Token: 0x020001DB RID: 475
[JsonObject(MemberSerialization.OptIn)]
[Serializable]
public class InterfaceProfile_Layout
{
	// Token: 0x06000C18 RID: 3096 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
	public void InvalidateMinResolution()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
	public int MinVerticalResolution
	{
		get
		{
			if (!true)
			{
			}
			float x = this._minResolution.X;
			float y = this._minResolution.Y;
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			int size = this.RightGroupings._size;
			Rectangle rectangle;
			return rectangle.Bottom;
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0003BFBC File Offset: 0x0003A1BC
	public bool IsPageSelected(GUIPageIcons.Category category)
	{
		/*
An exception occurred when decompiling this method (06000C1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InterfaceProfile_Layout::IsPageSelected(GUIPageIcons/Category)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_3_19, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_4_25, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_7_35, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
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

	// Token: 0x06000C1B RID: 3099 RVA: 0x0003C008 File Offset: 0x0003A208
	public bool LoadSettingRegion(GUIPageIconGrouping.SettingCategory category)
	{
		/*
An exception occurred when decompiling this method (06000C1B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InterfaceProfile_Layout::LoadSettingRegion(GUIPageIconGrouping/SettingCategory)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_2_19, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_3_25, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_5_34, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_7_3F, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_8_47, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this)))
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

	// Token: 0x06000C1C RID: 3100 RVA: 0x0003C060 File Offset: 0x0003A260
	public GUIPageIconGrouping GetSettingGrouping(GUIPageIconGrouping.SettingCategory category)
	{
		/*
An exception occurred when decompiling this method (06000C1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIPageIconGrouping InterfaceProfile_Layout::GetSettingGrouping(GUIPageIconGrouping/SettingCategory)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_2_19, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_3_25, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_5_34, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_7_3F, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this)))
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

	// Token: 0x06000C1D RID: 3101 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
	public GUIPageIconGrouping GetCategoryGrouping(GUIPageIcons.Category category, bool includeOptions = true)
	{
		/*
An exception occurred when decompiling this method (06000C1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIPageIconGrouping InterfaceProfile_Layout::GetCategoryGrouping(GUIPageIcons/Category,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, call:bool(GUIPageIconGrouping::InteractionCategory, ldloc:Category(category)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](var_1_0D)))
	stloc:object(var_4_1D, ldfld:object(List`1::_syncRoot, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](var_1_0D)))
	stloc:int32(var_5_2A, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_6_32, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:int32(var_7_3B, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](var_6_32)))
	stloc:object(var_9_47, ldfld:object(List`1::_syncRoot, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](var_6_32)))
	stloc:int32(var_10_54, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_11_61, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_12_6E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_13_7B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_15_8B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_17_96, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_18_9E, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_19_A6, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(var_20_AE, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>(InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this)))
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

	// Token: 0x06000C1E RID: 3102 RVA: 0x0003C16C File Offset: 0x0003A36C
	public void SetCollapsed(GUIPageIcons.Category category, bool collapsed)
	{
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed = this.GroupsCollapsed;
		if (!true)
		{
		}
		Main.SettingsSavePending = true;
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0003C18C File Offset: 0x0003A38C
	public bool IsCollapsed(GUIPageIcons.Category category)
	{
		if (this.forceEquipmentExpanded)
		{
		}
		if (this.GroupsCollapsed == null)
		{
		}
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed = this.GroupsCollapsed;
		return true;
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
	private bool IsGroupSame(GUIPageIconGrouping dest, GUIPageIconGrouping src, int groupIndex, bool allowFixups)
	{
		/*
An exception occurred when decompiling this method (06000C20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InterfaceProfile_Layout::IsGroupSame(GUIPageIconGrouping,GUIPageIconGrouping,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ControlId(var_0_06, ldfld:ControlId(GUIPageIconGrouping::AnchorControl, ldloc:GUIPageIconGrouping(dest)))
	stloc:ControlId(var_1_0D, ldfld:ControlId(GUIPageIconGrouping::AnchorControl, ldloc:GUIPageIconGrouping(src)))
	stloc:AnchorType(var_2_14, ldfld:AnchorType(GUIPageIconGrouping::Anchor, ldloc:GUIPageIconGrouping(dest)))
	stloc:AnchorType(var_3_1B, ldfld:AnchorType(GUIPageIconGrouping::Anchor, ldloc:GUIPageIconGrouping(src)))
	stloc:float32(var_4_27, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(dest))))
	stloc:float32(var_5_34, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(dest))))
	stloc:float32(var_6_41, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(src))))
	stloc:float32(var_7_4E, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(src))))
	stloc:float32(var_10_5E, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(dest))))
	stloc:float32(var_11_6B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(src))))
	stloc:float32(var_12_78, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(src))))
	stloc:float32(var_13_85, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIPageIconGrouping::Location, ldloc:GUIPageIconGrouping(dest))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_14_8D, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(dest)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_15_95, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(src)))
	stloc:int32(var_16_9E, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>[exp:List`1](var_14_8D)))
	stloc:int32(var_17_A7, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>[exp:List`1](var_15_95)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_19_B2, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(src)))
	stloc:int32(var_20_BF, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>[exp:List`1](GUIPageIconGrouping::AllowedCategories, ldloc:GUIPageIconGrouping(dest))))
	stloc:int32(var_21_CC, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>[exp:List`1](GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(src))))
	stloc:int32(var_22_D9, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>[exp:List`1](GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(dest))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(var_24_E4, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(src)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(var_25_EC, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(dest)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(var_26_F4, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(src)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(var_27_FC, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(GUIPageIconGrouping::SettingEntries, ldloc:GUIPageIconGrouping(dest)))
	stloc:int32(var_29_108, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>[exp:List`1](var_27_FC)))
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

	// Token: 0x06000C21 RID: 3105 RVA: 0x0003C2D0 File Offset: 0x0003A4D0
	private bool IsGroupListSame(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool allowFixups, int groupOffset = 0)
	{
		/*
An exception occurred when decompiling this method (06000C21)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InterfaceProfile_Layout::IsGroupListSame(System.Collections.Generic.List`1<GUIPageIconGrouping>,System.Collections.Generic.List`1<GUIPageIconGrouping>,System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](dest)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](src)))
	stloc:int32(var_4_16, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](src)))
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

	// Token: 0x06000C22 RID: 3106 RVA: 0x0003C2FC File Offset: 0x0003A4FC
	public bool IsSame(InterfaceProfile_Layout other, bool allowFixups = false)
	{
		int verticalResolution = this.VerticalResolution;
		int verticalResolution2 = other.VerticalResolution;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = other.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings3 = this.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = other.RightGroupings;
		int size = leftGroupings3._size;
		bool flag;
		return flag;
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0003C358 File Offset: 0x0003A558
	private void CopyGroup(GUIPageIconGrouping dest, GUIPageIconGrouping src, bool copySerialiseSettings = false)
	{
		ControlAnchor.ControlId anchorControl = src.AnchorControl;
		List<GUIPageIcons.Category> allowedCategories = dest.AllowedCategories;
		dest.AnchorControl = anchorControl;
		Vector2 location = src.Location;
		dest.Location = location;
		int version = allowedCategories._version;
		allowedCategories._syncRoot = version;
		List<GUIPageIcons.Category> allowedCategories2 = src.AllowedCategories;
		List<GUIPageIconGrouping.SettingCategory> settingEntries = dest.SettingEntries;
		int version2 = settingEntries._version;
		settingEntries._syncRoot = version2;
		List<GUIPageIconGrouping.SettingCategory> settingEntries2 = src.SettingEntries;
		GUIPageIcons.Category lastSelectedCategory = src._lastSelectedCategory;
		bool lastSelectedSet = src._lastSelectedSet;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x000021DB File Offset: 0x000003DB
	private void CopyGroupList(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool copySerialiseSettings = false)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0003C3E8 File Offset: 0x0003A5E8
	public void Copy(InterfaceProfile_Layout other, bool copySerialiseSettings = false)
	{
		int verticalResolution = other.VerticalResolution;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		this.VerticalResolution = verticalResolution;
		List<GUIPageIconGrouping> leftGroupings2 = other.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = other.RightGroupings;
		Dictionary<GUIPageIcons.Category, bool> groupsCollapsed = this.GroupsCollapsed;
		if (other.GroupsCollapsed != null)
		{
			Dictionary<GUIPageIcons.Category, bool> groupsCollapsed2 = this.GroupsCollapsed;
			return;
		}
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0003C490 File Offset: 0x0003A690
	private void CleanGroupList(List<GUIPageIconGrouping> dest, bool touchProfile)
	{
		int size = dest._size;
		if (14 == 0)
		{
		}
		int version = dest._version;
		dest._version = version;
		Rectangle rectangle;
		int bottom = rectangle.Bottom;
		int size2 = dest._size;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0003C4D4 File Offset: 0x0003A6D4
	public void Clean(bool touchProfile = false)
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		this.CleanGroupList(leftGroupings, touchProfile);
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		this.CleanGroupList(rightGroupings, touchProfile);
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0003C504 File Offset: 0x0003A704
	public void OpenUI(GUIPageIcons.Category left, GUIPageIcons.Category right)
	{
		bool flag = GUIPageIconGrouping.InteractionCategory(left);
		bool flag2 = GUIPageIconGrouping.InteractionCategory(right);
		this.RefreshAllItems();
		int size = this.LeftGroupings._size;
		object syncRoot = this.LeftGroupings._syncRoot;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0003C618 File Offset: 0x0003A818
	public void Close(bool shutdown = false)
	{
		int size = this.LeftGroupings._size;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings3 = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings4 = this.LeftGroupings;
		int size2 = this.LeftGroupings._size;
		int size3 = this.RightGroupings._size;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings3 = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings4 = this.RightGroupings;
		int size4 = this.RightGroupings._size;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0003C6A4 File Offset: 0x0003A8A4
	public GUIPageIcons.Category GetFirstSelectedCategory()
	{
		int size = this.LeftGroupings._size;
		int size2 = this.LeftGroupings._size;
		int size3 = this.RightGroupings._size;
		int size4 = this.RightGroupings._size;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		GUIPageIcons.Category category;
		return category;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0003C700 File Offset: 0x0003A900
	public bool AnyOpen()
	{
		/*
An exception occurred when decompiling this method (06000C2B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InterfaceProfile_Layout::AnyOpen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_3_19, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::LeftGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_4_25, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
	stloc:int32(var_7_35, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIPageIconGrouping>[exp:List`1](InterfaceProfile_Layout::RightGroupings, ldloc:InterfaceProfile_Layout(this))))
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

	// Token: 0x06000C2C RID: 3116 RVA: 0x000021DB File Offset: 0x000003DB
	private void AddAvailable(GUIPageIcons.Category category)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0003C74C File Offset: 0x0003A94C
	public void RefreshAllItems()
	{
		int size = this.LeftGroupings._size;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings3 = this.LeftGroupings;
		if (size == 0)
		{
		}
		int gameMode = Main.GameMode;
		List<GUIPageIconGrouping> leftGroupings4 = this.LeftGroupings;
		int size2 = this.LeftGroupings._size;
		int size3 = this.RightGroupings._size;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings3 = this.RightGroupings;
		if (size3 == 0)
		{
		}
		int gameMode2 = Main.GameMode;
		List<GUIPageIconGrouping> rightGroupings4 = this.RightGroupings;
		int size4 = this.RightGroupings._size;
		if (size4 == 0)
		{
		}
		int gameMode3 = Main.GameMode;
		if (size4 == 0)
		{
		}
		bool inGuideCraftMenu = Main.InGuideCraftMenu;
		if (size4 == 0)
		{
		}
		bool inReforgeMenu = Main.InReforgeMenu;
		if (size4 == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (size4 == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
			if (size4 == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			Tile tile;
			ushort type = tile.type;
			int myPlayer5 = Main.myPlayer;
			TileEntity tileEntity2;
			if (tileEntity2 != null)
			{
			}
			return;
		}
		int myPlayer6 = Main.myPlayer;
		if (Main.npcShop != 0)
		{
		}
		int size5 = this.LeftGroupings._size;
		int size6 = this.LeftGroupings._size;
		int size7 = this.RightGroupings._size;
		int size8 = this.RightGroupings._size;
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
	public void DrawClosed()
	{
		if (this.forceEquipmentExpanded)
		{
		}
		int size = this.LeftGroupings._size;
		int size2 = this.LeftGroupings._size;
		int size3 = this.RightGroupings._size;
		int size4 = this.RightGroupings._size;
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0003C910 File Offset: 0x0003AB10
	public void Draw()
	{
		int num = 1;
		bool flag = this.forceEquipmentExpanded;
		if (num == 0)
		{
		}
		bool isAir = Main.mouseItem.IsAir;
		if (flag)
		{
			Item mouseItem = Main.mouseItem;
			return;
		}
		Item mouseItem2 = Main.mouseItem;
		int num2 = 1;
		this.forceEquipmentExpanded = num2 != 0;
		int size = this.LeftGroupings._size;
		int size2 = this.LeftGroupings._size;
		int size3 = this.RightGroupings._size;
		int size4 = this.RightGroupings._size;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int size5 = this.LeftGroupings._size;
		int size6 = this.LeftGroupings._size;
		int size7 = this.RightGroupings._size;
		int size8 = this.RightGroupings._size;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
	public void DrawEdit()
	{
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0003CB88 File Offset: 0x0003AD88
	public void LeftRightPageController()
	{
		GUIPageIcons.Category categoryFromActiveController = GUIPageIconGrouping.GetCategoryFromActiveController();
		int size = this.LeftGroupings._size;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		int size2 = this.LeftGroupings._size;
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0003CD70 File Offset: 0x0003AF70
	public GUIControllerItem GetGroupUp(GUIPageIconGrouping sourceGroup, int column)
	{
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings3 = this.LeftGroupings;
		int size = this.LeftGroupings._size;
		float x = sourceGroup.Location.X;
		List<GUIPageIconGrouping> leftGroupings4 = this.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings3 = this.RightGroupings;
		int size2 = this.RightGroupings._size;
		float x2 = sourceGroup.Location.X;
		List<GUIPageIconGrouping> rightGroupings4 = this.RightGroupings;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
	public GUIControllerItem GetGroupDown(GUIPageIconGrouping sourceGroup, int column)
	{
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		int size = this.LeftGroupings._size;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		int size2 = this.LeftGroupings._size;
		float x = sourceGroup.Location.X;
		List<GUIPageIconGrouping> leftGroupings3 = this.LeftGroupings;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		int size3 = this.RightGroupings._size;
		List<GUIPageIconGrouping> rightGroupings2 = this.RightGroupings;
		int size4 = this.RightGroupings._size;
		float x2 = sourceGroup.Location.X;
		List<GUIPageIconGrouping> rightGroupings3 = this.RightGroupings;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x0003CE88 File Offset: 0x0003B088
	public GUIControllerItem GetGroupLeft(GUIPageIconGrouping sourceGroup, int row)
	{
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		int size = this.LeftGroupings._size;
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		List<GUIPageIconGrouping> leftGroupings2 = this.LeftGroupings;
		float y = sourceGroup.Location.Y;
		int version = leftGroupings2._version;
		int size2 = this.LeftGroupings._size;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
	public GUIControllerItem GetGroupRight(GUIPageIconGrouping sourceGroup, int row)
	{
		List<GUIPageIconGrouping> leftGroupings = this.LeftGroupings;
		int size = this.RightGroupings._size;
		List<GUIPageIconGrouping> rightGroupings = this.RightGroupings;
		List<GUIPageIconGrouping> rightGroupings2 = this.RightGroupings;
		float y = sourceGroup.Location.Y;
		int version = rightGroupings2._version;
		int size2 = this.RightGroupings._size;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x0003CF48 File Offset: 0x0003B148
	public InterfaceProfile_Layout()
	{
	}

	// Token: 0x04001109 RID: 4361
	[JsonProperty(null)]
	public string ProfileName;

	// Token: 0x0400110A RID: 4362
	[JsonProperty("Resolution")]
	public int VerticalResolution;

	// Token: 0x0400110B RID: 4363
	private Vector2 _minResolution;

	// Token: 0x0400110C RID: 4364
	private bool forceEquipmentExpanded;

	// Token: 0x0400110D RID: 4365
	[JsonProperty("Collapsed")]
	public Dictionary<GUIPageIcons.Category, bool> GroupsCollapsed;

	// Token: 0x0400110E RID: 4366
	[JsonProperty("Left")]
	public List<GUIPageIconGrouping> LeftGroupings;

	// Token: 0x0400110F RID: 4367
	[JsonProperty("Right")]
	public List<GUIPageIconGrouping> RightGroupings;
}
