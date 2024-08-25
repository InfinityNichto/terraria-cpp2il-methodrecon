using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002FA RID: 762
	[ComVisible(true)]
	public class SHA1Managed : SHA1
	{
		// Token: 0x060019CD RID: 6605 RVA: 0x000377A0 File Offset: 0x000359A0
		public SHA1Managed()
		{
			this.HashSizeValue = 160;
			if (160 == 0)
			{
			}
			uint[] stateSHA = this._stateSHA1;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000377CC File Offset: 0x000359CC
		public override void Initialize()
		{
			uint[] stateSHA = this._stateSHA1;
			byte[] buffer = this._buffer;
			uint[] expandedBuffer = this._expandedBuffer;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000377F0 File Offset: 0x000359F0
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			this._HashData(rgb, ibStart, cbSize);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00037808 File Offset: 0x00035A08
		protected override byte[] HashFinal()
		{
			return this._EndHash();
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0003781C File Offset: 0x00035A1C
		private void InitializeState()
		{
			uint[] stateSHA = this._stateSHA1;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00037830 File Offset: 0x00035A30
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			long count = this._count;
			if (this._stateSHA1 != null)
			{
				return;
			}
			if (this._buffer != null)
			{
				return;
			}
			if (this._expandedBuffer != null)
			{
				return;
			}
			long num = 0L;
			byte[] buffer = this._buffer;
			int num2 = 64;
			bool flag = Buffer.InternalBlockCopy(partIn, ibStart, buffer, cbSize, num2);
			byte[] buffer2 = this._buffer;
			bool flag2 = Buffer.InternalBlockCopy(partIn, ibStart, buffer2, (int)num, cbSize);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00037894 File Offset: 0x00035A94
		private byte[] _EndHash()
		{
			/*
An exception occurred when decompiling this method (060019D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.SHA1Managed::_EndHash()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_09, ldfld:int64(SHA1Managed::_count, ldloc:SHA1Managed(this)))
	stloc:int64(var_2_10, ldfld:int64(SHA1Managed::_count, ldloc:SHA1Managed(this)))
	stloc:uint32[](var_3_17, ldfld:uint32[](SHA1Managed::_stateSHA1, ldloc:SHA1Managed(this)))
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

		// Token: 0x060019D4 RID: 6612 RVA: 0x000378B8 File Offset: 0x00035AB8
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			int num = 1;
			uint value = state->m_value;
			if (num == 0)
			{
			}
			int num2 = 16;
			Utils.DWORDFromBigEndian(expandedBuffer, num2, block);
			SHA1Managed.SHAExpand(expandedBuffer);
			uint value2 = expandedBuffer->m_value;
			int num3 = 60321;
			int value3 = num3.m_value;
			uint value4 = state->m_value;
			state->m_value = value4;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0003791C File Offset: 0x00035B1C
		private unsafe static void SHAExpand(uint* x)
		{
		}

		// Token: 0x04000D13 RID: 3347
		private byte[] _buffer;

		// Token: 0x04000D14 RID: 3348
		private long _count;

		// Token: 0x04000D15 RID: 3349
		private uint[] _stateSHA1;

		// Token: 0x04000D16 RID: 3350
		private uint[] _expandedBuffer;
	}
}
