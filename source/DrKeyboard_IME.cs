using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
internal class DrKeyboard_IME : DrKeyboard_Base
{
	// Token: 0x0600008D RID: 141 RVA: 0x00003160 File Offset: 0x00001360
	public DrKeyboard_IME(string initialText, int maxChars, string title, string prompt)
	{
		Input.imeCompositionMode = IMECompositionMode.On;
		this._text = initialText;
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600008E RID: 142 RVA: 0x00003194 File Offset: 0x00001394
	// (set) Token: 0x0600008F RID: 143 RVA: 0x000031A8 File Offset: 0x000013A8
	public override bool active
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600008E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DrKeyboard_IME::get_active()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IMECompositionMode(var_1_07, callgetter:IMECompositionMode(Input::get_imeCompositionMode))
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

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000090 RID: 144 RVA: 0x000031B8 File Offset: 0x000013B8
	public override bool done
	{
		get
		{
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000091 RID: 145 RVA: 0x000031C8 File Offset: 0x000013C8
	// (set) Token: 0x06000092 RID: 146 RVA: 0x000031DC File Offset: 0x000013DC
	public override string text
	{
		get
		{
			return this._text;
		}
		set
		{
			this._text = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000093 RID: 147 RVA: 0x000031F0 File Offset: 0x000013F0
	public override bool wasCanceled
	{
		get
		{
			return this._wasCanceled;
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00003204 File Offset: 0x00001404
	public override void Update()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		bool keyDown = KeyboardInput.GetKeyDown(KeyCode.KeypadEnter);
		if (!true)
		{
		}
		bool keyDown2 = KeyboardInput.GetKeyDown(KeyCode.Return);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00003294 File Offset: 0x00001494
	private void Append(string input)
	{
		if (input != null)
		{
			int stringLength = input._stringLength;
			long num = 0L;
			long num2 = 0L;
			char c = input[(int)num];
			string text = this._text;
			int stringLength2 = text._stringLength;
			long num3 = 0L;
			string text2 = text.Substring((int)num3, (int)num2);
			return;
		}
	}

	// Token: 0x04000063 RID: 99
	private int _lastFrame = 1;

	// Token: 0x04000064 RID: 100
	private string _lastIME = "";

	// Token: 0x04000065 RID: 101
	private string _text;

	// Token: 0x04000066 RID: 102
	private bool _wasCanceled;
}
