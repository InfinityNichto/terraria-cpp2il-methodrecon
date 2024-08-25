using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000D5 RID: 213
	internal static class Marvin
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x00012B98 File Offset: 0x00010D98
		public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
		{
			int num;
			return num;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00012BA8 File Offset: 0x00010DA8
		public static int ComputeHash32(byte data, int count, ulong seed)
		{
			/*
An exception occurred when decompiling this method (060007E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Marvin::ComputeHash32(System.Byte,System.Int32,System.UInt64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
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

		// Token: 0x060007E2 RID: 2018 RVA: 0x00012BD8 File Offset: 0x00010DD8
		private static void Block(uint rp0, uint rp1)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint _rotl(uint value, int shift)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public static ulong DefaultSeed
		{
			[CompilerGenerated]
			get
			{
				if ((ulong)4294967296L == 0UL)
				{
				}
				return (ulong)4294967296L;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00012C0C File Offset: 0x00010E0C
		private static ulong GenerateSeed()
		{
			return (ulong)126512556670976L;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00012C24 File Offset: 0x00010E24
		// Note: this type is marked as 'beforefieldinit'.
		static Marvin()
		{
		}

		// Token: 0x04000364 RID: 868
		[CompilerGenerated]
		private static readonly ulong <DefaultSeed>k__BackingField;
	}
}
