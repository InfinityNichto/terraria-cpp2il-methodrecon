using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Math
{
	// Token: 0x0200004F RID: 79
	internal class BigInteger
	{
		// Token: 0x060001BA RID: 442 RVA: 0x000071FC File Offset: 0x000053FC
		public BigInteger(BigInteger.Sign sign, uint len)
		{
			this.length = 1U;
			base..ctor();
			this.length = len;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007220 File Offset: 0x00005420
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

		// Token: 0x060001BC RID: 444 RVA: 0x00007268 File Offset: 0x00005468
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

		// Token: 0x060001BD RID: 445 RVA: 0x000072A8 File Offset: 0x000054A8
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

		// Token: 0x060001BE RID: 446 RVA: 0x000072F8 File Offset: 0x000054F8
		public BigInteger(uint ui)
		{
			this.length = 1U;
			base..ctor();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000207A File Offset: 0x0000027A
		public static implicit operator BigInteger(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000207A File Offset: 0x0000027A
		public static implicit operator BigInteger(int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007314 File Offset: 0x00005514
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

		// Token: 0x060001C2 RID: 450 RVA: 0x00007330 File Offset: 0x00005530
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

		// Token: 0x060001C3 RID: 451 RVA: 0x00007358 File Offset: 0x00005558
		public static uint operator %(BigInteger bi, uint ui)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00007368 File Offset: 0x00005568
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			BigInteger[] array;
			return array;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00007378 File Offset: 0x00005578
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			BigInteger[] array;
			return array;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00007388 File Offset: 0x00005588
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

		// Token: 0x060001C7 RID: 455 RVA: 0x000073D8 File Offset: 0x000055D8
		public static BigInteger operator *(BigInteger bi, int i)
		{
			if (bi == null)
			{
				return 0;
			}
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000073F0 File Offset: 0x000055F0
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00007400 File Offset: 0x00005600
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00007410 File Offset: 0x00005610
		private static RandomNumberGenerator Rng
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001CA)

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

		// Token: 0x060001CB RID: 459 RVA: 0x00007424 File Offset: 0x00005624
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			/*
An exception occurred when decompiling this method (060001CB)

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

		// Token: 0x060001CC RID: 460 RVA: 0x00007434 File Offset: 0x00005634
		public static BigInteger GenerateRandom(int bits)
		{
			if (!true)
			{
			}
			RandomNumberGenerator randomNumberGenerator = BigInteger.Rng;
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000744C File Offset: 0x0000564C
		public void Randomize(RandomNumberGenerator rng)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = this == (uint)num;
			int num2 = this.BitCount();
			uint[] array = this.data;
			uint[] array2 = this.data;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000074AC File Offset: 0x000056AC
		public void Randomize()
		{
			if (!true)
			{
			}
			RandomNumberGenerator randomNumberGenerator = BigInteger.Rng;
			this.Randomize(randomNumberGenerator);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000074CC File Offset: 0x000056CC
		public int BitCount()
		{
			/*
An exception occurred when decompiling this method (060001CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Math.BigInteger::BitCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:uint32(var_0_06, ldfld:uint32(BigInteger::length, ldloc:BigInteger(this)))
	stloc:uint32[](var_1_0D, ldfld:uint32[](BigInteger::data, ldloc:BigInteger(this)))
	brtrue(IL_0000, logicnot:bool(ldloc:uint32[exp:bool](var_0_06)))
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

		// Token: 0x060001D0 RID: 464 RVA: 0x000074EC File Offset: 0x000056EC
		public bool TestBit(uint bitNum)
		{
			/*
An exception occurred when decompiling this method (060001D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Math.BigInteger::TestBit(System.UInt32)

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

		// Token: 0x060001D1 RID: 465 RVA: 0x00007500 File Offset: 0x00005700
		public bool TestBit(int bitNum)
		{
			/*
An exception occurred when decompiling this method (060001D1)

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

		// Token: 0x060001D2 RID: 466 RVA: 0x00007518 File Offset: 0x00005718
		public void SetBit(uint bitNum)
		{
			uint num = this.length;
			uint[] array = this.data;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007534 File Offset: 0x00005734
		public void SetBit(uint bitNum, bool value)
		{
			uint num = this.length;
			uint[] array = this.data;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007550 File Offset: 0x00005750
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

		// Token: 0x060001D5 RID: 469 RVA: 0x00007574 File Offset: 0x00005774
		public byte[] GetBytes()
		{
			/*
An exception occurred when decompiling this method (060001D5)

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

		// Token: 0x060001D6 RID: 470 RVA: 0x000075A8 File Offset: 0x000057A8
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			while (!true)
			{
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000075BC File Offset: 0x000057BC
		public static bool operator !=(BigInteger bi1, uint ui)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000075CC File Offset: 0x000057CC
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

		// Token: 0x060001D9 RID: 473 RVA: 0x000075E8 File Offset: 0x000057E8
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

		// Token: 0x060001DA RID: 474 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007604 File Offset: 0x00005804
		public string ToString(uint radix)
		{
			return this.ToString(radix, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007620 File Offset: 0x00005820
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
			int num2 = 1;
			bool flag2 = this == (uint)num2;
			if ("" == null)
			{
			}
			ThrowHelper.ThrowIndexOutOfRangeException();
			string text;
			return text + "";
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007674 File Offset: 0x00005874
		private void Normalize()
		{
			uint num = this.length;
			if (num != 0U)
			{
				uint[] array = this.data;
				this.length = num;
			}
			int num2 = 1;
			this.length = (uint)num2;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000076A4 File Offset: 0x000058A4
		public void Clear()
		{
			if (this.length != 0U)
			{
				uint[] array = this.data;
				uint num = this.length;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000076CC File Offset: 0x000058CC
		public override int GetHashCode()
		{
			if (this.length != 0U)
			{
				uint[] array = this.data;
				return;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000076F0 File Offset: 0x000058F0
		public override string ToString()
		{
			return this.ToString((uint)10);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007708 File Offset: 0x00005908
		public override bool Equals(object o)
		{
			if (o != null)
			{
				bool flag;
				return flag;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00007724 File Offset: 0x00005924
		public BigInteger ModInverse(BigInteger modulus)
		{
			return BigInteger.Kernel.modInverse(this, modulus);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007738 File Offset: 0x00005938
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			BigInteger bigInteger;
			return bigInteger;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007748 File Offset: 0x00005948
		public bool IsProbablePrime()
		{
			if (!true)
			{
			}
			BigInteger bigInteger = 0U;
			BigInteger.Sign sign = BigInteger.Kernel.Compare(this, bigInteger);
			uint num = this.length;
			if (num != 0U)
			{
				uint[] array = this.data;
				long num2 = 0L;
				while (num2 != 0L)
				{
				}
				return false;
			}
			bool flag;
			return flag;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000207A File Offset: 0x0000027A
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007798 File Offset: 0x00005998
		public void Incr2()
		{
			uint[] array = this.data;
			uint num = this.length;
			this.length = num;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000077BC File Offset: 0x000059BC
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
		}

		// Token: 0x0400017D RID: 381
		private uint length;

		// Token: 0x0400017E RID: 382
		private uint[] data;

		// Token: 0x0400017F RID: 383
		internal static readonly uint[] smallPrimes;

		// Token: 0x04000180 RID: 384
		private static RandomNumberGenerator rng;

		// Token: 0x02000050 RID: 80
		public enum Sign
		{
			// Token: 0x04000182 RID: 386
			Negative = -1,
			// Token: 0x04000183 RID: 387
			Zero,
			// Token: 0x04000184 RID: 388
			Positive
		}

		// Token: 0x02000051 RID: 81
		internal sealed class ModulusRing
		{
			// Token: 0x060001EB RID: 491 RVA: 0x000077CC File Offset: 0x000059CC
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

			// Token: 0x060001EC RID: 492 RVA: 0x00007804 File Offset: 0x00005A04
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

			// Token: 0x060001ED RID: 493 RVA: 0x000078B8 File Offset: 0x00005AB8
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

			// Token: 0x060001EE RID: 494 RVA: 0x00007954 File Offset: 0x00005B54
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

			// Token: 0x060001EF RID: 495 RVA: 0x000079D8 File Offset: 0x00005BD8
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

			// Token: 0x060001F0 RID: 496 RVA: 0x00007A28 File Offset: 0x00005C28
			public BigInteger Pow(uint b, BigInteger exp)
			{
				BigInteger bigInteger;
				return bigInteger;
			}

			// Token: 0x04000185 RID: 389
			private BigInteger mod;

			// Token: 0x04000186 RID: 390
			private BigInteger constant;
		}

		// Token: 0x02000052 RID: 82
		private sealed class Kernel
		{
			// Token: 0x060001F1 RID: 497 RVA: 0x00007A38 File Offset: 0x00005C38
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

			// Token: 0x060001F2 RID: 498 RVA: 0x00007A5C File Offset: 0x00005C5C
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				/*
An exception occurred when decompiling this method (060001F2)

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

			// Token: 0x060001F3 RID: 499 RVA: 0x00007A80 File Offset: 0x00005C80
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

			// Token: 0x060001F4 RID: 500 RVA: 0x00007AD4 File Offset: 0x00005CD4
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

			// Token: 0x060001F5 RID: 501 RVA: 0x00007B20 File Offset: 0x00005D20
			public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				/*
An exception occurred when decompiling this method (060001F5)

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

			// Token: 0x060001F6 RID: 502 RVA: 0x00007B54 File Offset: 0x00005D54
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				/*
An exception occurred when decompiling this method (060001F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Mono.Math.BigInteger/Kernel::SingleByteDivideInPlace(Mono.Math.BigInteger,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:BigInteger[exp:bool](n)))
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

			// Token: 0x060001F7 RID: 503 RVA: 0x00007B68 File Offset: 0x00005D68
			public static uint DwordMod(BigInteger n, uint d)
			{
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00007B78 File Offset: 0x00005D78
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

			// Token: 0x060001F9 RID: 505 RVA: 0x00007BA4 File Offset: 0x00005DA4
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

			// Token: 0x060001FA RID: 506 RVA: 0x00007C80 File Offset: 0x00005E80
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				/*
An exception occurred when decompiling this method (060001FA)

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

			// Token: 0x060001FB RID: 507 RVA: 0x00007C98 File Offset: 0x00005E98
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				/*
An exception occurred when decompiling this method (060001FB)

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

			// Token: 0x060001FC RID: 508 RVA: 0x00007CA8 File Offset: 0x00005EA8
			public static BigInteger MultiplyByDword(BigInteger n, uint f)
			{
				/*
An exception occurred when decompiling this method (060001FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::MultiplyByDword(Mono.Math.BigInteger,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:BigInteger[exp:bool](n))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

			// Token: 0x060001FD RID: 509 RVA: 0x00007CC0 File Offset: 0x00005EC0
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

			// Token: 0x060001FE RID: 510 RVA: 0x00007CE8 File Offset: 0x00005EE8
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

			// Token: 0x060001FF RID: 511 RVA: 0x00007D10 File Offset: 0x00005F10
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				/*
An exception occurred when decompiling this method (060001FF)

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

			// Token: 0x06000200 RID: 512 RVA: 0x00007D2C File Offset: 0x00005F2C
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
