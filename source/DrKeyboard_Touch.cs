using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class DrKeyboard_Touch : DrKeyboard_Base
{
	// Token: 0x06000099 RID: 153 RVA: 0x00003340 File Offset: 0x00001540
	public static void AppFocusGained()
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00003350 File Offset: 0x00001550
	public DrKeyboard_Touch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false)
	{
		TouchScreenKeyboard touchScreenKeyboard;
		this._keyboard = touchScreenKeyboard;
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600009B RID: 155 RVA: 0x0000336C File Offset: 0x0000156C
	// (set) Token: 0x0600009C RID: 156 RVA: 0x00003388 File Offset: 0x00001588
	public override bool active
	{
		get
		{
			while (this._keyboard.status == TouchScreenKeyboard.Status.Visible)
			{
			}
		}
		set
		{
			TouchScreenKeyboard keyboard = this._keyboard;
			long num = 0L;
			keyboard.active = num != 0L;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600009D RID: 157 RVA: 0x000033A8 File Offset: 0x000015A8
	public override bool done
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600009D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DrKeyboard_Touch::get_done()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Status(var_0_0B, callgetter:Status(TouchScreenKeyboard::get_status, ldfld:TouchScreenKeyboard(DrKeyboard_Touch::_keyboard, ldloc:DrKeyboard_Touch(this))))
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

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600009E RID: 158 RVA: 0x000033C0 File Offset: 0x000015C0
	// (set) Token: 0x0600009F RID: 159 RVA: 0x000033D8 File Offset: 0x000015D8
	public override string text
	{
		get
		{
			return this._keyboard.text;
		}
		set
		{
			this._keyboard.text = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x000033F4 File Offset: 0x000015F4
	public override bool wasCanceled
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DrKeyboard_Touch::get_wasCanceled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Status(var_0_0B, callgetter:Status(TouchScreenKeyboard::get_status, ldfld:TouchScreenKeyboard(DrKeyboard_Touch::_keyboard, ldloc:DrKeyboard_Touch(this))))
	stloc:Status(var_1_17, callgetter:Status(TouchScreenKeyboard::get_status, ldfld:TouchScreenKeyboard(DrKeyboard_Touch::_keyboard, ldloc:DrKeyboard_Touch(this))))
	stloc:Status(var_2_23, callgetter:Status(TouchScreenKeyboard::get_status, ldfld:TouchScreenKeyboard(DrKeyboard_Touch::_keyboard, ldloc:DrKeyboard_Touch(this))))
	stloc:TouchScreenKeyboard(var_3_2A, ldfld:TouchScreenKeyboard(DrKeyboard_Touch::_keyboard, ldloc:DrKeyboard_Touch(this)))
	stloc:int64(var_4_2C, ldc.i4:int64(0))
	callsetter:bool(TouchScreenKeyboard::set_active, ldloc:TouchScreenKeyboard(var_3_2A), ldloc:int64[exp:bool](var_4_2C))
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

	// Token: 0x04000068 RID: 104
	private static bool appGainedFocus;

	// Token: 0x04000069 RID: 105
	private TouchScreenKeyboard _keyboard;
}
