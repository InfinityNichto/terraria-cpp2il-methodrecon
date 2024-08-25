using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000377 RID: 887
	[Serializable]
	internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x0003FDA8 File Offset: 0x0003DFA8
		internal static void RegisterCrossAppDomainChannel()
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0003FDD8 File Offset: 0x0003DFD8
		public virtual string ChannelName
		{
			get
			{
				return "MONOCAD";
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0003FDEC File Offset: 0x0003DFEC
		public virtual int ChannelPriority
		{
			get
			{
				return 100;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0003FDFC File Offset: 0x0003DFFC
		public virtual object ChannelData
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Channels.CrossAppDomainChannel::get_ChannelData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, call:int32(Thread::GetDomainID))
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

		// Token: 0x06001D31 RID: 7473 RVA: 0x0003FE10 File Offset: 0x0003E010
		public virtual void StartListening(object data)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0003FE20 File Offset: 0x0003E020
		public virtual IMessageSink CreateMessageSink(string url, object data, [Out] string uri)
		{
			if (data != null)
			{
				string processId = RemotingConfiguration.ProcessId;
				bool flag = uri == processId;
			}
			if (url != null)
			{
				bool flag2 = url.StartsWith("MONOCAD");
				return;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0003FE54 File Offset: 0x0003E054
		public CrossAppDomainChannel()
		{
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0003FE68 File Offset: 0x0003E068
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainChannel()
		{
		}

		// Token: 0x04000EBE RID: 3774
		private static object s_lock;
	}
}
