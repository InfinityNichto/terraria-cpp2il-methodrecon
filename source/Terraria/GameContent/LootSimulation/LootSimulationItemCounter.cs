using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x0200085A RID: 2138
	public class LootSimulationItemCounter
	{
		// Token: 0x0600436D RID: 17261 RVA: 0x0024E1E0 File Offset: 0x0024C3E0
		public LootSimulationItemCounter()
		{
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0024E1F4 File Offset: 0x0024C3F4
		public void AddItem(int itemId, int amount, bool expert)
		{
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x0024E208 File Offset: 0x0024C408
		public void Exclude(params int[] itemIds)
		{
			long[] itemCountsObtained = this._itemCountsObtained;
			long[] itemCountsObtainedExpert = this._itemCountsObtainedExpert;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x0024E228 File Offset: 0x0024C428
		public void IncreaseTimesAttempted(int amount, bool expert)
		{
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x0024E238 File Offset: 0x0024C438
		public string PrintCollectedItems(bool expert)
		{
			long[] itemCountsObtained = this._itemCountsObtained;
			long totalTimesAttempted = this._totalTimesAttempted;
			long[] itemCountsObtainedExpert = this._itemCountsObtainedExpert;
			long totalTimesAttemptedExpert = this._totalTimesAttemptedExpert;
			this._totalTimesAttempted = totalTimesAttemptedExpert;
			if (totalTimesAttemptedExpert == 0L)
			{
			}
			if (this != null || totalTimesAttemptedExpert == 0L)
			{
			}
			return string.Join(",\n", itemCountsObtainedExpert);
		}

		// Token: 0x04008178 RID: 33144
		private long[] _itemCountsObtained;

		// Token: 0x04008179 RID: 33145
		private long[] _itemCountsObtainedExpert;

		// Token: 0x0400817A RID: 33146
		private long _totalTimesAttempted;

		// Token: 0x0400817B RID: 33147
		private long _totalTimesAttemptedExpert;

		// Token: 0x0200085B RID: 2139
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004372 RID: 17266 RVA: 0x0024E27C File Offset: 0x0024C47C
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004373 RID: 17267 RVA: 0x0024E290 File Offset: 0x0024C490
			internal string <PrintCollectedItems>b__3(int itemId)
			{
				if (!true)
				{
				}
				long[] array = this.collectionToUse;
				long num = this.totalDropsAttempted;
				string text;
				return text;
			}

			// Token: 0x0400817C RID: 33148
			public long[] collectionToUse;

			// Token: 0x0400817D RID: 33149
			public long totalDropsAttempted;
		}

		// Token: 0x0200085C RID: 2140
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004374 RID: 17268 RVA: 0x0024E2B0 File Offset: 0x0024C4B0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004375 RID: 17269 RVA: 0x0024E2C0 File Offset: 0x0024C4C0
			public <>c()
			{
			}

			// Token: 0x06004376 RID: 17270 RVA: 0x000021DB File Offset: 0x000003DB
			internal <>f__AnonymousType3<int, long> <PrintCollectedItems>b__8_0(long count, int itemId)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004377 RID: 17271 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <PrintCollectedItems>b__8_1(<>f__AnonymousType3<int, long> entry)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004378 RID: 17272 RVA: 0x0024E2D4 File Offset: 0x0024C4D4
			internal int <PrintCollectedItems>b__8_2(<>f__AnonymousType3<int, long> entry)
			{
				/*
An exception occurred when decompiling this method (06004378)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.LootSimulation.LootSimulationItemCounter/<>c::<PrintCollectedItems>b__8_2(<>f__AnonymousType3`2<System.Int32,System.Int64>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_06, ldfld:!'<itemId>j__TPar'[exp:!0]('<>f__AnonymousType3`2'::<itemId>i__Field, ldloc:class '<>f__AnonymousType3`2'<int32, int64>[exp:'<>f__AnonymousType3`2'](entry)))
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

			// Token: 0x0400817E RID: 33150
			public static readonly LootSimulationItemCounter.<>c <>9;

			// Token: 0x0400817F RID: 33151
			public static Func<long, int, <>f__AnonymousType3<int, long>> <>9__8_0;

			// Token: 0x04008180 RID: 33152
			public static Func<<>f__AnonymousType3<int, long>, bool> <>9__8_1;

			// Token: 0x04008181 RID: 33153
			public static Func<<>f__AnonymousType3<int, long>, int> <>9__8_2;
		}
	}
}
