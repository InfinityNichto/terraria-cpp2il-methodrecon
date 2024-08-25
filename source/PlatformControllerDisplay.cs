using System;

// Token: 0x02000041 RID: 65
[ResourceLocation("Managers/PlatformControllerDisplay")]
public class PlatformControllerDisplay : Singleton<PlatformControllerDisplay>
{
	// Token: 0x06000177 RID: 375 RVA: 0x00004860 File Offset: 0x00002A60
	public PlatformControllerDisplay.ControllerDisplayState DisplayedController()
	{
		/*
An exception occurred when decompiling this method (06000177)

ICSharpCode.Decompiler.DecompilerException: Error decompiling PlatformControllerDisplay/ControllerDisplayState PlatformControllerDisplay::DisplayedController()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:string[](var_5_27, ldfld:string[](PlatformControllerDisplay::Controller_PS4, ldloc:PlatformControllerDisplay(this)))
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

	// Token: 0x06000178 RID: 376 RVA: 0x00004898 File Offset: 0x00002A98
	public PlatformControllerDisplay()
	{
	}

	// Token: 0x0400010A RID: 266
	public string[] Controller_XBO;

	// Token: 0x0400010B RID: 267
	public string[] Controller_PS4;

	// Token: 0x02000042 RID: 66
	public enum ControllerDisplayState
	{
		// Token: 0x0400010D RID: 269
		Controller_None,
		// Token: 0x0400010E RID: 270
		Controller_XBO,
		// Token: 0x0400010F RID: 271
		Controller_PS4
	}

	// Token: 0x02000043 RID: 67
	[Serializable]
	public class PlatformControllerDisplayState
	{
		// Token: 0x06000179 RID: 377 RVA: 0x000048B0 File Offset: 0x00002AB0
		public PlatformControllerDisplayState()
		{
		}

		// Token: 0x04000110 RID: 272
		public string ControllerId;

		// Token: 0x04000111 RID: 273
		public PlatformControllerDisplay.ControllerDisplayState DisplayState;
	}
}
