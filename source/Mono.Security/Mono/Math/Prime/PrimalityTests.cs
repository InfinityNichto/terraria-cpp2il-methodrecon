using System;

namespace Mono.Math.Prime
{
	// Token: 0x02000068 RID: 104
	public sealed class PrimalityTests
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			int num;
			return num;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			/*
An exception occurred when decompiling this method (060002F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Math.Prime.PrimalityTests::RabinMillerTest(Mono.Math.BigInteger,Mono.Math.Prime.ConfidenceFactor)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:BigInteger(var_11_37, call:BigInteger(BigInteger::GenerateRandom, ldloc:int32(var_0)))
	stloc:BigInteger(var_12_3F, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(2)))
	stloc:Sign(var_13_4A, call:Sign(Kernel::Compare, ldloc:BigInteger(var_11_37), ldloc:BigInteger(var_12_3F)))
	stloc:Sign(var_14_55, call:Sign(Kernel::Compare, ldloc:BigInteger(var_11_37), ldloc:BigInteger(var_4_15)))
	stloc:int32(var_16_58, ldc.i4:int32(1))
	stloc:bool(var_17_63, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_15), ldloc:int32[exp:uint32](var_16_58)))
	stloc:bool(var_18_6E, call:bool(BigInteger::op_Inequality, ldloc:BigInteger(var_15), ldloc:BigInteger(var_4_15)))
	stloc:BigInteger(var_19_76, call:BigInteger(BigInteger::op_Implicit, ldc.i4:int32(2)))
	stloc:int32(var_21_79, ldc.i4:int32(1))
	stloc:bool(var_22_84, call:bool(BigInteger::op_Equality, ldloc:BigInteger(var_20), ldloc:int32[exp:uint32](var_21_79)))
	stloc:bool(var_23_8F, call:bool(BigInteger::op_Inequality, ldloc:BigInteger(var_20), ldloc:BigInteger(var_4_15)))
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
