using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	internal class PlayerEditorConnectionEvents
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00009428 File Offset: 0x00007628
		public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId)
		{
			List<PlayerEditorConnectionEvents.MessageTypeSubscribers> list = this.messageTypeSubscribers;
			bool flag = Enumerable.Any(list);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000021B3 File Offset: 0x000003B3
		public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00009490 File Offset: 0x00007690
		public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			List<PlayerEditorConnectionEvents.MessageTypeSubscribers> list = this.messageTypeSubscribers;
			PlayerEditorConnectionEvents.MessageTypeSubscribers messageTypeSubscribers;
			if (messageTypeSubscribers != null)
			{
				int subscriberCount = messageTypeSubscribers.subscriberCount;
				messageTypeSubscribers.subscriberCount = subscriberCount;
				PlayerEditorConnectionEvents.MessageEvent messageCallback = messageTypeSubscribers.messageCallback;
				int subscriberCount2 = messageTypeSubscribers.subscriberCount;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000094D0 File Offset: 0x000076D0
		public PlayerEditorConnectionEvents()
		{
		}

		// Token: 0x04000412 RID: 1042
		[SerializeField]
		public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;

		// Token: 0x04000413 RID: 1043
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;

		// Token: 0x04000414 RID: 1044
		[SerializeField]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

		// Token: 0x020000F4 RID: 244
		[Serializable]
		public class MessageEvent : UnityEvent<MessageEventArgs>
		{
			// Token: 0x06000529 RID: 1321 RVA: 0x000094E4 File Offset: 0x000076E4
			public MessageEvent()
			{
			}
		}

		// Token: 0x020000F5 RID: 245
		[Serializable]
		public class ConnectionChangeEvent : UnityEvent<int>
		{
			// Token: 0x0600052A RID: 1322 RVA: 0x000094F4 File Offset: 0x000076F4
			public ConnectionChangeEvent()
			{
			}
		}

		// Token: 0x020000F6 RID: 246
		[Serializable]
		public class MessageTypeSubscribers
		{
			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x00009504 File Offset: 0x00007704
			// (set) Token: 0x0600052C RID: 1324 RVA: 0x00009518 File Offset: 0x00007718
			public Guid MessageTypeId
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600052B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::get_MessageTypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(MessageTypeSubscribers::m_messageTypeId, ldloc:MessageTypeSubscribers(this)))
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
				set
				{
					string text;
					this.m_messageTypeId = text;
				}
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x0000952C File Offset: 0x0000772C
			public MessageTypeSubscribers()
			{
			}

			// Token: 0x04000415 RID: 1045
			[SerializeField]
			private string m_messageTypeId;

			// Token: 0x04000416 RID: 1046
			public int subscriberCount;

			// Token: 0x04000417 RID: 1047
			public PlayerEditorConnectionEvents.MessageEvent messageCallback;
		}

		// Token: 0x020000F7 RID: 247
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600052E RID: 1326 RVA: 0x00009540 File Offset: 0x00007740
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00009554 File Offset: 0x00007754
			internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				string messageTypeId = x.m_messageTypeId;
				Guid guid = this.messageId;
				byte d = this.messageId._d;
				bool flag;
				return flag;
			}

			// Token: 0x04000418 RID: 1048
			public Guid messageId;
		}

		// Token: 0x020000F8 RID: 248
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06000530 RID: 1328 RVA: 0x0000957C File Offset: 0x0000777C
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00009590 File Offset: 0x00007790
			internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				string messageTypeId = x.m_messageTypeId;
				Guid guid = this.messageId;
				byte d = this.messageId._d;
				bool flag;
				return flag;
			}

			// Token: 0x04000419 RID: 1049
			public Guid messageId;
		}

		// Token: 0x020000F9 RID: 249
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06000532 RID: 1330 RVA: 0x000095B8 File Offset: 0x000077B8
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x000095CC File Offset: 0x000077CC
			internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				string messageTypeId = x.m_messageTypeId;
				Guid guid = this.messageId;
				byte d = this.messageId._d;
				bool flag;
				return flag;
			}

			// Token: 0x0400041A RID: 1050
			public Guid messageId;
		}
	}
}
