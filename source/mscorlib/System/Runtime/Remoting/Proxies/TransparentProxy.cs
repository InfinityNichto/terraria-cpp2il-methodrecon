using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Mono;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x0200035A RID: 858
	[StructLayout(0)]
	internal class TransparentProxy
	{
		// Token: 0x06001C93 RID: 7315 RVA: 0x0003E27C File Offset: 0x0003C47C
		internal RuntimeType GetProxyType()
		{
			RuntimeClassHandle runtimeClassHandle;
			if (Type.GetTypeFromHandle(runtimeClassHandle.GetTypeHandle()) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0003E29C File Offset: 0x0003C49C
		private bool IsContextBoundObject
		{
			get
			{
				return this.GetProxyType().IsContextful;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		private Context TargetContext
		{
			get
			{
				return this._rp._targetContext;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0003E2CC File Offset: 0x0003C4CC
		private bool InCurrentContext()
		{
			/*
An exception occurred when decompiling this method (06001C96)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Proxies.TransparentProxy::InCurrentContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, callgetter:bool(Type::get_IsContextful, call:RuntimeType[exp:Type](TransparentProxy::GetProxyType, ldloc:TransparentProxy(this))))
	stloc:RealProxy(var_1_12, ldfld:RealProxy(TransparentProxy::_rp, ldloc:TransparentProxy(this)))
	stloc:Context(var_3_1B, ldfld:Context(RealProxy::_targetContext, ldloc:RealProxy(var_1_12)))
	stloc:Context(var_4_21, callgetter:Context(Thread::get_CurrentContext))
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

		// Token: 0x06001C97 RID: 7319 RVA: 0x0003E300 File Offset: 0x0003C500
		internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
		{
			do
			{
				bool flag = this.InCurrentContext();
				MarshalByRefObject server = this._rp._server;
				RuntimeTypeHandle runtimeTypeHandle;
				Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle);
				FieldInfo fieldInfo;
				if ((typeFromHandle != null && typeFromHandle == null) || (fieldInfo != null && fieldInfo == null))
				{
					goto IL_003D;
				}
				RealProxy rp = this._rp;
			}
			while (this != null);
			object obj;
			return obj;
			IL_003D:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0003E350 File Offset: 0x0003C550
		internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg)
		{
			bool flag = this.InCurrentContext();
			MarshalByRefObject server = this._rp._server;
			FieldInfo fieldInfo;
			fieldInfo.SetValue(server, arg);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		public TransparentProxy()
		{
		}

		// Token: 0x04000E7B RID: 3707
		public RealProxy _rp;

		// Token: 0x04000E7C RID: 3708
		private RuntimeRemoteClassHandle _class;

		// Token: 0x04000E7D RID: 3709
		private bool _custom_type_info;
	}
}
