using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x02000059 RID: 89
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	public sealed class ZlibCodec
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		public int Adler32
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.ZlibCodec::get_Adler32()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(ZlibCodec::_Adler32, ldloc:ZlibCodec(this)))
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

		// Token: 0x060003C8 RID: 968 RVA: 0x0000ED70 File Offset: 0x0000CF70
		public ZlibCodec()
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000ED84 File Offset: 0x0000CF84
		public ZlibCodec(CompressionMode mode)
		{
			do
			{
				base..ctor();
				if (mode != CompressionMode.Compress)
				{
					return;
				}
			}
			while (this._InternalInitializeDeflate(true) != 0);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		public int InitializeInflate()
		{
			/*
An exception occurred when decompiling this method (060003CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.ZlibCodec::InitializeInflate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ZlibCodec::WindowBits, ldloc:ZlibCodec(this)))
	stloc:int32(var_1_0F, call:int32(ZlibCodec::InitializeInflate, ldloc:ZlibCodec(this), ldloc:int32(var_0_06), ldc.i4:bool(1)))
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

		// Token: 0x060003CB RID: 971 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		public int InitializeInflate(bool expectRfc1950Header)
		{
			/*
An exception occurred when decompiling this method (060003CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.ZlibCodec::InitializeInflate(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ZlibCodec::WindowBits, ldloc:ZlibCodec(this)))
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

		// Token: 0x060003CC RID: 972 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		public int InitializeInflate(int windowBits)
		{
			/*
An exception occurred when decompiling this method (060003CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.ZlibCodec::InitializeInflate(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(ZlibCodec::WindowBits, ldloc:ZlibCodec(this), ldloc:int32(windowBits))
	stloc:int32(var_0_0F, call:int32(ZlibCodec::InitializeInflate, ldloc:ZlibCodec(this), ldloc:int32(windowBits), ldc.i4:bool(1)))
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

		// Token: 0x060003CD RID: 973 RVA: 0x0000EE10 File Offset: 0x0000D010
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			for (;;)
			{
				DeflateManager deflateManager = this.dstate;
				this.WindowBits = windowBits;
				if (deflateManager == null)
				{
					return;
				}
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000EE30 File Offset: 0x0000D030
		public int Inflate(FlushType flush)
		{
			InflateManager inflateManager;
			do
			{
				inflateManager = this.istate;
			}
			while (inflateManager == null);
			return inflateManager.Inflate(flush);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000EE50 File Offset: 0x0000D050
		public int EndInflate()
		{
			InflateManager inflateManager;
			do
			{
				inflateManager = this.istate;
			}
			while (inflateManager == null);
			InflateBlocks blocks = inflateManager.blocks;
			if (blocks != null)
			{
				uint num = blocks.Reset();
				return;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public int SyncInflate()
		{
			InflateManager inflateManager;
			do
			{
				inflateManager = this.istate;
			}
			while (inflateManager == null);
			return inflateManager.Sync();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000EE9C File Offset: 0x0000D09C
		public int InitializeDeflate()
		{
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		public int InitializeDeflate(CompressionLevel level)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000EECC File Offset: 0x0000D0CC
		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			int num;
			return num;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			this.CompressLevel = level;
			this.Strategy = (CompressionStrategy)bits;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000EF08 File Offset: 0x0000D108
		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			this.Strategy = (CompressionStrategy)bits;
			int num;
			return num;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000EF24 File Offset: 0x0000D124
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			while (this.istate != null)
			{
			}
			CompressionLevel compressLevel = this.CompressLevel;
			CompressionStrategy strategy = this.Strategy;
			CompressionStrategy strategy2 = this.Strategy;
			int num;
			return num;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000EF50 File Offset: 0x0000D150
		public int Deflate(FlushType flush)
		{
			DeflateManager deflateManager;
			do
			{
				deflateManager = this.dstate;
			}
			while (deflateManager == null);
			return deflateManager.Deflate(flush);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000EF70 File Offset: 0x0000D170
		public int EndDeflate()
		{
			while (this.dstate == null)
			{
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000EF88 File Offset: 0x0000D188
		public void ResetDeflate()
		{
			DeflateManager deflateManager;
			do
			{
				deflateManager = this.dstate;
			}
			while (deflateManager == null);
			deflateManager.Reset();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			DeflateManager deflateManager;
			do
			{
				deflateManager = this.dstate;
			}
			while (deflateManager == null);
			return deflateManager.SetParams(level, strategy);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		public int SetDictionary(byte[] dictionary)
		{
			InflateManager inflateManager;
			DeflateManager deflateManager;
			for (;;)
			{
				inflateManager = this.istate;
				if (inflateManager != null)
				{
					break;
				}
				deflateManager = this.dstate;
				if (deflateManager != null)
				{
					goto Block_1;
				}
			}
			return inflateManager.SetDictionary(dictionary);
			Block_1:
			return deflateManager.SetDictionary(dictionary);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		internal void flush_pending()
		{
			DeflateManager deflateManager = this.dstate;
			int availableBytesOut = this.AvailableBytesOut;
			int pendingCount = deflateManager.pendingCount;
			byte[] pending = deflateManager.pending;
			int nextPending = deflateManager.nextPending;
			byte[] outputBuffer = this.OutputBuffer;
			int nextOut = this.NextOut;
			int nextOut2 = this.NextOut;
			DeflateManager deflateManager2 = this.dstate;
			this.NextOut = nextOut2;
			int nextPending2 = deflateManager2.nextPending;
			deflateManager2.nextPending = nextPending2;
			long totalBytesOut = this.TotalBytesOut;
			int availableBytesOut2 = this.AvailableBytesOut;
			this.TotalBytesOut = totalBytesOut;
			this.AvailableBytesOut = (int)totalBytesOut;
			int pendingCount2 = deflateManager2.pendingCount;
			deflateManager2.pendingCount = pendingCount2;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		internal int read_buf(byte[] buf, int start, int size)
		{
			int availableBytesIn = this.AvailableBytesIn;
			if (size != 0)
			{
				DeflateManager deflateManager = this.dstate;
				this.AvailableBytesIn = availableBytesIn;
				if (deflateManager._WantRfc1950HeaderBytes)
				{
					uint adler = this._Adler32;
					byte[] inputBuffer = this.InputBuffer;
					int nextIn = this.NextIn;
					uint num = Adler.Adler32(adler, inputBuffer, nextIn, size);
					this._Adler32 = num;
				}
				byte[] inputBuffer2 = this.InputBuffer;
				int nextIn2 = this.NextIn;
				Array.Copy(inputBuffer2, nextIn2, buf, start, size);
				int nextIn3 = this.NextIn;
				long totalBytesIn = this.TotalBytesIn;
				this.NextIn = nextIn3;
				this.TotalBytesIn = totalBytesIn;
			}
			return size;
		}

		// Token: 0x04000300 RID: 768
		public byte[] InputBuffer;

		// Token: 0x04000301 RID: 769
		public int NextIn;

		// Token: 0x04000302 RID: 770
		public int AvailableBytesIn;

		// Token: 0x04000303 RID: 771
		public long TotalBytesIn;

		// Token: 0x04000304 RID: 772
		public byte[] OutputBuffer;

		// Token: 0x04000305 RID: 773
		public int NextOut;

		// Token: 0x04000306 RID: 774
		public int AvailableBytesOut;

		// Token: 0x04000307 RID: 775
		public long TotalBytesOut;

		// Token: 0x04000308 RID: 776
		public string Message;

		// Token: 0x04000309 RID: 777
		internal DeflateManager dstate;

		// Token: 0x0400030A RID: 778
		internal InflateManager istate;

		// Token: 0x0400030B RID: 779
		internal uint _Adler32;

		// Token: 0x0400030C RID: 780
		public CompressionLevel CompressLevel;

		// Token: 0x0400030D RID: 781
		public int WindowBits;

		// Token: 0x0400030E RID: 782
		public CompressionStrategy Strategy;
	}
}
