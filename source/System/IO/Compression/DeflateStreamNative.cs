using System;
using System.Runtime.InteropServices;
using Mono.Util;

namespace System.IO.Compression
{
	// Token: 0x02000440 RID: 1088
	internal class DeflateStreamNative
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x0004FF20 File Offset: 0x0004E120
		private DeflateStreamNative()
		{
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0004FF34 File Offset: 0x0004E134
		public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0004FF48 File Offset: 0x0004E148
		protected override void Finalize()
		{
			long num = 0L;
			this.Dispose(num != 0L);
			base.Finalize();
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0004FF88 File Offset: 0x0004E188
		public void Dispose(bool disposing)
		{
			bool flag = this.disposed;
			if (flag)
			{
				if (!flag)
				{
				}
				if (this.z_stream != null)
				{
					this.z_stream.Dispose();
				}
				return;
			}
			int num = 1;
			this.disposed = num != 0;
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		public void Flush()
		{
			int num = DeflateStreamNative.Flush(this.z_stream);
			this.CheckResult(num, "Flush");
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0004FFF0 File Offset: 0x0004E1F0
		public int ReadZStream(IntPtr buffer, int length)
		{
			int num = DeflateStreamNative.ReadZStream(this.z_stream, buffer, length);
			this.CheckResult(num, "ReadInternal");
			return num;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00050018 File Offset: 0x0004E218
		public void WriteZStream(IntPtr buffer, int length)
		{
			int num = DeflateStreamNative.WriteZStream(this.z_stream, buffer, length);
			this.CheckResult(num, "WriteInternal");
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00050040 File Offset: 0x0004E240
		[Mono.Util.MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			GCHandle gchandle = GCHandle.FromIntPtr((IntPtr)length);
			if (gchandle.Target != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00050060 File Offset: 0x0004E260
		private int UnmanagedRead(IntPtr buffer, int length)
		{
			/*
An exception occurred when decompiling this method (06001DE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStreamNative::UnmanagedRead(System.IntPtr,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_1_15, call:int32(Math::Min, ldloc:int32(length), ldloc:int32(var_0)))
	stloc:Stream(var_2_1C, ldfld:Stream(DeflateStreamNative::base_stream, ldloc:DeflateStreamNative(this)))
	stloc:uint8[](var_3_23, ldfld:uint8[](DeflateStreamNative::io_buffer, ldloc:DeflateStreamNative(this)))
	stloc:uint8[](var_4_2A, ldfld:uint8[](DeflateStreamNative::io_buffer, ldloc:DeflateStreamNative(this)))
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

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000500A0 File Offset: 0x0004E2A0
		[Mono.Util.MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			GCHandle gchandle = GCHandle.FromIntPtr((IntPtr)length);
			if (gchandle.Target != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000500C0 File Offset: 0x0004E2C0
		private int UnmanagedWrite(IntPtr buffer, int length)
		{
			/*
An exception occurred when decompiling this method (06001DE8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStreamNative::UnmanagedWrite(System.IntPtr,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_2_1A, call:int32(Math::Min, ldloc:int32(length), ldloc:int32(var_1)))
	stloc:uint8[](var_3_21, ldfld:uint8[](DeflateStreamNative::io_buffer, ldloc:DeflateStreamNative(this)))
	stloc:int64(var_4_23, ldc.i4:int64(0))
	call:void(Marshal::Copy, ldloc:native int(buffer), ldloc:uint8[](var_3_21), ldloc:int64[exp:int32](var_4_23), ldloc:int32(var_2_1A))
	stloc:Stream(var_5_35, ldfld:Stream(DeflateStreamNative::base_stream, ldloc:DeflateStreamNative(this)))
	stloc:uint8[](var_6_3D, ldfld:uint8[](DeflateStreamNative::io_buffer, ldloc:DeflateStreamNative(this)))
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

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00050114 File Offset: 0x0004E314
		private void CheckResult(int result, string where)
		{
		}

		// Token: 0x06001DEA RID: 7658
		private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data);

		// Token: 0x06001DEB RID: 7659
		private static extern int CloseZStream(IntPtr stream);

		// Token: 0x06001DEC RID: 7660
		private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream);

		// Token: 0x06001DED RID: 7661
		private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		// Token: 0x06001DEE RID: 7662
		private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		// Token: 0x0400140F RID: 5135
		private DeflateStreamNative.UnmanagedReadOrWrite feeder;

		// Token: 0x04001410 RID: 5136
		private Stream base_stream;

		// Token: 0x04001411 RID: 5137
		private DeflateStreamNative.SafeDeflateStreamHandle z_stream;

		// Token: 0x04001412 RID: 5138
		private GCHandle data;

		// Token: 0x04001413 RID: 5139
		private bool disposed;

		// Token: 0x04001414 RID: 5140
		private byte[] io_buffer;

		// Token: 0x04001415 RID: 5141
		private Exception last_error;

		// Token: 0x02000441 RID: 1089
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private sealed class UnmanagedReadOrWrite : MulticastDelegate
		{
			// Token: 0x06001DEF RID: 7663 RVA: 0x0005013C File Offset: 0x0004E33C
			public UnmanagedReadOrWrite(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001DF0 RID: 7664 RVA: 0x00050190 File Offset: 0x0004E390
			public int Invoke(IntPtr buffer, int length, IntPtr data)
			{
				/*
An exception occurred when decompiling this method (06001DF0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStreamNative/UnmanagedReadOrWrite::Invoke(System.IntPtr,System.Int32,System.IntPtr)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:UnmanagedReadOrWrite[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:UnmanagedReadOrWrite[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:UnmanagedReadOrWrite[exp:Delegate](this)))
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

		// Token: 0x02000442 RID: 1090
		private sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000501B4 File Offset: 0x0004E3B4
			public override bool IsInvalid
			{
				get
				{
					IntPtr handle = this.handle;
					bool flag;
					return flag;
				}
			}

			// Token: 0x06001DF2 RID: 7666 RVA: 0x000501CC File Offset: 0x0004E3CC
			private SafeDeflateStreamHandle()
			{
			}

			// Token: 0x06001DF3 RID: 7667 RVA: 0x000501DC File Offset: 0x0004E3DC
			protected override bool ReleaseHandle()
			{
				/*
An exception occurred when decompiling this method (06001DF3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.Compression.DeflateStreamNative/SafeDeflateStreamHandle::ReleaseHandle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(SafeHandle::handle, ldloc:SafeDeflateStreamHandle[exp:SafeHandle](this)))
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
}
