using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020001B9 RID: 441
public static class RightSideHUDAnchorUpdator
{
	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0003AAD0 File Offset: 0x00038CD0
	// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0003AAE4 File Offset: 0x00038CE4
	public static bool UseCollpasedCoinsAmmo
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000BC4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean RightSideHUDAnchorUpdator::get_UseCollpasedCoinsAmmo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(RightSideHUDAnchorUpdator::Update)
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
		set
		{
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0003AAF4 File Offset: 0x00038CF4
	public static bool AllowSecondRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0003AB04 File Offset: 0x00038D04
	public static int AllowRowHeight
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0003AB14 File Offset: 0x00038D14
	public static bool AllowDraw
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0003AB24 File Offset: 0x00038D24
	private static int currentFrame
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0003AB34 File Offset: 0x00038D34
	public static void Update()
	{
		List<GUIPageIconGrouping> rightGroupings = InterfaceStyles_Layout.Active.RightGroupings;
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		int size = rightGroupings._size;
		int size2 = rightGroupings._size;
		int size3 = leftGroupings._size;
		int size4 = leftGroupings._size;
		Rectangle rectangle;
		int right = rectangle.Right;
	}

	// Token: 0x04000EA2 RID: 3746
	public const int HUD_Height = 246;

	// Token: 0x04000EA3 RID: 3747
	public const int HUD_Width = 220;

	// Token: 0x04000EA4 RID: 3748
	public const int HUD_Width2 = 178;
}
