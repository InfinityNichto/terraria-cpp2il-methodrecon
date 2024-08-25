using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000266 RID: 614
	internal class DecoderNLS : Decoder
	{
		// Token: 0x060014B1 RID: 5297 RVA: 0x0002B4B8 File Offset: 0x000296B8
		internal DecoderNLS(Encoding encoding)
		{
			this._encoding = encoding;
			DecoderFallback decoderFallback = encoding.decoderFallback;
			this._fallback = decoderFallback;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0002B4E0 File Offset: 0x000296E0
		public override void Reset()
		{
			if (this._fallbackBuffer != null)
			{
				return;
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0002B4F8 File Offset: 0x000296F8
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			/*
An exception occurred when decompiling this method (060014B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.DecoderNLS::GetCharCount(System.Byte[],System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_2_0B, call:!!0[exp:!0](MemoryMarshal::GetReference, ldloc:Span`1(var_1)))
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

		// Token: 0x060014B5 RID: 5301 RVA: 0x0002B510 File Offset: 0x00029710
		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			/*
An exception occurred when decompiling this method (060014B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.DecoderNLS::GetCharCount(System.Byte*,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_0_09, ldfld:Encoding(DecoderNLS::_encoding, ldloc:DecoderNLS(this)))
	stfld:bool(DecoderNLS::_throwOnOverflow, ldloc:DecoderNLS(this), ldc.i4:bool(1))
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

		// Token: 0x060014B6 RID: 5302 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0002B530 File Offset: 0x00029730
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			if (chars != null && bytes != null)
			{
				Span span;
				!0 reference = MemoryMarshal.GetReference(span);
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0002B554 File Offset: 0x00029754
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			/*
An exception occurred when decompiling this method (060014B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.DecoderNLS::GetChars(System.Byte*,System.Int32,System.Char*,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:Encoding(var_0_0C, ldfld:Encoding(DecoderNLS::_encoding, ldloc:DecoderNLS(this)))
	stfld:bool(DecoderNLS::_throwOnOverflow, ldloc:DecoderNLS(this), ldc.i4:bool(1))
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

		// Token: 0x060014B9 RID: 5305 RVA: 0x0002B574 File Offset: 0x00029774
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, [Out] int bytesUsed, [Out] int charsUsed, [Out] bool completed)
		{
			if (chars != null && bytes != null)
			{
				Span span;
				!0 reference = MemoryMarshal.GetReference(span);
				return;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0002B594 File Offset: 0x00029794
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, [Out] int bytesUsed, [Out] int charsUsed, [Out] bool completed)
		{
			if (bytes != null && chars != null)
			{
				Encoding encoding = this._encoding;
				charsUsed.m_value = encoding;
				int bytesUsed2 = this._bytesUsed;
				bytesUsed.m_value = bytesUsed2;
				return;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0002B5D0 File Offset: 0x000297D0
		public bool MustFlush
		{
			get
			{
				return this._mustFlush;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0002B5E4 File Offset: 0x000297E4
		internal virtual bool HasState
		{
			get
			{
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0002B5F4 File Offset: 0x000297F4
		internal void ClearMustFlush()
		{
		}

		// Token: 0x04000AF4 RID: 2804
		private Encoding _encoding;

		// Token: 0x04000AF5 RID: 2805
		private bool _mustFlush;

		// Token: 0x04000AF6 RID: 2806
		internal bool _throwOnOverflow;

		// Token: 0x04000AF7 RID: 2807
		internal int _bytesUsed;
	}
}
