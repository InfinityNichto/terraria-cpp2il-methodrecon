using System;

namespace System.Xml
{
	// Token: 0x0200000A RID: 10
	internal static class Bits
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002390 File Offset: 0x00000590
		public static int Count(uint num)
		{
			/*
An exception occurred when decompiling this method (06000017)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Bits::Count(System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:int32(var_1_0B, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_0_01)))
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

		// Token: 0x06000018 RID: 24 RVA: 0x000023A8 File Offset: 0x000005A8
		public static int LeastPosition(uint num)
		{
			return Bits.Count((uint)42167320);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023C4 File Offset: 0x000005C4
		// Note: this type is marked as 'beforefieldinit'.
		static Bits()
		{
		}

		// Token: 0x04000012 RID: 18
		private static readonly uint MASK_0101010101010101;

		// Token: 0x04000013 RID: 19
		private static readonly uint MASK_0011001100110011;

		// Token: 0x04000014 RID: 20
		private static readonly uint MASK_0000111100001111;

		// Token: 0x04000015 RID: 21
		private static readonly uint MASK_0000000011111111;

		// Token: 0x04000016 RID: 22
		private static readonly uint MASK_1111111111111111;
	}
}
