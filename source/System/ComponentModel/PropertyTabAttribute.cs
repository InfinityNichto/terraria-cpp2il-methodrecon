using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200036D RID: 877
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		// Token: 0x060016DA RID: 5850 RVA: 0x00042594 File Offset: 0x00040794
		public PropertyTabAttribute()
		{
			if (!true)
			{
			}
			this.TabScopes = 1;
			if (!true)
			{
			}
			this._tabClassNames = 1;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000425BC File Offset: 0x000407BC
		public PropertyTabAttribute(Type tabClass)
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000425CC File Offset: 0x000407CC
		public PropertyTabAttribute(string tabClassName)
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x000425DC File Offset: 0x000407DC
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
			if (tabClass == null || tabClass != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000425FC File Offset: 0x000407FC
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
			if (tabClassName == null || tabClassName != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0004261C File Offset: 0x0004081C
		public Type[] TabClasses
		{
			get
			{
				/*
An exception occurred when decompiling this method (060016DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type[] System.ComponentModel.PropertyTabAttribute::get_TabClasses()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009B:
	stloc:string(var_20_A7, call:string(SR::Format, ldstr:string("Couldn't find type {0}"), ldloc:Assembly[exp:object](var_15)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000426D4 File Offset: 0x000408D4
		protected string[] TabClassNames
		{
			get
			{
				object obj;
				if (this._tabClassNames == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x000426F4 File Offset: 0x000408F4
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00042708 File Offset: 0x00040908
		public PropertyTabScope[] TabScopes
		{
			[CompilerGenerated]
			get
			{
				return this.<TabScopes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TabScopes>k__BackingField = value;
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0004271C File Offset: 0x0004091C
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00042730 File Offset: 0x00040930
		public bool Equals(PropertyTabAttribute other)
		{
			/*
An exception occurred when decompiling this method (060016E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.PropertyTabAttribute::Equals(System.ComponentModel.PropertyTabAttribute)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:valuetype System.ComponentModel.PropertyTabScope[](var_10_44, ldfld:valuetype System.ComponentModel.PropertyTabScope[](PropertyTabAttribute::<TabScopes>k__BackingField, ldloc:PropertyTabAttribute(this)))
	stloc:valuetype System.ComponentModel.PropertyTabScope[](var_11_4C, ldfld:valuetype System.ComponentModel.PropertyTabScope[](PropertyTabAttribute::<TabScopes>k__BackingField, ldloc:PropertyTabAttribute(other)))
	stloc:class [mscorlib]System.Type[](var_12_54, callgetter:class [mscorlib]System.Type[](PropertyTabAttribute::get_TabClasses, ldloc:PropertyTabAttribute(this)))
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

		// Token: 0x060016E5 RID: 5861 RVA: 0x00042798 File Offset: 0x00040998
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x000427AC File Offset: 0x000409AC
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000427BC File Offset: 0x000409BC
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000427CC File Offset: 0x000409CC
		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			object obj;
			if (tabClasses != null)
			{
				if (tabScopes != null)
				{
				}
				if (obj == null)
				{
					goto IL_0046;
				}
				if (obj != null)
				{
					this._tabClasses = obj;
					if (obj == null)
					{
						return;
					}
					goto IL_0046;
				}
			}
			else if (obj != null)
			{
				if (tabScopes != null)
				{
				}
				object obj2;
				if (obj2 == null)
				{
					goto IL_0046;
				}
				if (obj2 != null)
				{
					this._tabClassNames = obj2;
					if (obj2 != null)
					{
						goto IL_0046;
					}
				}
			}
			else
			{
				if (this._tabClasses == null && this._tabClassNames == null)
				{
					return;
				}
				goto IL_0046;
			}
			throw new InvalidCastException();
			IL_0046:
			if (tabScopes == null)
			{
				return;
			}
			object obj3;
			if (obj3 == null || obj3 != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x04001208 RID: 4616
		private Type[] _tabClasses;

		// Token: 0x04001209 RID: 4617
		private string[] _tabClassNames;

		// Token: 0x0400120A RID: 4618
		[CompilerGenerated]
		private PropertyTabScope[] <TabScopes>k__BackingField;
	}
}
