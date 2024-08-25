using System;
using System.Collections.Generic;

namespace Terraria.Utilities
{
	// Token: 0x02000509 RID: 1289
	public class WeightedRandom<T>
	{
		// Token: 0x06003127 RID: 12583 RVA: 0x001F7A38 File Offset: 0x001F5C38
		public WeightedRandom()
		{
			this.elements = 1;
			this.needsRefresh = true;
			base..ctor();
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x001F7A5C File Offset: 0x001F5C5C
		public WeightedRandom(int seed)
		{
			this.elements = 1;
			this.needsRefresh = true;
			base..ctor();
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x001F7A80 File Offset: 0x001F5C80
		public WeightedRandom(UnifiedRandom random)
		{
			this.elements = this;
			this.needsRefresh = true;
			base..ctor();
			this.random = random;
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x001F7AA8 File Offset: 0x001F5CA8
		public WeightedRandom(params Tuple<T, double>[] theElements)
		{
			this.elements = 1;
			this.needsRefresh = true;
			base..ctor();
			this.elements = theElements;
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x001F7AD0 File Offset: 0x001F5CD0
		public WeightedRandom(int seed, params Tuple<T, double>[] theElements)
		{
			this.elements = 1;
			this.needsRefresh = true;
			base..ctor();
			this.elements = theElements;
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x001F7AF8 File Offset: 0x001F5CF8
		public WeightedRandom(UnifiedRandom random, params Tuple<T, double>[] theElements)
		{
			this.elements = this;
			this.needsRefresh = true;
			base..ctor();
			this.random = random;
			this.elements = theElements;
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x001F7B28 File Offset: 0x001F5D28
		public void Add(T element, double weight = 1.0)
		{
			List list = this.elements;
			this.needsRefresh = true;
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x001F7B44 File Offset: 0x001F5D44
		public T Get()
		{
			if (this.needsRefresh)
			{
			}
			UnifiedRandom unifiedRandom = this.random;
			double num = unifiedRandom.NextDouble();
			List list = this.elements;
			if (false || 6 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x001F7B88 File Offset: 0x001F5D88
		public void CalculateTotalWeight()
		{
			List list = this.elements;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x001F7BB4 File Offset: 0x001F5DB4
		public void Clear()
		{
			List list = this.elements;
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x001F7BC8 File Offset: 0x001F5DC8
		public static implicit operator T(WeightedRandom<T> weightedRandom)
		{
			/*
An exception occurred when decompiling this method (06003131)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Terraria.Utilities.WeightedRandom`1::op_Implicit(Terraria.Utilities.WeightedRandom`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(WeightedRandom`1::needsRefresh, ldloc:class Terraria.Utilities.WeightedRandom`1<!T>[exp:WeightedRandom`1](weightedRandom)))
	stloc:bool(var_1_0D, ldfld:bool(WeightedRandom`1::needsRefresh, ldloc:class Terraria.Utilities.WeightedRandom`1<!T>[exp:WeightedRandom`1](weightedRandom)))
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

		// Token: 0x04003AF7 RID: 15095
		public readonly List<Tuple<T, double>> elements;

		// Token: 0x04003AF8 RID: 15096
		public readonly UnifiedRandom random;

		// Token: 0x04003AF9 RID: 15097
		public bool needsRefresh;

		// Token: 0x04003AFA RID: 15098
		private double _totalWeight;
	}
}
