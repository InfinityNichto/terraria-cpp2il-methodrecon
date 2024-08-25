using System;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	// Token: 0x02000305 RID: 773
	public class TcpClient : IDisposable
	{
		// Token: 0x0600140C RID: 5132 RVA: 0x0003D49C File Offset: 0x0003B69C
		public TcpClient()
		{
			bool on = Logging.On;
			bool on2 = Logging.On;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0003D4BC File Offset: 0x0003B6BC
		public TcpClient(AddressFamily family)
		{
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			bool on = Logging.On;
			this.m_Family = family;
			this.initialize();
			bool on2 = Logging.On;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		internal TcpClient(Socket acceptedSocket)
		{
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			bool on = Logging.On;
			this.m_ClientSocket = acceptedSocket;
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0003D534 File Offset: 0x0003B734
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0003D548 File Offset: 0x0003B748
		public Socket Client
		{
			get
			{
				return this.m_ClientSocket;
			}
			set
			{
				this.m_ClientSocket = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0003D55C File Offset: 0x0003B75C
		public bool Connected
		{
			get
			{
				return this.m_ClientSocket.is_connected;
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0003D574 File Offset: 0x0003B774
		public void Connect(string hostname, int port)
		{
			bool on = Logging.On;
			if (!this.m_CleanedUp)
			{
				if (hostname != null)
				{
					bool flag = ValidationHelper.ValidateTcpPort(port);
					if (this.m_Active)
					{
						return;
					}
					IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
					Socket clientSocket = this.m_ClientSocket;
					if (clientSocket == null)
					{
						if (clientSocket == null)
						{
						}
						bool ossupportsIPv = Socket.OSSupportsIPv4;
						if (clientSocket == null)
						{
						}
						bool ossupportsIPv2 = Socket.OSSupportsIPv6;
					}
					ushort[] numbers = hostAddresses._numbers;
					if (numbers != null)
					{
						return;
					}
					AddressFamily addressFamily;
					if (addressFamily != AddressFamily.Unspecified)
					{
						if (addressFamily != AddressFamily.Unspecified)
						{
							return;
						}
					}
					else if (addressFamily == AddressFamily.Unspecified || addressFamily != AddressFamily.Unspecified)
					{
					}
					return;
				}
			}
			else
			{
				IPAddress[] hostAddresses;
				Type type = hostAddresses.GetType();
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0003D64C File Offset: 0x0003B84C
		public void Connect(IPAddress address, int port)
		{
			bool on = Logging.On;
			if (!this.m_CleanedUp)
			{
				if (address != null)
				{
					bool flag = ValidationHelper.ValidateTcpPort(port);
					bool on2 = Logging.On;
					return;
				}
			}
			else
			{
				Type type = base.GetType();
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0003D688 File Offset: 0x0003B888
		public void Connect(IPEndPoint remoteEP)
		{
			/*
An exception occurred when decompiling this method (06001414)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.TcpClient::Connect(System.Net.IPEndPoint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:Type(var_4_35, call:Type(object::GetType, ldloc:TcpClient[exp:object](this)))
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

		// Token: 0x06001415 RID: 5141 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			/*
An exception occurred when decompiling this method (06001415)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.TcpClient::BeginConnect(System.String,System.Int32,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Logging::get_On))
	stloc:IAsyncResult(var_2_18, call:IAsyncResult(Socket::BeginConnect, ldfld:Socket(TcpClient::m_ClientSocket, ldloc:TcpClient(this)), ldloc:string(host), ldloc:int32(port), ldloc:AsyncCallback(requestCallback), ldloc:object(state)))
	stloc:bool(var_3_1E, callgetter:bool(Logging::get_On))
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

		// Token: 0x06001416 RID: 5142 RVA: 0x0003D6F8 File Offset: 0x0003B8F8
		public void EndConnect(IAsyncResult asyncResult)
		{
			bool on = Logging.On;
			this.m_ClientSocket.EndConnect(asyncResult);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0003D728 File Offset: 0x0003B928
		public Task ConnectAsync(string host, int port)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0003D73C File Offset: 0x0003B93C
		public NetworkStream GetStream()
		{
			/*
An exception occurred when decompiling this method (06001418)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.NetworkStream System.Net.Sockets.TcpClient::GetStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003C:
	stloc:string(var_5_46, call:string(SR::GetString, ldstr:string("The operation is not allowed on non-connected sockets.")))
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

		// Token: 0x06001419 RID: 5145 RVA: 0x0003D790 File Offset: 0x0003B990
		public void Close()
		{
			bool on = Logging.On;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0003D7B0 File Offset: 0x0003B9B0
		protected virtual void Dispose(bool disposing)
		{
			bool on = Logging.On;
			if (!this.m_CleanedUp)
			{
				if (this.m_DataStream != null)
				{
					return;
				}
				Socket clientSocket = this.m_ClientSocket;
				if (clientSocket != null)
				{
					clientSocket.Close();
					return;
				}
				GC.SuppressFinalize(this);
				int num = 1;
				this.m_CleanedUp = num != 0;
			}
			bool on2 = Logging.On;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0003D824 File Offset: 0x0003BA24
		public void Dispose()
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0003D834 File Offset: 0x0003BA34
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x1700048D RID: 1165
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0003D868 File Offset: 0x0003BA68
		public int SendTimeout
		{
			set
			{
				this.m_ClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0003D88C File Offset: 0x0003BA8C
		public bool NoDelay
		{
			set
			{
				Socket clientSocket = this.m_ClientSocket;
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0003D8A0 File Offset: 0x0003BAA0
		private void initialize()
		{
			AddressFamily family = this.m_Family;
		}

		// Token: 0x040010D0 RID: 4304
		private Socket m_ClientSocket;

		// Token: 0x040010D1 RID: 4305
		private bool m_Active;

		// Token: 0x040010D2 RID: 4306
		private NetworkStream m_DataStream;

		// Token: 0x040010D3 RID: 4307
		private AddressFamily m_Family;

		// Token: 0x040010D4 RID: 4308
		private bool m_CleanedUp;
	}
}
