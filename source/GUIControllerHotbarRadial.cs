using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200008F RID: 143
public class GUIControllerHotbarRadial : GUIControllerItem
{
	// Token: 0x0600037D RID: 893 RVA: 0x0000B76C File Offset: 0x0000996C
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0000B77C File Offset: 0x0000997C
	public void Activate()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0000B7D8 File Offset: 0x000099D8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600037F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerHotbarRadial::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stloc:int32(var_10_41, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_11_49, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_12_51, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_13_59, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_13_59))
	stloc:int32(var_14_69, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_15_71, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_15_71))
	stloc:int32(var_16_81, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_17_89, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_17_89))
	stloc:int32(var_18_99, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_18_99))
	stloc:int32(var_20_AD, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_21_B5, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:int32(var_22_BD, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_22_BD))
	stloc:int32(var_23_CD, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this), ldloc:int32(var_23_CD))
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

	// Token: 0x06000380 RID: 896 RVA: 0x0000B8BC File Offset: 0x00009ABC
	public int GetSelectedItem()
	{
		bool flag = this.hotbarMode;
		int num = this.selectedColumn;
		if (!flag)
		{
			int num2 = this.selectedRow;
			return num;
		}
		return num;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0000B910 File Offset: 0x00009B10
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000381)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerHotbarRadial::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00BB:
	stloc:String_Layout(var_24_C2, ldfld:String_Layout(Hotbar_Layout::Title, ldloc:Hotbar_Layout(var_11)))
	stloc:!0(var_25_C9, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_28_D4, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:!0(var_29_DB, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_30_E2, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_31_E9, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_33_F1, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:!0(var_34_F8, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_35_FF, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_36_106, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_38_10E, ldfld:int32(GUIControllerHotbarRadial::selectedColumn, ldloc:GUIControllerHotbarRadial(this)))
	stloc:!0(var_39_115, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_40_11D, ldfld:int32(GUIControllerHotbarRadial::selectedRow, ldloc:GUIControllerHotbarRadial(this)))
	stloc:!0(var_41_124, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000382 RID: 898 RVA: 0x0000BA44 File Offset: 0x00009C44
	public GUIControllerHotbarRadial()
	{
	}

	// Token: 0x04000363 RID: 867
	private bool hotbarMode;

	// Token: 0x04000364 RID: 868
	private int selectedRow;

	// Token: 0x04000365 RID: 869
	private int selectedColumn;
}
