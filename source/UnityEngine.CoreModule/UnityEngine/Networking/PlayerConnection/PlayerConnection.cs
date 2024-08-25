using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class PlayerConnection : ScriptableObject
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000095F4 File Offset: 0x000077F4
		public static PlayerConnection instance
		{
			get
			{
				return PlayerConnection.CreateInstance();
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000021B3 File Offset: 0x000003B3
		public bool isConnected
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000960C File Offset: 0x0000780C
		private static PlayerConnection CreateInstance()
		{
			PlayerConnection playerConnection = ScriptableObject.CreateInstance<PlayerConnection>();
			playerConnection.hideFlags = HideFlags.HideAndDontSave;
			return playerConnection;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00009628 File Offset: 0x00007828
		public void OnEnable()
		{
			if (this.m_IsInitilized)
			{
				return;
			}
			int num = 1;
			this.m_IsInitilized = num != 0;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000021B3 File Offset: 0x000003B3
		private IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00009648 File Offset: 0x00007848
		public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers = this.m_PlayerEditorConnectionEvents.messageTypeSubscribers;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000966C File Offset: 0x0000786C
		public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			this.m_PlayerEditorConnectionEvents.UnregisterManagedCallback(messageId, callback);
			List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers = this.m_PlayerEditorConnectionEvents.messageTypeSubscribers;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00009694 File Offset: 0x00007894
		public void RegisterConnection(UnityAction<int> callback)
		{
			List<int> connectedPlayers = this.m_connectedPlayers;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000096C8 File Offset: 0x000078C8
		public void RegisterDisconnection(UnityAction<int> callback)
		{
			PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent = this.m_PlayerEditorConnectionEvents.disconnectionEvent;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000096E4 File Offset: 0x000078E4
		public void UnregisterConnection(UnityAction<int> callback)
		{
			PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent = this.m_PlayerEditorConnectionEvents.connectionEvent;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00009700 File Offset: 0x00007900
		public void UnregisterDisconnection(UnityAction<int> callback)
		{
			PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent = this.m_PlayerEditorConnectionEvents.disconnectionEvent;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000971C File Offset: 0x0000791C
		public void Send(Guid messageId, byte[] data)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000021B3 File Offset: 0x000003B3
		public bool TrySend(Guid messageId, byte[] data)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000972C File Offset: 0x0000792C
		public bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			/*
An exception occurred when decompiling this method (06000541)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Networking.PlayerConnection.PlayerConnection::BlockUntilRecvMsg(System.Guid,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:float64(var_4_22, callgetter:float64(TimeSpan::get_TotalMilliseconds, call:TimeSpan[exp:valuetype [mscorlib]System.TimeSpan&](DateTime::op_Subtraction, callgetter:DateTime(DateTime::get_Now), ldloc:DateTime(var_2_0C))))
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

		// Token: 0x06000542 RID: 1346 RVA: 0x0000975C File Offset: 0x0000795C
		public void DisconnectAll()
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000976C File Offset: 0x0000796C
		[RequiredByNativeCode]
		private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			if (size != 0UL)
			{
				return;
			}
			PlayerEditorConnectionEvents playerEditorConnectionEvents = PlayerConnection.instance.m_PlayerEditorConnectionEvents;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000021B3 File Offset: 0x000003B3
		[RequiredByNativeCode]
		private static void ConnectedCallbackInternal(int playerId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00009790 File Offset: 0x00007990
		[RequiredByNativeCode]
		private static void DisconnectedCallback(int playerId)
		{
			List<int> connectedPlayers = PlayerConnection.instance.m_connectedPlayers;
			PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent = PlayerConnection.instance.m_PlayerEditorConnectionEvents.disconnectionEvent;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000097B8 File Offset: 0x000079B8
		public PlayerConnection()
		{
		}

		// Token: 0x0400041B RID: 1051
		internal static IPlayerEditorConnectionNative connectionNative;

		// Token: 0x0400041C RID: 1052
		[SerializeField]
		private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;

		// Token: 0x0400041D RID: 1053
		[SerializeField]
		private List<int> m_connectedPlayers;

		// Token: 0x0400041E RID: 1054
		private bool m_IsInitilized;

		// Token: 0x0400041F RID: 1055
		private static PlayerConnection s_Instance;

		// Token: 0x020000FB RID: 251
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06000547 RID: 1351 RVA: 0x000097CC File Offset: 0x000079CC
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x000097E0 File Offset: 0x000079E0
			internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				string messageTypeId = x.m_messageTypeId;
				Guid guid = this.messageId;
				byte d = this.messageId._d;
				bool flag;
				return flag;
			}

			// Token: 0x04000420 RID: 1056
			public Guid messageId;
		}

		// Token: 0x020000FC RID: 252
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06000549 RID: 1353 RVA: 0x00009808 File Offset: 0x00007A08
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x0000981C File Offset: 0x00007A1C
			internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				string messageTypeId = x.m_messageTypeId;
				Guid guid = this.messageId;
				byte d = this.messageId._d;
				bool flag;
				return flag;
			}

			// Token: 0x04000421 RID: 1057
			public Guid messageId;
		}

		// Token: 0x020000FD RID: 253
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x0600054B RID: 1355 RVA: 0x00009844 File Offset: 0x00007A44
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x00009858 File Offset: 0x00007A58
			internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args)
			{
				this.msgReceived = true;
			}

			// Token: 0x04000422 RID: 1058
			public bool msgReceived;
		}
	}
}
