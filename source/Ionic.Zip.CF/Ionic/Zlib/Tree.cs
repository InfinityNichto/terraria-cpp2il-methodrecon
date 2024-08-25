using System;
using Cpp2IlInjected;

namespace Ionic.Zlib
{
	// Token: 0x0200004C RID: 76
	internal sealed class Tree
	{
		// Token: 0x0600039A RID: 922 RVA: 0x0000E284 File Offset: 0x0000C484
		internal static int DistanceCode(int dist)
		{
			/*
An exception occurred when decompiling this method (0600039A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.Tree::DistanceCode(System.Int32)

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

		// Token: 0x0600039B RID: 923 RVA: 0x0000E294 File Offset: 0x0000C494
		internal void gen_bitlen(DeflateManager s)
		{
			StaticTree staticTree = this.staticTree;
			short[] array = this.dyn_tree;
			int maxLength = staticTree.maxLength;
			short[] treeCodes = staticTree.treeCodes;
			int[] extraBits = staticTree.extraBits;
			int extraBase = staticTree.extraBase;
			if (staticTree == null)
			{
			}
			short[] bl_count = s.bl_count;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000E374 File Offset: 0x0000C574
		internal void build_tree(DeflateManager s)
		{
			StaticTree staticTree = this.staticTree;
			short[] array = this.dyn_tree;
			short[] treeCodes = staticTree.treeCodes;
			int elems = staticTree.elems;
			if (staticTree == null)
			{
			}
			int heap_len = s.heap_len;
			int[] heap = s.heap;
			s.heap_len = heap_len;
			sbyte[] depth = s.depth;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002122 File Offset: 0x00000322
		internal static int bi_reverse(int code, int len)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public Tree()
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		// Note: this type is marked as 'beforefieldinit'.
		static Tree()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040002A7 RID: 679
		internal const int Buf_size = 16;

		// Token: 0x040002A8 RID: 680
		private static readonly int HEAP_SIZE;

		// Token: 0x040002A9 RID: 681
		internal static readonly int[] ExtraLengthBits;

		// Token: 0x040002AA RID: 682
		internal static readonly int[] ExtraDistanceBits;

		// Token: 0x040002AB RID: 683
		internal static readonly int[] extra_blbits;

		// Token: 0x040002AC RID: 684
		internal static readonly sbyte[] bl_order;

		// Token: 0x040002AD RID: 685
		private static readonly sbyte[] _dist_code;

		// Token: 0x040002AE RID: 686
		internal static readonly sbyte[] LengthCode;

		// Token: 0x040002AF RID: 687
		internal static readonly int[] LengthBase;

		// Token: 0x040002B0 RID: 688
		internal static readonly int[] DistanceBase;

		// Token: 0x040002B1 RID: 689
		internal short[] dyn_tree;

		// Token: 0x040002B2 RID: 690
		internal int max_code;

		// Token: 0x040002B3 RID: 691
		internal StaticTree staticTree;
	}
}
