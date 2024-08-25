using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x0200026B RID: 619
	internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0000207A File Offset: 0x0000027A
		private static object InternalSyncObject
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0002B950 File Offset: 0x00029B50
		public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
		{
			long num = 0L;
			base..ctor();
			this._oFallback = fallback;
			if (fallback._arrayBestFit == null)
			{
				object internalSyncObject = InternalEncoderBestFitFallbackBuffer.InternalSyncObject;
				Monitor.Enter(internalSyncObject, num != 0L);
				InternalEncoderBestFitFallback oFallback = this._oFallback;
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

		// Token: 0x060014DF RID: 5343 RVA: 0x0002B9C8 File Offset: 0x00029BC8
		public override bool Fallback(char charUnknown, int index)
		{
			char c = this.TryBestFit(charUnknown);
			this._cBestFit = '?';
			return true;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0002B9E8 File Offset: 0x00029BE8
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
			this._cBestFit = '?';
			return true;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0002BA18 File Offset: 0x00029C18
		public override char GetNextChar()
		{
			int iCount = this._iCount;
			this._iCount = iCount;
			this._iCount = iCount;
			return this._cBestFit;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0002BA44 File Offset: 0x00029C44
		public override bool MovePrevious()
		{
			/*
An exception occurred when decompiling this method (060014E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.InternalEncoderBestFitFallbackBuffer::MovePrevious()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InternalEncoderBestFitFallbackBuffer::_iCount, ldloc:InternalEncoderBestFitFallbackBuffer(this)))
	stfld:int32(InternalEncoderBestFitFallbackBuffer::_iCount, ldloc:InternalEncoderBestFitFallbackBuffer(this), ldloc:int32(var_0_06))
	stloc:int32(var_1_14, ldfld:int32(InternalEncoderBestFitFallbackBuffer::_iSize, ldloc:InternalEncoderBestFitFallbackBuffer(this)))
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0002BA68 File Offset: 0x00029C68
		public override int Remaining
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.InternalEncoderBestFitFallbackBuffer::get_Remaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InternalEncoderBestFitFallbackBuffer::_iCount, ldloc:InternalEncoderBestFitFallbackBuffer(this)))
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

		// Token: 0x060014E4 RID: 5348 RVA: 0x0002BA7C File Offset: 0x00029C7C
		public override void Reset()
		{
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0002BA8C File Offset: 0x00029C8C
		private char TryBestFit(char cUnknown)
		{
			/*
An exception occurred when decompiling this method (060014E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Text.InternalEncoderBestFitFallbackBuffer::TryBestFit(System.Char)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_0B, ldfld:char[](InternalEncoderBestFitFallback::_arrayBestFit, ldfld:InternalEncoderBestFitFallback(InternalEncoderBestFitFallbackBuffer::_oFallback, ldloc:InternalEncoderBestFitFallbackBuffer(this))))
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

		// Token: 0x04000B00 RID: 2816
		private char _cBestFit;

		// Token: 0x04000B01 RID: 2817
		private InternalEncoderBestFitFallback _oFallback;

		// Token: 0x04000B02 RID: 2818
		private int _iCount;

		// Token: 0x04000B03 RID: 2819
		private int _iSize;

		// Token: 0x04000B04 RID: 2820
		private static object s_InternalSyncObject;
	}
}
