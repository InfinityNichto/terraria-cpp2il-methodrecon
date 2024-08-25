using System;
using Microsoft.Xna.Framework;

// Token: 0x02000086 RID: 134
public class GUIControllerAchievements : GUIControllerItem
{
	// Token: 0x0600033C RID: 828 RVA: 0x0000AB00 File Offset: 0x00008D00
	public void Activate()
	{
		this.selectedControl = GUIControllerAchievements.Controls.Element;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0000AB14 File Offset: 0x00008D14
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0000AB24 File Offset: 0x00008D24
	private void UpdateScroll()
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0000AB34 File Offset: 0x00008D34
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600033F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerAchievements::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Controls(var_0_06, ldfld:Controls(GUIControllerAchievements::selectedControl, ldloc:GUIControllerAchievements(this)))
	stloc:int32(var_1_08, ldc.i4:int32(4))
	stfld:Controls(GUIControllerAchievements::selectedControl, ldloc:GUIControllerAchievements(this), ldloc:int32[exp:Controls](var_1_08))
	stloc:int32(var_2_11, ldc.i4:int32(4))
	stfld:Controls(GUIControllerAchievements::selectedControl, ldloc:GUIControllerAchievements(this), ldloc:int32[exp:Controls](var_2_11))
	stloc:int32(var_3_1A, ldc.i4:int32(5))
	stfld:Controls(GUIControllerAchievements::selectedControl, ldloc:GUIControllerAchievements(this), ldloc:int32[exp:Controls](var_3_1A))
	stloc:int32(var_4_23, ldc.i4:int32(5))
	stfld:Controls(GUIControllerAchievements::selectedControl, ldloc:GUIControllerAchievements(this), ldloc:int32[exp:Controls](var_4_23))
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

	// Token: 0x06000340 RID: 832 RVA: 0x0000AB70 File Offset: 0x00008D70
	public Rectangle GetSelectedItemRegion()
	{
		GUIControllerAchievements.Controls controls = this.selectedControl;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000AB88 File Offset: 0x00008D88
	public GUIControllerAchievements()
	{
	}

	// Token: 0x0400033E RID: 830
	public GUIControllerAchievements.Controls selectedControl = GUIControllerAchievements.Controls.Element;

	// Token: 0x02000087 RID: 135
	public enum Controls
	{
		// Token: 0x04000340 RID: 832
		FilterSlayer,
		// Token: 0x04000341 RID: 833
		FilterCollector,
		// Token: 0x04000342 RID: 834
		FilterExplorer,
		// Token: 0x04000343 RID: 835
		FilterChallenger,
		// Token: 0x04000344 RID: 836
		Element,
		// Token: 0x04000345 RID: 837
		Back
	}
}
