using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	// Token: 0x02000279 RID: 633
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x00036638 File Offset: 0x00034838
		public SocketPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0003664C File Offset: 0x0003484C
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00036660 File Offset: 0x00034860
		public string Access
		{
			get
			{
				return this.m_access;
			}
			set
			{
				while (this.m_access != null)
				{
				}
				this.m_access = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0003667C File Offset: 0x0003487C
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00036690 File Offset: 0x00034890
		public string Host
		{
			get
			{
				return this.m_host;
			}
			set
			{
				while (this.m_host != null)
				{
				}
				this.m_host = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x000366AC File Offset: 0x000348AC
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x000366C0 File Offset: 0x000348C0
		public string Port
		{
			get
			{
				return this.m_port;
			}
			set
			{
				while (this.m_port != null)
				{
				}
				this.m_port = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x000366DC File Offset: 0x000348DC
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x000366F0 File Offset: 0x000348F0
		public string Transport
		{
			get
			{
				return this.m_transport;
			}
			set
			{
				while (this.m_transport != null)
				{
				}
				this.m_transport = value;
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0003670C File Offset: 0x0003490C
		public override IPermission CreatePermission()
		{
			/*
An exception occurred when decompiling this method (06001178)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.IPermission System.Net.SocketPermissionAttribute::CreatePermission()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00EE:
	stloc:string(var_22_FB, call:string(Locale::GetText, ldstr:string("The parameter value for 'Access', '{1}, is invalid.")))
	stloc:string(var_23_107, call:string(Locale::GetText, ldstr:string("The parameter value for 'Port', '{1}, is invalid.")))
	stloc:int64(var_25_10D, ldc.i4:int64(0))
	stloc:string(var_26_120, call:string(string::Format, call:string(Locale::GetText, ldstr:string("The parameter value for 'Transport', '{1}, is invalid.")), ldloc:int64[exp:object](var_25_10D)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001179 RID: 4473 RVA: 0x00036840 File Offset: 0x00034A40
		internal void AlreadySet(string property)
		{
			/*
An exception occurred when decompiling this method (06001179)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.SocketPermissionAttribute::AlreadySet(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_10, call:string(string::Format, call:string(Locale::GetText, ldstr:string("The parameter '{0}' can be set only once.")), ldloc:string[exp:object](property)))
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

		// Token: 0x04000D82 RID: 3458
		private string m_access;

		// Token: 0x04000D83 RID: 3459
		private string m_host;

		// Token: 0x04000D84 RID: 3460
		private string m_port;

		// Token: 0x04000D85 RID: 3461
		private string m_transport;
	}
}
