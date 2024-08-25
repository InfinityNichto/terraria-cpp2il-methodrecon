using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Math
{
	// Token: 0x02000062 RID: 98
	public class BigInteger
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000B194 File Offset: 0x00009394
		[CLSCompliant(false)]
		public BigInteger(BigInteger.Sign sign, uint len)
		{
			this.length = 1U;
			base..ctor();
			this.length = len;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000B1B8 File Offset: 0x000093B8
		public BigInteger(BigInteger bi)
		{
			this.length = 1U;
			base..ctor();
			uint[] array = bi.data;
			object obj;
			if (obj != null)
			{
				if (obj != null)
				{
					this.data = obj;
					if (obj != null)
					{
						goto IL_002A;
					}
				}
				throw new InvalidCastException();
			}
			IL_002A:
			uint num = bi.length;
			this.length = num;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000B200 File Offset: 0x00009400
		[CLSCompliant(false)]
		public BigInteger(BigInteger bi, uint len)
		{
			int num = 1;
			this.length = (uint)num;
			base..ctor();
			if (bi.length != 0U)
			{
				uint[] array = bi.data;
				uint num2 = bi.length;
				return;
			}
			long num3 = 0L;
			this.length = (uint)num3;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000B240 File Offset: 0x00009440
		public BigInteger(byte[] inData)
		{
			int num = 1;
			this.length = (uint)num;
			base..ctor();
			int num2;
			if (num == 0)
			{
				num2 = 1;
			}
			this.length = (uint)num2;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000B290 File Offset: 0x00009490
		[CLSCompliant(false)]
		public BigInteger(uint ui)
		{
			this.length = 1U;
			base..ctor();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		public static implicit operator BigInteger(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000B2AC File Offset: 0x000094AC
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = bi1 == (uint)num;
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000B2C8 File Offset: 0x000094C8
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = bi1 == (uint)num;
			BigInteger.Sign sign;
			if (sign != BigInteger.Sign.Zero)
			{
				BigInteger bigInteger;
				return bigInteger;
			}
			return 0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000B2F0 File Offset: 0x000094F0
		[CLSCompliant(false)]
		public static uint operator %(BigInteger bi, uint ui)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000B300 File Offset: 0x00009500
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			BigInteger[] array;
			return array;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000B310 File Offset: 0x00009510
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			BigInteger[] array;
			return array;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000B320 File Offset: 0x00009520
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = bi1 == (uint)num2;
			if (num == 0)
			{
			}
			return 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000B370 File Offset: 0x00009570
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000B380 File Offset: 0x00009580
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000B390 File Offset: 0x00009590
		private static RandomNumberGenerator Rng
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RandomNumberGenerator Mono.Math.BigInteger::get_Rng()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RandomNumberGenerator(var_1_07, call:RandomNumberGenerator(RandomNumberGenerator::Create))
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

		// Token: 0x060002BE RID: 702 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			/*
An exception occurred when decompiling this method (060002BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger Mono.Math.BigInteger::GenerateRandom(System.Int32,System.Security.Cryptography.RandomNumberGenerator)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000B3B4 File Offset: 0x000095B4
		public static BigInteger GenerateRandom(int bits)
		{
			if (!true)
			{
			}
			RandomNumberGenerator randomNumberGenerator = BigInteger.Rng;
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000B3CC File Offset: 0x000095CC
		public int BitCount()
		{
			/*
An exception occurred when decompiling this method (060002C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Math.BigInteger::BitCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int32(var_2_12, ldc.i4:int32(1))
	stfld:uint32(BigInteger::length, ldloc:BigInteger(this), ldloc:int32[exp:uint32](var_2_12))
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

		// Token: 0x060002C1 RID: 705 RVA: 0x0000B3F4 File Offset: 0x000095F4
		public bool TestBit(int bitNum)
		{
			/*
An exception occurred when decompiling this method (060002C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Math.BigInteger::TestBit(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32[](var_0_06, ldfld:uint32[](BigInteger::data, ldloc:BigInteger(this)))
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

		// Token: 0x060002C2 RID: 706 RVA: 0x0000B40C File Offset: 0x0000960C
		[CLSCompliant(false)]
		public void SetBit(uint bitNum)
		{
			uint num = this.length;
			uint[] array = this.data;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000B428 File Offset: 0x00009628
		[CLSCompliant(false)]
		public void SetBit(uint bitNum, bool value)
		{
			uint num = this.length;
			uint[] array = this.data;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000B444 File Offset: 0x00009644
		public int LowestSetBit()
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = this == (uint)num;
			bool flag2 = this.TestBit(0);
			return 0;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000B468 File Offset: 0x00009668
		public byte[] GetBytes()
		{
			/*
An exception occurred when decompiling this method (060002C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Math.BigInteger::GetBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int64(var_0_04, ldc.i4:int64(0))
	stloc:bool(var_1_0C, call:bool(BigInteger::op_Equality, ldloc:BigInteger(this), ldloc:int64[exp:uint32](var_0_04)))
	stloc:int32(var_3_15, call:int32(BigInteger::BitCount, ldloc:BigInteger(this)))
	stloc:uint32(var_4_1C, ldfld:uint32(BigInteger::length, ldloc:BigInteger(this)))
	stloc:uint32[](var_5_24, ldfld:uint32[](BigInteger::data, ldloc:BigInteger(this)))
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

		// Token: 0x060002C6 RID: 710 RVA: 0x0000B49C File Offset: 0x0000969C
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			while (!true)
			{
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			while (!true)
			{
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B4C4 File Offset: 0x000096C4
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000B4FC File Offset: 0x000096FC
		[CLSCompliant(false)]
		public string ToString(uint radix)
		{
			return this.ToString(radix, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000B518 File Offset: 0x00009718
		[CLSCompliant(false)]
		public string ToString(uint radix, string characterSet)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = this == (uint)num;
			if ("0" == null)
			{
			}
			bool flag2 = this == (uint)1;
			if ("" == null)
			{
			}
			uint num2;
			return characterSet[(int)num2].ToString() + "";
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000B570 File Offset: 0x00009770
		private void Normalize()
		{
			uint[] array = this.data;
			int num = 1;
			this.length = (uint)num;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000B590 File Offset: 0x00009790
		public void Clear()
		{
			if (this.length != 0U)
			{
				uint[] array = this.data;
				uint num = this.length;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B5B8 File Offset: 0x000097B8
		public override int GetHashCode()
		{
			if (this.length != 0U)
			{
				uint[] array = this.data;
				return;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000B5DC File Offset: 0x000097DC
		public override string ToString()
		{
			return this.ToString((uint)10);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public override bool Equals(object o)
		{
			if (o != null)
			{
				bool flag;
				return flag;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B610 File Offset: 0x00009810
		public BigInteger ModInverse(BigInteger modulus)
		{
			return BigInteger.Kernel.modInverse(this, modulus);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B624 File Offset: 0x00009824
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000B634 File Offset: 0x00009834
		public void Incr2()
		{
			uint[] array = this.data;
			uint num = this.length;
			this.length = num;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000B658 File Offset: 0x00009858
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
		}

		// Token: 0x04000294 RID: 660
		private uint length;

		// Token: 0x04000295 RID: 661
		private uint[] data;

		// Token: 0x04000296 RID: 662
		internal static readonly uint[] smallPrimes;

		// Token: 0x04000297 RID: 663
		private static RandomNumberGenerator rng;

		// Token: 0x02000063 RID: 99
		public enum Sign
		{
			// Token: 0x04000299 RID: 665
			Negative = -1,
			// Token: 0x0400029A RID: 666
			Zero,
			// Token: 0x0400029B RID: 667
			Positive
		}

		// Token: 0x02000064 RID: 100
		public sealed class ModulusRing
		{
			// Token: 0x060002DA RID: 730 RVA: 0x0000B668 File Offset: 0x00009868
			public ModulusRing(BigInteger modulus)
			{
				int num = 1;
				base..ctor();
				this.mod = modulus;
				uint length = modulus.length;
				BigInteger bigInteger = this.mod;
				if (num == 0)
				{
				}
				this.constant = num;
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0000B6A0 File Offset: 0x000098A0
			public void BarrettReduction(BigInteger x)
			{
				BigInteger bigInteger = this.mod;
				uint length = x.length;
				uint length2 = bigInteger.length;
				uint[] data = x.data;
				uint length3 = this.constant.length;
				BigInteger bigInteger2 = this.constant;
				uint length4 = x.length;
				uint[] data2 = x.data;
				uint[] data3 = bigInteger2.data;
				uint length5 = bigInteger2.length;
				uint length6 = x.length;
				x.length = length4;
				if (length4 != 0U)
				{
					uint[] data4 = x.data;
					x.length = length4;
				}
				int num = 1;
				x.length = (uint)num;
				uint[] data5 = bigInteger.data;
				uint length7 = bigInteger.length;
				if (length4 != 0U)
				{
				}
				if (!true)
				{
				}
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000B754 File Offset: 0x00009954
			public BigInteger Multiply(BigInteger a, BigInteger b)
			{
				if (!true)
				{
				}
				long num = 0L;
				bool flag = a == (uint)num;
				if (!true)
				{
				}
				long num2 = 0L;
				bool flag2 = b == (uint)num2;
				if (!true)
				{
				}
				return 0;
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0000B7F0 File Offset: 0x000099F0
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				while (BigInteger.Kernel.Compare(a, b) != BigInteger.Sign.Zero)
				{
				}
				if (!true)
				{
				}
				return 0;
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000B874 File Offset: 0x00009A74
			public BigInteger Pow(BigInteger a, BigInteger k)
			{
				if (!true)
				{
				}
				long num = 0L;
				bool flag = k == (uint)num;
				uint[] data = k.data;
				int num2 = k.BitCount();
				int num3 = 1;
				BigInteger bigInteger = this.Multiply(a, a);
				bool flag2 = k.TestBit(num3);
				int num4 = k.BitCount();
				BigInteger bigInteger2;
				return bigInteger2;
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0000B8C4 File Offset: 0x00009AC4
			[CLSCompliant(false)]
			public BigInteger Pow(uint b, BigInteger exp)
			{
				BigInteger bigInteger;
				return bigInteger;
			}

			// Token: 0x0400029C RID: 668
			private BigInteger mod;

			// Token: 0x0400029D RID: 669
			private BigInteger constant;
		}

		// Token: 0x02000065 RID: 101
		private sealed class Kernel
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x0000B8D4 File Offset: 0x00009AD4
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2)
			{
				uint length = bi1.length;
				long num = 0L;
				if (false)
				{
				}
				if (num != 0L)
				{
					return;
				}
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				/*
An exception occurred when decompiling this method (060002E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::Subtract(Mono.Math.BigInteger,Mono.Math.BigInteger)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_1_08)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000B91C File Offset: 0x00009B1C
			public static void MinusEq(BigInteger big, BigInteger small)
			{
				uint[] data = big.data;
				uint[] data2 = small.data;
				long num = 0L;
				uint length = small.length;
				uint length2 = big.length;
				uint length3 = big.length;
				if (length3 != 0U)
				{
					if (length3 != 0U)
					{
						return;
					}
					big.length = (uint)num;
				}
				int num2 = 1;
				big.length = (uint)num2;
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000B970 File Offset: 0x00009B70
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
				uint length = bi1.length;
				uint length2 = bi2.length;
				uint[] data = bi1.data;
				long num = 0L;
				long num2 = 0L;
				if (num2 != 0L)
				{
				}
				length2.m_value = (uint)num2;
				bi1.length = (uint)num;
				if (num == 0L)
				{
					return;
				}
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000B9BC File Offset: 0x00009BBC
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				/*
An exception occurred when decompiling this method (060002E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger/Sign Mono.Math.BigInteger/Kernel::Compare(Mono.Math.BigInteger,Mono.Math.BigInteger)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:uint32[](var_3_1F, ldfld:uint32[](BigInteger::data, ldloc:BigInteger(bi1)))
	stloc:uint32[](var_4_26, ldfld:uint32[](BigInteger::data, ldloc:BigInteger(bi1)))
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

			// Token: 0x060002E5 RID: 741 RVA: 0x0000B9F0 File Offset: 0x00009BF0
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				while (n == null)
				{
				}
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000BA04 File Offset: 0x00009C04
			public static uint DwordMod(BigInteger n, uint d)
			{
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000BA14 File Offset: 0x00009C14
			public static BigInteger[] DwordDivMod(BigInteger n, uint d)
			{
				if (true)
				{
				}
				long num = 0L;
				if (n != null)
				{
				}
				if (!true)
				{
				}
				BigInteger bigInteger = (uint)num;
				if (bigInteger == null || bigInteger != null)
				{
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000BA40 File Offset: 0x00009C40
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				int num = 1;
				if (bi1.length != 0U)
				{
					uint[] data = bi1.data;
					if (num != 0)
					{
						long num2 = 0L;
						BigInteger bigInteger;
						uint[] data2 = bigInteger.data;
						BigInteger bigInteger2;
						uint length = bigInteger2.length;
						uint[] data3 = bigInteger2.data;
						while (bigInteger2 == null)
						{
						}
						long num3 = 0L;
						if (num3 != 0L)
						{
						}
						if (data3 == null || length == 0U)
						{
						}
						uint length2 = bigInteger.length;
						if (length2 != 0U)
						{
							uint[] data4 = bigInteger.data;
							if (length != 0U)
							{
								goto IL_00AD;
							}
							bigInteger.length = length2;
						}
						int num4 = 1;
						bigInteger.length = (uint)num4;
						IL_00AD:
						if (bigInteger != null)
						{
							while (num2 == 0L)
							{
							}
							BigInteger bigInteger3 = BigInteger.Kernel.RightShift(bigInteger, (int)num2);
							while (bigInteger3 != null)
							{
							}
							return bigInteger3;
						}
						throw new ArrayTypeMismatchException();
					}
				}
				int num5 = 1;
				bi1.length = (uint)num5;
				uint[] data5 = bi1.data;
				BigInteger[] array;
				return array;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000BB1C File Offset: 0x00009D1C
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				/*
An exception occurred when decompiling this method (060002E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::LeftShift(Mono.Math.BigInteger,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_0)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0000BB34 File Offset: 0x00009D34
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				/*
An exception occurred when decompiling this method (060002EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::RightShift(Mono.Math.BigInteger,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:BigInteger[exp:bool](bi)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0000BB44 File Offset: 0x00009D44
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset)
			{
				if (x != null)
				{
					if (y == null)
					{
						return;
					}
				}
				else if (y == null)
				{
					if (d != null)
					{
						return;
					}
					return;
				}
				if (d == null)
				{
					return;
				}
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000BB6C File Offset: 0x00009D6C
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
				if (x != null)
				{
					if (y == null)
					{
						return;
					}
				}
				else if (y == null)
				{
					if (d != null)
					{
						return;
					}
					return;
				}
				if (d == null)
				{
					return;
				}
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0000BB94 File Offset: 0x00009D94
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				/*
An exception occurred when decompiling this method (060002ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Mono.Math.BigInteger/Kernel::modInverse(Mono.Math.BigInteger,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	brtrue(IL_000B, ldloc:int64[exp:bool](var_0_04))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000BBB0 File Offset: 0x00009DB0
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				uint length = bi.length;
				uint[] data = bi.data;
				uint num;
				return num;
			}
		}
	}
}
