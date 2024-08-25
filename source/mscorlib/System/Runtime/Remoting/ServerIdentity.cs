using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;

namespace System.Runtime.Remoting
{
	// Token: 0x0200034B RID: 843
	internal abstract class ServerIdentity : Identity
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x0003D898 File Offset: 0x0003BA98
		public ServerIdentity(string objectUri, Context context, Type objectType)
		{
			this._objectUri = objectUri;
			this._objectType = objectType;
			this._context = context;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0003D8C0 File Offset: 0x0003BAC0
		public Type ObjectType
		{
			get
			{
				return this._objectType;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
		public void StartTrackingLifetime(ILease lease)
		{
			if (lease != null)
			{
				return;
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0003D8F8 File Offset: 0x0003BAF8
		public virtual void OnLifetimeExpired()
		{
			this.DisposeServerObject();
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0003D90C File Offset: 0x0003BB0C
		public override ObjRef CreateObjRef(Type requestedType)
		{
			ObjRef objRef = this._objRef;
			if (objRef != null)
			{
				objRef.UpdateChannelInfo();
				return objRef;
			}
			Type objectType = this._objectType;
			ObjRef objRef2 = this._objRef;
			string objectUri = this._objectUri;
			if (this._envoySink != null)
			{
				ObjRef objRef3 = this._objRef;
			}
			return this._objRef;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0003D958 File Offset: 0x0003BB58
		public void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
			/*
An exception occurred when decompiling this method (06001C4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.Remoting.ServerIdentity::AttachServerObject(System.MarshalByRefObject,System.Runtime.Remoting.Contexts.Context)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ServerIdentity::DisposeServerObject, ldloc:ServerIdentity(this))
	stfld:Context(ServerIdentity::_context, ldloc:ServerIdentity(this), ldloc:Context(context))
	stfld:MarshalByRefObject(ServerIdentity::_serverObject, ldloc:ServerIdentity(this), ldloc:MarshalByRefObject(serverObject))
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0003D978 File Offset: 0x0003BB78
		public Lease Lease
		{
			get
			{
				return this._lease;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0003D98C File Offset: 0x0003BB8C
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		public Context Context
		{
			get
			{
				return this._context;
			}
			set
			{
				this._context = value;
			}
		}

		// Token: 0x06001C52 RID: 7250
		public abstract IMessage SyncObjectProcessMessage(IMessage msg);

		// Token: 0x06001C53 RID: 7251
		public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

		// Token: 0x06001C54 RID: 7252 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		protected void DisposeServerObject()
		{
			MarshalByRefObject serverObject = this._serverObject;
			if (serverObject != null)
			{
				if (!true)
				{
				}
				TrackingServices.NotifyDisconnectedObject(serverObject);
				return;
			}
		}

		// Token: 0x04000E5D RID: 3677
		protected Type _objectType;

		// Token: 0x04000E5E RID: 3678
		protected MarshalByRefObject _serverObject;

		// Token: 0x04000E5F RID: 3679
		protected IMessageSink _serverSink;

		// Token: 0x04000E60 RID: 3680
		protected Context _context;

		// Token: 0x04000E61 RID: 3681
		protected Lease _lease;
	}
}
