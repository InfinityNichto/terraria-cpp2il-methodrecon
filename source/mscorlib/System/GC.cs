using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000155 RID: 341
	public static class GC
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetCollectionCount(int generation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0001D840 File Offset: 0x0001BA40
		private static void InternalCollect(int generation)
		{
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0001D850 File Offset: 0x0001BA50
		internal static void register_ephemeron_array(Ephemeron[] array)
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0000207A File Offset: 0x0000027A
		private static object get_ephemeron_tombstone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0001D860 File Offset: 0x0001BA60
		internal static void GetMemoryInfo([Out] uint highMemLoadThreshold, [Out] ulong totalPhysicalMem, [Out] uint lastRecordedMemLoad, [Out] UIntPtr lastRecordedHeapSize, [Out] UIntPtr lastRecordedFragmentation)
		{
			totalPhysicalMem.m_value = 1UL;
			if (!true)
			{
			}
			lastRecordedHeapSize._pointer = 1;
			lastRecordedFragmentation._pointer = 1;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0001D888 File Offset: 0x0001BA88
		public static void Collect(int generation)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0001D898 File Offset: 0x0001BA98
		public static void Collect(int generation, GCCollectionMode mode)
		{
			if (!true)
			{
			}
			GC.Collect(generation, mode, true);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		public static void Collect(int generation, GCCollectionMode mode, bool blocking)
		{
			if (!true)
			{
			}
			long num = 0L;
			GC.Collect(generation, mode, blocking, num != 0L);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0001D8CC File Offset: 0x0001BACC
		public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int CollectionCount(int generation)
		{
			/*
An exception occurred when decompiling this method (06000D87)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.GC::CollectionCount(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Value must be positive.")))
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

		// Token: 0x06000D88 RID: 3464 RVA: 0x0001D908 File Offset: 0x0001BB08
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void KeepAlive(object obj)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0001D918 File Offset: 0x0001BB18
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static void _SuppressFinalize(object o)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0001D928 File Offset: 0x0001BB28
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SuppressFinalize(object obj)
		{
			while (obj == null)
			{
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0001D938 File Offset: 0x0001BB38
		private static void _ReRegisterForFinalize(object o)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0001D948 File Offset: 0x0001BB48
		public static void ReRegisterForFinalize(object obj)
		{
			while (obj == null)
			{
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0000207A File Offset: 0x0000027A
		public static long GetTotalMemory(bool forceFullCollection)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0001D958 File Offset: 0x0001BB58
		// Note: this type is marked as 'beforefieldinit'.
		static GC()
		{
		}

		// Token: 0x04000539 RID: 1337
		internal static readonly object EPHEMERON_TOMBSTONE;
	}
}
