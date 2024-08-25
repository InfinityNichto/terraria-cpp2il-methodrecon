using System;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x02000541 RID: 1345
	[Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x060027B3 RID: 10163 RVA: 0x0005635C File Offset: 0x0005455C
		private void CheckAsyncTaskInProgress()
		{
			bool isCompleted = this._asyncWriteTask.IsCompleted;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowAsyncIOInProgress()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0005637C File Offset: 0x0005457C
		private static Encoding UTF8NoBOM
		{
			get
			{
				if (!true)
				{
				}
				return EncodingHelper.UTF8Unmarked;
			}
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00056394 File Offset: 0x00054594
		internal StreamWriter()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000563AC File Offset: 0x000545AC
		public StreamWriter(Stream stream)
		{
			if (!true)
			{
			}
			Encoding utf8NoBOM = StreamWriter.UTF8NoBOM;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000563C4 File Offset: 0x000545C4
		public StreamWriter(Stream stream, Encoding encoding)
		{
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000563D4 File Offset: 0x000545D4
		public StreamWriter(Stream stream, Encoding encoding, int bufferSize)
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000563E4 File Offset: 0x000545E4
		public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._asyncWriteTask = 1;
			if (!true)
			{
			}
			if (encoding != null && stream != null)
			{
				this.Init(stream, encoding, bufferSize, leaveOpen);
				return;
			}
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00056414 File Offset: 0x00054614
		public StreamWriter(string path)
		{
			if (!true)
			{
			}
			Encoding utf8NoBOM = StreamWriter.UTF8NoBOM;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0005642C File Offset: 0x0005462C
		public StreamWriter(string path, bool append)
		{
			if (!true)
			{
			}
			Encoding utf8NoBOM = StreamWriter.UTF8NoBOM;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00056444 File Offset: 0x00054644
		public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
		{
			if (!true)
			{
			}
			base..ctor();
			if (path == null)
			{
				return;
			}
			if (encoding == null)
			{
				return;
			}
			if (path._stringLength != 0)
			{
				return;
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0005646C File Offset: 0x0005466C
		private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
			this._stream = streamArg;
			this._encoding = encodingArg;
			this._encoder = encodingArg;
			Encoding encoding = this._encoding;
			Stream stream = this._stream;
			this._charLen = bufferSize;
			Stream stream2 = this._stream;
			this._haveWrittenPreamble = true;
			this._closable = true;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000564B8 File Offset: 0x000546B8
		public override void Close()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000564CC File Offset: 0x000546CC
		protected override void Dispose(bool disposing)
		{
			if (this._stream != null)
			{
				this.CheckAsyncTaskInProgress();
				this.Flush(true, true);
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000564F0 File Offset: 0x000546F0
		public override void Flush()
		{
			this.CheckAsyncTaskInProgress();
			this.Flush(true, true);
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0005650C File Offset: 0x0005470C
		private void Flush(bool flushStream, bool flushEncoder)
		{
			while (this._stream == null)
			{
			}
			if (this._charPos == 0)
			{
			}
			if (!this._haveWrittenPreamble)
			{
				Encoding encoding = this._encoding;
				this._haveWrittenPreamble = true;
				Stream stream = this._stream;
			}
			Encoder encoder = this._encoder;
			byte[] byteBuffer = this._byteBuffer;
			char[] charBuffer = this._charBuffer;
			int charPos = this._charPos;
			Stream stream2 = this._stream;
			byte[] byteBuffer2 = this._byteBuffer;
			Stream stream3 = this._stream;
		}

		// Token: 0x170005B6 RID: 1462
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00056580 File Offset: 0x00054780
		public virtual bool AutoFlush
		{
			set
			{
				this.CheckAsyncTaskInProgress();
				long num = 0L;
				this.Flush(true, num != 0L);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000565A0 File Offset: 0x000547A0
		internal bool LeaveOpen
		{
			get
			{
				/*
An exception occurred when decompiling this method (060027C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.StreamWriter::get_LeaveOpen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(StreamWriter::_closable, ldloc:StreamWriter(this)))
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x000565B4 File Offset: 0x000547B4
		public override Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000565C8 File Offset: 0x000547C8
		public override void Write(char value)
		{
			this.CheckAsyncTaskInProgress();
			int charPos = this._charPos;
			bool autoFlush = this._autoFlush;
			long num = 0L;
			long num2 = 0L;
			this.Flush(num != 0L, num2 != 0L);
			int charPos2 = this._charPos;
			char[] charBuffer = this._charBuffer;
			bool autoFlush2 = this._autoFlush;
			this._charPos = charPos2;
			if (autoFlush2)
			{
				int num3 = 1;
				long num4 = 0L;
				this.Flush(num3 != 0, num4 != 0L);
				return;
			}
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0005662C File Offset: 0x0005482C
		public override void Write(char[] buffer)
		{
			this.CheckAsyncTaskInProgress();
			int charPos = this._charPos;
			bool autoFlush = this._autoFlush;
			char[] charBuffer = this._charBuffer;
			int charPos2 = this._charPos;
			long num = 0L;
			long num2 = 0L;
			this.Flush(num != 0L, num2 != 0L);
			int num3 = Math.Min(0, -1073741824);
			int charPos3 = this._charPos;
			this._charPos = charPos3;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000566B4 File Offset: 0x000548B4
		public override void Write(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				return;
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			this.CheckAsyncTaskInProgress();
			int charPos = this._charPos;
			bool autoFlush = this._autoFlush;
			if (this._charBuffer != null)
			{
				int charPos2 = this._charPos;
				long num = 0L;
				long num2 = 0L;
				this.Flush(num != 0L, num2 != 0L);
				int num3 = Math.Min(0, count);
				int charPos3 = this._charPos;
				this._charPos = charPos3;
				return;
			}
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00056750 File Offset: 0x00054950
		private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
		{
			do
			{
				this.CheckAsyncTaskInProgress();
				int charPos = this._charPos;
				bool autoFlush = this._autoFlush;
			}
			while (this._charBuffer == null);
			int charPos2 = this._charPos;
			long num = 0L;
			long num2 = 0L;
			this.Flush(num != 0L, num2 != 0L);
			int num3 = Math.Min(0, appendNewLine ? 1 : 0);
			int charPos3 = this._charPos;
			this._charPos = charPos3;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00056814 File Offset: 0x00054A14
		public override void Write(string value)
		{
			int stringLength;
			while (value == null)
			{
				this.CheckAsyncTaskInProgress();
				int charPos = this._charPos;
				bool autoFlush = this._autoFlush;
				if (this._charBuffer != null)
				{
					int charPos2 = this._charPos;
					long num = 0L;
					long num2 = 0L;
					this.Flush(num != 0L, num2 != 0L);
					int num3 = Math.Min(0, stringLength);
					int charPos3 = this._charPos;
					this._charPos = charPos3;
					return;
				}
			}
			char rawStringData = value.GetRawStringData();
			stringLength = value._stringLength;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000568B4 File Offset: 0x00054AB4
		public override void WriteLine(string value)
		{
			for (;;)
			{
				this.CheckAsyncTaskInProgress();
				if (value != null)
				{
					break;
				}
				this.CheckAsyncTaskInProgress();
				int charPos = this._charPos;
				bool autoFlush = this._autoFlush;
				if (this._charBuffer != null)
				{
					goto Block_1;
				}
			}
			char rawStringData = value.GetRawStringData();
			int stringLength = value._stringLength;
			return;
			Block_1:
			int charPos2 = this._charPos;
			long num = 0L;
			long num2 = 0L;
			this.Flush(num != 0L, num2 != 0L);
			int num3 = Math.Min(0, stringLength);
			int charPos3 = this._charPos;
			this._charPos = charPos3;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00056994 File Offset: 0x00054B94
		// Note: this type is marked as 'beforefieldinit'.
		static StreamWriter()
		{
			if (!true)
			{
			}
			Encoding utf8NoBOM = StreamWriter.UTF8NoBOM;
		}

		// Token: 0x040015A4 RID: 5540
		public new static readonly StreamWriter Null;

		// Token: 0x040015A5 RID: 5541
		private Stream _stream;

		// Token: 0x040015A6 RID: 5542
		private Encoding _encoding;

		// Token: 0x040015A7 RID: 5543
		private Encoder _encoder;

		// Token: 0x040015A8 RID: 5544
		private byte[] _byteBuffer;

		// Token: 0x040015A9 RID: 5545
		private char[] _charBuffer;

		// Token: 0x040015AA RID: 5546
		private int _charPos;

		// Token: 0x040015AB RID: 5547
		private int _charLen;

		// Token: 0x040015AC RID: 5548
		private bool _autoFlush;

		// Token: 0x040015AD RID: 5549
		private bool _haveWrittenPreamble;

		// Token: 0x040015AE RID: 5550
		private bool _closable;

		// Token: 0x040015AF RID: 5551
		private Task _asyncWriteTask;
	}
}
