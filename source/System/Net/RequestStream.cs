using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200026C RID: 620
	internal class RequestStream : Stream
	{
		// Token: 0x060010A0 RID: 4256 RVA: 0x0003499C File Offset: 0x00032B9C
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000349AC File Offset: 0x00032BAC
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length, long contentlength)
		{
			if (!true)
			{
			}
			base..ctor();
			this.stream = stream;
			this.buffer = buffer;
			this.offset = offset;
			this.remaining_body = (long)length;
			this.remaining_body = contentlength;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000349E8 File Offset: 0x00032BE8
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x000349F8 File Offset: 0x00032BF8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00034A08 File Offset: 0x00032C08
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
		public override long Position
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00034A18 File Offset: 0x00032C18
		public override void Close()
		{
			this.disposed = true;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00034A2C File Offset: 0x00032C2C
		public override void Flush()
		{
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00034A3C File Offset: 0x00032C3C
		private int FillFromBuffer(byte[] buffer, int off, int count)
		{
			if (buffer != null)
			{
				long num = this.remaining_body;
				if (num != 0L)
				{
					int num2 = this.length;
					if (num2 != 0)
					{
						if (num == 0L)
						{
						}
						int num3 = Math.Min(num2, count);
						long num4 = this.remaining_body;
						if (num == 0L)
						{
						}
						byte[] array = this.buffer;
						int num5 = this.offset;
						long num7;
						int num6 = Math.Min((int)num7, (int)num4);
						if (num6 != 0)
						{
							byte[] array2 = this.buffer;
							int num8 = this.offset;
							Buffer.BlockCopy(array2, num8, buffer, off, num6);
							int num9 = this.offset;
							long num10 = this.remaining_body;
							long num11 = this.remaining_body;
							this.offset = num9;
							this.remaining_body = num10;
							this.remaining_body = num11;
						}
					}
				}
			}
			return "offset";
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00034AFC File Offset: 0x00032CFC
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060010AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.RequestStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_11, call:int32(RequestStream::FillFromBuffer, ldloc:RequestStream(this), ldloc:uint8[](buffer), ldloc:int32(offset), ldloc:int32(count)))
	stloc:Stream(var_1_18, ldfld:Stream(RequestStream::stream, ldloc:RequestStream(this)))
	stloc:int64(var_2_1F, ldfld:int64(RequestStream::remaining_body, ldloc:RequestStream(this)))
	stfld:int64(RequestStream::remaining_body, ldloc:RequestStream(this), ldloc:int64(var_2_1F))
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

		// Token: 0x060010AC RID: 4268 RVA: 0x00034B34 File Offset: 0x00032D34
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			/*
An exception occurred when decompiling this method (060010AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.RequestStream::BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:Stream(var_4_24, ldfld:Stream(RequestStream::stream, ldloc:RequestStream(this)))
	stloc:int32(var_5_2D, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int64[exp:int32](var_2_1A)))
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

		// Token: 0x060010AD RID: 4269 RVA: 0x00034B70 File Offset: 0x00032D70
		public override int EndRead(IAsyncResult ares)
		{
			if (!this.disposed && ares != null)
			{
				Stream stream = this.stream;
				long num = this.remaining_body;
				this.remaining_body = num;
			}
			throw new InvalidCastException();
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00002050 File Offset: 0x00000250
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00002050 File Offset: 0x00000250
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
		public override void EndWrite(IAsyncResult async_result)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000D20 RID: 3360
		private byte[] buffer;

		// Token: 0x04000D21 RID: 3361
		private int offset;

		// Token: 0x04000D22 RID: 3362
		private int length;

		// Token: 0x04000D23 RID: 3363
		private long remaining_body;

		// Token: 0x04000D24 RID: 3364
		private bool disposed;

		// Token: 0x04000D25 RID: 3365
		private Stream stream;
	}
}
