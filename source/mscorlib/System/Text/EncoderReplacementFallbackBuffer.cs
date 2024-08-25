using System;

namespace System.Text
{
	// Token: 0x02000273 RID: 627
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x0002BF8C File Offset: 0x0002A18C
		public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
		{
			string strDefault = fallback._strDefault;
			string text = strDefault + strDefault;
			this._strDefault = text;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		public override bool Fallback(char charUnknown, int index)
		{
			/*
An exception occurred when decompiling this method (0600151C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.EncoderReplacementFallbackBuffer::Fallback(System.Char,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int64(var_0_09, ldc.i4:int64(0))
	stloc:bool(var_1_10, call:bool(char::IsHighSurrogate, ldloc:char(charUnknown)))
	stloc:int32(var_2_17, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackCount, ldloc:EncoderReplacementFallbackBuffer(this)))
	stloc:int32(var_3_1E, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackIndex, ldloc:EncoderReplacementFallbackBuffer(this)))
	stloc:char(var_4_2B, callgetter:char(string::get_Chars, ldfld:string(EncoderReplacementFallbackBuffer::_strDefault, ldloc:EncoderReplacementFallbackBuffer(this)), ldloc:int64[exp:int32](var_0_09)))
	stloc:int64(var_5_2E, ldc.i4:int64(0))
	stloc:bool(var_6_37, call:bool(char::IsLowSurrogate, ldloc:char(var_4_2B)))
	stloc:int32(var_7_3F, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackIndex, ldloc:EncoderReplacementFallbackBuffer(this)))
	stloc:char(var_8_4E, callgetter:char(string::get_Chars, ldfld:string(EncoderReplacementFallbackBuffer::_strDefault, ldloc:EncoderReplacementFallbackBuffer(this)), ldloc:int64[exp:int32](var_5_2E)))
	stloc:int32(var_9_58, call:int32(char::ConvertToUtf32, ldloc:char(charUnknown), ldloc:char(var_8_4E)))
	call:void(EncoderFallbackBuffer::ThrowLastCharRecursive, ldloc:EncoderReplacementFallbackBuffer[exp:EncoderFallbackBuffer](this), ldloc:int32(var_9_58))
	call:void(EncoderFallbackBuffer::ThrowLastCharRecursive, ldloc:EncoderReplacementFallbackBuffer[exp:EncoderFallbackBuffer](this), ldloc:int32(var_9_58))
	stloc:int32(var_10_75, ldfld:int32(string::_stringLength, ldfld:string(EncoderReplacementFallbackBuffer::_strDefault, ldloc:EncoderReplacementFallbackBuffer(this))))
	stfld:int32(EncoderReplacementFallbackBuffer::_fallbackCount, ldloc:EncoderReplacementFallbackBuffer(this), ldloc:int32(var_10_75))
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

		// Token: 0x0600151D RID: 5405 RVA: 0x0002C044 File Offset: 0x0002A244
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!true)
			{
			}
			bool flag = char.IsHighSurrogate(charUnknownHigh);
			if (!true)
			{
			}
			bool flag2 = char.IsLowSurrogate(charUnknownLow);
			if (this._fallbackCount == 0)
			{
			}
			int num = char.ConvertToUtf32(charUnknownHigh, charUnknownLow);
			base.ThrowLastCharRecursive(num);
			int stringLength = this._strDefault._stringLength;
			this._fallbackCount = stringLength;
			return "charUnknownHigh" != null;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0002C094 File Offset: 0x0002A294
		public override char GetNextChar()
		{
			int fallbackCount = this._fallbackCount;
			this._fallbackCount = fallbackCount;
			this._fallbackCount = fallbackCount;
			char c;
			return c;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		public override bool MovePrevious()
		{
			/*
An exception occurred when decompiling this method (0600151F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.EncoderReplacementFallbackBuffer::MovePrevious()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackCount, ldloc:EncoderReplacementFallbackBuffer(this)))
	stloc:int32(var_1_0D, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackIndex, ldloc:EncoderReplacementFallbackBuffer(this)))
	stfld:int32(EncoderReplacementFallbackBuffer::_fallbackCount, ldloc:EncoderReplacementFallbackBuffer(this), ldloc:int32(var_0_06))
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
		public override int Remaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001520)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.EncoderReplacementFallbackBuffer::get_Remaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(EncoderReplacementFallbackBuffer::_fallbackCount, ldloc:EncoderReplacementFallbackBuffer(this)))
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

		// Token: 0x06001521 RID: 5409 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public override void Reset()
		{
		}

		// Token: 0x04000B18 RID: 2840
		private string _strDefault;

		// Token: 0x04000B19 RID: 2841
		private int _fallbackCount;

		// Token: 0x04000B1A RID: 2842
		private int _fallbackIndex;
	}
}
