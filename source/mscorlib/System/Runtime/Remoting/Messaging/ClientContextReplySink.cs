using System;
using System.Runtime.Remoting.Contexts;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A2 RID: 930
	internal class ClientContextReplySink : IMessageSink
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x00041458 File Offset: 0x0003F658
		public ClientContextReplySink(Context ctx, IMessageSink replySink)
		{
			this._replySink = replySink;
			this._context = ctx;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0004147C File Offset: 0x0003F67C
		public IMessage SyncProcessMessage(IMessage msg)
		{
			/*
An exception occurred when decompiling this method (06001DDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IMessage System.Runtime.Remoting.Messaging.ClientContextReplySink::SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_04, ldc.i4:int32(1))
	stloc:int32(var_1_06, ldc.i4:int32(1))
	call:void(Context::NotifyGlobalDynamicSinks, ldc.i4:bool(1), ldloc:IMessage(msg), ldloc:int32[exp:bool](var_0_04), ldloc:int32[exp:bool](var_1_06))
	stloc:Context(var_2_16, ldfld:Context(ClientContextReplySink::_context, ldloc:ClientContextReplySink(this)))
	stloc:int32(var_3_18, ldc.i4:int32(1))
	stloc:int32(var_4_1A, ldc.i4:int32(1))
	stloc:int64(var_5_1D, ldc.i4:int64(0))
	call:void(Context::NotifyDynamicSinks, ldloc:Context(var_2_16), ldloc:int64[exp:bool](var_5_1D), ldloc:IMessage(msg), ldloc:int32[exp:bool](var_3_18), ldloc:int32[exp:bool](var_4_1A))
	stloc:IMessageSink(var_6_31, ldfld:IMessageSink(ClientContextReplySink::_replySink, ldloc:ClientContextReplySink(this)))
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

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000207A File Offset: 0x0000027A
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000F17 RID: 3863
		private IMessageSink _replySink;

		// Token: 0x04000F18 RID: 3864
		private Context _context;
	}
}
