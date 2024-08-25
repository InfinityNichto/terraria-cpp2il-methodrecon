using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Cpp2IlInjected;

namespace System.Net.Sockets
{
	// Token: 0x020002EB RID: 747
	public class Socket : IDisposable
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x0003B258 File Offset: 0x00039458
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs;
			bool flag = awaitableSocketAsyncEventArgs.Reserve();
			awaitableSocketAsyncEventArgs.SetBuffer(buffer);
			awaitableSocketAsyncEventArgs.<SocketFlags>k__BackingField = (fromNetworkStream ? SocketFlags.OutOfBand : SocketFlags.None);
			ValueTask<int> valueTask;
			return valueTask;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0003B288 File Offset: 0x00039488
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			/*
An exception occurred when decompiling this method (06001328)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.Sockets.Socket::ReceiveAsyncApm(System.Memory`1<System.Byte>,System.Net.Sockets.SocketFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
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

		// Token: 0x06001329 RID: 4905 RVA: 0x0003B2A4 File Offset: 0x000394A4
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			Task task = Task.FromCanceled(cancellationToken);
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs;
			bool flag = awaitableSocketAsyncEventArgs.Reserve();
			Memory<byte> memory = MemoryMarshal.AsMemory(buffer);
			awaitableSocketAsyncEventArgs.SetBuffer(memory);
			int num = 1;
			awaitableSocketAsyncEventArgs.<SocketFlags>k__BackingField = cancellationToken;
			awaitableSocketAsyncEventArgs.<WrapExceptionsInIOExceptions>k__BackingField = num != 0;
			return awaitableSocketAsyncEventArgs.SendAsyncForNetworkStream(this);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0003B2F8 File Offset: 0x000394F8
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			/*
An exception occurred when decompiling this method (0600132A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.Sockets.Socket::SendAsyncApm(System.ReadOnlyMemory`1<System.Byte>,System.Net.Sockets.SocketFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x0600132B RID: 4907 RVA: 0x0003B30C File Offset: 0x0003950C
		private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			if (true)
			{
				s._cachedTaskEventArgs.TaskAccept = saea;
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0003B32C File Offset: 0x0003952C
		private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			SocketError <SocketError>k__BackingField = saea.<SocketError>k__BackingField;
			int <BytesTransferred>k__BackingField = saea.<BytesTransferred>k__BackingField;
			bool wrapExceptionsInIOExceptions = saea._wrapExceptionsInIOExceptions;
			Socket.CachedEventArgs cachedTaskEventArgs = s._cachedTaskEventArgs;
			if (<SocketError>k__BackingField != SocketError.Success)
			{
				return;
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0003B35C File Offset: 0x0003955C
		private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			Socket.CachedEventArgs cachedTaskEventArgs = this._cachedTaskEventArgs;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0003B370 File Offset: 0x00039570
		private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			this._cachedTaskEventArgs.TaskAccept = saea;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0003B38C File Offset: 0x0003958C
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
			bool on = Logging.On;
			Socket.InitializeSockets();
			this.addressFamily = addressFamily;
			this.protocolType = (ProtocolType)socketType;
			this.protocolType = protocolType;
			if (!true)
			{
			}
			this.SocketDefaults();
			if (!true)
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public static bool OSSupportsIPv4
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001331)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.Socket::get_OSSupportsIPv4()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	call:void(Socket::InitializeSockets)
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0003B3E8 File Offset: 0x000395E8
		public static bool OSSupportsIPv6
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001332)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.Socket::get_OSSupportsIPv6()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	call:void(Socket::InitializeSockets)
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0003B3FC File Offset: 0x000395FC
		public IntPtr Handle
		{
			get
			{
				return this.m_Handle.handle;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0003B414 File Offset: 0x00039614
		public AddressFamily AddressFamily
		{
			get
			{
				return this.addressFamily;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0003B428 File Offset: 0x00039628
		public SocketType SocketType
		{
			get
			{
				return this.socketType;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0003B43C File Offset: 0x0003963C
		public ProtocolType ProtocolType
		{
			get
			{
				return this.protocolType;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x0003B450 File Offset: 0x00039650
		public bool ExclusiveAddressUse
		{
			set
			{
				/*
An exception occurred when decompiling this method (06001337)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.Socket::set_ExclusiveAddressUse(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(SR::GetString, ldstr:string("The socket must not be bound or connected.")))
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

		// Token: 0x17000476 RID: 1142
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0003B470 File Offset: 0x00039670
		public int SendTimeout
		{
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0003B480 File Offset: 0x00039680
		public bool DontFragment
		{
			set
			{
				AddressFamily addressFamily = this.addressFamily;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0003B4A0 File Offset: 0x000396A0
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0003B4D0 File Offset: 0x000396D0
		public bool DualMode
		{
			get
			{
				AddressFamily addressFamily = this.addressFamily;
				object socketOption = this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only);
				string @string = SR.GetString("This protocol version is not supported.");
				throw new InvalidCastException();
			}
			set
			{
				AddressFamily addressFamily = this.addressFamily;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0003B4F0 File Offset: 0x000396F0
		private bool IsDualMode
		{
			get
			{
				AddressFamily addressFamily = this.addressFamily;
				return this.DualMode;
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0003B50C File Offset: 0x0003970C
		internal bool CanTryAddressFamily(AddressFamily family)
		{
			AddressFamily addressFamily = this.addressFamily;
			return true;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003B528 File Offset: 0x00039728
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			int num;
			return num;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0003B538 File Offset: 0x00039738
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			int num;
			return num;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0003B548 File Offset: 0x00039748
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			int num;
			return num;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0003B558 File Offset: 0x00039758
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			int num;
			return num;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0003B568 File Offset: 0x00039768
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			int num;
			return num;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0003B578 File Offset: 0x00039778
		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
			AddressFamily addressFamily = this.addressFamily;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0003B5A4 File Offset: 0x000397A4
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0003B5B4 File Offset: 0x000397B4
		public int EndSend(IAsyncResult asyncResult)
		{
			int num;
			return num;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0003B5C4 File Offset: 0x000397C4
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0003B5D4 File Offset: 0x000397D4
		public int EndReceive(IAsyncResult asyncResult)
		{
			int num;
			return num;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0003B5E4 File Offset: 0x000397E4
		private static object InternalSyncObject
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001348)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Net.Sockets.Socket::get_InternalSyncObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0003B5F8 File Offset: 0x000397F8
		internal bool CleanedUp
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001349)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.Socket::get_CleanedUp()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Socket::m_IntCleanedUp, ldloc:Socket(this)))
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

		// Token: 0x0600134A RID: 4938 RVA: 0x0003B60C File Offset: 0x0003980C
		internal static void InitializeSockets()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			object internalSyncObject = Socket.InternalSyncObject;
			if (!true)
			{
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0003B678 File Offset: 0x00039878
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0003B68C File Offset: 0x0003988C
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0003B6C0 File Offset: 0x000398C0
		internal void InternalShutdown(SocketShutdown how)
		{
			if (this.is_connected)
			{
				int intCleanedUp = this.m_IntCleanedUp;
				SafeSocketHandle handle = this.m_Handle;
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0003B6E4 File Offset: 0x000398E4
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			Type type;
			for (;;)
			{
				int intCleanedUp = this.m_IntCleanedUp;
				if (this.is_closed)
				{
					break;
				}
				SafeSocketHandle handle = this.m_Handle;
				if (type == null)
				{
					return;
				}
			}
			type = base.GetType();
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0003B714 File Offset: 0x00039914
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
			this.addressFamily = family;
			this.protocolType = (ProtocolType)type;
			this.protocolType = proto;
			this.m_Handle = safe_handle;
			this.is_connected = true;
			if (!true)
			{
			}
			Socket.InitializeSockets();
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0003B75C File Offset: 0x0003995C
		private void SocketDefaults()
		{
			AddressFamily addressFamily = this.addressFamily;
			long num = 0L;
			this.DontFragment = num != 0L;
			ProtocolType protocolType = this.protocolType;
			long num2 = 0L;
			this.NoDelay = num2 != 0L;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00002050 File Offset: 0x00000250
		private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0003B7A4 File Offset: 0x000399A4
		public int Available
		{
			get
			{
				if (!true)
				{
				}
				int num;
				return num;
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0003B7B8 File Offset: 0x000399B8
		private static int Available_internal(SafeSocketHandle safeHandle, [Out] int error)
		{
			if (!false)
			{
				return 43159552;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
		private static int Available_icall(IntPtr socket, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700047D RID: 1149
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0003B7E8 File Offset: 0x000399E8
		public bool EnableBroadcast
		{
			set
			{
				this.ThrowIfDisposedAndClosed();
				ProtocolType protocolType = this.protocolType;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0003B804 File Offset: 0x00039A04
		public bool IsBound
		{
			get
			{
				return this.is_bound;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0003B818 File Offset: 0x00039A18
		public EndPoint LocalEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.seed_endpoint != null)
				{
					SafeSocketHandle handle = this.m_Handle;
					AddressFamily addressFamily = this.addressFamily;
					return this.seed_endpoint;
				}
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003B84C File Offset: 0x00039A4C
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, [Out] int error)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00002050 File Offset: 0x00000250
		private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0003B874 File Offset: 0x00039A74
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0003B888 File Offset: 0x00039A88
		public bool Blocking
		{
			get
			{
				return this.is_blocking;
			}
			set
			{
				do
				{
					this.ThrowIfDisposedAndClosed();
					SafeSocketHandle handle = this.m_Handle;
					if (!true)
					{
					}
				}
				while (true);
				this.is_blocking = true;
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, [Out] int error)
		{
			safeHandle.DangerousAddRef(block);
			IntPtr handle = safeHandle.handle;
			if (!true)
			{
			}
			long num = 0L;
			if (true)
			{
				safeHandle.DangerousRelease();
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003B900 File Offset: 0x00039B00
		internal static void Blocking_icall(IntPtr socket, bool block, [Out] int error)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0003B910 File Offset: 0x00039B10
		public bool Connected
		{
			get
			{
				return this.is_connected;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0003B924 File Offset: 0x00039B24
		public bool NoDelay
		{
			set
			{
				this.ThrowIfDisposedAndClosed();
				this.ThrowIfUdp();
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0003B940 File Offset: 0x00039B40
		public EndPoint RemoteEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.is_connected && this.seed_endpoint != null)
				{
					SafeSocketHandle handle = this.m_Handle;
					AddressFamily addressFamily = this.addressFamily;
					return;
				}
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0003B974 File Offset: 0x00039B74
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, [Out] int error)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002050 File Offset: 0x00000250
		private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0003B99C File Offset: 0x00039B9C
		public bool Poll(int microSeconds, SelectMode mode)
		{
			this.ThrowIfDisposedAndClosed();
			SafeSocketHandle handle = this.m_Handle;
			if (!this.is_connected)
			{
				object socketOption = this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error);
				this.is_connected = true;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0003B9DC File Offset: 0x00039BDC
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, [Out] int error)
		{
			if (!false)
			{
				return false;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002050 File Offset: 0x00000250
		private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003BA08 File Offset: 0x00039C08
		public Socket Accept()
		{
			/*
An exception occurred when decompiling this method (06001366)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.Socket System.Net.Sockets.Socket::Accept()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0039:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(Socket::is_closed, ldloc:Socket(this))))
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

		// Token: 0x06001367 RID: 4967 RVA: 0x0003BA58 File Offset: 0x00039C58
		internal void Accept(Socket acceptSocket)
		{
			/*
An exception occurred when decompiling this method (06001367)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.Socket::Accept(System.Net.Sockets.Socket)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0067:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(Socket::is_closed, ldloc:Socket(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001368 RID: 4968 RVA: 0x0003BAD4 File Offset: 0x00039CD4
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			do
			{
				this.ThrowIfDisposedAndClosed();
				if (!this.is_bound)
				{
					goto IL_006B;
				}
			}
			while (!this.is_listening || e._bufferList != null);
			int count = e._count;
			Socket <AcceptSocket>k__BackingField = e.<AcceptSocket>k__BackingField;
			bool flag;
			if (<AcceptSocket>k__BackingField != null)
			{
				if (!<AcceptSocket>k__BackingField.is_bound)
				{
					flag = <AcceptSocket>k__BackingField.is_connected;
					if (!flag)
					{
						goto IL_0041;
					}
				}
				return "AcceptSocket: The socket must not be bound or connected." != null;
			}
			IL_0041:
			if (!flag)
			{
			}
			SocketAsyncResult socket_async_result = e.socket_async_result;
			SemaphoreSlim readSem = this.ReadSem;
			IntPtr handle = socket_async_result.Handle;
			SocketAsyncResult socket_async_result2 = e.socket_async_result;
			return true;
			IL_006B:
			return "You must call the Bind method before performing this operation." != null;
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0003BB54 File Offset: 0x00039D54
		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (06001369)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.Socket::BeginAccept(System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:SemaphoreSlim(var_0_1C, ldfld:SemaphoreSlim(Socket::ReadSem, ldloc:Socket(this)))
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

		// Token: 0x0600136A RID: 4970 RVA: 0x0003BB80 File Offset: 0x00039D80
		public Socket EndAccept(IAsyncResult asyncResult)
		{
			Socket socket;
			return socket;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00002050 File Offset: 0x00000250
		public Socket EndAccept([Out] byte[] buffer, [Out] int bytesTransferred, IAsyncResult asyncResult)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0003BB90 File Offset: 0x00039D90
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, [Out] int error, bool blocking)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
		private static IntPtr Accept_icall(IntPtr sock, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		public void Bind(EndPoint localEP)
		{
			do
			{
				this.ThrowIfDisposedAndClosed();
				if (localEP == null)
				{
					return;
				}
			}
			while (this.m_Handle != null);
			int num = 1;
			this.is_bound = num != 0;
			IPEndPoint ipendPoint;
			this.seed_endpoint = ipendPoint;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, [Out] int error)
		{
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0003BC20 File Offset: 0x00039E20
		private static void Bind_icall(IntPtr sock, SocketAddress sa, [Out] int error)
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0003BC30 File Offset: 0x00039E30
		public void Listen(int backlog)
		{
			do
			{
				this.ThrowIfDisposedAndClosed();
				if (!this.is_bound)
				{
					return;
				}
				SafeSocketHandle handle = this.m_Handle;
			}
			while (backlog != 0);
			this.is_listening = true;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0003BC60 File Offset: 0x00039E60
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, [Out] int error)
		{
			safeHandle.DangerousAddRef(backlog != 0);
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		private static void Listen_icall(IntPtr sock, int backlog, [Out] int error)
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		public void Connect(IPAddress address, int port)
		{
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		public void Connect(EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				return;
			}
			long num = 0L;
			if (!this.is_listening)
			{
				if (num != 0L)
				{
				}
				SafeSocketHandle handle = this.m_Handle;
				bool flag = this.is_blocking;
				IPEndPoint ipendPoint;
				this.seed_endpoint = ipendPoint;
				SocketType socketType = this.socketType;
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0003BD68 File Offset: 0x00039F68
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (06001376)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.Socket::BeginConnect(System.String,System.Int32,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:class [mscorlib]System.Threading.Tasks.Task`1<class System.Net.IPAddress[]>(var_2_24, call:Task`1[exp:class [mscorlib]System.Threading.Tasks.Task`1<class System.Net.IPAddress[]>](Dns::GetHostAddressesAsync, ldloc:string(host)))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001377 RID: 4983 RVA: 0x0003BD9C File Offset: 0x00039F9C
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (06001377)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.Socket::BeginConnect(System.Net.EndPoint,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldfld:bool(Socket::is_listening, ldloc:Socket(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001378 RID: 4984 RVA: 0x0003BDBC File Offset: 0x00039FBC
		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0003BDD8 File Offset: 0x00039FD8
		public void EndConnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndConnect", "asyncResult");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0003BE14 File Offset: 0x0003A014
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, [Out] int error, bool blocking)
		{
			safeHandle.RegisterForBlockingSyscall();
			IntPtr handle = safeHandle.handle;
			safeHandle.UnRegisterForBlockingSyscall();
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0003BE58 File Offset: 0x0003A058
		private static void Connect_icall(IntPtr sock, SocketAddress sa, [Out] int error, bool blocking)
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0003BE68 File Offset: 0x0003A068
		public void Disconnect(bool reuseSocket)
		{
			this.ThrowIfDisposedAndClosed();
			SafeSocketHandle handle = this.m_Handle;
			if (!true)
			{
			}
			if (!reuseSocket)
			{
				return;
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0003BE8C File Offset: 0x0003A08C
		public void EndDisconnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndDisconnect", "asyncResult");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003BEC8 File Offset: 0x0003A0C8
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, [Out] int error)
		{
			safeHandle.DangerousAddRef(reuse);
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0003BF10 File Offset: 0x0003A110
		private static void Disconnect_icall(IntPtr sock, bool reuse, [Out] int error)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0003BF20 File Offset: 0x0003A120
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			int num = 1;
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (buffer == null || num != 0)
			{
			}
			SafeSocketHandle handle = this.m_Handle;
			bool flag = this.is_blocking;
			if (num == 0)
			{
			}
			errorCode.value__ = num;
			int num3;
			if (num == 0)
			{
				int num2 = 1;
				this.is_connected = num2 != 0;
				return num3;
			}
			return num3;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0003BF78 File Offset: 0x0003A178
		private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			ThrowHelper.ThrowArgumentOutOfRangeException();
			SafeSocketHandle handle = this.m_Handle;
			if (offset == 0)
			{
			}
			int num2;
			if (offset == 0)
			{
				int num = 1;
				this.is_connected = num != 0;
				return num2;
			}
			return num2;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
		[CLSCompliant(false)]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers != null && buffers != null)
			{
				if (41586688 != 0)
				{
					return 41586688;
				}
				if (!false)
				{
					int num;
					return num;
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0003C014 File Offset: 0x0003A214
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			int num;
			return num;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00002050 File Offset: 0x00000250
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00002050 File Offset: 0x00000250
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0003C024 File Offset: 0x0003A224
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, [Out] SocketError errorCode, AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (06001387)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.Socket::BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.Sockets.SocketError,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SemaphoreSlim(var_1_06, ldfld:SemaphoreSlim(Socket::ReadSem, ldloc:Socket(this)))
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

		// Token: 0x06001388 RID: 5000 RVA: 0x0003C038 File Offset: 0x0003A238
		public int EndReceive(IAsyncResult asyncResult, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndReceive", "asyncResult");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			SocketError errorCode2 = socketAsyncResult.ErrorCode;
			socketAsyncResult.CheckIfThrowDelayedException();
			return socketAsyncResult.Total;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0003C080 File Offset: 0x0003A280
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0003C108 File Offset: 0x0003A308
		private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, [Out] SocketError errorCode)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
			SafeSocketHandle handle = this.m_Handle;
			bool flag = this.is_blocking;
			if (offset == 0)
			{
			}
			long num = 0L;
			if (offset != 0)
			{
				int num2;
				return num2;
			}
			if (num != 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0003C168 File Offset: 0x0003A368
		public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (0600138E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.Sockets.Socket::BeginReceiveFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(Socket::ThrowIfDisposedAndClosed, ldloc:Socket(this))
	call:void(Socket::ThrowIfBufferNull, ldloc:Socket(this), ldloc:uint8[](buffer))
	call:void(Socket::ThrowIfBufferOutOfRange, ldloc:Socket(this), ldloc:uint8[](buffer), ldloc:int32(offset), ldloc:int32(size))
	stloc:SemaphoreSlim(var_1_1C, ldfld:SemaphoreSlim(Socket::ReadSem, ldloc:Socket(this)))
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

		// Token: 0x0600138F RID: 5007 RVA: 0x0003C194 File Offset: 0x0003A394
		public int EndReceiveFrom(IAsyncResult asyncResult, EndPoint endPoint)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndReceiveFrom", "asyncResult");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			EndPoint endPoint2 = socketAsyncResult.EndPoint;
			return socketAsyncResult.Total;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			this.ThrowIfDisposedAndClosed();
			if (!sockares.completed)
			{
				WaitHandle asyncWaitHandle = sockares.AsyncWaitHandle;
			}
			sockares.CheckIfThrowDelayedException();
			EndPoint endPoint = sockares.EndPoint;
			ares.remote_ep = endPoint;
			return sockares.Total;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0003C218 File Offset: 0x0003A418
		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0003C25C File Offset: 0x0003A45C
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			int num2;
			if (size != 0)
			{
				if (buffer != null)
				{
				}
				SafeSocketHandle handle = this.m_Handle;
				bool flag = this.is_blocking;
				int num = 1;
				this.is_connected = num != 0;
				return num2;
			}
			return num2;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003C2A8 File Offset: 0x0003A4A8
		[CLSCompliant(false)]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers != null && buffers != null)
			{
				long num = 0L;
				int num2 = 18;
				if (num == 0L)
				{
					if (num2 == 0)
					{
					}
					int num3;
					return num3;
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			IList<ArraySegment<byte>> bufferList;
			do
			{
				this.ThrowIfDisposedAndClosed();
				object @object = e._buffer._object;
				bufferList = e._bufferList;
			}
			while (bufferList == null);
			if (!true)
			{
			}
			IntPtr handle;
			SocketAsyncResult socket_async_result2;
			if (bufferList != null)
			{
				SocketAsyncResult socket_async_result = e.socket_async_result;
				IList<ArraySegment<byte>> bufferList2 = e._bufferList;
				socket_async_result.Buffers = bufferList2;
				SemaphoreSlim writeSem = this.WriteSem;
				handle = socket_async_result.Handle;
				socket_async_result2 = e.socket_async_result;
			}
			bool completed_synchronously = socket_async_result2.completed_synchronously;
			int offset = socket_async_result2.Offset;
			bool completed_synchronously2 = socket_async_result2.completed_synchronously;
			Socket acceptSocket = socket_async_result2.AcceptSocket;
			SemaphoreSlim writeSem2 = this.WriteSem;
			if (handle == 0)
			{
			}
			bool completed_synchronously3 = socket_async_result2.completed_synchronously;
			return true;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003C38C File Offset: 0x0003A58C
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, [Out] SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (!this.is_connected)
			{
				return;
			}
			SemaphoreSlim writeSem = this.WriteSem;
			if (offset == 0)
			{
				return;
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0003C3C4 File Offset: 0x0003A5C4
		private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			int length = sockares.Buffer._length;
			int size = sockares.Size;
			int size2 = sockares.Size;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			Memory<byte> buffer = sockares.Buffer;
			int index = sockares.Buffer._index;
			Socket socket = sockares.socket;
			int size3 = sockares.Size;
			SafeSocketHandle handle = socket.m_Handle;
			if (!false)
			{
				int offset = sockares.Offset;
				SocketFlags sockFlags = sockares.SockFlags;
				Socket socket2 = sockares.socket;
				sockares.SockFlags = (SocketFlags)offset;
				int intCleanedUp = socket2.m_IntCleanedUp;
				IntPtr handle2 = sockares.Handle;
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0003C4A0 File Offset: 0x0003A6A0
		public int EndSend(IAsyncResult asyncResult, [Out] SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSend", "asyncResult");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			SocketError errorCode2 = socketAsyncResult.ErrorCode;
			socketAsyncResult.CheckIfThrowDelayedException();
			return socketAsyncResult.Total;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0003C4E8 File Offset: 0x0003A6E8
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0003C530 File Offset: 0x0003A730
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0003C574 File Offset: 0x0003A774
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			for (;;)
			{
				int num = 1;
				this.ThrowIfDisposedAndClosed();
				this.ThrowIfBufferNull(buffer);
				this.ThrowIfBufferOutOfRange(buffer, offset, size);
				if (remoteEP != null)
				{
					if (buffer == null || num != 0)
					{
					}
					SafeSocketHandle handle = this.m_Handle;
					bool flag = this.is_blocking;
					if (socketFlags == SocketFlags.None)
					{
						break;
					}
				}
			}
			int num2;
			return num2;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0003C5C0 File Offset: 0x0003A7C0
		public int EndSendTo(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSendTo", "result");
			if (!socketAsyncResult.completed)
			{
				WaitHandle asyncWaitHandle = socketAsyncResult.AsyncWaitHandle;
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			return socketAsyncResult.Total;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0003C600 File Offset: 0x0003A800
		private unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, [Out] int error, bool blocking)
		{
			return 43159552;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		private unsafe static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, [Out] int error, bool blocking)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0003C644 File Offset: 0x0003A844
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			int num = 1;
			this.ThrowIfDisposedAndClosed();
			SafeSocketHandle handle = this.m_Handle;
			if (num == 0)
			{
			}
			if (optionLevel == SocketOptionLevel.IP)
			{
				if (handle == null || handle != null)
				{
				}
				while (handle == null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0003C674 File Offset: 0x0003A874
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, [Out] object obj_val, [Out] int error)
		{
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
		private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, [Out] object obj_val, [Out] int error)
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			do
			{
				this.ThrowIfDisposedAndClosed();
				SafeSocketHandle handle = this.m_Handle;
				if (!true)
				{
				}
			}
			while (optionValue != 0);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0003C6E4 File Offset: 0x0003A8E4
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, [Out] int error)
		{
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0003C724 File Offset: 0x0003A924
		private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, [Out] int error)
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0003C734 File Offset: 0x0003A934
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			do
			{
				int intCleanedUp = this.m_IntCleanedUp;
				SafeSocketHandle handle = this.m_Handle;
			}
			while (optionOutValue != null);
			int num;
			return num;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0003C75C File Offset: 0x0003A95C
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, [Out] int error)
		{
			if (!false)
			{
				return 43159552;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, [Out] int error)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0003C78C File Offset: 0x0003A98C
		public void Close()
		{
			this.Dispose();
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0003C7A0 File Offset: 0x0003A9A0
		public void Close(int timeout)
		{
			this.linger_timeout = timeout;
			this.Dispose();
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0003C7BC File Offset: 0x0003A9BC
		internal static void Close_icall(IntPtr socket, [Out] int error)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		public void Shutdown(SocketShutdown how)
		{
			do
			{
				this.ThrowIfDisposedAndClosed();
			}
			while (!this.is_connected);
			SafeSocketHandle handle = this.m_Handle;
			if (how != SocketShutdown.Receive)
			{
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, [Out] int error)
		{
			IntPtr handle = safeHandle.handle;
			long num = 0L;
			safeHandle.DangerousRelease();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0003C834 File Offset: 0x0003AA34
		internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, [Out] int error)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0003C844 File Offset: 0x0003AA44
		protected virtual void Dispose(bool disposing)
		{
			SafeSocketHandle handle;
			bool flag;
			do
			{
				int intCleanedUp = this.m_IntCleanedUp;
				handle = this.m_Handle;
				flag = this.is_connected;
				this.m_IntCleanedUp = 1;
				if (handle == null)
				{
					return;
				}
				this.is_closed = true;
			}
			while (!flag);
			IntPtr handle2 = handle.handle;
			this.Linger(handle2);
			this.m_Handle.Dispose();
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003C894 File Offset: 0x0003AA94
		private void Linger(IntPtr handle)
		{
			if (this.is_connected)
			{
				int num = this.linger_timeout;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (1000 == 0)
					{
					}
					if (1000 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0003C8C8 File Offset: 0x0003AAC8
		private void ThrowIfDisposedAndClosed()
		{
			/*
An exception occurred when decompiling this method (060013B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.Socket::ThrowIfDisposedAndClosed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:Type(var_1_16, call:Type(object::GetType, ldloc:Socket[exp:object](this)))
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

		// Token: 0x060013B3 RID: 5043 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		private void ThrowIfBufferNull(byte[] buffer)
		{
			while (buffer == null)
			{
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0003C8FC File Offset: 0x0003AAFC
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0003C90C File Offset: 0x0003AB0C
		private void ThrowIfUdp()
		{
			ProtocolType protocolType = this.protocolType;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0003C920 File Offset: 0x0003AB20
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			/*
An exception occurred when decompiling this method (060013B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.SocketAsyncResult System.Net.Sockets.Socket::ValidateEndIAsyncResult(System.IAsyncResult,System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_04, ldc.i4:int32(1))
	stloc:int64(var_1_06, ldc.i4:int64(0))
	stloc:int32(var_2_13, call:int32(Interlocked::CompareExchange, ldc.i4:int32(-2147483648), ldloc:int32(var_0_04), ldloc:int64[exp:int32](var_1_06)))
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

		// Token: 0x060013B7 RID: 5047 RVA: 0x0003C940 File Offset: 0x0003AB40
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, global::System.IOSelectorJob job)
		{
			bool isCompleted = sem.WaitAsync().IsCompleted;
			int intCleanedUp = this.m_IntCleanedUp;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0003C964 File Offset: 0x0003AB64
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
			e.socket_async_result.Init(this, callback, state, operation);
			Socket <AcceptSocket>k__BackingField = e.<AcceptSocket>k__BackingField;
			if (<AcceptSocket>k__BackingField != null)
			{
				e.socket_async_result.AcceptSocket = <AcceptSocket>k__BackingField;
			}
			e.current_socket = this;
			SocketAsyncOperation socketAsyncOperation;
			e.SetLastOperation(socketAsyncOperation);
			long num = 0L;
			e.SetBytesTransferred((int)num);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002050 File Offset: 0x00000250
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			/*
An exception occurred when decompiling this method (060013BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.IPEndPoint System.Net.Sockets.Socket::RemapIPEndPoint(System.Net.IPEndPoint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AddressFamily(var_0_06, ldfld:AddressFamily(Socket::addressFamily, ldloc:Socket(this)))
	stloc:bool(var_1_0D, callgetter:bool(Socket::get_DualMode, ldloc:Socket(this)))
	stloc:IPAddress(var_2_19, call:IPAddress(IPAddress::MapToIPv6, ldfld:IPAddress(IPEndPoint::_address, ldloc:IPEndPoint(input))))
	stloc:int32(var_3_20, ldfld:int32(IPEndPoint::_port, ldloc:IPEndPoint(input)))
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

		// Token: 0x060013BB RID: 5051 RVA: 0x0003C9E0 File Offset: 0x0003ABE0
		internal static void cancel_blocking_socket_operation(Thread thread)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		internal static int FamilyHint
		{
			get
			{
				/*
An exception occurred when decompiling this method (060013BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Sockets.Socket::get_FamilyHint()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_08, callgetter:bool(Socket::get_OSSupportsIPv4))
	stloc:bool(var_1_0E, callgetter:bool(Socket::get_OSSupportsIPv6))
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

		// Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		private static bool IsProtocolSupported_internal(global::System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		private static bool IsProtocolSupported(global::System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface)
		{
			/*
An exception occurred when decompiling this method (060013BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.Socket::IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent)

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

		// Token: 0x060013BF RID: 5055 RVA: 0x0003CA1C File Offset: 0x0003AC1C
		// Note: this type is marked as 'beforefieldinit'.
		static Socket()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000F91 RID: 3985
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler;

		// Token: 0x04000F92 RID: 3986
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler;

		// Token: 0x04000F93 RID: 3987
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler;

		// Token: 0x04000F94 RID: 3988
		private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel;

		// Token: 0x04000F95 RID: 3989
		private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;

		// Token: 0x04000F96 RID: 3990
		private static readonly Task<int> s_zeroTask;

		// Token: 0x04000F97 RID: 3991
		private Socket.CachedEventArgs _cachedTaskEventArgs;

		// Token: 0x04000F98 RID: 3992
		private static object s_InternalSyncObject;

		// Token: 0x04000F99 RID: 3993
		internal static bool s_SupportsIPv4;

		// Token: 0x04000F9A RID: 3994
		internal static bool s_SupportsIPv6;

		// Token: 0x04000F9B RID: 3995
		internal static bool s_OSSupportsIPv6;

		// Token: 0x04000F9C RID: 3996
		internal static bool s_Initialized;

		// Token: 0x04000F9D RID: 3997
		private static bool s_LoggingEnabled;

		// Token: 0x04000F9E RID: 3998
		private bool is_closed;

		// Token: 0x04000F9F RID: 3999
		private bool is_listening;

		// Token: 0x04000FA0 RID: 4000
		private int linger_timeout;

		// Token: 0x04000FA1 RID: 4001
		private AddressFamily addressFamily;

		// Token: 0x04000FA2 RID: 4002
		private SocketType socketType;

		// Token: 0x04000FA3 RID: 4003
		private ProtocolType protocolType;

		// Token: 0x04000FA4 RID: 4004
		internal SafeSocketHandle m_Handle;

		// Token: 0x04000FA5 RID: 4005
		internal EndPoint seed_endpoint;

		// Token: 0x04000FA6 RID: 4006
		internal SemaphoreSlim ReadSem;

		// Token: 0x04000FA7 RID: 4007
		internal SemaphoreSlim WriteSem;

		// Token: 0x04000FA8 RID: 4008
		internal bool is_blocking = true;

		// Token: 0x04000FA9 RID: 4009
		internal bool is_bound;

		// Token: 0x04000FAA RID: 4010
		internal bool is_connected;

		// Token: 0x04000FAB RID: 4011
		private int m_IntCleanedUp;

		// Token: 0x04000FAC RID: 4012
		internal bool connect_in_progress;

		// Token: 0x04000FAD RID: 4013
		private static AsyncCallback AcceptAsyncCallback;

		// Token: 0x04000FAE RID: 4014
		private static global::System.IOAsyncCallback BeginAcceptCallback;

		// Token: 0x04000FAF RID: 4015
		private static global::System.IOAsyncCallback BeginAcceptReceiveCallback;

		// Token: 0x04000FB0 RID: 4016
		private static AsyncCallback ConnectAsyncCallback;

		// Token: 0x04000FB1 RID: 4017
		private static global::System.IOAsyncCallback BeginConnectCallback;

		// Token: 0x04000FB2 RID: 4018
		private static AsyncCallback DisconnectAsyncCallback;

		// Token: 0x04000FB3 RID: 4019
		private static global::System.IOAsyncCallback BeginDisconnectCallback;

		// Token: 0x04000FB4 RID: 4020
		private static AsyncCallback ReceiveAsyncCallback;

		// Token: 0x04000FB5 RID: 4021
		private static global::System.IOAsyncCallback BeginReceiveCallback;

		// Token: 0x04000FB6 RID: 4022
		private static global::System.IOAsyncCallback BeginReceiveGenericCallback;

		// Token: 0x04000FB7 RID: 4023
		private static AsyncCallback ReceiveFromAsyncCallback;

		// Token: 0x04000FB8 RID: 4024
		private static global::System.IOAsyncCallback BeginReceiveFromCallback;

		// Token: 0x04000FB9 RID: 4025
		private static AsyncCallback SendAsyncCallback;

		// Token: 0x04000FBA RID: 4026
		private static global::System.IOAsyncCallback BeginSendGenericCallback;

		// Token: 0x04000FBB RID: 4027
		private static AsyncCallback SendToAsyncCallback;

		// Token: 0x020002EC RID: 748
		private sealed class CachedEventArgs
		{
			// Token: 0x060013C0 RID: 5056 RVA: 0x0003CA30 File Offset: 0x0003AC30
			public CachedEventArgs()
			{
			}

			// Token: 0x04000FBC RID: 4028
			public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept;

			// Token: 0x04000FBD RID: 4029
			public Socket.Int32TaskSocketAsyncEventArgs TaskReceive;

			// Token: 0x04000FBE RID: 4030
			public Socket.Int32TaskSocketAsyncEventArgs TaskSend;

			// Token: 0x04000FBF RID: 4031
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;

			// Token: 0x04000FC0 RID: 4032
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		// Token: 0x020002ED RID: 749
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x060013C1 RID: 5057 RVA: 0x0003CA44 File Offset: 0x0003AC44
			internal TaskSocketAsyncEventArgs()
			{
				long num = 0L;
				base..ctor(num != 0L);
			}

			// Token: 0x060013C2 RID: 5058 RVA: 0x0003CA5C File Offset: 0x0003AC5C
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility([Out] bool responsibleForReturningToPool)
			{
				Monitor.Enter(this, responsibleForReturningToPool);
				long num = 0L;
				Monitor.Exit(this);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x04000FC1 RID: 4033
			internal AsyncTaskMethodBuilder<TResult> _builder;

			// Token: 0x04000FC2 RID: 4034
			internal bool _accessed;
		}

		// Token: 0x020002EE RID: 750
		private sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x060013C3 RID: 5059 RVA: 0x0003CA98 File Offset: 0x0003AC98
			public Int32TaskSocketAsyncEventArgs()
			{
			}

			// Token: 0x04000FC3 RID: 4035
			internal bool _wrapExceptionsInIOExceptions;
		}

		// Token: 0x020002EF RID: 751
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			// Token: 0x060013C4 RID: 5060 RVA: 0x0003CAAC File Offset: 0x0003ACAC
			public AwaitableSocketAsyncEventArgs()
			{
				if (!true)
				{
				}
				long num = 0L;
				this._continuation = 1;
				base..ctor(num != 0L);
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0003CACC File Offset: 0x0003ACCC
			// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0003CAE0 File Offset: 0x0003ACE0
			public bool WrapExceptionsInIOExceptions
			{
				[CompilerGenerated]
				get
				{
					return this.<WrapExceptionsInIOExceptions>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060013C7 RID: 5063 RVA: 0x0003CAF0 File Offset: 0x0003ACF0
			public bool Reserve()
			{
				/*
An exception occurred when decompiling this method (060013C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::Reserve()

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

			// Token: 0x060013C8 RID: 5064 RVA: 0x0003CB00 File Offset: 0x0003AD00
			private void Release()
			{
				short token = this._token;
				this._token = token;
				if (token == 0)
				{
				}
			}

			// Token: 0x060013C9 RID: 5065 RVA: 0x0003CB20 File Offset: 0x0003AD20
			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
				if (this._continuation == null)
				{
					if (!true)
					{
					}
					if (this == null)
					{
						return;
					}
				}
				if (!true)
				{
				}
				ExecutionContext executionContext = this._executionContext;
				this._continuation = 1;
				if (executionContext != null)
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
					return;
				}
			}

			// Token: 0x060013CA RID: 5066 RVA: 0x0003CB58 File Offset: 0x0003AD58
			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				bool flag = socket.ReceiveAsync(this);
				short token = this._token;
				if (this == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
				}
				return 39;
			}

			// Token: 0x060013CB RID: 5067 RVA: 0x0003CBB4 File Offset: 0x0003ADB4
			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				bool flag = socket.SendAsync(this);
				short token = this._token;
				if (this == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
				}
				return 39;
			}

			// Token: 0x060013CC RID: 5068 RVA: 0x0003CC08 File Offset: 0x0003AE08
			public ValueTaskSourceStatus GetStatus(short token)
			{
				/*
An exception occurred when decompiling this method (060013CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Sources.ValueTaskSourceStatus System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::GetStatus(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:SocketError(var_3_19, ldfld:SocketError(SocketAsyncEventArgs::<SocketError>k__BackingField, ldloc:AwaitableSocketAsyncEventArgs[exp:SocketAsyncEventArgs](this)))
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

			// Token: 0x060013CD RID: 5069 RVA: 0x0003CC30 File Offset: 0x0003AE30
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				short token2 = this._token;
				ExecutionContext executionContext = ExecutionContext.Capture();
				this._executionContext = executionContext;
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null)
				{
					Type type;
					bool flag = synchronizationContext.GetType() != type;
				}
				TaskScheduler taskScheduler = TaskScheduler.Current;
				if (!true)
				{
				}
				this._scheduler = taskScheduler;
				this.<UserToken>k__BackingField = state;
			}

			// Token: 0x060013CE RID: 5070 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
				if (this._scheduler != null)
				{
					if (!true)
					{
					}
					CancellationToken none = CancellationToken.None;
					return;
				}
			}

			// Token: 0x060013CF RID: 5071 RVA: 0x0003CCD4 File Offset: 0x0003AED4
			public int GetResult(short token)
			{
				/*
An exception occurred when decompiling this method (060013CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::GetResult(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	call:void(AwaitableSocketAsyncEventArgs::ThrowException, ldloc:AwaitableSocketAsyncEventArgs(this), ldloc:SocketError(var_1_0D))
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

			// Token: 0x060013D0 RID: 5072 RVA: 0x0003CD08 File Offset: 0x0003AF08
			void IValueTaskSource.GetResult(short token)
			{
				/*
An exception occurred when decompiling this method (060013D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::System.Threading.Tasks.Sources.IValueTaskSource.GetResult(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	call:void(AwaitableSocketAsyncEventArgs::ThrowException, ldloc:AwaitableSocketAsyncEventArgs(this), ldloc:SocketError(var_1_0D))
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

			// Token: 0x060013D1 RID: 5073 RVA: 0x00002050 File Offset: 0x00000250
			private void ThrowIncorrectTokenException()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
			private void ThrowMultipleContinuationsException()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013D3 RID: 5075 RVA: 0x0003CD3C File Offset: 0x0003AF3C
			private void ThrowException(SocketError error)
			{
				/*
An exception occurred when decompiling this method (060013D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::ThrowException(System.Net.Sockets.SocketError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_07, call:Exception(AwaitableSocketAsyncEventArgs::CreateException, ldloc:AwaitableSocketAsyncEventArgs(this), ldloc:SocketError(error)))
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

			// Token: 0x060013D4 RID: 5076 RVA: 0x0003CD50 File Offset: 0x0003AF50
			private Exception CreateException(SocketError error)
			{
				/*
An exception occurred when decompiling this method (060013D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Net.Sockets.Socket/AwaitableSocketAsyncEventArgs::CreateException(System.Net.Sockets.SocketError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(AwaitableSocketAsyncEventArgs::<WrapExceptionsInIOExceptions>k__BackingField, ldloc:AwaitableSocketAsyncEventArgs(this))))
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

			// Token: 0x060013D5 RID: 5077 RVA: 0x0003CD64 File Offset: 0x0003AF64
			// Note: this type is marked as 'beforefieldinit'.
			static AwaitableSocketAsyncEventArgs()
			{
			}

			// Token: 0x04000FC4 RID: 4036
			internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved;

			// Token: 0x04000FC5 RID: 4037
			private static readonly Action<object> s_completedSentinel;

			// Token: 0x04000FC6 RID: 4038
			private static readonly Action<object> s_availableSentinel;

			// Token: 0x04000FC7 RID: 4039
			private Action<object> _continuation;

			// Token: 0x04000FC8 RID: 4040
			private ExecutionContext _executionContext;

			// Token: 0x04000FC9 RID: 4041
			private object _scheduler;

			// Token: 0x04000FCA RID: 4042
			private short _token;

			// Token: 0x04000FCB RID: 4043
			[CompilerGenerated]
			private bool <WrapExceptionsInIOExceptions>k__BackingField;

			// Token: 0x020002F0 RID: 752
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060013D6 RID: 5078 RVA: 0x0000205C File Offset: 0x0000025C
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x060013D7 RID: 5079 RVA: 0x0000205C File Offset: 0x0000025C
				public <>c()
				{
				}

				// Token: 0x060013D8 RID: 5080 RVA: 0x0000205C File Offset: 0x0000025C
				internal void <OnCompleted>b__14_0(object runState)
				{
				}

				// Token: 0x060013D9 RID: 5081 RVA: 0x0000205C File Offset: 0x0000025C
				internal void <InvokeContinuation>b__20_0(object s)
				{
				}

				// Token: 0x060013DA RID: 5082 RVA: 0x0000205C File Offset: 0x0000025C
				internal void <.cctor>b__27_0(object state)
				{
				}

				// Token: 0x060013DB RID: 5083 RVA: 0x0000205C File Offset: 0x0000025C
				internal void <.cctor>b__27_1(object state)
				{
				}

				// Token: 0x04000FCC RID: 4044
				public static readonly Socket.AwaitableSocketAsyncEventArgs.<>c <>9;

				// Token: 0x04000FCD RID: 4045
				public static ContextCallback <>9__14_0;

				// Token: 0x04000FCE RID: 4046
				public static SendOrPostCallback <>9__20_0;
			}
		}

		// Token: 0x020002F1 RID: 753
		private struct WSABUF
		{
			// Token: 0x04000FCF RID: 4047
			public int len;

			// Token: 0x04000FD0 RID: 4048
			public IntPtr buf;
		}

		// Token: 0x020002F2 RID: 754
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060013DC RID: 5084 RVA: 0x0003CD74 File Offset: 0x0003AF74
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060013DD RID: 5085 RVA: 0x0003CD84 File Offset: 0x0003AF84
			public <>c()
			{
			}

			// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
			internal Socket.CachedEventArgs <ReceiveAsync>b__14_0()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
			internal Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013E0 RID: 5088 RVA: 0x0003CD98 File Offset: 0x0003AF98
			internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar)
			{
			}

			// Token: 0x060013E1 RID: 5089 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
			internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar)
			{
			}

			// Token: 0x060013E2 RID: 5090 RVA: 0x00002050 File Offset: 0x00000250
			internal Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
			internal Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013E4 RID: 5092 RVA: 0x0003CE08 File Offset: 0x0003B008
			internal void <SendAsyncApm>b__23_0(IAsyncResult iar)
			{
			}

			// Token: 0x060013E5 RID: 5093 RVA: 0x0003CE30 File Offset: 0x0003B030
			internal void <SendAsyncApm>b__23_1(IAsyncResult iar)
			{
			}

			// Token: 0x060013E6 RID: 5094 RVA: 0x0003CE68 File Offset: 0x0003B068
			internal void <SendAsync>b__295_0(global::System.IOAsyncResult s)
			{
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
			}

			// Token: 0x060013E7 RID: 5095 RVA: 0x0003CE88 File Offset: 0x0003B088
			internal void <BeginSend>b__297_0(global::System.IOAsyncResult s)
			{
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
			}

			// Token: 0x060013E8 RID: 5096 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
			internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e)
			{
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
				if (e != null)
				{
				}
			}

			// Token: 0x060013E9 RID: 5097 RVA: 0x0003CED0 File Offset: 0x0003B0D0
			internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e)
			{
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
				if (e != null)
				{
				}
			}

			// Token: 0x060013EA RID: 5098 RVA: 0x0003CEF8 File Offset: 0x0003B0F8
			internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e)
			{
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
				if (e != null)
				{
				}
			}

			// Token: 0x060013EB RID: 5099 RVA: 0x0003CF20 File Offset: 0x0003B120
			internal void <.cctor>b__367_3(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(42186008, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013EC RID: 5100 RVA: 0x0003CF74 File Offset: 0x0003B174
			internal void <.cctor>b__367_4(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013ED RID: 5101 RVA: 0x0003CF94 File Offset: 0x0003B194
			internal void <.cctor>b__367_5(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013EE RID: 5102 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
			internal void <.cctor>b__367_6(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013EF RID: 5103 RVA: 0x0003D018 File Offset: 0x0003B218
			internal void <.cctor>b__367_7(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013F0 RID: 5104 RVA: 0x0003D048 File Offset: 0x0003B248
			internal void <.cctor>b__367_8(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013F1 RID: 5105 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
			internal void <.cctor>b__367_9(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013F2 RID: 5106 RVA: 0x0003D0BC File Offset: 0x0003B2BC
			internal void <.cctor>b__367_10(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013F3 RID: 5107 RVA: 0x0003D114 File Offset: 0x0003B314
			internal void <.cctor>b__367_11(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
				ThrowHelper.ThrowArgumentOutOfRangeException();
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013F4 RID: 5108 RVA: 0x0003D158 File Offset: 0x0003B358
			internal void <.cctor>b__367_12(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013F5 RID: 5109 RVA: 0x0003D174 File Offset: 0x0003B374
			internal void <.cctor>b__367_13(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013F6 RID: 5110 RVA: 0x0003D1D4 File Offset: 0x0003B3D4
			internal void <.cctor>b__367_14(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
				if (43159552 != 0)
				{
					return;
				}
			}

			// Token: 0x060013F7 RID: 5111 RVA: 0x0003D1FC File Offset: 0x0003B3FC
			internal void <.cctor>b__367_15(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060013F8 RID: 5112 RVA: 0x0003D254 File Offset: 0x0003B454
			internal void <.cctor>b__367_16(global::System.IOAsyncResult ares)
			{
				if (ares != null)
				{
				}
			}

			// Token: 0x060013F9 RID: 5113 RVA: 0x0003D270 File Offset: 0x0003B470
			internal void <.cctor>b__367_17(IAsyncResult ares)
			{
				if (ares != null)
				{
				}
				long num = 0L;
				int num2 = Interlocked.Exchange(int.MinValue, (int)num);
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x04000FD1 RID: 4049
			public static readonly Socket.<>c <>9;

			// Token: 0x04000FD2 RID: 4050
			public static Func<Socket.CachedEventArgs> <>9__14_0;

			// Token: 0x04000FD3 RID: 4051
			public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__14_1;

			// Token: 0x04000FD4 RID: 4052
			public static AsyncCallback <>9__15_0;

			// Token: 0x04000FD5 RID: 4053
			public static AsyncCallback <>9__15_1;

			// Token: 0x04000FD6 RID: 4054
			public static Func<Socket.CachedEventArgs> <>9__22_0;

			// Token: 0x04000FD7 RID: 4055
			public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__22_1;

			// Token: 0x04000FD8 RID: 4056
			public static AsyncCallback <>9__23_0;

			// Token: 0x04000FD9 RID: 4057
			public static AsyncCallback <>9__23_1;

			// Token: 0x04000FDA RID: 4058
			public static global::System.IOAsyncCallback <>9__295_0;

			// Token: 0x04000FDB RID: 4059
			public static global::System.IOAsyncCallback <>9__297_0;
		}

		// Token: 0x020002F3 RID: 755
		[CompilerGenerated]
		private sealed class <>c__DisplayClass240_0
		{
			// Token: 0x060013FA RID: 5114 RVA: 0x0003D2C8 File Offset: 0x0003B4C8
			public <>c__DisplayClass240_0()
			{
			}

			// Token: 0x060013FB RID: 5115 RVA: 0x0003D2DC File Offset: 0x0003B4DC
			internal void <BeginConnect>b__0(Task<IPAddress[]> t)
			{
				bool isFaulted = t.IsFaulted;
				SocketAsyncResult socketAsyncResult = this.sockares;
				Exception innerException = t.Exception._innerException;
				socketAsyncResult.DelayedException = innerException;
			}

			// Token: 0x04000FDC RID: 4060
			public SocketAsyncResult sockares;
		}

		// Token: 0x020002F4 RID: 756
		[CompilerGenerated]
		private sealed class <>c__DisplayClass298_0
		{
			// Token: 0x060013FC RID: 5116 RVA: 0x0003D324 File Offset: 0x0003B524
			public <>c__DisplayClass298_0()
			{
			}

			// Token: 0x060013FD RID: 5117 RVA: 0x0003D338 File Offset: 0x0003B538
			internal void <BeginSendCallback>b__0(global::System.IOAsyncResult s)
			{
				int num = this.sent_so_far;
				if (true)
				{
					if (s == null)
					{
						return;
					}
				}
				else if (s != null)
				{
				}
			}

			// Token: 0x04000FDD RID: 4061
			public int sent_so_far;
		}

		// Token: 0x020002F5 RID: 757
		[CompilerGenerated]
		private sealed class <>c__DisplayClass355_0
		{
			// Token: 0x060013FE RID: 5118 RVA: 0x0003D35C File Offset: 0x0003B55C
			public <>c__DisplayClass355_0()
			{
			}

			// Token: 0x060013FF RID: 5119 RVA: 0x0003D370 File Offset: 0x0003B570
			internal void <QueueIOSelectorJob>b__0(Task t)
			{
				bool cleanedUp = this.<>4__this.CleanedUp;
				this.job.MarkDisposed();
			}

			// Token: 0x04000FDE RID: 4062
			public Socket <>4__this;

			// Token: 0x04000FDF RID: 4063
			public global::System.IOSelectorJob job;

			// Token: 0x04000FE0 RID: 4064
			public IntPtr handle;
		}
	}
}
