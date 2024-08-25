using System;
using UnityEngine;

// Token: 0x02000263 RID: 611
public class GUILowMemoryPopup
{
	// Token: 0x06000DB2 RID: 3506 RVA: 0x00041AC0 File Offset: 0x0003FCC0
	public void CheckMemoryAction(GUILowMemoryPopup.MemoryAction action, Action continueAction)
	{
		int systemMemorySize = SystemInfo.systemMemorySize;
		this.ContinueCallback = continueAction;
		this.CurrentWarning = action;
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00041AFC File Offset: 0x0003FCFC
	public static long DeviceMemory
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000DB3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 GUILowMemoryPopup::get_DeviceMemory()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(SystemInfo::get_systemMemorySize))
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

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00041B10 File Offset: 0x0003FD10
	public void Draw()
	{
		if (!true)
		{
		}
		GUILowMemoryPopup.MemoryAction currentWarning = this.CurrentWarning;
		if (currentWarning != GUILowMemoryPopup.MemoryAction.Host)
		{
			if (currentWarning == GUILowMemoryPopup.MemoryAction.Host)
			{
			}
			return;
		}
		if (currentWarning == GUILowMemoryPopup.MemoryAction.Host)
		{
		}
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00041B84 File Offset: 0x0003FD84
	public GUILowMemoryPopup()
	{
	}

	// Token: 0x0400194C RID: 6476
	public bool WarningDisplayed;

	// Token: 0x0400194D RID: 6477
	public bool DisableWarnings;

	// Token: 0x0400194E RID: 6478
	private GUILowMemoryPopup.MemoryAction CurrentWarning;

	// Token: 0x0400194F RID: 6479
	private Action ContinueCallback;

	// Token: 0x04001950 RID: 6480
	private float scale0;

	// Token: 0x04001951 RID: 6481
	private float scale1;

	// Token: 0x04001952 RID: 6482
	private float scale2;

	// Token: 0x02000264 RID: 612
	public enum MemoryAction
	{
		// Token: 0x04001954 RID: 6484
		Host,
		// Token: 0x04001955 RID: 6485
		PlayLarge,
		// Token: 0x04001956 RID: 6486
		GenerateLarge
	}
}
