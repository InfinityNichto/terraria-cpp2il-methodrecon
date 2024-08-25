using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000BA RID: 186
public class GUIControllerCrafting : GUIPageContentController
{
	// Token: 0x06000470 RID: 1136 RVA: 0x0000E238 File Offset: 0x0000C438
	public GUIControllerCrafting()
	{
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0000E248 File Offset: 0x0000C448
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0000E258 File Offset: 0x0000C458
	public override void Activate()
	{
		int focusRecipe = Main.focusRecipe;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0000E27C File Offset: 0x0000C47C
	public virtual void RefreshScrollOffset()
	{
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0000E2CC File Offset: 0x0000C4CC
	protected virtual void UpdateScroll()
	{
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000475 RID: 1141 RVA: 0x000021DB File Offset: 0x000003DB
	private int MinRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000476 RID: 1142 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinColumns
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0000E324 File Offset: 0x0000C524
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.itemColumn;
		int num2 = this.itemColumn;
		int num3 = this.itemColumn;
		this.itemColumn = num3;
		int num4 = this.itemRow;
		int num5 = this.itemRow;
		this.itemRow = num5;
		int num6 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0000E370 File Offset: 0x0000C570
	protected virtual void ClampPosition()
	{
		int num = this.itemColumn;
		int num2;
		this.itemColumn = num2;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000479)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerCrafting::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_3_10, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_4_16, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_5_1D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_7_24, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_8_2B, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x0400043F RID: 1087
	public int itemRow;

	// Token: 0x04000440 RID: 1088
	public int itemColumn;

	// Token: 0x04000441 RID: 1089
	public int scrollOffset;
}
