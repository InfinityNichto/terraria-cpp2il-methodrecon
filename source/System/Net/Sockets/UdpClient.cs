using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000307 RID: 775
	public class UdpClient : IDisposable
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x0003DA20 File Offset: 0x0003BC20
		public UdpClient()
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0003DA30 File Offset: 0x0003BC30
		public UdpClient(AddressFamily family)
		{
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			this.m_Family = family;
			this.createClientSocket();
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0003DA60 File Offset: 0x0003BC60
		public UdpClient(int port)
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0003DA70 File Offset: 0x0003BC70
		public UdpClient(int port, AddressFamily family)
		{
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			if (2 == 0)
			{
			}
			bool flag = ValidationHelper.ValidateTcpPort(port);
			this.m_Family = family;
			if (2 == 0)
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0003DACC File Offset: 0x0003BCCC
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

		// Token: 0x17000491 RID: 1169
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		public bool EnableBroadcast
		{
			set
			{
				this.m_ClientSocket.EnableBroadcast = value;
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0003DAFC File Offset: 0x0003BCFC
		public void Close()
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0003DB0C File Offset: 0x0003BD0C
		private void FreeResources()
		{
			if (!this.m_CleanedUp)
			{
				Socket clientSocket = this.m_ClientSocket;
				if (clientSocket != null)
				{
					clientSocket.InternalShutdown(SocketShutdown.Both);
					clientSocket.Close();
				}
				this.m_CleanedUp = true;
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0003DB40 File Offset: 0x0003BD40
		public void Dispose()
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0003DB50 File Offset: 0x0003BD50
		protected virtual void Dispose(bool disposing)
		{
			this.FreeResources();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0003DB6C File Offset: 0x0003BD6C
		private void CheckForBroadcast(IPAddress ipAddress)
		{
			if (this.m_ClientSocket != null && !this.m_IsBroadcast)
			{
				bool flag = UdpClient.IsBroadcast(ipAddress);
				Socket clientSocket = this.m_ClientSocket;
				this.m_IsBroadcast = true;
				clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
				return;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		private static bool IsBroadcast(IPAddress address)
		{
			/*
An exception occurred when decompiling this method (06001433)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.UdpClient::IsBroadcast(System.Net.IPAddress)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001434 RID: 5172 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
		{
			/*
An exception occurred when decompiling this method (06001434)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Sockets.UdpClient::Send(System.Byte[],System.Int32,System.Net.IPEndPoint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0042:
	stloc:string(var_6_4C, call:string(SR::GetString, ldstr:string("Cannot send packets to an arbitrary host while connected.")))
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

		// Token: 0x06001435 RID: 5173 RVA: 0x0003DC20 File Offset: 0x0003BE20
		public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state)
		{
			/*
An exception occurred when decompiling this method (06001435)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.UdpClient::BeginReceive(System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:Type(var_5_2B, call:Type(object::GetType, ldloc:UdpClient[exp:object](this)))
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

		// Token: 0x06001436 RID: 5174 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		public byte[] EndReceive(IAsyncResult asyncResult, IPEndPoint remoteEP)
		{
			bool cleanedUp;
			do
			{
				cleanedUp = this.m_CleanedUp;
			}
			while (cleanedUp);
			AddressFamily family = this.m_Family;
			if (!cleanedUp)
			{
			}
			int num = this.m_ClientSocket.EndReceiveFrom(asyncResult, remoteEP);
			throw new InvalidCastException();
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		public Task<UdpReceiveResult> ReceiveAsync()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0003DC98 File Offset: 0x0003BE98
		private void createClientSocket()
		{
			AddressFamily family = this.m_Family;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		[CompilerGenerated]
		private IAsyncResult <ReceiveAsync>b__65_0(AsyncCallback callback, object state)
		{
			return this.BeginReceive(callback, state);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		private UdpReceiveResult <ReceiveAsync>b__65_1(IAsyncResult ar)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040010D9 RID: 4313
		private Socket m_ClientSocket;

		// Token: 0x040010DA RID: 4314
		private bool m_Active;

		// Token: 0x040010DB RID: 4315
		private byte[] m_Buffer;

		// Token: 0x040010DC RID: 4316
		private AddressFamily m_Family;

		// Token: 0x040010DD RID: 4317
		private bool m_CleanedUp;

		// Token: 0x040010DE RID: 4318
		private bool m_IsBroadcast;
	}
}
