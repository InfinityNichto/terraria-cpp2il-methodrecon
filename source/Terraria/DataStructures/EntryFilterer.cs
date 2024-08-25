using System;
using System.Collections.Generic;

namespace Terraria.DataStructures
{
	// Token: 0x02000628 RID: 1576
	public class EntryFilterer<T, U> where T : new() where U : IEntryFilter<T>
	{
		// Token: 0x060035F7 RID: 13815 RVA: 0x00211F88 File Offset: 0x00210188
		public EntryFilterer()
		{
			this.AvailableFilters = this;
			this.ActiveFilters = this;
			this.AlwaysActiveFilters = this;
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00211FB0 File Offset: 0x002101B0
		public void AddFilters(List<U> filters)
		{
			List availableFilters = this.AvailableFilters;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00211FC4 File Offset: 0x002101C4
		public bool FitsFilter(T entry)
		{
			if (this._searchFilter != null)
			{
			}
			List alwaysActiveFilters = this.AlwaysActiveFilters;
			List alwaysActiveFilters2 = this.AlwaysActiveFilters;
			List alwaysActiveFilters3 = this.AlwaysActiveFilters;
			if (this.ActiveFilters != null)
			{
				List activeFilters = this.ActiveFilters;
				List activeFilters2 = this.ActiveFilters;
				List activeFilters3 = this.ActiveFilters;
				return;
			}
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00212018 File Offset: 0x00210218
		public void ToggleFilter(int filterIndex)
		{
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00212028 File Offset: 0x00210228
		public bool IsFilterActive(int filterIndex)
		{
			/*
An exception occurred when decompiling this method (060035FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.EntryFilterer`2::IsFilterActive(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:List`1(var_1_10, ldfld:class [mscorlib]System.Collections.Generic.List`1<!U>[exp:List`1](EntryFilterer`2::AvailableFilters, ldloc:EntryFilterer`2(this)))
	stloc:List`1(var_2_17, ldfld:class [mscorlib]System.Collections.Generic.List`1<!U>[exp:List`1](EntryFilterer`2::ActiveFilters, ldloc:EntryFilterer`2(this)))
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

		// Token: 0x060035FC RID: 13820 RVA: 0x00212050 File Offset: 0x00210250
		public void SetSearchFilterObject<Z>(Z searchFilter) where Z : ISearchFilter<T>, U
		{
			this._searchFilterFromConstructor = searchFilter;
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00212064 File Offset: 0x00210264
		public void SetSearchFilter(string searchFilter)
		{
			bool flag = string.IsNullOrWhiteSpace(searchFilter);
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0021208C File Offset: 0x0021028C
		public string GetDisplayName()
		{
			List activeFilters = this.ActiveFilters;
			string text;
			return text;
		}

		// Token: 0x040076C9 RID: 30409
		public List<U> AvailableFilters;

		// Token: 0x040076CA RID: 30410
		public List<U> ActiveFilters;

		// Token: 0x040076CB RID: 30411
		public List<U> AlwaysActiveFilters;

		// Token: 0x040076CC RID: 30412
		private ISearchFilter<T> _searchFilter;

		// Token: 0x040076CD RID: 30413
		private ISearchFilter<T> _searchFilterFromConstructor;
	}
}
