using System;
using System.Collections.Generic;

namespace Terraria.DataStructures
{
	// Token: 0x02000629 RID: 1577
	public class EntrySorter<TEntryType, TStepType> : IComparer<TEntryType> where TEntryType : new() where TStepType : IEntrySortStep<TEntryType>
	{
		// Token: 0x060035FF RID: 13823 RVA: 0x002120A4 File Offset: 0x002102A4
		public void AddSortSteps(List<TStepType> sortSteps)
		{
			List steps = this.Steps;
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x002120B8 File Offset: 0x002102B8
		public int Compare(TEntryType x, TEntryType y)
		{
			/*
An exception occurred when decompiling this method (06003600)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.EntrySorter`2::Compare(TEntryType,TEntryType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:List`1(var_4_2D, ldfld:class [mscorlib]System.Collections.Generic.List`1<!TStepType>[exp:List`1](EntrySorter`2::Steps, ldloc:EntrySorter`2(this)))
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

		// Token: 0x06003601 RID: 13825 RVA: 0x002120F8 File Offset: 0x002102F8
		public void SetPrioritizedStepIndex(int index)
		{
			this._prioritizedStep = index;
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0021210C File Offset: 0x0021030C
		public string GetDisplayName()
		{
			int prioritizedStep = this._prioritizedStep;
			List steps = this.Steps;
			string text;
			return text;
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x00212128 File Offset: 0x00210328
		public EntrySorter()
		{
			this.Steps = this;
			base..ctor();
		}

		// Token: 0x040076CE RID: 30414
		public List<TStepType> Steps;

		// Token: 0x040076CF RID: 30415
		private int _prioritizedStep;
	}
}
