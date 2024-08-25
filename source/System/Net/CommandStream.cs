using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000143 RID: 323
	internal class CommandStream : NetworkStreamWrapper
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x0001B628 File Offset: 0x00019828
		internal CommandStream(global::System.Net.Sockets.TcpClient client)
		{
			Encoding utf = Encoding.UTF8;
			this._encoding = utf;
			base..ctor(client);
			Encoding encoding = this._encoding;
			this._decoder = encoding;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0001B65C File Offset: 0x0001985C
		internal virtual void Abort(Exception e)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			NetEventSource.Info(this, "closing control Stream", "Abort");
			if (this._aborted)
			{
				return;
			}
			long num = 0L;
			this._aborted = true;
			if (true)
			{
				Monitor.Exit(this);
			}
			if (num == 0L)
			{
				if (5 == 0)
				{
					long num2 = 0L;
					base.Close((int)num2);
					long num3 = 0L;
					if (e != null)
					{
						return;
					}
					long num4 = 0L;
					this.InvokeRequestCallback(num4);
					if (num3 != 0L)
					{
						goto IL_005B;
					}
				}
				return;
			}
			IL_005B:
			throw new OutOfMemoryException();
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001B710 File Offset: 0x00019910
		protected override void Dispose(bool disposing)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			long num = 0L;
			this.InvokeRequestCallback(num);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001B734 File Offset: 0x00019934
		protected void InvokeRequestCallback(object obj)
		{
			if (this._request != null)
			{
				return;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0001B750 File Offset: 0x00019950
		internal bool RecoverableFailure
		{
			get
			{
				return this._recoverableFailure;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001B764 File Offset: 0x00019964
		protected void MarkAsRecoverableFailure()
		{
			int index = this._index;
			this._recoverableFailure = true;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001B780 File Offset: 0x00019980
		internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
		{
			return this.ContinueCommandPipeline();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001B794 File Offset: 0x00019994
		protected virtual void ClearState()
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001B7A4 File Offset: 0x000199A4
		protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001B7B4 File Offset: 0x000199B4
		protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
		{
			/*
An exception occurred when decompiling this method (060007E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Net.CommandStream::GenerateException(System.Net.FtpStatusCode,System.String,System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_07, call:string(NetRes::GetWebStatusCodeString, ldloc:FtpStatusCode(code), ldloc:string(statusDescription)))
	stloc:string(var_1_13, call:string(SR::Format, ldstr:string("The remote server returned an error: {0}."), ldloc:string[exp:object](var_0_07)))
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

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001B7D4 File Offset: 0x000199D4
		protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync)
		{
			this._commands = commands;
			this._doRead = 257 != 0;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001B7F4 File Offset: 0x000199F4
		internal void CheckContinuePipeline()
		{
			if (!this._isAsync)
			{
				Stream stream = this.ContinueCommandPipeline();
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001B814 File Offset: 0x00019A14
		protected Stream ContinueCommandPipeline()
		{
			bool isAsync = this._isAsync;
			CommandStream.PipelineEntry[] commands = this._commands;
			CommandStream.PipelineEntryFlags flags = commands.Flags;
			if (this._doSend)
			{
				Encoding encoding = this._encoding;
				string command = commands.Command;
				int stringLength = this._commands.Command._stringLength;
				CommandStream.PipelineEntryFlags flags2 = this._commands.Flags;
				int num = 32;
				string text;
				int num2 = text.IndexOf((char)num);
				long num3 = 0L;
				string text2 = text.Substring((int)num3, num2) + " ********";
				if (flags2 == (CommandStream.PipelineEntryFlags)0)
				{
				}
				bool isEnabled = NetEventSource.IsEnabled;
				if (text2 != null && text2 == null)
				{
					goto IL_00C3;
				}
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "ContinueCommandPipeline");
				if (isAsync)
				{
					CodePageDataItem dataItem = encoding.dataItem;
					goto IL_00C0;
				}
				CodePageDataItem dataItem2 = encoding.dataItem;
			}
			long num4 = 0L;
			Monitor.Exit(this);
			if (num4 != 0L)
			{
				throw new OutOfMemoryException();
			}
			IL_00C0:
			IL_00C3:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0001B914 File Offset: 0x00019B14
		private bool PostSendCommandProcessing(Stream stream)
		{
			if (this._doRead)
			{
				bool isAsync = this._isAsync;
				CommandStream.PipelineEntry[] commands = this._commands;
				ResponseDescription responseDescription = this.ReceiveCommandResponse();
				int num;
				if (isAsync)
				{
					num = 1;
				}
				this._currentResponseDescription = num;
			}
			return this.PostReadCommandProcessing(stream);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001B974 File Offset: 0x00019B74
		private bool PostReadCommandProcessing(Stream stream)
		{
			CommandStream.PipelineEntryFlags flags = this._commands.Flags;
			return "QUIT\r\n" != null;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001BA18 File Offset: 0x00019C18
		protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0001BA28 File Offset: 0x00019C28
		private static void ReadCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001BA68 File Offset: 0x00019C68
		private static void WriteCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0001BAA0 File Offset: 0x00019CA0
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		protected Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
				this._decoder = value;
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		protected virtual bool CheckValid(ResponseDescription response, int validThrough, int completeLength)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		private ResponseDescription ReceiveCommandResponse()
		{
			string buffer = this._buffer;
			bool isAsync = this._isAsync;
			if (isAsync)
			{
				if (!isAsync)
				{
				}
			}
			if (this == null)
			{
				base.CloseSocket();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0001BB38 File Offset: 0x00019D38
		private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
		{
			int validThrough = state.ValidThrough;
			string buffer = this._buffer;
			int stringLength = buffer._stringLength;
			StringBuilder stringBuilder = state.Resp.StatusBuffer.Append(buffer);
			ResponseDescription resp = state.Resp;
			byte[] buffer2 = state.Buffer;
			if (!this._isAsync)
			{
				while (this != null)
				{
				}
				base.CloseSocket();
				return;
			}
			int num;
			if (num == 0)
			{
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		// Note: this type is marked as 'beforefieldinit'.
		static CommandStream()
		{
		}

		// Token: 0x0400064E RID: 1614
		private static readonly AsyncCallback s_writeCallbackDelegate;

		// Token: 0x0400064F RID: 1615
		private static readonly AsyncCallback s_readCallbackDelegate;

		// Token: 0x04000650 RID: 1616
		private bool _recoverableFailure;

		// Token: 0x04000651 RID: 1617
		protected WebRequest _request;

		// Token: 0x04000652 RID: 1618
		protected bool _isAsync;

		// Token: 0x04000653 RID: 1619
		private bool _aborted;

		// Token: 0x04000654 RID: 1620
		protected CommandStream.PipelineEntry[] _commands;

		// Token: 0x04000655 RID: 1621
		protected int _index;

		// Token: 0x04000656 RID: 1622
		private bool _doRead;

		// Token: 0x04000657 RID: 1623
		private bool _doSend;

		// Token: 0x04000658 RID: 1624
		private ResponseDescription _currentResponseDescription;

		// Token: 0x04000659 RID: 1625
		protected string _abortReason;

		// Token: 0x0400065A RID: 1626
		private const int WaitingForPipeline = 1;

		// Token: 0x0400065B RID: 1627
		private const int CompletedPipeline = 2;

		// Token: 0x0400065C RID: 1628
		private string _buffer;

		// Token: 0x0400065D RID: 1629
		private Encoding _encoding;

		// Token: 0x0400065E RID: 1630
		private Decoder _decoder;

		// Token: 0x02000144 RID: 324
		internal enum PipelineInstruction
		{
			// Token: 0x04000660 RID: 1632
			Abort,
			// Token: 0x04000661 RID: 1633
			Advance,
			// Token: 0x04000662 RID: 1634
			Pause,
			// Token: 0x04000663 RID: 1635
			Reread,
			// Token: 0x04000664 RID: 1636
			GiveStream
		}

		// Token: 0x02000145 RID: 325
		[Flags]
		internal enum PipelineEntryFlags
		{
			// Token: 0x04000666 RID: 1638
			UserCommand = 1,
			// Token: 0x04000667 RID: 1639
			GiveDataStream = 2,
			// Token: 0x04000668 RID: 1640
			CreateDataConnection = 4,
			// Token: 0x04000669 RID: 1641
			DontLogParameter = 8
		}

		// Token: 0x02000146 RID: 326
		internal class PipelineEntry
		{
			// Token: 0x060007F7 RID: 2039 RVA: 0x0001BCC4 File Offset: 0x00019EC4
			internal PipelineEntry(string command)
			{
				this.Command = command;
			}

			// Token: 0x060007F8 RID: 2040 RVA: 0x0001BCE0 File Offset: 0x00019EE0
			internal PipelineEntry(string command, CommandStream.PipelineEntryFlags flags)
			{
				this.Command = command;
				this.Flags = flags;
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x0001BD04 File Offset: 0x00019F04
			internal bool HasFlag(CommandStream.PipelineEntryFlags flags)
			{
				/*
An exception occurred when decompiling this method (060007F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CommandStream/PipelineEntry::HasFlag(System.Net.CommandStream/PipelineEntryFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PipelineEntryFlags(var_0_06, ldfld:PipelineEntryFlags(PipelineEntry::Flags, ldloc:PipelineEntry(this)))
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

			// Token: 0x0400066A RID: 1642
			internal string Command;

			// Token: 0x0400066B RID: 1643
			internal CommandStream.PipelineEntryFlags Flags;
		}
	}
}
