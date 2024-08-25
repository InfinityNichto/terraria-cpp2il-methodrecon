using System;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C0 RID: 960
	internal class ServerObjectReplySink : IMessageSink
	{
		// Token: 0x06001EB2 RID: 7858 RVA: 0x000432B0 File Offset: 0x000414B0
		public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
		{
			this._replySink = replySink;
			this._identity = identity;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000432D4 File Offset: 0x000414D4
		public IMessage SyncProcessMessage(IMessage msg)
		{
			/*
An exception occurred when decompiling this method (06001EB3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IMessage System.Runtime.Remoting.Messaging.ServerObjectReplySink::SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ServerIdentity(var_0_06, ldfld:ServerIdentity(ServerObjectReplySink::_identity, ldloc:ServerObjectReplySink(this)))
	stloc:int32(var_1_08, ldc.i4:int32(1))
	stloc:int32(var_2_0A, ldc.i4:int32(1))
	stloc:int64(var_3_0C, ldc.i4:int64(0))
	call:void(Identity::NotifyServerDynamicSinks, ldloc:ServerIdentity[exp:Identity](var_0_06), ldloc:int64[exp:bool](var_3_0C), ldloc:IMessage(msg), ldloc:int32[exp:bool](var_1_08), ldloc:int32[exp:bool](var_2_0A))
	stloc:IMessageSink(var_4_1D, ldfld:IMessageSink(ServerObjectReplySink::_replySink, ldloc:ServerObjectReplySink(this)))
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

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0000207A File Offset: 0x0000027A
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000F6F RID: 3951
		private IMessageSink _replySink;

		// Token: 0x04000F70 RID: 3952
		private ServerIdentity _identity;
	}
}
