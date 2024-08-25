using System;
using Cpp2IlInjected;

namespace Ionic.Zlib
{
	// Token: 0x02000040 RID: 64
	internal sealed class DeflateManager
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0000AC98 File Offset: 0x00008E98
		internal DeflateManager()
		{
			if (!true)
			{
			}
			int num = 1;
			this._WantRfc1950HeaderBytes = num != 0;
			base..ctor();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000ACCC File Offset: 0x00008ECC
		private void _InitializeLazyMatch()
		{
			int num = this.w_size;
			short[] array = this.head;
			int num2 = this.hash_size;
			long num3 = 0L;
			this.window_size = num;
			Array.Clear(array, (int)num3, num2);
			CompressionLevel compressionLevel = this.compressionLevel;
			if (num == 0)
			{
			}
			DeflateManager.Config config = DeflateManager.Config.Lookup(compressionLevel);
			this.config = config;
			this.SetDeflater();
			if (num == 0)
			{
			}
			this.prev_length = num;
			this.match_length = num;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000AD34 File Offset: 0x00008F34
		private void _InitializeTreeData()
		{
			Tree tree = this.treeLiterals;
			short[] array = this.dyn_ltree;
			tree.dyn_tree = array;
			if (array == null)
			{
			}
			Tree tree2 = this.treeDistances;
			short[] array2 = this.dyn_dtree;
			tree2.dyn_tree = array2;
			tree2.staticTree = array2;
			Tree tree3 = this.treeBitLengths;
			short[] array3 = this.bl_tree;
			tree3.dyn_tree = array3;
			tree3.staticTree = array;
			this.last_eob_len = 8;
			this._InitializeBlocks();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000ADA4 File Offset: 0x00008FA4
		internal void _InitializeBlocks()
		{
			if (!true)
			{
			}
			short[] array = this.dyn_ltree;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		internal void pqdownheap(short[] tree, int k)
		{
			int[] array = this.heap;
			int num = this.heap_len;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000AE44 File Offset: 0x00009044
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000AE54 File Offset: 0x00009054
		internal void scan_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000AEA4 File Offset: 0x000090A4
		internal int build_bl_tree()
		{
			/*
An exception occurred when decompiling this method (06000314)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::build_bl_tree()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_7_6B, ldfld:int32(DeflateManager::opt_len, ldloc:DeflateManager(this)))
	stfld:int32(DeflateManager::opt_len, ldloc:DeflateManager(this), ldloc:int32(var_7_6B))
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

		// Token: 0x06000315 RID: 789 RVA: 0x0000AF28 File Offset: 0x00009128
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
			int num = 1;
			int num2 = 5;
			this.send_bits(lcodes, num2);
			int num3 = 5;
			this.send_bits(dcodes, num3);
			int num4 = 4;
			this.send_bits(dcodes, num4);
			short[] array = this.bl_tree;
			if (num == 0)
			{
			}
			int num5 = 3;
			this.send_bits(dcodes, num5);
			short[] array2 = this.dyn_ltree;
			this.send_tree(array2, num5);
			short[] array3 = this.dyn_dtree;
			this.send_tree(array3, dcodes);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000AF94 File Offset: 0x00009194
		internal void send_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000AFE4 File Offset: 0x000091E4
		private void put_bytes(byte[] p, int start, int len)
		{
			byte[] array = this.pending;
			int num = this.pendingCount;
			Array.Copy(p, start, array, num, len);
			int num2 = this.pendingCount;
			this.pendingCount = num2;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000B018 File Offset: 0x00009218
		internal void send_code(int c, short[] tree)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000B028 File Offset: 0x00009228
		internal void send_bits(int value, int length)
		{
			int num = 1;
			int num2 = this.bi_valid;
			if (num != 0)
			{
				return;
			}
			int num3 = this.bi_valid;
			short num4 = this.bi_buf;
			byte[] array = this.pending;
			byte[] array2 = this.pending;
			if (num3 == 0)
			{
			}
			int num5 = this.bi_valid;
			this.bi_buf = array;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000B07C File Offset: 0x0000927C
		internal void _tr_align()
		{
			if (!true)
			{
			}
			this.send_bits(int.MinValue, int.MinValue);
			this.bi_flush();
			int num = this.last_eob_len;
			int num2 = this.bi_valid;
			if (num == 0)
			{
			}
			int num3 = 3;
			this.send_bits(int.MinValue, num3);
			if (num2 == 0)
			{
			}
			this.send_bits(int.MinValue, int.MinValue);
			this.bi_flush();
			int num4 = 7;
			this.last_eob_len = num4;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000B0E4 File Offset: 0x000092E4
		internal bool _tr_tally(int dist, int lc)
		{
			/*
An exception occurred when decompiling this method (0600031B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.DeflateManager::_tr_tally(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C2:
	stloc:int32(var_21_C8, ldfld:int32(DeflateManager::last_lit, ldloc:DeflateManager(this)))
	stloc:int32(var_22_D0, ldfld:int32(DeflateManager::matches, ldloc:DeflateManager(this)))
	stloc:int32(var_24_DB, ldfld:int32(DeflateManager::lit_bufsize, ldloc:DeflateManager(this)))
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

		// Token: 0x0600031C RID: 796 RVA: 0x0000B1D0 File Offset: 0x000093D0
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
			while (this.last_lit == 0)
			{
			}
			int distanceOffset = this._distanceOffset;
			byte[] array = this.pending;
			int lengthOffset = this._lengthOffset;
			long num;
			if (43151360 != 0)
			{
				if (distanceOffset == 0)
				{
				}
				if (array == null)
				{
				}
				if (dtree == null || array == null)
				{
				}
				num = 0L;
				int num2 = 2;
				if (43151360 != 0)
				{
					if (num2 == 0)
					{
					}
					return;
				}
			}
			else
			{
				this.send_bits((int)num, 43151360);
			}
			if (this.last_lit == 0)
			{
			}
			this.send_bits((int)num, 43151360);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000B244 File Offset: 0x00009444
		internal void set_data_type()
		{
			short[] array = this.dyn_ltree;
			if (!false)
			{
			}
			short[] array2 = this.dyn_ltree;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000B284 File Offset: 0x00009484
		internal void bi_flush()
		{
			int num = this.bi_valid;
			byte[] array = this.pending;
			short num2 = this.bi_buf;
			this.pendingCount = (int)num2;
			byte[] array2 = this.pending;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000B2E8 File Offset: 0x000094E8
		internal void bi_windup()
		{
			int num = this.bi_valid;
			byte[] array = this.pending;
			short num2 = this.bi_buf;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000B324 File Offset: 0x00009524
		internal void copy_block(int buf, int len, bool header)
		{
			this.bi_windup();
			int num = 8;
			this.last_eob_len = num;
			byte[] array = this.pending;
			byte[] array2 = this.pending;
			byte[] array3 = this.pending;
			byte[] array4 = this.pending;
			byte[] array5 = this.window;
			byte[] array6 = this.pending;
			int num2 = this.pendingCount;
			Array.Copy(array5, buf, array6, num2, len);
			int num3 = this.pendingCount;
			this.pendingCount = num3;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000B394 File Offset: 0x00009594
		internal void flush_block_only(bool eof)
		{
			int num = this.block_start;
			int num2 = this.strstart;
			int num3 = this.strstart;
			ZlibCodec codec = this._codec;
			this.block_start = num3;
			codec.flush_pending();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000B3CC File Offset: 0x000095CC
		internal BlockState DeflateNone(FlushType flush)
		{
			for (;;)
			{
				byte[] array = this.pending;
				int num = this.lookahead;
				this._fillWindow();
				int num2 = this.lookahead;
				long num9;
				if (num2 != 0)
				{
					int num3 = this.strstart;
					int num4 = this.block_start;
					long num5 = 0L;
					this.lookahead = num3;
					this.strstart = num2;
					this.flush_block_only(num5 != 0L);
					int availableBytesOut = this._codec.AvailableBytesOut;
					if (availableBytesOut == 0)
					{
						return;
					}
					int num6 = this.strstart;
					int num7 = this.block_start;
					int num8 = this.w_size;
					if (availableBytesOut == 0)
					{
					}
					num9 = 0L;
					this.flush_block_only(num9 != 0L);
					if (this._codec.AvailableBytesOut != 0)
					{
						continue;
					}
				}
				if (flush == FlushType.None)
				{
					return;
				}
				this.flush_block_only(num9 != 0L);
				if (this._codec.AvailableBytesOut != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000B48C File Offset: 0x0000968C
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			if (!true)
			{
			}
			this.send_bits(eof ? 1 : 0, 3);
			this.copy_block(buf, stored_len, true);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000B4B0 File Offset: 0x000096B0
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
			if (this.compressionLevel == CompressionLevel.None)
			{
			}
			this.set_data_type();
			this.treeLiterals.build_tree(this);
			this.treeDistances.build_tree(this);
			int num = this.build_bl_tree();
			int num2 = this.static_len;
			int num3 = this.opt_len;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000B580 File Offset: 0x00009780
		private void _fillWindow()
		{
			int num2;
			int num8;
			for (;;)
			{
				int num = this.window_size;
				num2 = this.lookahead;
				int num3 = this.strstart;
				if (num2 != 0)
				{
					break;
				}
				int num4 = this.w_size;
				if (this._codec.AvailableBytesIn == 0)
				{
					return;
				}
				int num5 = this.strstart;
				int num6 = this.lookahead;
				byte[] array = this.window;
				int num7 = this.lookahead;
				this.lookahead = num4;
				if (num7 == 0)
				{
				}
				byte[] array2 = this.window;
				this.ins_h = num8;
				int num9 = this.hash_mask;
				int num10 = this.block_start;
				this.ins_h = array2;
				int num11 = this.lookahead;
				if (array2 == null)
				{
				}
				if (this._codec.AvailableBytesIn == 0)
				{
					return;
				}
			}
			int num12 = this.w_size;
			if (num2 == 0)
			{
			}
			byte[] array3 = this.window;
			int num13 = this.w_size;
			long num14 = 0L;
			Array.Copy(array3, num13, array3, (int)num14, num13);
			int num15 = this.w_size;
			int num16 = this.block_start;
			num8 = this.hash_size;
			short[] array4 = this.head;
			this.block_start = num16;
			short[] array5 = this.prev;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000B688 File Offset: 0x00009888
		internal BlockState DeflateFast(FlushType flush)
		{
			/*
An exception occurred when decompiling this method (06000326)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zlib.BlockState Ionic.Zlib.DeflateManager::DeflateFast(Ionic.Zlib.FlushType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_020B:
	call:void(DeflateManager::flush_block_only, ldloc:DeflateManager(this), ldloc:int64[exp:bool](var_45))
	brtrue(IL_0000, logicnot:bool(ldfld:int32[exp:bool](ZlibCodec::AvailableBytesOut, ldfld:ZlibCodec(DeflateManager::_codec, ldloc:DeflateManager(this)))))
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

		// Token: 0x06000327 RID: 807 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		internal BlockState DeflateSlow(FlushType flush)
		{
			/*
An exception occurred when decompiling this method (06000327)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zlib.BlockState Ionic.Zlib.DeflateManager::DeflateSlow(Ionic.Zlib.FlushType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_02D7:
	call:void(DeflateManager::flush_block_only, ldloc:DeflateManager(this), ldloc:int64[exp:bool](var_62))
	brtrue(IL_0000, logicnot:bool(ldfld:int32[exp:bool](ZlibCodec::AvailableBytesOut, ldfld:ZlibCodec(DeflateManager::_codec, ldloc:DeflateManager(this)))))
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

		// Token: 0x06000328 RID: 808 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		internal int longest_match(int cur_match)
		{
			/*
An exception occurred when decompiling this method (06000328)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::longest_match(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008B:
	stfld:int32(DeflateManager::match_start, ldloc:DeflateManager(this), ldloc:int32(cur_match))
	stloc:uint8[](var_18_98, ldfld:uint8[](DeflateManager::window, ldloc:DeflateManager(this)))
	stloc:int16[](var_19_A0, ldfld:int16[](DeflateManager::prev, ldloc:DeflateManager(this)))
	stloc:uint8[](var_20_A8, ldfld:uint8[](DeflateManager::window, ldloc:DeflateManager(this)))
	stloc:int32(var_21_B0, ldfld:int32(DeflateManager::lookahead, ldloc:DeflateManager(this)))
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000BC74 File Offset: 0x00009E74
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000BC88 File Offset: 0x00009E88
		internal bool WantRfc1950HeaderBytes
		{
			get
			{
				return this._WantRfc1950HeaderBytes;
			}
			set
			{
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000BC98 File Offset: 0x00009E98
		internal int Initialize(ZlibCodec codec, CompressionLevel level)
		{
			/*
An exception occurred when decompiling this method (0600032B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::Initialize(Ionic.Zlib.ZlibCodec,Ionic.Zlib.CompressionLevel)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0A, call:int32(DeflateManager::Initialize, ldloc:DeflateManager(this), ldloc:ZlibCodec(codec), ldloc:CompressionLevel(level), ldc.i4:int32(15)))
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

		// Token: 0x0600032C RID: 812 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000BCDC File Offset: 0x00009EDC
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			/*
An exception occurred when decompiling this method (0600032E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::Initialize(Ionic.Zlib.ZlibCodec,Ionic.Zlib.CompressionLevel,System.Int32,System.Int32,Ionic.Zlib.CompressionStrategy)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int32(var_3_38, ldfld:int32(DeflateManager::w_size, ldloc:DeflateManager(this)))
	stloc:int32(var_4_3F, ldfld:int32(DeflateManager::hash_size, ldloc:DeflateManager(this)))
	stloc:int32(var_5_47, ldfld:int32(DeflateManager::lit_bufsize, ldloc:DeflateManager(this)))
	stfld:CompressionLevel(DeflateManager::compressionLevel, ldloc:DeflateManager(this), ldloc:CompressionLevel(level))
	stfld:int32(DeflateManager::_distanceOffset, ldloc:DeflateManager(this), ldloc:int32(var_5_47))
	stfld:int32(DeflateManager::_lengthOffset, ldloc:DeflateManager(this), ldloc:int32(var_5_47))
	call:void(DeflateManager::Reset, ldloc:DeflateManager(this))
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

		// Token: 0x0600032F RID: 815 RVA: 0x0000BD54 File Offset: 0x00009F54
		internal void Reset()
		{
			ZlibCodec codec = this._codec;
			bool wantRfc1950HeaderBytes = this._WantRfc1950HeaderBytes;
			ZlibCodec codec2;
			if (!true)
			{
				codec2 = this._codec;
			}
			this.status = 1;
			if (!true)
			{
			}
			uint num;
			codec2._Adler32 = num;
			this._InitializeTreeData();
			this._InitializeLazyMatch();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000BD9C File Offset: 0x00009F9C
		internal int End()
		{
			/*
An exception occurred when decompiling this method (06000330)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::End()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_1_10, ldfld:int32(DeflateManager::status, ldloc:DeflateManager(this)))
	stloc:int32(var_2_17, ldfld:int32(DeflateManager::status, ldloc:DeflateManager(this)))
	stloc:int32(var_3_1E, ldfld:int32(DeflateManager::status, ldloc:DeflateManager(this)))
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

		// Token: 0x06000331 RID: 817 RVA: 0x0000BDCC File Offset: 0x00009FCC
		private void SetDeflater()
		{
			if (this.config.Flavor != DeflateFlavor.Store)
			{
				return;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
		{
			/*
An exception occurred when decompiling this method (06000332)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::SetParams(Ionic.Zlib.CompressionLevel,Ionic.Zlib.CompressionStrategy)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stfld:CompressionLevel(DeflateManager::compressionLevel, ldloc:DeflateManager(this), ldloc:CompressionLevel(level))
	stfld:Config(DeflateManager::config, ldloc:DeflateManager(this), ldloc:Config(var_1_0D))
	call:void(DeflateManager::SetDeflater, ldloc:DeflateManager(this))
	stfld:CompressionStrategy(DeflateManager::compressionStrategy, ldloc:DeflateManager(this), ldloc:CompressionStrategy(strategy))
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

		// Token: 0x06000333 RID: 819 RVA: 0x0000BE50 File Offset: 0x0000A050
		internal int SetDictionary(byte[] dictionary)
		{
			/*
An exception occurred when decompiling this method (06000333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateManager::SetDictionary(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A4:
	stloc:int32(var_17_AA, ldfld:int32(DeflateManager::hash_mask, ldloc:DeflateManager(this)))
	stloc:int16[](var_18_B2, ldfld:int16[](DeflateManager::prev, ldloc:DeflateManager(this)))
	stloc:int16[](var_19_BA, ldfld:int16[](DeflateManager::head, ldloc:DeflateManager(this)))
	stloc:int32(var_20_C2, ldfld:int32(DeflateManager::w_mask, ldloc:DeflateManager(this)))
	stfld:int32(DeflateManager::ins_h, ldloc:DeflateManager(this), ldloc:uint8[][exp:int32](var_10_57))
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

		// Token: 0x06000334 RID: 820 RVA: 0x0000BF2C File Offset: 0x0000A12C
		internal int Deflate(FlushType flush)
		{
			int availableBytesOut;
			for (;;)
			{
				ZlibCodec codec = this._codec;
				if (codec.OutputBuffer != null)
				{
					int availableBytesIn;
					if (codec.InputBuffer == null)
					{
						availableBytesIn = codec.AvailableBytesIn;
						if (availableBytesIn != 0)
						{
							continue;
						}
					}
					int num = this.status;
					if (availableBytesIn == 0)
					{
					}
					availableBytesOut = this._codec.AvailableBytesOut;
					if (availableBytesOut != 0)
					{
						break;
					}
				}
			}
			int num2 = this.last_flush;
			this.last_flush = (int)flush;
			int num3 = this.status;
			if (availableBytesOut == 0)
			{
			}
			if (availableBytesOut == 0)
			{
			}
			int num4 = this.w_bits;
			CompressionLevel compressionLevel = this.compressionLevel;
			int num5 = this.strstart;
			int num6 = 3;
			if (num5 == 0 || availableBytesOut == 0)
			{
			}
			int num7 = 2115;
			if (num4 == 0)
			{
			}
			byte[] array = this.pending;
			this.pendingCount = num4;
			this.status = num7;
			byte[] array2 = this.pending;
			this.pendingCount = num4;
			if (this.strstart != 0)
			{
				ZlibCodec codec2 = this._codec;
				this.pendingCount = num6;
				byte[] array3 = this.pending;
				ZlibCodec codec3 = this._codec;
				this.pendingCount = array3;
				byte[] array4 = this.pending;
				ZlibCodec codec4 = this._codec;
				this.pendingCount = array4;
				byte[] array5 = this.pending;
				uint adler = codec4._Adler32;
				ZlibCodec codec5 = this._codec;
				this.pendingCount = array5;
				byte[] array6 = this.pending;
				uint adler2 = codec5._Adler32;
			}
			ZlibCodec codec6 = this._codec;
			uint num8;
			codec6._Adler32 = num8;
			int num9 = this.pendingCount;
			ZlibCodec codec7 = this._codec;
			if (num9 != 0)
			{
				codec7.flush_pending();
				int availableBytesOut2 = this._codec.AvailableBytesOut;
				if (availableBytesOut2 == 0)
				{
					return;
				}
				int num10 = this.status;
				if (availableBytesOut2 == 0)
				{
				}
				ZlibCodec codec8 = this._codec;
				int availableBytesIn2 = codec8.AvailableBytesIn;
				if (availableBytesIn2 != 0)
				{
					codec8.Message = availableBytesOut2;
					return "status == FINISH_STATE && _codec.AvailableBytesIn != 0";
				}
				if (availableBytesIn2 != 0)
				{
					if (availableBytesOut2 == 0)
					{
					}
					if ("status == FINISH_STATE && _codec.AvailableBytesIn != 0" != null || availableBytesOut2 != 0)
					{
						return;
					}
				}
				if (flush != FlushType.None)
				{
					if (availableBytesIn2 == 0)
					{
					}
					return;
				}
				return;
			}
			else
			{
				int availableBytesOut2;
				if (availableBytesOut2 != 0)
				{
					return "status == FINISH_STATE && _codec.AvailableBytesIn != 0";
				}
				return;
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000C104 File Offset: 0x0000A304
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateManager()
		{
			if (("need dictionary" == null || "need dictionary" != null) && ("stream end" == null || "stream end" != null) && ("" == null || "" != null) && ("file error" == null || "file error" != null) && ("stream error" == null || "stream error" != null) && ("data error" == null || "data error" != null) && ("insufficient memory" == null || "insufficient memory" != null) && ("buffer error" == null || "buffer error" != null) && ("incompatible version" == null || "incompatible version" != null) && ("" == null || "" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040001DC RID: 476
		private static readonly int MEM_LEVEL_MAX;

		// Token: 0x040001DD RID: 477
		private static readonly int MEM_LEVEL_DEFAULT;

		// Token: 0x040001DE RID: 478
		private DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x040001DF RID: 479
		private static readonly string[] _ErrorMessage;

		// Token: 0x040001E0 RID: 480
		private static readonly int PRESET_DICT;

		// Token: 0x040001E1 RID: 481
		private static readonly int INIT_STATE;

		// Token: 0x040001E2 RID: 482
		private static readonly int BUSY_STATE;

		// Token: 0x040001E3 RID: 483
		private static readonly int FINISH_STATE;

		// Token: 0x040001E4 RID: 484
		private static readonly int Z_DEFLATED;

		// Token: 0x040001E5 RID: 485
		private static readonly int STORED_BLOCK;

		// Token: 0x040001E6 RID: 486
		private static readonly int STATIC_TREES;

		// Token: 0x040001E7 RID: 487
		private static readonly int DYN_TREES;

		// Token: 0x040001E8 RID: 488
		private static readonly int Z_BINARY;

		// Token: 0x040001E9 RID: 489
		private static readonly int Z_ASCII;

		// Token: 0x040001EA RID: 490
		private static readonly int Z_UNKNOWN;

		// Token: 0x040001EB RID: 491
		private static readonly int Buf_size;

		// Token: 0x040001EC RID: 492
		private static readonly int MIN_MATCH;

		// Token: 0x040001ED RID: 493
		private static readonly int MAX_MATCH;

		// Token: 0x040001EE RID: 494
		private static readonly int MIN_LOOKAHEAD;

		// Token: 0x040001EF RID: 495
		private static readonly int HEAP_SIZE;

		// Token: 0x040001F0 RID: 496
		private static readonly int END_BLOCK;

		// Token: 0x040001F1 RID: 497
		internal ZlibCodec _codec;

		// Token: 0x040001F2 RID: 498
		internal int status;

		// Token: 0x040001F3 RID: 499
		internal byte[] pending;

		// Token: 0x040001F4 RID: 500
		internal int nextPending;

		// Token: 0x040001F5 RID: 501
		internal int pendingCount;

		// Token: 0x040001F6 RID: 502
		internal sbyte data_type;

		// Token: 0x040001F7 RID: 503
		internal int last_flush;

		// Token: 0x040001F8 RID: 504
		internal int w_size;

		// Token: 0x040001F9 RID: 505
		internal int w_bits;

		// Token: 0x040001FA RID: 506
		internal int w_mask;

		// Token: 0x040001FB RID: 507
		internal byte[] window;

		// Token: 0x040001FC RID: 508
		internal int window_size;

		// Token: 0x040001FD RID: 509
		internal short[] prev;

		// Token: 0x040001FE RID: 510
		internal short[] head;

		// Token: 0x040001FF RID: 511
		internal int ins_h;

		// Token: 0x04000200 RID: 512
		internal int hash_size;

		// Token: 0x04000201 RID: 513
		internal int hash_bits;

		// Token: 0x04000202 RID: 514
		internal int hash_mask;

		// Token: 0x04000203 RID: 515
		internal int hash_shift;

		// Token: 0x04000204 RID: 516
		internal int block_start;

		// Token: 0x04000205 RID: 517
		private DeflateManager.Config config;

		// Token: 0x04000206 RID: 518
		internal int match_length;

		// Token: 0x04000207 RID: 519
		internal int prev_match;

		// Token: 0x04000208 RID: 520
		internal int match_available;

		// Token: 0x04000209 RID: 521
		internal int strstart;

		// Token: 0x0400020A RID: 522
		internal int match_start;

		// Token: 0x0400020B RID: 523
		internal int lookahead;

		// Token: 0x0400020C RID: 524
		internal int prev_length;

		// Token: 0x0400020D RID: 525
		internal CompressionLevel compressionLevel;

		// Token: 0x0400020E RID: 526
		internal CompressionStrategy compressionStrategy;

		// Token: 0x0400020F RID: 527
		internal short[] dyn_ltree;

		// Token: 0x04000210 RID: 528
		internal short[] dyn_dtree;

		// Token: 0x04000211 RID: 529
		internal short[] bl_tree;

		// Token: 0x04000212 RID: 530
		internal Tree treeLiterals;

		// Token: 0x04000213 RID: 531
		internal Tree treeDistances;

		// Token: 0x04000214 RID: 532
		internal Tree treeBitLengths;

		// Token: 0x04000215 RID: 533
		internal short[] bl_count;

		// Token: 0x04000216 RID: 534
		internal int[] heap;

		// Token: 0x04000217 RID: 535
		internal int heap_len;

		// Token: 0x04000218 RID: 536
		internal int heap_max;

		// Token: 0x04000219 RID: 537
		internal sbyte[] depth;

		// Token: 0x0400021A RID: 538
		internal int _lengthOffset;

		// Token: 0x0400021B RID: 539
		internal int lit_bufsize;

		// Token: 0x0400021C RID: 540
		internal int last_lit;

		// Token: 0x0400021D RID: 541
		internal int _distanceOffset;

		// Token: 0x0400021E RID: 542
		internal int opt_len;

		// Token: 0x0400021F RID: 543
		internal int static_len;

		// Token: 0x04000220 RID: 544
		internal int matches;

		// Token: 0x04000221 RID: 545
		internal int last_eob_len;

		// Token: 0x04000222 RID: 546
		internal short bi_buf;

		// Token: 0x04000223 RID: 547
		internal int bi_valid;

		// Token: 0x04000224 RID: 548
		private bool Rfc1950BytesEmitted;

		// Token: 0x04000225 RID: 549
		private bool _WantRfc1950HeaderBytes;

		// Token: 0x02000041 RID: 65
		internal sealed class CompressFunc : MulticastDelegate
		{
			// Token: 0x06000336 RID: 822 RVA: 0x0000C1AC File Offset: 0x0000A3AC
			public CompressFunc(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000C200 File Offset: 0x0000A400
			public BlockState Invoke(FlushType flush)
			{
				/*
An exception occurred when decompiling this method (06000337)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zlib.BlockState Ionic.Zlib.DeflateManager/CompressFunc::Invoke(Ionic.Zlib.FlushType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:CompressFunc[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:CompressFunc[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:CompressFunc[exp:Delegate](this)))
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

			// Token: 0x06000338 RID: 824 RVA: 0x00002122 File Offset: 0x00000322
			public IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00002122 File Offset: 0x00000322
			public BlockState EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000042 RID: 66
		internal class Config
		{
			// Token: 0x0600033A RID: 826 RVA: 0x0000C224 File Offset: 0x0000A424
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
				this.GoodLength = goodLength;
				this.NiceLength = maxLazy;
				this.NiceLength = niceLength;
				this.Flavor = (DeflateFlavor)maxChainLength;
				this.Flavor = flavor;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000C25C File Offset: 0x0000A45C
			public static DeflateManager.Config Lookup(CompressionLevel level)
			{
				/*
An exception occurred when decompiling this method (0600033B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zlib.DeflateManager/Config Ionic.Zlib.DeflateManager/Config::Lookup(Ionic.Zlib.CompressionLevel)

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

			// Token: 0x0600033C RID: 828 RVA: 0x0000C26C File Offset: 0x0000A46C
			static Config()
			{
			}

			// Token: 0x04000226 RID: 550
			internal int GoodLength;

			// Token: 0x04000227 RID: 551
			internal int MaxLazy;

			// Token: 0x04000228 RID: 552
			internal int NiceLength;

			// Token: 0x04000229 RID: 553
			internal int MaxChainLength;

			// Token: 0x0400022A RID: 554
			internal DeflateFlavor Flavor;

			// Token: 0x0400022B RID: 555
			private static readonly DeflateManager.Config[] Table;
		}
	}
}
