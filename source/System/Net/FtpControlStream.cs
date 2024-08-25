using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net
{
	// Token: 0x0200014A RID: 330
	internal class FtpControlStream : CommandStream
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		internal NetworkCredential Credentials
		{
			get
			{
				while (this._credentials == null || this._credentials == null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (this._credentials == null)
				{
				}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0001BDF0 File Offset: 0x00019FF0
		internal FtpControlStream(global::System.Net.Sockets.TcpClient client)
			: base(client)
		{
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0001BE04 File Offset: 0x0001A004
		internal void AbortConnect()
		{
			global::System.Net.Sockets.Socket dataSocket = this._dataSocket;
			if (dataSocket != null)
			{
				dataSocket.Close();
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0001BE28 File Offset: 0x0001A028
		private static void AcceptCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0001BE70 File Offset: 0x0001A070
		private static void ConnectCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0001BE8C File Offset: 0x0001A08C
		private static void SSLHandshakeCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(Stream stream)
		{
			if (this._dataSocket == null)
			{
				throw new InvalidCastException();
			}
			if (this._tlsStream != null)
			{
				WebRequest request = this._request;
				TriState triState = this.IsFtpDataStreamWriteable();
				if (request != null)
				{
				}
			}
			bool usingSecureStream = base.UsingSecureStream;
			if (this._request != null)
			{
			}
			global::System.Net.Sockets.Socket dataSocket = this._dataSocket;
			bool isAsync = this._isAsync;
			if (isAsync)
			{
				if (!isAsync)
				{
				}
				return CommandStream.PipelineInstruction.Pause;
			}
			WebRequest request2 = this._request;
			TriState triState2 = this.IsFtpDataStreamWriteable();
			if (request2 != null)
			{
			}
			return CommandStream.PipelineInstruction.GiveStream;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001BF20 File Offset: 0x0001A120
		protected override void ClearState()
		{
			this._contentLength = 1L;
			if (!true)
			{
			}
			this._lastModified = 1;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0001BF40 File Offset: 0x0001A140
		protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (entry != null)
			{
				string command = entry.Command;
				if (command == null || command == null)
				{
				}
			}
			if (response != null)
			{
				string statusDescription = response.StatusDescription;
				if (statusDescription != null && statusDescription == null)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			FormattableString formattableString;
			NetEventSource.Info(this, formattableString, "PipelineCallback");
			if (response != null)
			{
				int status = response.Status;
				this.StatusCode = (FtpStatusCode)status;
				string statusDescription2 = response.StatusDescription;
				this.StatusLine = statusDescription2;
				int index = this._index;
				bool flag = entry.Command == "OPTS utf8 on\r\n";
				int status2 = response.Status;
				Encoding utf = Encoding.UTF8;
				string statusLine = this.StatusLine;
				int num = entry.Command.IndexOf("USER");
				int num2 = 1;
				this._loginState = (FtpLoginState)num2;
				this._index = "USER";
				FtpLoginState loginState = this._loginState;
				int num3 = entry.Command.IndexOf("PASS");
				int num4 = 1;
				this._loginState = (FtpLoginState)num4;
				if (entry.Flags == (CommandStream.PipelineEntryFlags)0)
				{
					goto IL_0178;
				}
				if (this._dataSocket != null)
				{
					string command2 = entry.Command;
					string text;
					this._abortReason = text;
				}
			}
			Encoding @default = Encoding.Default;
			this._encoding = @default;
			this._decoder = @default;
			StringBuilder welcomeMessage = this._welcomeMessage;
			string statusLine2 = this.StatusLine;
			StringBuilder stringBuilder = welcomeMessage.Append(statusLine2);
			StringBuilder stringBuilder2 = this._exitMessage.Append(statusLine2);
			base.CloseSocket();
			bool usingSecureStream = base.UsingSecureStream;
			bool flag2 = entry.Command == "AUTH TLS\r\n";
			IL_0178:
			this.TryUpdateContentLength("AUTH TLS\r\n");
			WebRequest request = this._request;
			if (request != null)
			{
			}
			return this.QueueOrCreateFtpDataStream(stream);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0001C140 File Offset: 0x0001A340
		protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req)
		{
			if (req != null)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			this._responseUri = req;
			bool usingSecureStream = base.UsingSecureStream;
			FtpLoginState loginState = this._loginState;
			int num = 2;
			this._loginState = (FtpLoginState)num;
			FtpLoginState loginState2 = this._loginState;
			if (loginState != FtpLoginState.NotLoggedIn)
			{
			}
			string password;
			if (this.Credentials != null)
			{
				string userName = this.Credentials.UserName;
				string domain = this.Credentials.Domain;
				bool flag = string.IsNullOrEmpty(domain);
				string text = domain + "\\" + userName;
				password = this.Credentials.Password;
			}
			if (password._stringLength != 0 || password._stringLength == 0)
			{
			}
			bool usingSecureStream2 = base.UsingSecureStream;
			if ("0" == null)
			{
			}
			string establishedServerDirectory = this._establishedServerDirectory;
			if (establishedServerDirectory != null)
			{
				string loginDirectory = this._loginDirectory;
				if (loginDirectory != null)
				{
					bool flag2 = establishedServerDirectory != loginDirectory;
					string loginDirectory2 = this._loginDirectory;
					string loginDirectory3 = this._loginDirectory;
					this._requestedServerDirectory = loginDirectory3;
				}
			}
			string text2;
			int stringLength = text2._stringLength;
			this._requestedServerDirectory = text2;
			string currentTypeSetting = this._currentTypeSetting;
			ushort[] numbers = base.ServerAddress._numbers;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text4;
			string text3 = text4 + "/";
			throw new InvalidCastException();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0001C278 File Offset: 0x0001A478
		private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream, [Out] bool isSocketReady)
		{
			if (this._dataHandshakeStarted)
			{
				int num = 1;
				isSocketReady.m_value = num != 0;
			}
			int num2 = 1;
			this._dataHandshakeStarted = num2 != 0;
			bool flag = entry.Command == "PASV\r\n";
			bool flag2 = entry.Command == "EPSV\r\n";
			int status = response.Status;
			bool flag3 = entry.Command == "PASV\r\n";
			string statusDescription = response.StatusDescription;
			string text;
			this._abortReason = text;
			IPEndPoint passiveEndPoint = this._passiveEndPoint;
			if (text == null)
			{
			}
			NetEventSource.Fail(this, "'port' not set.", "QueueOrCreateDataConection");
			WebRequest request = this._request;
			global::System.Net.Sockets.Socket socket = base.Socket;
			if (request != null)
			{
			}
			global::System.Net.Sockets.Socket socket2;
			this._dataSocket = socket2;
			if (base.Socket.LocalEndPoint != null)
			{
			}
			global::System.Net.Sockets.Socket dataSocket = this._dataSocket;
			IPAddress serverAddress = base.ServerAddress;
			bool isEnabled = NetEventSource.IsEnabled;
			NetEventSource.Info(this, "starting Connect()", "QueueOrCreateDataConection");
			bool isAsync = this._isAsync;
			global::System.Net.Sockets.Socket dataSocket2 = this._dataSocket;
			global::System.Net.Sockets.Socket dataSocket3;
			if (isAsync)
			{
				if (!isAsync)
				{
				}
				if (!isAsync)
				{
				}
				bool isEnabled2 = NetEventSource.IsEnabled;
				if (!isAsync)
				{
				}
				NetEventSource.Info(this, "starting Accept()", "QueueOrCreateDataConection");
				bool isAsync2 = this._isAsync;
				dataSocket3 = this._dataSocket;
				if (isAsync2)
				{
					if (!isAsync2)
					{
					}
				}
			}
			global::System.Net.Sockets.Socket socket3 = dataSocket3.Accept();
			this._dataSocket = socket3;
			IPAddress serverAddress2 = base.ServerAddress;
			if (this._dataSocket.RemoteEndPoint != null)
			{
			}
			dataSocket3.Close();
			throw new InvalidCastException();
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0001C434 File Offset: 0x0001A634
		private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, global::System.Uri uri, [Out] string path, [Out] string directory, [Out] string filename)
		{
			int num = 47;
			string text;
			int num2 = text.LastIndexOf((char)num);
			int num3 = 47;
			string text2;
			int num4 = text2.LastIndexOf((char)num3);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0001C468 File Offset: 0x0001A668
		private string FormatAddress(IPAddress address, int Port)
		{
			/*
An exception occurred when decompiling this method (0600080E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::FormatAddress(System.Net.IPAddress,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, call:uint8[](IPAddress::GetAddressBytes, ldloc:IPAddress(address)))
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

		// Token: 0x0600080F RID: 2063 RVA: 0x0001C488 File Offset: 0x0001A688
		private string FormatAddressV6(IPAddress address, int port)
		{
			/*
An exception occurred when decompiling this method (0600080F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::FormatAddressV6(System.Net.IPAddress,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NumberFormatInfo(var_4_07, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		internal long ContentLength
		{
			get
			{
				return this._contentLength;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
		internal DateTime LastModified
		{
			get
			{
				DateTime lastModified = this._lastModified;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001C4CC File Offset: 0x0001A6CC
		internal global::System.Uri ResponseUri
		{
			get
			{
				return this._responseUri;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
		internal string BannerMessage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000813)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::get_BannerMessage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:StringBuilder[exp:bool](FtpControlStream::_bannerMessage, ldloc:FtpControlStream(this))))
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
		internal string WelcomeMessage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000814)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::get_WelcomeMessage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:StringBuilder[exp:bool](FtpControlStream::_welcomeMessage, ldloc:FtpControlStream(this))))
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0001C508 File Offset: 0x0001A708
		internal string ExitMessage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000815)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::get_ExitMessage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:StringBuilder[exp:bool](FtpControlStream::_exitMessage, ldloc:FtpControlStream(this))))
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

		// Token: 0x06000816 RID: 2070 RVA: 0x0001C51C File Offset: 0x0001A71C
		private long GetContentLengthFrom213Response(string responseString)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			long num;
			return num;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0001C540 File Offset: 0x0001A740
		private DateTime GetLastModifiedFrom213Response(string str)
		{
			/*
An exception occurred when decompiling this method (06000817)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Net.FtpControlStream::GetLastModifiedFrom213Response(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTime(var_0_06, ldfld:DateTime(FtpControlStream::_lastModified, ldloc:FtpControlStream(this)))
	stloc:NumberFormatInfo(var_8_1A, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int32(var_9_25, call:int32(Convert::ToInt32, ldloc:string(var_6), ldloc:NumberFormatInfo[exp:IFormatProvider](var_8_1A)))
	stloc:NumberFormatInfo(var_14_35, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_15_40, call:int16(Convert::ToInt16, ldloc:string(var_12), ldloc:NumberFormatInfo[exp:IFormatProvider](var_14_35)))
	stloc:NumberFormatInfo(var_20_50, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_21_5B, call:int16(Convert::ToInt16, ldloc:string(var_18), ldloc:NumberFormatInfo[exp:IFormatProvider](var_20_50)))
	stloc:NumberFormatInfo(var_26_6B, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_27_76, call:int16(Convert::ToInt16, ldloc:string(var_24), ldloc:NumberFormatInfo[exp:IFormatProvider](var_26_6B)))
	stloc:NumberFormatInfo(var_32_87, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_33_92, call:int16(Convert::ToInt16, ldloc:string(var_30), ldloc:NumberFormatInfo[exp:IFormatProvider](var_32_87)))
	stloc:NumberFormatInfo(var_38_A3, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_39_AE, call:int16(Convert::ToInt16, ldloc:string(var_36), ldloc:NumberFormatInfo[exp:IFormatProvider](var_38_A3)))
	stloc:NumberFormatInfo(var_41_B8, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:int16(var_42_C2, call:int16(Convert::ToInt16, ldloc:string[][exp:string](var_3), ldloc:NumberFormatInfo[exp:IFormatProvider](var_41_B8)))
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

		// Token: 0x06000818 RID: 2072 RVA: 0x0001C618 File Offset: 0x0001A818
		private void TryUpdateResponseUri(string str, FtpWebRequest request)
		{
			int num = str.IndexOf("for ");
			int num2 = 40;
			int num3 = str.LastIndexOf((char)num2);
			int stringLength = str._stringLength;
			string text2;
			string text = text2.Replace("#", "%23");
			long num4 = 0L;
			string text3;
			int stringLength2 = text3._stringLength;
			char c = text3[(int)num4];
			string text4 = text3 + "/";
			global::System.Uri uri;
			string[] segments = uri.Segments;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0001C698 File Offset: 0x0001A898
		private void TryUpdateContentLength(string str)
		{
			int num = str.LastIndexOf("(");
			int num2 = str.IndexOf(" bytes).");
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			this._contentLength = " bytes).";
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		private string GetLoginDirectory(string str)
		{
			int num = 34;
			int num2 = str.IndexOf((char)num);
			int num3 = 34;
			long num4 = 0L;
			int num5 = str.LastIndexOf((char)num3);
			return str.Substring(num3, (int)num4);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001C704 File Offset: 0x0001A904
		private int GetPortV4(string responseString)
		{
			/*
An exception occurred when decompiling this method (0600081B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.FtpControlStream::GetPortV4(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_2_03, ldc.i4:int64(0))
	stloc:bool(var_3_0B, call:bool(char::IsNumber, ldloc:string(responseString), ldloc:int64[exp:int32](var_2_03)))
	stloc:NumberFormatInfo(var_5_14, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:uint8(var_6_1E, call:uint8(Convert::ToByte, ldloc:string(responseString), ldloc:NumberFormatInfo[exp:IFormatProvider](var_5_14)))
	stloc:NumberFormatInfo(var_8_28, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:uint8(var_9_32, call:uint8(Convert::ToByte, ldloc:string[][exp:string](var_1), ldloc:NumberFormatInfo[exp:IFormatProvider](var_8_28)))
	stloc:string(var_10_40, call:string(SR::Format, ldstr:string("The response string '{0}' has invalid format."), ldloc:uint8[exp:object](var_6_1E)))
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

		// Token: 0x0600081C RID: 2076 RVA: 0x0001C754 File Offset: 0x0001A954
		private int GetPortV6(string responseString)
		{
			int num = responseString.LastIndexOf("(");
			int num2 = responseString.LastIndexOf(")");
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			return Convert.ToInt32(responseString, invariantInfo);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		private void CreateFtpListenerSocket(FtpWebRequest request)
		{
			if (base.Socket.LocalEndPoint != null)
			{
			}
			global::System.Net.Sockets.Socket socket = base.Socket;
			global::System.Net.Sockets.Socket socket2;
			this._dataSocket = socket2;
			global::System.Net.Sockets.Socket dataSocket = this._dataSocket;
			int num = 1;
			dataSocket.Listen(num);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		private string GetPortCommandLine(FtpWebRequest request)
		{
			if (this._dataSocket.LocalEndPoint != null)
			{
			}
			if (base.ServerAddress._numbers == null)
			{
				string text;
				return text;
			}
			if (base.ServerAddress._numbers != null)
			{
				string text2;
				return text2;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0001C82C File Offset: 0x0001AA2C
		private string FormatFtpCommand(string command, string parameter)
		{
			/*
An exception occurred when decompiling this method (0600081F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpControlStream::FormatFtpCommand(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:bool(var_3_1D, call:bool(string::IsNullOrEmpty, ldloc:string(parameter)))
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

		// Token: 0x06000820 RID: 2080 RVA: 0x0001C85C File Offset: 0x0001AA5C
		protected global::System.Net.Sockets.Socket CreateFtpDataSocket(FtpWebRequest request, global::System.Net.Sockets.Socket templateSocket)
		{
			/*
An exception occurred when decompiling this method (06000820)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.Socket System.Net.FtpControlStream::CreateFtpDataSocket(System.Net.FtpWebRequest,System.Net.Sockets.Socket)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AddressFamily(var_0_06, ldfld:AddressFamily(Socket::addressFamily, ldloc:Socket(templateSocket)))
	stloc:ProtocolType(var_1_0D, ldfld:ProtocolType(Socket::protocolType, ldloc:Socket(templateSocket)))
	stloc:ProtocolType(var_2_14, ldfld:ProtocolType(Socket::protocolType, ldloc:Socket(templateSocket)))
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

		// Token: 0x06000821 RID: 2081 RVA: 0x0001C880 File Offset: 0x0001AA80
		protected override bool CheckValid(ResponseDescription response, int validThrough, int completeLength)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			StringBuilder statusBuffer = response.StatusBuffer;
			if (statusBuffer == null || statusBuffer != null)
			{
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "CheckValid");
				int length = response.StatusBuffer.Length;
				StringBuilder statusBuffer2 = response.StatusBuffer;
				int status = response.Status;
				validThrough.m_value = status;
				bool multiline = response.Multiline;
				if (multiline)
				{
					char[] chunkChars = statusBuffer2.m_ChunkChars;
					string statusCodeString = response.StatusCodeString;
					string text;
					bool flag = text == statusCodeString;
				}
				if (!multiline)
				{
				}
				char c;
				bool flag2 = char.IsDigit(c);
				if (!multiline)
				{
				}
				char c2;
				bool flag3 = char.IsDigit(c2);
				if (!multiline)
				{
				}
				char c3;
				bool flag4 = char.IsDigit(c3);
				string text2;
				response.StatusCodeString = text2;
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				if (!multiline)
				{
				}
				short num = Convert.ToInt16(text2, invariantInfo);
				int num2 = 1;
				response.Multiline = num2 != 0;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001C978 File Offset: 0x0001AB78
		private TriState IsFtpDataStreamWriteable()
		{
			if (this._request != null)
			{
			}
			return TriState.True;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001C990 File Offset: 0x0001AB90
		// Note: this type is marked as 'beforefieldinit'.
		static FtpControlStream()
		{
		}

		// Token: 0x0400067C RID: 1660
		private global::System.Net.Sockets.Socket _dataSocket;

		// Token: 0x0400067D RID: 1661
		private IPEndPoint _passiveEndPoint;

		// Token: 0x0400067E RID: 1662
		private TlsStream _tlsStream;

		// Token: 0x0400067F RID: 1663
		private StringBuilder _bannerMessage;

		// Token: 0x04000680 RID: 1664
		private StringBuilder _welcomeMessage;

		// Token: 0x04000681 RID: 1665
		private StringBuilder _exitMessage;

		// Token: 0x04000682 RID: 1666
		private WeakReference _credentials;

		// Token: 0x04000683 RID: 1667
		private string _currentTypeSetting;

		// Token: 0x04000684 RID: 1668
		private long _contentLength;

		// Token: 0x04000685 RID: 1669
		private DateTime _lastModified;

		// Token: 0x04000686 RID: 1670
		private bool _dataHandshakeStarted;

		// Token: 0x04000687 RID: 1671
		private string _loginDirectory;

		// Token: 0x04000688 RID: 1672
		private string _establishedServerDirectory;

		// Token: 0x04000689 RID: 1673
		private string _requestedServerDirectory;

		// Token: 0x0400068A RID: 1674
		private global::System.Uri _responseUri;

		// Token: 0x0400068B RID: 1675
		private FtpLoginState _loginState;

		// Token: 0x0400068C RID: 1676
		internal FtpStatusCode StatusCode;

		// Token: 0x0400068D RID: 1677
		internal string StatusLine;

		// Token: 0x0400068E RID: 1678
		private static readonly AsyncCallback s_acceptCallbackDelegate;

		// Token: 0x0400068F RID: 1679
		private static readonly AsyncCallback s_connectCallbackDelegate;

		// Token: 0x04000690 RID: 1680
		private static readonly AsyncCallback s_SSLHandshakeCallback;

		// Token: 0x0200014B RID: 331
		private enum GetPathOption
		{
			// Token: 0x04000692 RID: 1682
			Normal,
			// Token: 0x04000693 RID: 1683
			AssumeFilename,
			// Token: 0x04000694 RID: 1684
			AssumeNoFilename
		}

		// Token: 0x0200014C RID: 332
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06000824 RID: 2084 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x0001C9B8 File Offset: 0x0001ABB8
			internal void <PipelineCallback>b__0(IAsyncResult ar)
			{
				this.tlsStream.EndAuthenticateAsClient(ar);
				FtpControlStream ftpControlStream = this.<>4__this;
				TlsStream tlsStream = this.tlsStream;
				ftpControlStream._networkStream = tlsStream;
				Stream stream = ftpControlStream.ContinueCommandPipeline();
			}

			// Token: 0x04000695 RID: 1685
			public FtpControlStream <>4__this;

			// Token: 0x04000696 RID: 1686
			public TlsStream tlsStream;
		}
	}
}
