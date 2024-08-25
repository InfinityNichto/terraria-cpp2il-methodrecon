using System;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000134 RID: 308
	internal sealed class Base64Stream : DelegatedStream, global::System.Net.Mime.IEncodableStream
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0001A28C File Offset: 0x0001848C
		internal Base64Stream(Stream stream, global::System.Net.Mime.Base64WriteStateInfo writeStateInfo)
			: base(stream)
		{
			int maxLineLength = writeStateInfo._maxLineLength;
			this._lineLength = maxLineLength;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001A2B0 File Offset: 0x000184B0
		internal Base64Stream(global::System.Net.Mime.Base64WriteStateInfo writeStateInfo)
		{
			int maxLineLength = writeStateInfo._maxLineLength;
			this._writeState = writeStateInfo;
			this._lineLength = maxLineLength;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001A2D4 File Offset: 0x000184D4
		private Base64Stream.ReadStateInfo ReadState
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600073D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Base64Stream/ReadStateInfo System.Net.Base64Stream::get_ReadState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:ReadStateInfo[exp:bool](Base64Stream::_readState, ldloc:Base64Stream(this)))
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
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001A2E8 File Offset: 0x000184E8
		internal global::System.Net.Mime.Base64WriteStateInfo WriteState
		{
			get
			{
				return this._writeState;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001A2FC File Offset: 0x000184FC
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			while (buffer == null)
			{
			}
			return "offset";
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001A318 File Offset: 0x00018518
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			while (buffer == null)
			{
			}
			return "offset";
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001A334 File Offset: 0x00018534
		public override void Close()
		{
			global::System.Net.Mime.Base64WriteStateInfo writeState = this._writeState;
			if (writeState != null)
			{
				int currentBufferUsed = writeState._currentBufferUsed;
				if (writeState.<Padding>k__BackingField == 0)
				{
				}
				byte <LastBits>k__BackingField = this._writeState.<LastBits>k__BackingField;
				return;
			}
			Stream stream = this._stream;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001A390 File Offset: 0x00018590
		public int DecodeBytes(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000742)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Base64Stream::DecodeBytes(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:uint8(var_1_13, ldfld:uint8(ReadStateInfo::<Pos>k__BackingField, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this))))
	stloc:ReadStateInfo(var_2_1A, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this)))
	stloc:uint8(var_3_26, ldfld:uint8(ReadStateInfo::<Val>k__BackingField, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this))))
	stloc:ReadStateInfo(var_4_2D, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this)))
	stloc:uint8(var_5_3A, ldfld:uint8(ReadStateInfo::<Val>k__BackingField, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this))))
	stfld:uint8(ReadStateInfo::<Val>k__BackingField, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this)), ldloc:uint8(var_5_3A))
	stloc:ReadStateInfo(var_6_4F, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this)))
	stloc:uint8(var_7_58, ldfld:uint8(ReadStateInfo::<Pos>k__BackingField, ldloc:ReadStateInfo(var_6_4F)))
	stfld:uint8(ReadStateInfo::<Pos>k__BackingField, ldloc:ReadStateInfo(var_6_4F), ldloc:uint8(var_7_58))
	stloc:uint8(var_8_6E, ldfld:uint8(ReadStateInfo::<Val>k__BackingField, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this))))
	stloc:ReadStateInfo(var_9_76, callgetter:ReadStateInfo(Base64Stream::get_ReadState, ldloc:Base64Stream(this)))
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

		// Token: 0x06000743 RID: 1859 RVA: 0x0001A414 File Offset: 0x00018614
		public int EncodeBytes(byte[] buffer, int offset, int count)
		{
			return this.EncodeBytes(buffer, offset, count, true, true);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001A42C File Offset: 0x0001862C
		internal int EncodeBytes(byte[] buffer, int offset, int count, bool dontDeferFinalBytes, bool shouldAppendSpaceToCRLF)
		{
			int num = 1;
			global::System.Net.Mime.Base64WriteStateInfo writeState = this._writeState;
			writeState.AppendHeader();
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		public Stream GetStream()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001A4B8 File Offset: 0x000186B8
		public string GetEncodedString()
		{
			/*
An exception occurred when decompiling this method (06000746)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.Base64Stream::GetEncodedString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_ASCII))
	stloc:Base64WriteStateInfo(var_2_0E, ldfld:Base64WriteStateInfo(Base64Stream::_writeState, ldloc:Base64Stream(this)))
	stloc:uint8[](var_3_15, ldfld:uint8[](WriteStateInfoBase::_buffer, ldloc:Base64WriteStateInfo[exp:WriteStateInfoBase](var_2_0E)))
	stloc:int32(var_4_1C, ldfld:int32(WriteStateInfoBase::_currentBufferUsed, ldloc:Base64WriteStateInfo[exp:WriteStateInfoBase](var_2_0E)))
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

		// Token: 0x06000747 RID: 1863 RVA: 0x0001A4E4 File Offset: 0x000186E4
		public override int EndRead(IAsyncResult asyncResult)
		{
			while (asyncResult == null)
			{
			}
			return Base64Stream.ReadAsyncResult.End(asyncResult);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001A4FC File Offset: 0x000186FC
		public override void EndWrite(IAsyncResult asyncResult)
		{
			while (asyncResult == null)
			{
			}
			Base64Stream.WriteAsyncResult.End(asyncResult);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001A514 File Offset: 0x00018714
		public override void Flush()
		{
			global::System.Net.Mime.Base64WriteStateInfo writeState = this._writeState;
			if (writeState != null)
			{
				int currentBufferUsed = writeState._currentBufferUsed;
				this.FlushInternal();
			}
			Stream stream = this._stream;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001A540 File Offset: 0x00018740
		private void FlushInternal()
		{
			global::System.Net.Mime.Base64WriteStateInfo writeState = this._writeState;
			long num = 0L;
			byte[] buffer = writeState._buffer;
			int currentBufferUsed = writeState._currentBufferUsed;
			base.Write(buffer, (int)num, currentBufferUsed);
			this._writeState.Reset();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001A578 File Offset: 0x00018778
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num;
			for (;;)
			{
				if (buffer != null)
				{
					num = base.Read(buffer, offset, count);
					if (num != 0)
					{
						break;
					}
				}
			}
			return this.DecodeBytes(buffer, offset, num);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001A5A4 File Offset: 0x000187A4
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				long num = 0L;
				long num2 = 0L;
				int num3 = this.EncodeBytes(buffer, offset, count, num != 0L, num2 != 0L);
				this.FlushInternal();
				long num4 = 0L;
				long num5 = 0L;
				int num6 = this.EncodeBytes(buffer, offset, count, num4 != 0L, num5 != 0L);
				return;
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001A5E0 File Offset: 0x000187E0
		// Note: this type is marked as 'beforefieldinit'.
		static Base64Stream()
		{
		}

		// Token: 0x040005D4 RID: 1492
		private static readonly byte[] s_base64DecodeMap;

		// Token: 0x040005D5 RID: 1493
		private static readonly byte[] s_base64EncodeMap;

		// Token: 0x040005D6 RID: 1494
		private readonly int _lineLength;

		// Token: 0x040005D7 RID: 1495
		private readonly global::System.Net.Mime.Base64WriteStateInfo _writeState;

		// Token: 0x040005D8 RID: 1496
		private Base64Stream.ReadStateInfo _readState;

		// Token: 0x040005D9 RID: 1497
		private const int SizeOfBase64EncodedChar = 4;

		// Token: 0x040005DA RID: 1498
		private const byte InvalidBase64Value = 255;

		// Token: 0x02000135 RID: 309
		private sealed class ReadAsyncResult : LazyAsyncResult
		{
			// Token: 0x0600074E RID: 1870 RVA: 0x0001A5F0 File Offset: 0x000187F0
			internal ReadAsyncResult(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				long num = 0L;
				base..ctor(num, state, callback);
				this._parent = parent;
				this._buffer = buffer;
				this._offset = offset;
				this._read = count;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0001A628 File Offset: 0x00018828
			private bool CompleteRead(IAsyncResult result)
			{
				Stream stream = this._parent._stream;
				this._read = stream;
				if (stream != null)
				{
					Base64Stream parent = this._parent;
					byte[] buffer = this._buffer;
					int offset = this._offset;
					int num;
					this._read = num;
				}
				base.InvokeCallback();
				return true;
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x0001A674 File Offset: 0x00018874
			internal void Read()
			{
				Base64Stream parent = this._parent;
				byte[] buffer = this._buffer;
				int offset = this._offset;
				int read = this._read;
				Stream stream = parent._stream;
				if (parent == null)
				{
				}
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x0001A6AC File Offset: 0x000188AC
			private static void OnRead(IAsyncResult result)
			{
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0001A6D0 File Offset: 0x000188D0
			internal static int End(IAsyncResult result)
			{
				throw new InvalidCastException();
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x0001A6E4 File Offset: 0x000188E4
			// Note: this type is marked as 'beforefieldinit'.
			static ReadAsyncResult()
			{
			}

			// Token: 0x040005DB RID: 1499
			private readonly Base64Stream _parent;

			// Token: 0x040005DC RID: 1500
			private readonly byte[] _buffer;

			// Token: 0x040005DD RID: 1501
			private readonly int _offset;

			// Token: 0x040005DE RID: 1502
			private readonly int _count;

			// Token: 0x040005DF RID: 1503
			private int _read;

			// Token: 0x040005E0 RID: 1504
			private static readonly AsyncCallback s_onRead;
		}

		// Token: 0x02000136 RID: 310
		private sealed class WriteAsyncResult : LazyAsyncResult
		{
			// Token: 0x06000754 RID: 1876 RVA: 0x0001A6F4 File Offset: 0x000188F4
			internal WriteAsyncResult(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				long num = 0L;
				base..ctor(num, state, callback);
				this._parent = parent;
				this._buffer = buffer;
				this._offset = offset;
				this._written = count;
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x0001A72C File Offset: 0x0001892C
			internal void Write()
			{
				int count = this._count;
				int offset = this._offset;
				Base64Stream parent = this._parent;
				byte[] buffer = this._buffer;
				int count2 = this._count;
				this._written = count;
				Base64Stream parent2 = this._parent;
				global::System.Net.Mime.Base64WriteStateInfo writeState = parent2._writeState;
				Stream stream = parent2._stream;
				byte[] buffer2 = writeState._buffer;
				int currentBufferUsed = writeState._currentBufferUsed;
				if (parent2 == null)
				{
				}
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x0001A7BC File Offset: 0x000189BC
			private void CompleteWrite(IAsyncResult result)
			{
				Stream stream = this._parent._stream;
				this._parent._writeState.Reset();
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x0001A7E8 File Offset: 0x000189E8
			private static void OnWrite(IAsyncResult result)
			{
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x0001A80C File Offset: 0x00018A0C
			internal static void End(IAsyncResult result)
			{
				if (result != null)
				{
				}
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x0001A824 File Offset: 0x00018A24
			// Note: this type is marked as 'beforefieldinit'.
			static WriteAsyncResult()
			{
			}

			// Token: 0x040005E1 RID: 1505
			private static readonly AsyncCallback s_onWrite;

			// Token: 0x040005E2 RID: 1506
			private readonly Base64Stream _parent;

			// Token: 0x040005E3 RID: 1507
			private readonly byte[] _buffer;

			// Token: 0x040005E4 RID: 1508
			private readonly int _offset;

			// Token: 0x040005E5 RID: 1509
			private readonly int _count;

			// Token: 0x040005E6 RID: 1510
			private int _written;
		}

		// Token: 0x02000137 RID: 311
		private sealed class ReadStateInfo
		{
			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001A834 File Offset: 0x00018A34
			// (set) Token: 0x0600075B RID: 1883 RVA: 0x0001A848 File Offset: 0x00018A48
			internal byte Val
			{
				[CompilerGenerated]
				get
				{
					return this.<Val>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Val>k__BackingField = value;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001A85C File Offset: 0x00018A5C
			// (set) Token: 0x0600075D RID: 1885 RVA: 0x0001A870 File Offset: 0x00018A70
			internal byte Pos
			{
				[CompilerGenerated]
				get
				{
					return this.<Pos>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<Pos>k__BackingField = value;
				}
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x0001A884 File Offset: 0x00018A84
			public ReadStateInfo()
			{
			}

			// Token: 0x040005E7 RID: 1511
			[CompilerGenerated]
			private byte <Val>k__BackingField;

			// Token: 0x040005E8 RID: 1512
			[CompilerGenerated]
			private byte <Pos>k__BackingField;
		}
	}
}
