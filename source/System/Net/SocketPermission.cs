using System;
using System.Collections;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x0600115E RID: 4446 RVA: 0x00036218 File Offset: 0x00034418
		public SocketPermission(PermissionState state)
		{
			this.m_noRestriction = true;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00036234 File Offset: 0x00034434
		public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
		{
			this.AddPermission(access, transport, hostName, portNumber);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00036254 File Offset: 0x00034454
		public IEnumerator AcceptList
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001160)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Net.SocketPermission::get_AcceptList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(SocketPermission::m_acceptList, ldloc:SocketPermission(this)))
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00036268 File Offset: 0x00034468
		public IEnumerator ConnectList
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001161)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Net.SocketPermission::get_ConnectList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(SocketPermission::m_connectList, ldloc:SocketPermission(this)))
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

		// Token: 0x06001162 RID: 4450 RVA: 0x0003627C File Offset: 0x0003447C
		public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
		{
			if (this.m_noRestriction)
			{
				return;
			}
			ArrayList acceptList = this.m_acceptList;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x000362A4 File Offset: 0x000344A4
		public override IPermission Copy()
		{
			do
			{
				bool noRestriction = this.m_noRestriction;
				if (this.m_connectList != null)
				{
				}
			}
			while (this.m_acceptList == null);
			throw new InvalidCastException();
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000362D0 File Offset: 0x000344D0
		public override IPermission Intersect(IPermission target)
		{
			/*
An exception occurred when decompiling this method (06001164)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.IPermission System.Net.SocketPermission::Intersect(System.Security.IPermission)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:ArrayList(var_3_15, ldfld:ArrayList(SocketPermission::m_connectList, ldloc:SocketPermission(this)))
	stloc:ArrayList(var_4_1C, ldfld:ArrayList(SocketPermission::m_acceptList, ldloc:SocketPermission(this)))
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

		// Token: 0x06001165 RID: 4453 RVA: 0x000362FC File Offset: 0x000344FC
		private bool IntersectEmpty(SocketPermission permission)
		{
			/*
An exception occurred when decompiling this method (06001165)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.SocketPermission::IntersectEmpty(System.Net.SocketPermission)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:ArrayList(var_1_18, ldfld:ArrayList(SocketPermission::m_acceptList, ldloc:SocketPermission(permission)))
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

		// Token: 0x06001166 RID: 4454 RVA: 0x00036324 File Offset: 0x00034524
		private void Intersect(ArrayList list1, ArrayList list2, ArrayList result)
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000363B4 File Offset: 0x000345B4
		public override bool IsSubsetOf(IPermission target)
		{
			if (target != null)
			{
				return true;
			}
			if (!this.m_noRestriction && this.m_connectList == null)
			{
				ArrayList acceptList = this.m_acceptList;
				if (this.m_noRestriction)
				{
				}
			}
			ArrayList connectList;
			if (this.m_acceptList == null)
			{
				connectList = this.m_connectList;
				while (connectList == null)
				{
				}
			}
			if (connectList == null)
			{
				while (connectList == null)
				{
				}
			}
			ArrayList connectList2 = this.m_connectList;
			ArrayList acceptList2 = this.m_acceptList;
			bool flag;
			return flag;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00036410 File Offset: 0x00034610
		private bool IsSubsetOf(ArrayList list1, ArrayList list2)
		{
			if (list1 != null)
			{
			}
			if (list2 != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0003647C File Offset: 0x0003467C
		public bool IsUnrestricted()
		{
			return this.m_noRestriction;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00036490 File Offset: 0x00034690
		public override SecurityElement ToXml()
		{
			if (this.m_noRestriction)
			{
				return "1";
			}
			ArrayList connectList = this.m_connectList;
			ArrayList connectList2 = this.m_connectList;
			ArrayList acceptList = this.m_acceptList;
			ArrayList acceptList2 = this.m_acceptList;
			return "1";
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000364D0 File Offset: 0x000346D0
		private void ToXml(SecurityElement root, string childName, IEnumerator enumerator)
		{
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000364E8 File Offset: 0x000346E8
		public override void FromXml(SecurityElement securityElement)
		{
			if (securityElement != null)
			{
				bool flag = securityElement.tag != "IPermission";
				string text = securityElement.Attribute("Unrestricted");
				if (text != null)
				{
					int num = 1;
					int num2 = string.Compare(text, "true", num != 0);
					this.m_noRestriction = "true" != null;
					if (num2 == 0)
					{
						return;
					}
				}
				ArrayList children = securityElement.children;
				return;
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00036590 File Offset: 0x00034790
		private void FromXml(ArrayList endpoints, NetworkAccess access)
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00036608 File Offset: 0x00034808
		public override IPermission Union(IPermission target)
		{
			if (target != null)
			{
				bool noRestriction = this.m_noRestriction;
				if (noRestriction || noRestriction)
				{
				}
			}
			ArrayList acceptList = this.m_acceptList;
			ArrayList connectList = this.m_connectList;
			throw new InvalidCastException();
		}

		// Token: 0x04000D7E RID: 3454
		private ArrayList m_acceptList;

		// Token: 0x04000D7F RID: 3455
		private ArrayList m_connectList;

		// Token: 0x04000D80 RID: 3456
		private bool m_noRestriction;

		// Token: 0x04000D81 RID: 3457
		public const int AllPorts = -1;
	}
}
