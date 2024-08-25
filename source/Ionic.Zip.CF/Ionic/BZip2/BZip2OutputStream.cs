using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Cpp2IlInjected;

namespace Ionic.BZip2
{
	// Token: 0x0200003B RID: 59
	public class BZip2OutputStream : Stream
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		public BZip2OutputStream(Stream output)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000AA08 File Offset: 0x00008C08
		public BZip2OutputStream(Stream output, int blockSize)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000AA18 File Offset: 0x00008C18
		public BZip2OutputStream(Stream output, bool leaveOpen)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000AA28 File Offset: 0x00008C28
		public BZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
			this.desiredTrace = BZip2OutputStream.TraceBits.Crc | BZip2OutputStream.TraceBits.Write;
			if (3 == 0)
			{
			}
			base..ctor();
			if (3 == 0)
			{
			}
			this.output = output;
			Stream stream = this.output;
			this.blockSize100k = blockSize;
			this.EmitHeader();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000AA64 File Offset: 0x00008C64
		public override void Close()
		{
			if (this.output != null)
			{
				this.Finish();
				if (!this.leaveOpen)
				{
					return;
				}
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000AA88 File Offset: 0x00008C88
		public override void Flush()
		{
			if (this.output != null)
			{
				BitWriter bitWriter = this.bw;
				long num = 0L;
				long num2 = 0L;
				bitWriter.WriteBits((int)num, (uint)num2);
				Stream stream = this.output;
				return;
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		private void EmitHeader()
		{
			int num = this.blockSize100k;
			Stream stream = this.output;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private void EmitTrailer()
		{
			this.bw.WriteBits(8, (uint)23);
			this.bw.WriteBits(8, (uint)114);
			this.bw.WriteBits(8, (uint)69);
			this.bw.WriteBits(8, (uint)56);
			this.bw.WriteBits(8, (uint)80);
			this.bw.WriteBits(8, (uint)144);
			BitWriter bitWriter = this.bw;
			uint num = this.combinedCRC;
			bitWriter.WriteInt(num);
			this.bw.FinishAndPad();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000AB64 File Offset: 0x00008D64
		private void Finish()
		{
			this.compressor.CompressAndWrite();
			BZip2Compressor bzip2Compressor = this.compressor;
			uint num = this.combinedCRC;
			uint <Crc32>k__BackingField = bzip2Compressor.<Crc32>k__BackingField;
			this.combinedCRC = <Crc32>k__BackingField;
			this.EmitTrailer();
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public override void Write(byte[] buffer, int offset, int count)
		{
			while (this.output == null)
			{
			}
			if (count != 0)
			{
				int num = this.compressor.Fill(buffer, offset, count);
				this.compressor.CompressAndWrite();
				BZip2Compressor bzip2Compressor = this.compressor;
				uint num2 = this.combinedCRC;
				uint <Crc32>k__BackingField = bzip2Compressor.<Crc32>k__BackingField;
				this.combinedCRC = <Crc32>k__BackingField;
				int num3 = this.totalBytesWrittenIn;
				this.totalBytesWrittenIn = num3;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000AC20 File Offset: 0x00008E20
		public override bool CanRead
		{
			get
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000AC30 File Offset: 0x00008E30
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000AC40 File Offset: 0x00008E40
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000303)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.BZip2.BZip2OutputStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:Stream[exp:bool](BZip2OutputStream::output, ldloc:BZip2OutputStream(this))))
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00002122 File Offset: 0x00000322
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002122 File Offset: 0x00000322
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000AC54 File Offset: 0x00008E54
		[Conditional("Trace")]
		private void TraceOutput(BZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
			BZip2OutputStream.TraceBits traceBits = this.desiredTrace;
			Thread currentThread = Thread.CurrentThread;
			Console.WriteLine(format, varParams);
		}

		// Token: 0x040001C5 RID: 453
		private int totalBytesWrittenIn;

		// Token: 0x040001C6 RID: 454
		private bool leaveOpen;

		// Token: 0x040001C7 RID: 455
		private BZip2Compressor compressor;

		// Token: 0x040001C8 RID: 456
		private uint combinedCRC;

		// Token: 0x040001C9 RID: 457
		private Stream output;

		// Token: 0x040001CA RID: 458
		private BitWriter bw;

		// Token: 0x040001CB RID: 459
		private int blockSize100k;

		// Token: 0x040001CC RID: 460
		private BZip2OutputStream.TraceBits desiredTrace;

		// Token: 0x0200003C RID: 60
		[Flags]
		private enum TraceBits : uint
		{
			// Token: 0x040001CE RID: 462
			None = 0U,
			// Token: 0x040001CF RID: 463
			Crc = 1U,
			// Token: 0x040001D0 RID: 464
			Write = 2U,
			// Token: 0x040001D1 RID: 465
			All = 4294967295U
		}
	}
}
