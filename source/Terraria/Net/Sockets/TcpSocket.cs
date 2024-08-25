using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006B2 RID: 1714
	public class TcpSocket : ISocket
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x0022681C File Offset: 0x00224A1C
		public int MessagesInQueue
		{
			get
			{
				return this._messagesInQueue;
			}
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00226830 File Offset: 0x00224A30
		public TcpSocket()
		{
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00226844 File Offset: 0x00224A44
		public TcpSocket(TcpClient tcpClient)
		{
			int num = 1;
			this._connection = tcpClient;
			tcpClient.NoDelay = num != 0;
			if (tcpClient.m_ClientSocket.RemoteEndPoint != null)
			{
			}
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x00226880 File Offset: 0x00224A80
		void ISocket.Close()
		{
			this._connection.Close();
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x00226898 File Offset: 0x00224A98
		bool ISocket.IsConnected()
		{
			TcpClient connection = this._connection;
			if (connection != null && connection.m_ClientSocket != null)
			{
				return connection.Connected;
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x002268C0 File Offset: 0x00224AC0
		void ISocket.Connect(RemoteAddress address)
		{
			if (address != null)
			{
			}
			TcpClient connection = this._connection;
			this._remoteAddress = address;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x002268E4 File Offset: 0x00224AE4
		private void ReadCallback(IAsyncResult result)
		{
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x00226908 File Offset: 0x00224B08
		private void SendCallback(IAsyncResult result)
		{
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x00226934 File Offset: 0x00224B34
		void ISocket.SendQueuedPackets()
		{
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00226944 File Offset: 0x00224B44
		void ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
			NetworkStream stream = this._connection.GetStream();
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00226960 File Offset: 0x00224B60
		void ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
			NetworkStream stream = this._connection.GetStream();
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0022697C File Offset: 0x00224B7C
		bool ISocket.IsDataAvailable()
		{
			/*
An exception occurred when decompiling this method (060038E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Net.Sockets.TcpSocket::Terraria.Net.Sockets.ISocket.IsDataAvailable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, callgetter:bool(TcpClient::get_Connected, ldfld:TcpClient(TcpSocket::_connection, ldloc:TcpSocket(this))))
	stloc:NetworkStream(var_1_17, call:NetworkStream(TcpClient::GetStream, ldfld:TcpClient(TcpSocket::_connection, ldloc:TcpSocket(this))))
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

		// Token: 0x060038E8 RID: 14568 RVA: 0x002269A4 File Offset: 0x00224BA4
		RemoteAddress ISocket.GetRemoteAddress()
		{
			return this._remoteAddress;
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x002269B8 File Offset: 0x00224BB8
		bool ISocket.StartListening(SocketConnectionAccepted callback)
		{
			if (!true)
			{
			}
			TcpListener listener = this._listener;
			int num = 1;
			this._isListening = num != 0;
			this._listenerCallback = callback;
			if (listener != null || num == 0)
			{
				return;
			}
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x002269F0 File Offset: 0x00224BF0
		void ISocket.StopListening()
		{
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00226A00 File Offset: 0x00224C00
		private void ListenLoop()
		{
			bool isListening = this._isListening;
			if (isListening)
			{
				if (!isListening)
				{
				}
				if (!isListening)
				{
					TcpClient tcpClient = this._listener.AcceptTcpClient();
					return;
				}
			}
			this._listener.Stop();
		}

		// Token: 0x04007960 RID: 31072
		private byte[] _packetBuffer;

		// Token: 0x04007961 RID: 31073
		private List<object> _callbackBuffer;

		// Token: 0x04007962 RID: 31074
		private int _messagesInQueue;

		// Token: 0x04007963 RID: 31075
		private TcpClient _connection;

		// Token: 0x04007964 RID: 31076
		private TcpListener _listener;

		// Token: 0x04007965 RID: 31077
		private SocketConnectionAccepted _listenerCallback;

		// Token: 0x04007966 RID: 31078
		private RemoteAddress _remoteAddress;

		// Token: 0x04007967 RID: 31079
		private bool _isListening;
	}
}
