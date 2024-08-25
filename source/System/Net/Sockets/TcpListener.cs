using System;

namespace System.Net.Sockets
{
	// Token: 0x02000306 RID: 774
	public class TcpListener
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
		public TcpListener(IPAddress localaddr, int port)
		{
			bool on = Logging.On;
			if (localaddr != null)
			{
				bool flag = ValidationHelper.ValidateTcpPort(port);
				bool on2 = Logging.On;
				return;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		public static TcpListener Create(int port)
		{
			/*
An exception occurred when decompiling this method (06001421)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.TcpListener System.Net.Sockets.TcpListener::Create(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:bool(var_4_1C, callgetter:bool(Logging::get_On))
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0003D910 File Offset: 0x0003BB10
		public Socket Server
		{
			get
			{
				return this.m_ServerSocket;
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0003D924 File Offset: 0x0003BB24
		public void Start()
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0003D934 File Offset: 0x0003BB34
		public void Start(int backlog)
		{
			bool on = Logging.On;
			Socket serverSocket = this.m_ServerSocket;
			if (serverSocket != null)
			{
				if (!this.m_Active)
				{
					IPEndPoint serverSocketEP = this.m_ServerSocketEP;
					serverSocket.Bind(serverSocketEP);
					this.m_ServerSocket.Listen(backlog);
					int num = 1;
					this.m_Active = num != 0;
				}
				bool on2 = Logging.On;
				return;
			}
			string @string = SR.GetString("The socket handle is not valid.");
			throw new OutOfMemoryException();
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		public void Stop()
		{
			bool on = Logging.On;
			Socket serverSocket = this.m_ServerSocket;
			if (serverSocket != null)
			{
				serverSocket.Close();
			}
			IPEndPoint serverSocketEP = this.m_ServerSocketEP;
			if (this.m_ExclusiveAddressUse)
			{
			}
			bool on2 = Logging.On;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003D9E0 File Offset: 0x0003BBE0
		public TcpClient AcceptTcpClient()
		{
			/*
An exception occurred when decompiling this method (06001426)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.TcpClient System.Net.Sockets.TcpListener::AcceptTcpClient()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:string(var_5_2F, call:string(SR::GetString, ldstr:string("Not listening. You must call the Start() method before calling this method.")))
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

		// Token: 0x040010D5 RID: 4309
		private IPEndPoint m_ServerSocketEP;

		// Token: 0x040010D6 RID: 4310
		private Socket m_ServerSocket;

		// Token: 0x040010D7 RID: 4311
		private bool m_Active;

		// Token: 0x040010D8 RID: 4312
		private bool m_ExclusiveAddressUse;
	}
}
