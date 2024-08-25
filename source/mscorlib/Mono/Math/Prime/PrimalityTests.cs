using System;

namespace Mono.Math.Prime
{
	// Token: 0x02000055 RID: 85
	internal sealed class PrimalityTests
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00007E60 File Offset: 0x00006060
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			int num;
			return num;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007E94 File Offset: 0x00006094
		public static bool Test(BigInteger n, ConfidenceFactor confidence)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00007EA4 File Offset: 0x000060A4
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			/*
An exception occurred when decompiling this method (06000205)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Math.Prime.PrimalityTests::RabinMillerTest(Mono.Math.BigInteger,Mono.Math.Prime.ConfidenceFactor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:BigInteger(var_10_34, call:BigInteger(BigInteger::GenerateRandom, ldloc:int32(var_0)))
	stloc:BigInteger(var_11_3C, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(2)))
	stloc:Sign(var_12_47, call:Sign(Kernel::Compare, ldloc:BigInteger(var_10_34), ldloc:BigInteger(var_11_3C)))
	stloc:Sign(var_13_52, call:Sign(Kernel::Compare, ldloc:BigInteger(var_10_34), ldloc:BigInteger(var_4_15)))
	stloc:int32(var_15_55, ldc.i4:int32(1))
	stloc:bool(var_16_60, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_14), ldloc:int32[exp:uint32](var_15_55)))
	stloc:bool(var_17_6B, call:bool(BigInteger::op_Inequality, ldloc:BigInteger(var_14), ldloc:BigInteger(var_4_15)))
	stloc:BigInteger(var_18_73, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(2)))
	stloc:int32(var_20_76, ldc.i4:int32(1))
	stloc:bool(var_21_81, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_19), ldloc:int32[exp:uint32](var_20_76)))
	stloc:bool(var_22_8C, call:bool(BigInteger::op_Inequality, ldloc:BigInteger(var_19), ldloc:BigInteger(var_4_15)))
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

		// Token: 0x06000206 RID: 518 RVA: 0x00007F44 File Offset: 0x00006144
		public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence)
		{
			/*
An exception occurred when decompiling this method (06000206)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Math.Prime.PrimalityTests::SmallPrimeSppTest(Mono.Math.BigInteger,Mono.Math.Prime.ConfidenceFactor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BigInteger(var_1_06, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(1)))
	stloc:BigInteger(var_2_0E, call:BigInteger(BigInteger::op_Subtraction, ldloc:BigInteger(var_1_06), ldloc:BigInteger(var_1_06)))
	stloc:int32(var_3_15, call:int32(BigInteger::LowestSetBit, ldloc:BigInteger(var_2_0E)))
	stloc:BigInteger(var_4_1D, call:BigInteger(Kernel::RightShift, ldloc:BigInteger(var_2_0E), ldloc:int32(var_3_15)))
	stloc:int32(var_7_23, ldc.i4:int32(1))
	stloc:bool(var_8_2E, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_6), ldloc:int32[exp:uint32](var_7_23)))
	stloc:bool(var_9_38, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_6), ldloc:BigInteger(var_2_0E)))
	stloc:class Mono.Math.BigInteger[](var_10_4A, call:class Mono.Math.BigInteger[](Kernel::multiByteDivide, call:BigInteger(BigInteger::op_Multiply, ldloc:BigInteger(var_6), ldloc:BigInteger(var_6)), ldloc:BigInteger(var_6)))
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
}
