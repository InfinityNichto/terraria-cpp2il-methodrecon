using System;
using Microsoft.Xna.Framework;

// Token: 0x0200009A RID: 154
public class GUIControllerMultiplayerLobby : GUIControllerItem
{
	// Token: 0x060003AE RID: 942 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
	public void Activate()
	{
		this.selectedControl = 4;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0000C104 File Offset: 0x0000A304
	private void UpdateScroll()
	{
		bool flag = DrPlatform.IsCurrentPlatform((DrPlatform.DrPlatformType)928);
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x0000C120 File Offset: 0x0000A320
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerMultiplayerLobby::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerMultiplayerLobby::selectedControl, ldloc:GUIControllerMultiplayerLobby(this)))
	stloc:int32(var_7_1A, ldc.i4:int32(6))
	stfld:int32(GUIControllerMultiplayerLobby::selectedControl, ldloc:GUIControllerMultiplayerLobby(this), ldloc:int32(var_7_1A))
	stfld:int32(GUIControllerMultiplayerLobby::selectedControl, ldloc:GUIControllerMultiplayerLobby(this), ldloc:int32(var_7_1A))
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

	// Token: 0x060003B2 RID: 946 RVA: 0x0000C158 File Offset: 0x0000A358
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.selectedControl;
		int num2 = 6;
		this.selectedControl = num2;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x0000C180 File Offset: 0x0000A380
	public GUIControllerMultiplayerLobby()
	{
	}

	// Token: 0x0400038B RID: 907
	public int selectedControl;

	// Token: 0x0200009B RID: 155
	public enum Controls
	{
		// Token: 0x0400038D RID: 909
		Local,
		// Token: 0x0400038E RID: 910
		Dedicated,
		// Token: 0x0400038F RID: 911
		Delete,
		// Token: 0x04000390 RID: 912
		Favourite,
		// Token: 0x04000391 RID: 913
		Play,
		// Token: 0x04000392 RID: 914
		Back,
		// Token: 0x04000393 RID: 915
		New
	}
}
