using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000260 RID: 608
	internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0000207A File Offset: 0x0000027A
		private static object InternalSyncObject
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0002B1BC File Offset: 0x000293BC
		public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
		{
			long num = 0L;
			base..ctor();
			this._oFallback = fallback;
			if (fallback._arrayBestFit == null)
			{
				object internalSyncObject = InternalDecoderBestFitFallbackBuffer.InternalSyncObject;
				Monitor.Enter(internalSyncObject, num != 0L);
				InternalDecoderBestFitFallback oFallback = this._oFallback;
				if (oFallback._arrayBestFit != null)
				{
					return;
				}
				long num2 = 0L;
				oFallback._arrayBestFit = internalSyncObject;
				Monitor.Exit(internalSyncObject);
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0002B234 File Offset: 0x00029434
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			char c = this.TryBestFit(bytesUnknown);
			this._cBestFit = c;
			char cReplacement = this._oFallback._cReplacement;
			this._cBestFit = cReplacement;
			return true;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0002B264 File Offset: 0x00029464
		public override char GetNextChar()
		{
			int iCount = this._iCount;
			this._iCount = iCount;
			this._iCount = iCount;
			return this._cBestFit;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0002B290 File Offset: 0x00029490
		public override int Remaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001491)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.InternalDecoderBestFitFallbackBuffer::get_Remaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InternalDecoderBestFitFallbackBuffer::_iCount, ldloc:InternalDecoderBestFitFallbackBuffer(this)))
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

		// Token: 0x06001492 RID: 5266 RVA: 0x0002B2A4 File Offset: 0x000294A4
		public override void Reset()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0002B2B4 File Offset: 0x000294B4
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 1;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0002B2C4 File Offset: 0x000294C4
		private char TryBestFit(byte[] bytesCheck)
		{
			/*
An exception occurred when decompiling this method (06001494)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Text.InternalDecoderBestFitFallbackBuffer::TryBestFit(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_0B, ldfld:char[](InternalDecoderBestFitFallback::_arrayBestFit, ldfld:InternalDecoderBestFitFallback(InternalDecoderBestFitFallbackBuffer::_oFallback, ldloc:InternalDecoderBestFitFallbackBuffer(this))))
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

		// Token: 0x04000AE9 RID: 2793
		private char _cBestFit;

		// Token: 0x04000AEA RID: 2794
		private int _iCount;

		// Token: 0x04000AEB RID: 2795
		private int _iSize;

		// Token: 0x04000AEC RID: 2796
		private InternalDecoderBestFitFallback _oFallback;

		// Token: 0x04000AED RID: 2797
		private static object s_InternalSyncObject;
	}
}
