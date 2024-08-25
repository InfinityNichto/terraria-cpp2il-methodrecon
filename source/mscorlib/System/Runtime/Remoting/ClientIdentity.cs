using System;

namespace System.Runtime.Remoting
{
	// Token: 0x02000340 RID: 832
	internal class ClientIdentity : Identity
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x0003BE10 File Offset: 0x0003A010
		public ClientIdentity(string objectUri, ObjRef objRef)
		{
			this._objectUri = objectUri;
			this._objRef = objRef;
			ObjRef objRef2;
			if (objRef != null)
			{
				objRef2 = this._objRef;
				return;
			}
			objRef.typeInfo = objRef2;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0003BE44 File Offset: 0x0003A044
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0003BE64 File Offset: 0x0003A064
		public MarshalByRefObject ClientProxy
		{
			get
			{
				WeakReference proxyReference = this._proxyReference;
				if (proxyReference == null || proxyReference != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0003BE74 File Offset: 0x0003A074
		public override ObjRef CreateObjRef(Type requestedType)
		{
			return this._objRef;
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0003BE88 File Offset: 0x0003A088
		public string TargetUri
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001BD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Remoting.ClientIdentity::get_TargetUri()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ObjRef(var_0_06, ldfld:ObjRef(Identity::_objRef, ldloc:ClientIdentity[exp:Identity](this)))
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

		// Token: 0x04000E28 RID: 3624
		private WeakReference _proxyReference;
	}
}
