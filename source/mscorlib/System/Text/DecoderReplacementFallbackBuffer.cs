using System;

namespace System.Text
{
	// Token: 0x02000268 RID: 616
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x0002B73C File Offset: 0x0002993C
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
			string strDefault = fallback._strDefault;
			this._strDefault = strDefault;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0002B760 File Offset: 0x00029960
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			int fallbackCount = this._fallbackCount;
			int stringLength = this._strDefault._stringLength;
			if (stringLength != 0)
			{
				this._fallbackCount = stringLength;
				return true;
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0002B790 File Offset: 0x00029990
		public override char GetNextChar()
		{
			int fallbackCount = this._fallbackCount;
			this._fallbackCount = fallbackCount;
			this._fallbackCount = fallbackCount;
			char c;
			return c;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0002B7B8 File Offset: 0x000299B8
		public override int Remaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.DecoderReplacementFallbackBuffer::get_Remaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(DecoderReplacementFallbackBuffer::_fallbackCount, ldloc:DecoderReplacementFallbackBuffer(this)))
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

		// Token: 0x060014CB RID: 5323 RVA: 0x0002B7CC File Offset: 0x000299CC
		public override void Reset()
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0002B7DC File Offset: 0x000299DC
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return this._strDefault._stringLength;
		}

		// Token: 0x04000AF9 RID: 2809
		private string _strDefault;

		// Token: 0x04000AFA RID: 2810
		private int _fallbackCount;

		// Token: 0x04000AFB RID: 2811
		private int _fallbackIndex;
	}
}
