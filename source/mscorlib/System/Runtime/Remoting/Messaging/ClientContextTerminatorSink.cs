using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A1 RID: 929
	internal class ClientContextTerminatorSink : IMessageSink
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x000412E4 File Offset: 0x0003F4E4
		public ClientContextTerminatorSink(Context ctx)
		{
			this._context = ctx;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00041300 File Offset: 0x0003F500
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (!true)
			{
			}
			int num = 1;
			int num2 = 1;
			long num3 = 0L;
			Context.NotifyGlobalDynamicSinks(num != 0, msg, num2 != 0, num3 != 0L);
			Context context = this._context;
			int num4 = 1;
			int num5 = 1;
			long num6 = 0L;
			context.NotifyDynamicSinks(num4 != 0, msg, num5 != 0, num6 != 0L);
			if (msg != null)
			{
				if (msg != null)
				{
					if (msg == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			else
			{
				IMessageSink channelSink = RemotingServices.GetMessageTargetIdentity(msg)._channelSink;
			}
			IMessage message;
			return message;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00041394 File Offset: 0x0003F594
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			/*
An exception occurred when decompiling this method (06001DDD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IMessageCtrl System.Runtime.Remoting.Messaging.ClientContextTerminatorSink::AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage,System.Runtime.Remoting.Messaging.IMessageSink)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0080:
	stloc:bool(var_14_85, callgetter:bool(Context::get_HasGlobalDynamicSinks))
	stloc:int32(var_15_88, ldc.i4:int32(1))
	stloc:int32(var_16_8B, ldc.i4:int32(1))
	call:void(Context::NotifyGlobalDynamicSinks, ldc.i4:bool(0), ldloc:IMessage(msg), ldloc:int32[exp:bool](var_15_88), ldloc:int32[exp:bool](var_16_8B))
	stloc:Context(var_17_9E, ldfld:Context(ClientContextTerminatorSink::_context, ldloc:ClientContextTerminatorSink(this)))
	stloc:int32(var_18_A1, ldc.i4:int32(1))
	stloc:int32(var_19_A4, ldc.i4:int32(1))
	stloc:int64(var_20_A7, ldc.i4:int64(0))
	call:void(Context::NotifyDynamicSinks, ldloc:Context(var_17_9E), ldloc:int64[exp:bool](var_20_A7), ldloc:IMessage(msg), ldloc:int32[exp:bool](var_18_A1), ldloc:int32[exp:bool](var_19_A4))
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

		// Token: 0x04000F16 RID: 3862
		private Context _context;
	}
}
