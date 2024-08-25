using System;
using System.Collections;
using System.Reflection;

namespace System.Xml.Schema
{
	// Token: 0x020000C5 RID: 197
	[DefaultMember("Item")]
	internal class SymbolsDictionary
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00019E18 File Offset: 0x00018018
		public SymbolsDictionary()
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00019E34 File Offset: 0x00018034
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000813)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.SymbolsDictionary::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(SymbolsDictionary::last, ldloc:SymbolsDictionary(this)))
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00019E48 File Offset: 0x00018048
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00019E5C File Offset: 0x0001805C
		public bool IsUpaEnforced
		{
			get
			{
				return this.isUpaEnforced;
			}
			set
			{
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00019E6C File Offset: 0x0001806C
		public int AddName(XmlQualifiedName name, object particle)
		{
			if (this.names != null)
			{
				ArrayList arrayList = this.particles;
			}
			int num = this.last;
			Hashtable hashtable = this.names;
			ArrayList arrayList2 = this.particles;
			return this.last;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00019EAC File Offset: 0x000180AC
		public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal)
		{
			if (list.type == NamespaceList.ListType.Any)
			{
				this.particleLast = particle;
				return;
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00019F1C File Offset: 0x0001811C
		private void AddWildcard(string wildcard, object particle)
		{
			if (this.wildcards == null)
			{
			}
			if (particle != null)
			{
				ArrayList arrayList = this.particles;
				return;
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00019F60 File Offset: 0x00018160
		public ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			Hashtable hashtable = this.names;
			if (hashtable != null)
			{
			}
			Hashtable hashtable2 = this.names;
			long num = 0L;
			if (hashtable != null)
			{
			}
			if (num == 0L)
			{
				Hashtable hashtable3 = this.wildcards;
				if (hashtable3 != null)
				{
					if (hashtable3 != null)
					{
					}
					Hashtable hashtable4 = this.wildcards;
					long num2 = 0L;
					int num3 = 5;
					if (hashtable3 != null)
					{
					}
					if (num2 != 0L)
					{
						goto IL_0061;
					}
					if (num3 != 0)
					{
						goto IL_0055;
					}
				}
				NamespaceList.ListType type = list.type;
				int num4 = this.last;
				IL_0055:
				throw new InvalidCastException();
			}
			IL_0061:
			throw new OutOfMemoryException();
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00019FF8 File Offset: 0x000181F8
		public bool Exists(XmlQualifiedName name)
		{
			/*
An exception occurred when decompiling this method (0600081A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.SymbolsDictionary::Exists(System.Xml.XmlQualifiedName)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_06, ldfld:Hashtable(SymbolsDictionary::names, ldloc:SymbolsDictionary(this)))
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

		// Token: 0x0600081B RID: 2075 RVA: 0x0001A00C File Offset: 0x0001820C
		public object GetParticle(int symbol)
		{
			int num = this.last;
			return this.particleLast;
		}

		// Token: 0x0400041A RID: 1050
		private int last;

		// Token: 0x0400041B RID: 1051
		private Hashtable names;

		// Token: 0x0400041C RID: 1052
		private Hashtable wildcards;

		// Token: 0x0400041D RID: 1053
		private ArrayList particles;

		// Token: 0x0400041E RID: 1054
		private object particleLast;

		// Token: 0x0400041F RID: 1055
		private bool isUpaEnforced = true;
	}
}
