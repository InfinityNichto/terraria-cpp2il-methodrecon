using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x0200053F RID: 1343
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x0600278A RID: 10122 RVA: 0x00055AE8 File Offset: 0x00053CE8
		private void CheckAsyncTaskInProgress()
		{
			bool isCompleted = this._asyncReadTask.IsCompleted;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowAsyncIOInProgress()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00055B08 File Offset: 0x00053D08
		internal StreamReader()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._asyncReadTask = 1;
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00055B2C File Offset: 0x00053D2C
		public StreamReader(Stream stream)
		{
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00055B44 File Offset: 0x00053D44
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
		{
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00055B5C File Offset: 0x00053D5C
		public StreamReader(Stream stream, Encoding encoding)
		{
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00055B6C File Offset: 0x00053D6C
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00055B7C File Offset: 0x00053D7C
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._asyncReadTask = 1;
			if (!true)
			{
			}
			base..ctor();
			if (encoding != null && stream != null)
			{
				this.Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen);
				return;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00055BB4 File Offset: 0x00053DB4
		public StreamReader(string path)
		{
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00055BCC File Offset: 0x00053DCC
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
		{
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00055BE4 File Offset: 0x00053DE4
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._asyncReadTask = 1;
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

		// Token: 0x06002795 RID: 10133 RVA: 0x00055C18 File Offset: 0x00053E18
		private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			this._stream = stream;
			this._encoding = encoding;
			this._decoder = encoding;
			this._maxCharsPerBuffer = encoding;
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00055C44 File Offset: 0x00053E44
		internal void Init(Stream stream)
		{
			this._stream = stream;
			this._closable = true;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00055C60 File Offset: 0x00053E60
		public override void Close()
		{
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00055C70 File Offset: 0x00053E70
		protected override void Dispose(bool disposing)
		{
			bool closable = this._closable;
			if (this._stream != null)
			{
			}
			if (!this._closable)
			{
				return;
			}
			if (this._stream != null)
			{
			}
			long num;
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x00055CC4 File Offset: 0x00053EC4
		public virtual Encoding CurrentEncoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00055CD8 File Offset: 0x00053ED8
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00055CEC File Offset: 0x00053EEC
		internal bool LeaveOpen
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600279B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.StreamReader::get_LeaveOpen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(StreamReader::_closable, ldloc:StreamReader(this)))
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

		// Token: 0x0600279C RID: 10140 RVA: 0x00055D00 File Offset: 0x00053F00
		public override int Peek()
		{
			/*
An exception occurred when decompiling this method (0600279C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.StreamReader::Peek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_2_2D, ldfld:int32(StreamReader::_charPos, ldloc:StreamReader(this)))
	stloc:char[](var_3_34, ldfld:char[](StreamReader::_charBuffer, ldloc:StreamReader(this)))
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

		// Token: 0x0600279D RID: 10141 RVA: 0x00055D44 File Offset: 0x00053F44
		public override int Read()
		{
			/*
An exception occurred when decompiling this method (0600279D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.StreamReader::Read()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:int32(var_2_25, ldfld:int32(StreamReader::_charPos, ldloc:StreamReader(this)))
	stloc:char[](var_3_2C, ldfld:char[](StreamReader::_charBuffer, ldloc:StreamReader(this)))
	stfld:int32(StreamReader::_charPos, ldloc:StreamReader(this), ldloc:int32(var_2_25))
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

		// Token: 0x0600279E RID: 10142 RVA: 0x00055D84 File Offset: 0x00053F84
		public override int Read(char[] buffer, int index, int count)
		{
			while (buffer == null)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num;
			return num;
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00055DA0 File Offset: 0x00053FA0
		private int ReadSpan(Span<char> buffer)
		{
			for (;;)
			{
				if (this._stream != null)
				{
					this.CheckAsyncTaskInProgress();
					int charPos = this._charPos;
					int byteLen = this._byteLen;
					ThrowHelper.ThrowArgumentOutOfRangeException();
					int num;
					if (num == 0)
					{
						break;
					}
					char[] charBuffer = this._charBuffer;
					if (charBuffer != null)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
						while (charBuffer != null)
						{
						}
					}
					ThrowHelper.ThrowArgumentOutOfRangeException();
					ThrowHelper.ThrowArgumentOutOfRangeException();
					int charPos2 = this._charPos;
					this._charPos = charPos2;
					if (this._isBlocked)
					{
						break;
					}
				}
			}
			return 43155456;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00055E18 File Offset: 0x00054018
		public override string ReadToEnd()
		{
			/*
An exception occurred when decompiling this method (060027A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.StreamReader::ReadToEnd()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(StreamReader::CheckAsyncTaskInProgress, ldloc:StreamReader(this))
	stloc:int32(var_0_14, ldfld:int32(StreamReader::_charPos, ldloc:StreamReader(this)))
	stloc:int32(var_1_1B, ldfld:int32(StreamReader::_byteLen, ldloc:StreamReader(this)))
	stloc:int32(var_2_22, ldfld:int32(StreamReader::_charLen, ldloc:StreamReader(this)))
	stloc:int32(var_3_29, ldfld:int32(StreamReader::_charPos, ldloc:StreamReader(this)))
	stloc:char[](var_4_30, ldfld:char[](StreamReader::_charBuffer, ldloc:StreamReader(this)))
	stloc:int32(var_6_38, ldfld:int32(StreamReader::_charLen, ldloc:StreamReader(this)))
	stfld:int32(StreamReader::_charPos, ldloc:StreamReader(this), ldloc:int32(var_6_38))
	stloc:int32(var_7_48, ldfld:int32(StreamReader::_charLen, ldloc:StreamReader(this)))
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

		// Token: 0x060027A1 RID: 10145 RVA: 0x00055E70 File Offset: 0x00054070
		private void CompressBuffer(int n)
		{
			int byteLen = this._byteLen;
			byte[] byteBuffer = this._byteBuffer;
			int byteLen2 = this._byteLen;
			this._byteLen = byteLen2;
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00055E9C File Offset: 0x0005409C
		private void DetectEncoding()
		{
			int byteLen = this._byteLen;
			byte[] byteBuffer = this._byteBuffer;
			Encoding bigEndianUnicode = Encoding.BigEndianUnicode;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00055F98 File Offset: 0x00054198
		private bool IsPreamble()
		{
			while (this._checkPreamble)
			{
				Encoding encoding = this._encoding;
				int byteLen = this._byteLen;
				int maxCharsPerBuffer = this._maxCharsPerBuffer;
				byte[] byteBuffer = this._byteBuffer;
				if (this._checkPreamble)
				{
					byte[] byteBuffer2 = this._byteBuffer;
					int byteLen2 = this._byteLen;
					this._byteLen = byteLen2;
					return;
				}
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00055FF4 File Offset: 0x000541F4
		internal virtual int ReadBuffer()
		{
			int charLen;
			do
			{
				if (this._checkPreamble)
				{
				}
				Stream stream = this._stream;
				byte[] byteBuffer = this._byteBuffer;
				int bytePos = this._bytePos;
				int byteLen = this._byteLen;
				if (stream == null)
				{
					goto IL_00B3;
				}
				this._byteLen = stream;
				this._byteLen = stream;
				if (stream == null)
				{
					goto IL_00DB;
				}
				byte[] byteBuffer2 = this._byteBuffer;
				this._isBlocked = byteBuffer2 != null;
				bool flag = this.IsPreamble();
				if (this._charLen == 0)
				{
					break;
				}
				if (this._detectEncoding)
				{
					int byteLen2 = this._byteLen;
					this.DetectEncoding();
				}
				Decoder decoder = this._decoder;
				byte[] byteBuffer3 = this._byteBuffer;
				charLen = this._charLen;
				int bytePos2 = this._bytePos;
				char[] charBuffer = this._charBuffer;
				this._charLen = charLen;
			}
			while (charLen != 0);
			bool checkPreamble = this._checkPreamble;
			IL_00B3:
			int charLen2 = this._charLen;
			Decoder decoder2 = this._decoder;
			byte[] byteBuffer4 = this._byteBuffer;
			char[] charBuffer2 = this._charBuffer;
			this._charLen = charLen2;
			IL_00DB:
			return this._charLen;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000560E4 File Offset: 0x000542E4
		private int ReadBuffer(Span<char> userBuffer, [Out] bool readToUserBuffer)
		{
			/*
An exception occurred when decompiling this method (060027A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.StreamReader::ReadBuffer(System.Span`1<System.Char>,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0128:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x060027A6 RID: 10150 RVA: 0x00056220 File Offset: 0x00054420
		public override string ReadLine()
		{
			while (this._stream == null)
			{
			}
			this.CheckAsyncTaskInProgress();
			int charPos = this._charPos;
			int byteLen = this._byteLen;
			if (this != null)
			{
				long num = 0L;
				int charPos2 = this._charPos;
				char[] charBuffer = this._charBuffer;
				int charLen = this._charLen;
				if (num == 0L)
				{
					char[] charBuffer2 = this._charBuffer;
					int charPos3 = this._charPos;
				}
				int charLen2 = this._charLen;
				int charPos4 = this._charPos;
				char[] charBuffer3 = this._charBuffer;
				this._charPos = charPos4;
				return;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000562A0 File Offset: 0x000544A0
		internal bool DataAvailable()
		{
			/*
An exception occurred when decompiling this method (060027A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.StreamReader::DataAvailable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(StreamReader::_charPos, ldloc:StreamReader(this)))
	stloc:int32(var_1_0D, ldfld:int32(StreamReader::_byteLen, ldloc:StreamReader(this)))
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

		// Token: 0x060027A8 RID: 10152 RVA: 0x000562BC File Offset: 0x000544BC
		// Note: this type is marked as 'beforefieldinit'.
		static StreamReader()
		{
		}

		// Token: 0x04001594 RID: 5524
		public new static readonly StreamReader Null;

		// Token: 0x04001595 RID: 5525
		private Stream _stream;

		// Token: 0x04001596 RID: 5526
		private Encoding _encoding;

		// Token: 0x04001597 RID: 5527
		private Decoder _decoder;

		// Token: 0x04001598 RID: 5528
		private byte[] _byteBuffer;

		// Token: 0x04001599 RID: 5529
		private char[] _charBuffer;

		// Token: 0x0400159A RID: 5530
		private int _charPos;

		// Token: 0x0400159B RID: 5531
		private int _charLen;

		// Token: 0x0400159C RID: 5532
		private int _byteLen;

		// Token: 0x0400159D RID: 5533
		private int _bytePos;

		// Token: 0x0400159E RID: 5534
		private int _maxCharsPerBuffer;

		// Token: 0x0400159F RID: 5535
		private bool _detectEncoding;

		// Token: 0x040015A0 RID: 5536
		private bool _checkPreamble;

		// Token: 0x040015A1 RID: 5537
		private bool _isBlocked;

		// Token: 0x040015A2 RID: 5538
		private bool _closable;

		// Token: 0x040015A3 RID: 5539
		private Task _asyncReadTask;

		// Token: 0x02000540 RID: 1344
		private class NullStreamReader : StreamReader
		{
			// Token: 0x060027A9 RID: 10153 RVA: 0x000562CC File Offset: 0x000544CC
			internal NullStreamReader()
			{
				if (!true)
				{
				}
				base..ctor();
				if (!true)
				{
				}
				this._closable = true;
				this._stream = 1;
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x060027AA RID: 10154 RVA: 0x000562F4 File Offset: 0x000544F4
			public override Stream BaseStream
			{
				get
				{
					if (!true)
					{
					}
					return 1;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x060027AB RID: 10155 RVA: 0x00056308 File Offset: 0x00054508
			public override Encoding CurrentEncoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x060027AC RID: 10156 RVA: 0x0005631C File Offset: 0x0005451C
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060027AD RID: 10157 RVA: 0x0000207A File Offset: 0x0000027A
			public override int Peek()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060027AE RID: 10158 RVA: 0x0000207A File Offset: 0x0000027A
			public override int Read()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060027AF RID: 10159 RVA: 0x0005632C File Offset: 0x0005452C
			public override int Read(char[] buffer, int index, int count)
			{
			}

			// Token: 0x060027B0 RID: 10160 RVA: 0x0005633C File Offset: 0x0005453C
			public override string ReadLine()
			{
			}

			// Token: 0x060027B1 RID: 10161 RVA: 0x0000207A File Offset: 0x0000027A
			public override string ReadToEnd()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060027B2 RID: 10162 RVA: 0x0005634C File Offset: 0x0005454C
			internal override int ReadBuffer()
			{
			}
		}
	}
}
