using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003BD RID: 957
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[Serializable]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x000472E4 File Offset: 0x000454E4
		public ToolboxItemFilterAttribute(string filterString)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000472F4 File Offset: 0x000454F4
		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
		{
			if (filterString == null)
			{
			}
			this.FilterType = filterType;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x00047314 File Offset: 0x00045514
		public string FilterString
		{
			[CompilerGenerated]
			get
			{
				return this.<FilterString>k__BackingField;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00047328 File Offset: 0x00045528
		public ToolboxItemFilterType FilterType
		{
			[CompilerGenerated]
			get
			{
				return this.<FilterType>k__BackingField;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0004733C File Offset: 0x0004553C
		public override object TypeId
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600197B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.ComponentModel.ToolboxItemFilterAttribute::get_TypeId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_09, call:Type(object::GetType, ldloc:ToolboxItemFilterAttribute[exp:object](this)))
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

		// Token: 0x0600197C RID: 6524 RVA: 0x00047354 File Offset: 0x00045554
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				ToolboxItemFilterType toolboxItemFilterType = this.<FilterType>k__BackingField;
				string text = this.<FilterString>k__BackingField;
				bool flag;
				return flag;
			}
			return true;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00047378 File Offset: 0x00045578
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600197D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ComponentModel.ToolboxItemFilterAttribute::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(ToolboxItemFilterAttribute::<FilterString>k__BackingField, ldloc:ToolboxItemFilterAttribute(this)))
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

		// Token: 0x0600197E RID: 6526 RVA: 0x0004738C File Offset: 0x0004558C
		public override bool Match(object obj)
		{
			if (obj != null)
			{
			}
			string text = this.<FilterString>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000473A8 File Offset: 0x000455A8
		public override string ToString()
		{
			string text = this.<FilterString>k__BackingField;
			if (!true)
			{
			}
			ToolboxItemFilterType toolboxItemFilterType = this.<FilterType>k__BackingField;
			string text2;
			return text + "," + text2;
		}

		// Token: 0x040012CB RID: 4811
		private string _typeId;

		// Token: 0x040012CC RID: 4812
		[CompilerGenerated]
		private readonly string <FilterString>k__BackingField;

		// Token: 0x040012CD RID: 4813
		[CompilerGenerated]
		private readonly ToolboxItemFilterType <FilterType>k__BackingField;
	}
}
