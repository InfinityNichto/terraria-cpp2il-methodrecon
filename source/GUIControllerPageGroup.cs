using System;
using Microsoft.Xna.Framework;

// Token: 0x020000D2 RID: 210
public class GUIControllerPageGroup : GUIControllerItem
{
	// Token: 0x06000543 RID: 1347 RVA: 0x00010260 File Offset: 0x0000E460
	public GUIControllerPageGroup(GUIPageIconGrouping grouping)
	{
		this.Grouping = grouping;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0001027C File Offset: 0x0000E47C
	public void Activate()
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0001028C File Offset: 0x0000E48C
	public int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (06000545)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageGroup::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPageIconGrouping(var_0_06, ldfld:GUIPageIconGrouping(GUIControllerPageGroup::Grouping, ldloc:GUIControllerPageGroup(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerPageGroup::MenuRow, ldloc:GUIControllerPageGroup(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>(GUIPageIconGrouping::_settings, ldloc:GUIPageIconGrouping(var_0_06)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(var_3_1B, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>(GUIPageIconGrouping::_options, ldloc:GUIPageIconGrouping(var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIconGrouping/SettingCategory>[exp:List`1](var_2_14)))
	stloc:int32(var_5_2A, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype GUIPageIcons/Category>[exp:List`1](var_3_1B)))
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

	// Token: 0x06000546 RID: 1350 RVA: 0x000102C4 File Offset: 0x0000E4C4
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIPageIconGrouping grouping = this.Grouping;
		LayoutCalculator.AnchorType anchor = grouping.Anchor;
		int menuRow = this.MenuRow;
		if (grouping.NavigateFromMenuIntoPage(menuRow) == null)
		{
			GUIPageIconGrouping grouping2 = this.Grouping;
			int menuRow2 = this.MenuRow;
			GUIControllerItem guicontrollerItem = grouping2.NavigateLeft(menuRow2);
			if (guicontrollerItem == null)
			{
				return guicontrollerItem;
			}
		}
		GUIControllerItem guicontrollerItem2;
		while (guicontrollerItem2 != null)
		{
		}
		return guicontrollerItem2;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x000103C8 File Offset: 0x0000E5C8
	public void ClampMenuItem(bool preferUp = true)
	{
		int menuRow = this.MenuRow;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00010420 File Offset: 0x0000E620
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000548)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerPageGroup::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stloc:int32(var_4_3B, ldfld:int32(GUIControllerPageGroup::MenuRow, ldloc:GUIControllerPageGroup(this)))
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

	// Token: 0x0400047E RID: 1150
	private readonly GUIPageIconGrouping Grouping;

	// Token: 0x0400047F RID: 1151
	public int MenuRow;
}
