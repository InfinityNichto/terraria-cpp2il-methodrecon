using System;
using System.IO;
using System.Security.Cryptography;

namespace Mono.Security.Authenticode
{
	// Token: 0x0200005F RID: 95
	public class AuthenticodeBase
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000A734 File Offset: 0x00008934
		public AuthenticodeBase()
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000A748 File Offset: 0x00008948
		internal int PEOffset
		{
			get
			{
				int num = this.blockNo;
				this.ReadFirstBlock();
				return this.peOffset;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000A768 File Offset: 0x00008968
		internal void Open(string filename)
		{
			if (this.fs != null)
			{
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000A780 File Offset: 0x00008980
		internal void Open(byte[] rawdata)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000A790 File Offset: 0x00008990
		internal void Close()
		{
			if (this.fs != null)
			{
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A7A8 File Offset: 0x000089A8
		internal void ReadFirstBlock()
		{
			if (this.ProcessFirstBlock() == 0)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000A7C4 File Offset: 0x000089C4
		internal int ProcessFirstBlock()
		{
			Stream stream;
			int num;
			do
			{
				stream = this.fs;
				num = 1;
			}
			while (stream == null);
			byte[] array = this.fileblock;
			Stream stream2 = this.fs;
			this.blockNo = num;
			this.peOffset = stream2;
			byte[] array2 = this.fileblock;
			long num2 = 0L;
			ushort num3 = BitConverterLE.ToUInt16(array2, (int)num2);
			byte[] array3 = this.fileblock;
			int num4 = 60;
			int num5 = BitConverterLE.ToInt32(array3, num4);
			byte[] array4 = this.fileblock;
			this.peOffset = num5;
			Stream stream3 = this.fs;
			return 3;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		internal byte[] GetSecurityEntry()
		{
			/*
An exception occurred when decompiling this method (0600029D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Authenticode.AuthenticodeBase::GetSecurityEntry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(AuthenticodeBase::blockNo, ldloc:AuthenticodeBase(this)))
	call:void(AuthenticodeBase::ReadFirstBlock, ldloc:AuthenticodeBase(this))
	stloc:int32(var_1_13, ldfld:int32(AuthenticodeBase::dirSecuritySize, ldloc:AuthenticodeBase(this)))
	stloc:Stream(var_2_1A, ldfld:Stream(AuthenticodeBase::fs, ldloc:AuthenticodeBase(this)))
	stloc:int32(var_3_21, ldfld:int32(AuthenticodeBase::dirSecurityOffset, ldloc:AuthenticodeBase(this)))
	stloc:Stream(var_4_28, ldfld:Stream(AuthenticodeBase::fs, ldloc:AuthenticodeBase(this)))
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

		// Token: 0x0600029E RID: 670 RVA: 0x0000A934 File Offset: 0x00008B34
		internal byte[] GetHash(HashAlgorithm hash)
		{
			/*
An exception occurred when decompiling this method (0600029E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Authenticode.AuthenticodeBase::GetHash(System.Security.Cryptography.HashAlgorithm)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_43_17D, ldfld:uint8[](AuthenticodeBase::fileblock, ldloc:AuthenticodeBase(this)))
	stloc:Stream(var_44_185, ldfld:Stream(AuthenticodeBase::fs, ldloc:AuthenticodeBase(this)))
	stloc:uint8[](var_45_18D, ldfld:uint8[](AuthenticodeBase::fileblock, ldloc:AuthenticodeBase(this)))
	stloc:uint8[](var_47_195, ldfld:uint8[](AuthenticodeBase::fileblock, ldloc:AuthenticodeBase(this)))
	stloc:Stream(var_48_19D, ldfld:Stream(AuthenticodeBase::fs, ldloc:AuthenticodeBase(this)))
	stloc:uint8[](var_49_1A5, ldfld:uint8[](AuthenticodeBase::fileblock, ldloc:AuthenticodeBase(this)))
	stloc:int64(var_50_1A8, ldc.i4:int64(0))
	stloc:int64(var_51_1AB, ldc.i4:int64(0))
	stloc:int32(var_52_1BD, call:int32(HashAlgorithm::TransformBlock, ldloc:HashAlgorithm(hash), ldloc:uint8[](var_49_1A5), ldloc:int64[exp:int32](var_50_1A8), ldloc:int64[exp:int32](var_31_126), ldloc:uint8[](var_49_1A5), ldloc:int64[exp:int32](var_51_1AB)))
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

		// Token: 0x0400027A RID: 634
		private byte[] fileblock;

		// Token: 0x0400027B RID: 635
		private Stream fs;

		// Token: 0x0400027C RID: 636
		private int blockNo;

		// Token: 0x0400027D RID: 637
		private int blockLength;

		// Token: 0x0400027E RID: 638
		private int peOffset;

		// Token: 0x0400027F RID: 639
		private int dirSecurityOffset;

		// Token: 0x04000280 RID: 640
		private int dirSecuritySize;

		// Token: 0x04000281 RID: 641
		private int coffSymbolTableOffset;

		// Token: 0x04000282 RID: 642
		private bool pe64;
	}
}
