using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace Telepathy
{
	// Token: 0x02000317 RID: 791
	public class Server : Common
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00059C60 File Offset: 0x00057E60
		private int NextConnectionId(TcpClient newClient)
		{
			ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary = this.clients;
			int num = 1;
			EndPoint endPoint;
			if (endPoint != null)
			{
			}
			if (newClient.m_ClientSocket.RemoteEndPoint != null)
			{
			}
			ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary2 = this.clients;
			bool flag = this.Disconnect(num);
			Thread.Sleep(10);
			return num;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00059CA8 File Offset: 0x00057EA8
		public bool Active
		{
			get
			{
				Thread thread = this.listenerThread;
				bool isAlive;
				if (thread != null)
				{
					isAlive = thread.IsAlive;
					return isAlive;
				}
				return isAlive;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00059CCC File Offset: 0x00057ECC
		private void Listen(int port)
		{
			TcpClient tcpClient = this.listener.AcceptTcpClient();
			if (tcpClient != null)
			{
				int num = this.NextConnectionId(tcpClient);
				ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary = this.clients;
				return;
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00059D14 File Offset: 0x00057F14
		public bool Start(int port)
		{
			/*
An exception occurred when decompiling this method (06001277)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Telepathy.Server::Start(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	call:void(TcpListener::Stop, ldloc:TcpListener(var_19_C0))
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

		// Token: 0x06001278 RID: 4728 RVA: 0x00059DF0 File Offset: 0x00057FF0
		private void Cleanup()
		{
			IEnumerator enumerator = this.clients.GetEnumerator();
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00059E60 File Offset: 0x00058060
		public void Stop()
		{
			Thread thread = this.listenerThread;
			if (thread != null)
			{
				bool isAlive = thread.IsAlive;
				if (!true)
				{
				}
				TcpListener tcpListener = this.listener;
				if (tcpListener != null)
				{
					tcpListener.Stop();
				}
				Thread thread2 = this.listenerThread;
				if (thread2 != null)
				{
					thread2.Interrupt();
				}
				if (!true)
				{
				}
				Thread.Sleep(10);
				TcpListener tcpListener2 = this.listener;
				if (tcpListener2 != null)
				{
					tcpListener2.Stop();
				}
			}
			this.Cleanup();
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00059EC4 File Offset: 0x000580C4
		public bool Send(int connectionId, byte[] data, int length)
		{
			if (this.MaxMessageSize == 0)
			{
			}
			string text2;
			string text3;
			string text = "Client.Send: message too big: " + text2 + ". Limit: " + text3;
			bool noDelay = this.NoDelay;
			TcpListener tcpListener = this.listener;
			ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary = this.clients;
			return true;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00059F14 File Offset: 0x00058114
		public string GetClientAddress(int connectionId)
		{
			ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary = this.clients;
			EndPoint endPoint;
			if (endPoint != null)
			{
			}
			return "";
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00059F38 File Offset: 0x00058138
		public bool Disconnect(int connectionId)
		{
			ConcurrentDictionary<int, Server.ClientToken> concurrentDictionary = this.clients;
			if (!true)
			{
			}
			string text2;
			string text = "Server.Disconnect connectionId:" + text2;
			return true;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00059F60 File Offset: 0x00058160
		public Server()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04002209 RID: 8713
		public TcpListener listener;

		// Token: 0x0400220A RID: 8714
		private Thread listenerThread;

		// Token: 0x0400220B RID: 8715
		private ConcurrentDictionary<int, Server.ClientToken> clients;

		// Token: 0x0400220C RID: 8716
		private static int counter;

		// Token: 0x02000318 RID: 792
		private class ClientToken
		{
			// Token: 0x0600127E RID: 4734 RVA: 0x00059F78 File Offset: 0x00058178
			public ClientToken(TcpClient client)
			{
				this.client = client;
			}

			// Token: 0x0400220D RID: 8717
			public TcpClient client;

			// Token: 0x0400220E RID: 8718
			public SafeQueue<byte[]> sendQueue;

			// Token: 0x0400220F RID: 8719
			public ManualResetEvent sendPending;
		}

		// Token: 0x02000319 RID: 793
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600127F RID: 4735 RVA: 0x00059F94 File Offset: 0x00058194
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06001280 RID: 4736 RVA: 0x00059FA8 File Offset: 0x000581A8
			internal void <Listen>b__0()
			{
				TcpClient tcpClient = this.client;
				Server.ClientToken clientToken = this.token;
				int num = this.connectionId;
				SafeQueue<byte[]> sendQueue = clientToken.sendQueue;
				ManualResetEvent sendPending = clientToken.sendPending;
				Common.SendLoop(num, tcpClient, sendQueue, sendPending);
			}

			// Token: 0x06001281 RID: 4737 RVA: 0x00059FEC File Offset: 0x000581EC
			internal void <Listen>b__1()
			{
				Server server = this.<>4__this;
				int num = this.connectionId;
				TcpClient tcpClient = this.client;
				ConcurrentQueue<Message> receiveQueue = server.receiveQueue;
				int maxMessageSize = server.MaxMessageSize;
				Common.ReceiveLoop(num, tcpClient, receiveQueue, maxMessageSize);
				int num2 = this.connectionId;
				string text;
				Debug.LogError(text);
				Server server2 = this.<>4__this;
				int num3 = this.connectionId;
				ConcurrentDictionary<int, Server.ClientToken> clients = server2.clients;
				Thread thread = this.sendThread;
				thread.Interrupt();
			}

			// Token: 0x04002210 RID: 8720
			public int connectionId;

			// Token: 0x04002211 RID: 8721
			public TcpClient client;

			// Token: 0x04002212 RID: 8722
			public Server.ClientToken token;

			// Token: 0x04002213 RID: 8723
			public Thread sendThread;

			// Token: 0x04002214 RID: 8724
			public Server <>4__this;
		}

		// Token: 0x0200031A RID: 794
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06001282 RID: 4738 RVA: 0x0005A06C File Offset: 0x0005826C
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06001283 RID: 4739 RVA: 0x0005A080 File Offset: 0x00058280
			internal void <Start>b__0()
			{
				Server server = this.<>4__this;
			}

			// Token: 0x04002215 RID: 8725
			public Server <>4__this;

			// Token: 0x04002216 RID: 8726
			public int port;
		}
	}
}
