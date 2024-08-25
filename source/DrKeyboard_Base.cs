using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
public abstract class DrKeyboard_Base
{
	// Token: 0x06000083 RID: 131 RVA: 0x00003108 File Offset: 0x00001308
	public static DrKeyboard_Base Create(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false, bool filterText = true)
	{
		/*
An exception occurred when decompiling this method (06000083)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DrKeyboard_Base DrKeyboard_Base::Create(UnityEngine.TouchScreenKeyboardType,System.String,System.Int32,System.String,System.String,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Application::get_isEditor))
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

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000084 RID: 132 RVA: 0x0000311C File Offset: 0x0000131C
	public static bool isSupported
	{
		get
		{
			bool isEditor = Application.isEditor;
			return true;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000085 RID: 133
	// (set) Token: 0x06000086 RID: 134
	public abstract bool active { get; set; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000087 RID: 135
	public abstract bool wasCanceled { get; }

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000088 RID: 136
	public abstract bool done { get; }

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000089 RID: 137
	// (set) Token: 0x0600008A RID: 138
	public abstract string text { get; set; }

	// Token: 0x0600008B RID: 139 RVA: 0x0000313C File Offset: 0x0000133C
	public virtual void Update()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000314C File Offset: 0x0000134C
	protected DrKeyboard_Base()
	{
	}
}
