using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x0200035B RID: 859
	[ComVisible(true)]
	[StructLayout(0)]
	public abstract class RealProxy
	{
		// Token: 0x06001C9A RID: 7322 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		protected RealProxy()
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
		protected RealProxy(Type classToProxy)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		internal RealProxy(Type classToProxy, ClientIdentity identity)
		{
			this._objectIdentity = identity;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0003E404 File Offset: 0x0003C604
		protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
		{
			this._targetDomainId = 1;
			base..ctor();
			bool isMarshalByRef = classToProxy.IsMarshalByRef;
			bool isInterface = classToProxy.IsInterface;
			this.class_to_proxy = classToProxy;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0003E434 File Offset: 0x0003C634
		private static Type InternalGetProxyType(object transparentProxy)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0003E448 File Offset: 0x0003C648
		public Type GetProxiedType()
		{
			if (this._objTP != null)
			{
				throw new NotSupportedException();
			}
			bool isInterface = this.class_to_proxy.IsInterface;
			Type type;
			return type;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0003E474 File Offset: 0x0003C674
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			RemotingServices.GetObjectData(this, info, context);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0003E48C File Offset: 0x0003C68C
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		internal Identity ObjectIdentity
		{
			get
			{
				return this._objectIdentity;
			}
			set
			{
				this._objectIdentity = value;
			}
		}

		// Token: 0x06001CA3 RID: 7331
		public abstract IMessage Invoke(IMessage msg);

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		internal static object PrivateInvoke(RealProxy rp, IMessage msg, [Out] Exception exc, [Out] object[] out_args)
		{
			if (rp != null)
			{
			}
			LogicalCallContext logicalCallContext = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
			rp._targetUri = logicalCallContext;
			long num = 0L;
			object stubData = rp._stubData;
			object stubData2 = rp._stubData;
			IMessage message;
			if (message != null && message == null)
			{
				throw new InvalidCastException();
			}
			Type type = rp.class_to_proxy;
			long num2;
			if (num != 0L)
			{
				num2 = 0L;
			}
			if (num2 == 0L)
			{
				if (rp == null)
				{
					throw new InvalidCastException();
				}
				IMessage message2;
				if (message2 != null)
				{
					if (message2 == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					if (message2 != null)
					{
						if (message2 == null)
						{
							throw new InvalidCastException();
						}
						if (num == 0L)
						{
							goto IL_0073;
						}
					}
					long num3 = 0L;
					if (num != 0L)
					{
						goto IL_0084;
					}
					IL_0073:
					object stubData3 = rp._stubData;
					long value = num3.m_value;
				}
			}
			IL_0084:
			LogicalCallContext logicalCallContext2 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
			CallType callType;
			if (callType != CallType.Sync)
			{
				object stubData4 = rp._stubData;
			}
			object[] array;
			return array;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0003E590 File Offset: 0x0003C790
		internal virtual object InternalGetTransparentProxy(string className)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		public virtual object GetTransparentProxy()
		{
			/*
An exception occurred when decompiling this method (06001CA6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Proxies.RealProxy::GetTransparentProxy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:Type(var_2_14, ldfld:Type(RealProxy::class_to_proxy, ldloc:RealProxy(this)))
	stfld:object(RealProxy::_objTP, ldloc:RealProxy(this), ldloc:RealProxy[exp:object](this))
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

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0003E5CC File Offset: 0x0003C7CC
		protected void AttachServer(MarshalByRefObject s)
		{
			this._server = s;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		internal void SetTargetDomain(int domainId)
		{
			this._targetDomainId = domainId;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0003E5F4 File Offset: 0x0003C7F4
		internal object GetAppDomainTarget()
		{
			/*
An exception occurred when decompiling this method (06001CA9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Remoting.Proxies.RealProxy::GetAppDomainTarget()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:string(var_1_24, ldfld:string(RealProxy::_targetUri, ldloc:RealProxy(this)))
	stloc:string(var_2_35, call:string(string::Concat, ldstr:string("Server for uri '"), ldloc:string(var_1_24), ldstr:string("' not found")))
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

		// Token: 0x06001CAA RID: 7338 RVA: 0x0003E638 File Offset: 0x0003C838
		private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			bool flag;
			bool value = flag.m_value;
			bool value2 = flag.m_value;
			bool value3 = flag.m_value;
			if (!flag || flag)
			{
				bool value4 = flag.m_value;
				while (!flag)
				{
				}
				if (value4)
				{
					if (!value4)
					{
					}
				}
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000E7E RID: 3710
		private Type class_to_proxy;

		// Token: 0x04000E7F RID: 3711
		internal Context _targetContext;

		// Token: 0x04000E80 RID: 3712
		internal MarshalByRefObject _server;

		// Token: 0x04000E81 RID: 3713
		private int _targetDomainId;

		// Token: 0x04000E82 RID: 3714
		internal string _targetUri;

		// Token: 0x04000E83 RID: 3715
		internal Identity _objectIdentity;

		// Token: 0x04000E84 RID: 3716
		private object _objTP;

		// Token: 0x04000E85 RID: 3717
		private object _stubData;
	}
}
