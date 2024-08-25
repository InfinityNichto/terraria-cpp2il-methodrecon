using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	// Token: 0x02000296 RID: 662
	[ComVisible(true)]
	[Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x060016DD RID: 5853 RVA: 0x00030264 File Offset: 0x0002E464
		internal NamedPermissionSet()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0003027C File Offset: 0x0002E47C
		public NamedPermissionSet(string name, PermissionState state)
		{
			if (!true)
			{
			}
			base..ctor();
			long num = 0L;
			PermissionState permissionState = CodeAccessPermission.CheckPermissionState(state, num != 0L);
			this.state = permissionState;
			this.Name = name;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000302AC File Offset: 0x0002E4AC
		public NamedPermissionSet(string name)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000302BC File Offset: 0x0002E4BC
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x000302D0 File Offset: 0x0002E4D0
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				/*
An exception occurred when decompiling this method (060016E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.NamedPermissionSet::set_Name(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:string(var_1_15, call:string(Locale::GetText, ldstr:string("invalid name")))
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

		// Token: 0x060016E2 RID: 5858 RVA: 0x000302F4 File Offset: 0x0002E4F4
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.ToXml();
			string text = this.name;
			if (text != null)
			{
				securityElement.AddAttribute("Name", text);
			}
			string text2 = this.description;
			if (text2 != null)
			{
				securityElement.AddAttribute("Description", text2);
			}
			return securityElement;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00030338 File Offset: 0x0002E538
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.name;
				return base.Equals(obj);
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00030358 File Offset: 0x0002E558
		[ComVisible(false)]
		public override int GetHashCode()
		{
			int hashCode = base.GetHashCode();
			if (this.name != null)
			{
			}
			return hashCode;
		}

		// Token: 0x04000B97 RID: 2967
		private string name;

		// Token: 0x04000B98 RID: 2968
		private string description;
	}
}
