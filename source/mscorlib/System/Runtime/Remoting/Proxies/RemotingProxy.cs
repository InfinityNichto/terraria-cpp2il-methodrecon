using System;
using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x0200035C RID: 860
	internal class RemotingProxy : RealProxy, IRemotingTypeInfo
	{
		// Token: 0x06001CAB RID: 7339 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		internal RemotingProxy(Type type, ClientIdentity identity)
			: base(type, identity)
		{
			IMessageSink channelSink = identity._channelSink;
			this._sink = channelSink;
			string targetUri = identity.TargetUri;
			this._targetUri = targetUri;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
		internal RemotingProxy(Type type, string activationUrl, object[] activationAttributes)
			: base(type)
		{
			ConstructionCall constructionCall = ActivationServices.CreateConstructionCall(type, activationUrl, activationAttributes);
			this._ctorCall = constructionCall;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0003E6FC File Offset: 0x0003C8FC
		public override IMessage Invoke(IMessage request)
		{
			if (request != null)
			{
				return request;
			}
			Type type;
			if (type != null)
			{
				if (type == null)
				{
					string targetUri = this._targetUri;
				}
				Identity objectIdentity = this._objectIdentity;
			}
			Identity objectIdentity2 = this._objectIdentity;
			bool hasExitSinks = Thread.CurrentContext.HasExitSinks;
			IMessageSink sink;
			if (this._hasEnvoySink)
			{
				sink = this._sink;
				if (type != null)
				{
				}
				Identity objectIdentity3 = this._objectIdentity;
			}
			IMessageSink clientContextSinkChain = Thread.CurrentContext.GetClientContextSinkChain();
			CallType callType;
			while (callType == CallType.Sync)
			{
			}
			if (sink != null)
			{
				goto IL_0074;
			}
			goto IL_0074;
			IL_0074:;
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0003E780 File Offset: 0x0003C980
		internal void AttachIdentity(Identity identity)
		{
			this._objectIdentity = identity;
			if (identity == null || this != null)
			{
			}
			string objectUri = identity._objectUri;
			this._targetUri = objectUri;
			IMessageSink envoySink = this._objectIdentity._envoySink;
			int num;
			if (envoySink != null)
			{
				num = 1;
				this._sink = envoySink;
				this._hasEnvoySink = num != 0;
				return;
			}
			this._sink = num;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0003E7E0 File Offset: 0x0003C9E0
		internal IMessage ActivateRemoteObject(IMethodMessage request)
		{
			ConstructionCall ctorCall;
			for (;;)
			{
				ctorCall = this._ctorCall;
				if (ctorCall != null)
				{
					break;
				}
				if (request != null && request == null)
				{
					goto Block_2;
				}
			}
			ctorCall.CopyFrom(request);
			ConstructionCall ctorCall2 = this._ctorCall;
			IMessage message;
			return message;
			Block_2:
			throw new InvalidCastException();
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0003E814 File Offset: 0x0003CA14
		public string TypeName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001CB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.Proxies.RemotingProxy::get_TypeName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	brtrue(IL_0000, logicnot:bool(call:Type[exp:bool](RealProxy::GetProxiedType, ldloc:RemotingProxy[exp:RealProxy](this))))
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

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0003E830 File Offset: 0x0003CA30
		public bool CanCastTo(Type fromType, object o)
		{
			/*
An exception occurred when decompiling this method (06001CB1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Proxies.RemotingProxy::CanCastTo(System.Type,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	brtrue(IL_0027, logicnot:bool(ldloc:Type[exp:bool](fromType)))
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

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0003E868 File Offset: 0x0003CA68
		protected override void Finalize()
		{
			if (this._objectIdentity != null)
			{
			}
			base.Finalize();
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingProxy()
		{
			if (!true)
			{
			}
			Type type;
			MethodInfo method = type.GetMethod("GetType");
			Type type2;
			MethodInfo method2 = type2.GetMethod("GetHashCode");
		}

		// Token: 0x04000E86 RID: 3718
		private static MethodInfo _cache_GetTypeMethod;

		// Token: 0x04000E87 RID: 3719
		private static MethodInfo _cache_GetHashCodeMethod;

		// Token: 0x04000E88 RID: 3720
		private IMessageSink _sink;

		// Token: 0x04000E89 RID: 3721
		private bool _hasEnvoySink;

		// Token: 0x04000E8A RID: 3722
		private ConstructionCall _ctorCall;
	}
}
