using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000394 RID: 916
	[ComVisible(true)]
	[Serializable]
	public sealed class LogicalCallContext : ISerializable, ICloneable
	{
		// Token: 0x06001D8F RID: 7567 RVA: 0x00040798 File Offset: 0x0003E998
		internal LogicalCallContext()
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x000407AC File Offset: 0x0003E9AC
		internal LogicalCallContext(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator.Name.Equals("__RemotingData");
			object value = enumerator.Value;
			if (value != null)
			{
				this.m_RemotingData = value;
				return;
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00040884 File Offset: 0x0003EA84
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			int num;
			do
			{
				num = 1;
			}
			while (info == null);
			if (num == 0)
			{
			}
			CallContextRemotingData remotingData = this.m_RemotingData;
			if (remotingData != null)
			{
				info.AddValue("__RemotingData", remotingData);
			}
			CallContextSecurityData securityData = this.m_SecurityData;
			if (securityData != null)
			{
				info.AddValue("__SecurityData", securityData);
			}
			object hostContext = this.m_HostContext;
			if (hostContext != null)
			{
				info.AddValue("__HostContext", hostContext);
			}
			if (this.m_IsCorrelationMgr)
			{
				int num2 = 1;
				info.AddValue("__CorrelationMgrSlotPresent", num2 != 0);
			}
			if (this.m_Datastore != null)
			{
				Hashtable datastore = this.m_Datastore;
				return;
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00040914 File Offset: 0x0003EB14
		public object Clone()
		{
			CallContextRemotingData remotingData = this.m_RemotingData;
			if (remotingData != null)
			{
				object obj = remotingData.Clone();
				if (obj != null)
				{
					return obj;
				}
			}
			CallContextSecurityData securityData = this.m_SecurityData;
			if (securityData != null && securityData.Clone() != null)
			{
				throw new InvalidCastException();
			}
			if (this.m_HostContext != null)
			{
			}
			bool isCorrelationMgr = this.m_IsCorrelationMgr;
			Hashtable datastore = this.m_Datastore;
			Hashtable datastore2 = this.m_Datastore;
			if (this.m_IsCorrelationMgr)
			{
				if (datastore2 != null)
				{
				}
				if (datastore2 == null)
				{
					throw new InvalidCastException();
				}
				if (datastore2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (datastore2 != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000409A0 File Offset: 0x0003EBA0
		internal void Merge(LogicalCallContext lc)
		{
			if (lc != null && lc.m_Datastore != null)
			{
				Hashtable datastore = lc.Datastore;
				return;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x000409CC File Offset: 0x0003EBCC
		public bool HasInfo
		{
			get
			{
				CallContextRemotingData remotingData = this.m_RemotingData;
				if (remotingData == null || remotingData._logicalCallID == null)
				{
					CallContextSecurityData securityData = this.m_SecurityData;
					if ((securityData == null || securityData._principal == null) && this.m_HostContext == null)
					{
						if (true)
						{
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00040A0C File Offset: 0x0003EC0C
		private bool HasUserData
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D95)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Messaging.LogicalCallContext::get_HasUserData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:Hashtable[exp:bool](LogicalCallContext::m_Datastore, ldloc:LogicalCallContext(this))))
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00040A20 File Offset: 0x0003EC20
		private Hashtable Datastore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D96)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Hashtable System.Runtime.Remoting.Messaging.LogicalCallContext::get_Datastore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:Hashtable[exp:bool](LogicalCallContext::m_Datastore, ldloc:LogicalCallContext(this)))
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

		// Token: 0x06001D97 RID: 7575 RVA: 0x00040A34 File Offset: 0x0003EC34
		public object GetData(string name)
		{
			/*
An exception occurred when decompiling this method (06001D97)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Messaging.LogicalCallContext::GetData(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_06, callgetter:Hashtable(LogicalCallContext::get_Datastore, ldloc:LogicalCallContext(this)))
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

		// Token: 0x06001D98 RID: 7576 RVA: 0x00040A48 File Offset: 0x0003EC48
		public void SetData(string name, object data)
		{
			Hashtable datastore = this.Datastore;
			bool flag = name.Equals("System.Diagnostics.Trace.CorrelationManagerSlot");
			this.m_IsCorrelationMgr = true;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00040A70 File Offset: 0x0003EC70
		// Note: this type is marked as 'beforefieldinit'.
		static LogicalCallContext()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000EE2 RID: 3810
		private static Type s_callContextType;

		// Token: 0x04000EE3 RID: 3811
		private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

		// Token: 0x04000EE4 RID: 3812
		private Hashtable m_Datastore;

		// Token: 0x04000EE5 RID: 3813
		private CallContextRemotingData m_RemotingData;

		// Token: 0x04000EE6 RID: 3814
		private CallContextSecurityData m_SecurityData;

		// Token: 0x04000EE7 RID: 3815
		private object m_HostContext;

		// Token: 0x04000EE8 RID: 3816
		private bool m_IsCorrelationMgr;

		// Token: 0x04000EE9 RID: 3817
		private Header[] _sendHeaders;

		// Token: 0x04000EEA RID: 3818
		private Header[] _recvHeaders;

		// Token: 0x02000395 RID: 917
		internal struct Reader
		{
			// Token: 0x06001D9A RID: 7578 RVA: 0x00040A80 File Offset: 0x0003EC80
			public Reader(LogicalCallContext ctx)
			{
				this.m_ctx = ctx;
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0000207A File Offset: 0x0000027A
			public bool IsNull
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00040A94 File Offset: 0x0003EC94
			public bool HasInfo
			{
				get
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x00040AA4 File Offset: 0x0003ECA4
			public LogicalCallContext Clone()
			{
				object obj;
				if (obj != null)
				{
				}
				throw new InvalidCastException();
			}

			// Token: 0x06001D9E RID: 7582 RVA: 0x0000207A File Offset: 0x0000027A
			public object GetData(string name)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000EEB RID: 3819
			private LogicalCallContext m_ctx;
		}
	}
}
