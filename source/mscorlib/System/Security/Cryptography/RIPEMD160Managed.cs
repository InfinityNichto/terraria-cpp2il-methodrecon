using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002F1 RID: 753
	[ComVisible(true)]
	public class RIPEMD160Managed : RIPEMD160
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x000366F4 File Offset: 0x000348F4
		public RIPEMD160Managed()
		{
			this.HashSizeValue = 160;
			if (160 == 0)
			{
			}
			bool allowOnlyFipsAlgorithms = CryptoConfig.AllowOnlyFipsAlgorithms;
			uint[] stateMD = this._stateMD160;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00036734 File Offset: 0x00034934
		public override void Initialize()
		{
			uint[] stateMD = this._stateMD160;
			uint[] blockDWords = this._blockDWords;
			byte[] buffer = this._buffer;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00036758 File Offset: 0x00034958
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			this._HashData(rgb, ibStart, cbSize);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00036770 File Offset: 0x00034970
		protected override byte[] HashFinal()
		{
			return this._EndHash();
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00036784 File Offset: 0x00034984
		private void InitializeState()
		{
			uint[] stateMD = this._stateMD160;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00036798 File Offset: 0x00034998
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			long count = this._count;
			if (this._stateMD160 != null)
			{
				return;
			}
			if (this._buffer != null)
			{
				return;
			}
			if (this._blockDWords != null)
			{
				return;
			}
			byte[] buffer = this._buffer;
			byte[] buffer2 = this._buffer;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000367DC File Offset: 0x000349DC
		private byte[] _EndHash()
		{
			/*
An exception occurred when decompiling this method (06001949)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RIPEMD160Managed::_EndHash()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_09, ldfld:int64(RIPEMD160Managed::_count, ldloc:RIPEMD160Managed(this)))
	stloc:int64(var_2_10, ldfld:int64(RIPEMD160Managed::_count, ldloc:RIPEMD160Managed(this)))
	stloc:uint32[](var_3_17, ldfld:uint32[](RIPEMD160Managed::_stateMD160, ldloc:RIPEMD160Managed(this)))
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

		// Token: 0x0600194A RID: 6474 RVA: 0x00036800 File Offset: 0x00034A00
		private unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
		{
			int num = 1;
			uint value = state->m_value;
			if (num == 0)
			{
			}
			int num2 = 16;
			Utils.DWORDFromLittleEndian(blockDWords, num2, block);
			uint value2 = blockDWords->m_value;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint F(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint G(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint H(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint I(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint J(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000CF1 RID: 3313
		private byte[] _buffer;

		// Token: 0x04000CF2 RID: 3314
		private long _count;

		// Token: 0x04000CF3 RID: 3315
		private uint[] _stateMD160;

		// Token: 0x04000CF4 RID: 3316
		private uint[] _blockDWords;
	}
}
