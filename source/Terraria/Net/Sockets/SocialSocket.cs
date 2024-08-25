using System;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006B0 RID: 1712
	public class SocialSocket : ISocket
	{
		// Token: 0x060038CB RID: 14539 RVA: 0x00226680 File Offset: 0x00224880
		public SocialSocket()
		{
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00226694 File Offset: 0x00224894
		public SocialSocket(RemoteAddress remoteAddress)
		{
			this._remoteAddress = remoteAddress;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x002266B0 File Offset: 0x002248B0
		void ISocket.Close()
		{
			if (this._remoteAddress != null)
			{
			}
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x002266C8 File Offset: 0x002248C8
		bool ISocket.IsConnected()
		{
			/*
An exception occurred when decompiling this method (060038CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Net.Sockets.SocialSocket::Terraria.Net.Sockets.ISocket.IsConnected()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RemoteAddress(var_0_06, ldfld:RemoteAddress(SocialSocket::_remoteAddress, ldloc:SocialSocket(this)))
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

		// Token: 0x060038CF RID: 14543 RVA: 0x002266DC File Offset: 0x002248DC
		void ISocket.Connect(RemoteAddress address)
		{
			this._remoteAddress = address;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x002266F0 File Offset: 0x002248F0
		void ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
			RemoteAddress remoteAddress = this._remoteAddress;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00226704 File Offset: 0x00224904
		private void ReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0022673C File Offset: 0x0022493C
		void ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0022674C File Offset: 0x0022494C
		void ISocket.SendQueuedPackets()
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0022675C File Offset: 0x0022495C
		bool ISocket.IsDataAvailable()
		{
			/*
An exception occurred when decompiling this method (060038D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Net.Sockets.SocialSocket::Terraria.Net.Sockets.ISocket.IsDataAvailable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RemoteAddress(var_0_06, ldfld:RemoteAddress(SocialSocket::_remoteAddress, ldloc:SocialSocket(this)))
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

		// Token: 0x060038D5 RID: 14549 RVA: 0x00226770 File Offset: 0x00224970
		RemoteAddress ISocket.GetRemoteAddress()
		{
			return this._remoteAddress;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x000021DB File Offset: 0x000003DB
		bool ISocket.StartListening(SocketConnectionAccepted callback)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00226784 File Offset: 0x00224984
		void ISocket.StopListening()
		{
		}

		// Token: 0x0400795F RID: 31071
		private RemoteAddress _remoteAddress;

		// Token: 0x020006B1 RID: 1713
		private sealed class InternalReadCallback : MulticastDelegate
		{
			// Token: 0x060038D8 RID: 14552 RVA: 0x00226794 File Offset: 0x00224994
			public InternalReadCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060038D9 RID: 14553 RVA: 0x002267E8 File Offset: 0x002249E8
			public void Invoke(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x060038DA RID: 14554 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(byte[] data, int offset, int size, SocketReceiveCallback callback, object state, AsyncCallback __callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060038DB RID: 14555 RVA: 0x0022680C File Offset: 0x00224A0C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
