using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000857 RID: 2135
	public class LootSimulator
	{
		// Token: 0x0600435B RID: 17243 RVA: 0x0024DFCC File Offset: 0x0024C1CC
		public LootSimulator()
		{
			this.FillDesiredTestConditions();
			this.FillItemExclusions();
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0024DFF0 File Offset: 0x0024C1F0
		private void FillItemExclusions()
		{
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0024E000 File Offset: 0x0024C200
		private void FillDesiredTestConditions()
		{
			int num = 1;
			List<ISimulationConditionSetter> neededTestConditions = this._neededTestConditions;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x0024E024 File Offset: 0x0024C224
		public void Run()
		{
			string text2;
			string text3;
			string text = text2 + text3;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x0024E03C File Offset: 0x0024C23C
		private void SetCleanSlateWorldConditions()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.GameMode = 0;
			if (num == 0)
			{
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0024E060 File Offset: 0x0024C260
		private bool TryGettingLootFor(int npcNetId, int timesMultiplier, [Out] string outputText)
		{
			return false;
		}

		// Token: 0x04008168 RID: 33128
		private List<ISimulationConditionSetter> _neededTestConditions;

		// Token: 0x04008169 RID: 33129
		private int[] _excludedItemIds;

		// Token: 0x02000858 RID: 2136
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004361 RID: 17249 RVA: 0x0024E0EC File Offset: 0x0024C2EC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004362 RID: 17250 RVA: 0x0024E0FC File Offset: 0x0024C2FC
			public <>c()
			{
			}

			// Token: 0x06004363 RID: 17251 RVA: 0x000021DB File Offset: 0x000003DB
			internal <>f__AnonymousType2<int, bool> <FillItemExclusions>b__3_0(bool state, int index)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004364 RID: 17252 RVA: 0x0024E110 File Offset: 0x0024C310
			internal bool <FillItemExclusions>b__3_1(<>f__AnonymousType2<int, bool> tuple)
			{
				/*
An exception occurred when decompiling this method (06004364)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.LootSimulation.LootSimulator/<>c::<FillItemExclusions>b__3_1(<>f__AnonymousType2`2<System.Int32,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!1(var_0_06, ldfld:!'<state>j__TPar'[exp:!1]('<>f__AnonymousType2`2'::<state>i__Field, ldloc:class '<>f__AnonymousType2`2'<int32, bool>[exp:'<>f__AnonymousType2`2'](tuple)))
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

			// Token: 0x06004365 RID: 17253 RVA: 0x0024E124 File Offset: 0x0024C324
			internal int <FillItemExclusions>b__3_2(<>f__AnonymousType2<int, bool> tuple)
			{
				/*
An exception occurred when decompiling this method (06004365)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.LootSimulation.LootSimulator/<>c::<FillItemExclusions>b__3_2(<>f__AnonymousType2`2<System.Int32,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_06, ldfld:!'<index>j__TPar'[exp:!0]('<>f__AnonymousType2`2'::<index>i__Field, ldloc:class '<>f__AnonymousType2`2'<int32, bool>[exp:'<>f__AnonymousType2`2'](tuple)))
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

			// Token: 0x06004366 RID: 17254 RVA: 0x000021DB File Offset: 0x000003DB
			internal <>f__AnonymousType2<int, bool> <FillItemExclusions>b__3_3(bool state, int index)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004367 RID: 17255 RVA: 0x0024E138 File Offset: 0x0024C338
			internal bool <FillItemExclusions>b__3_4(<>f__AnonymousType2<int, bool> tuple)
			{
				/*
An exception occurred when decompiling this method (06004367)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.LootSimulation.LootSimulator/<>c::<FillItemExclusions>b__3_4(<>f__AnonymousType2`2<System.Int32,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!1(var_0_06, ldfld:!'<state>j__TPar'[exp:!1]('<>f__AnonymousType2`2'::<state>i__Field, ldloc:class '<>f__AnonymousType2`2'<int32, bool>[exp:'<>f__AnonymousType2`2'](tuple)))
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

			// Token: 0x06004368 RID: 17256 RVA: 0x0024E14C File Offset: 0x0024C34C
			internal int <FillItemExclusions>b__3_5(<>f__AnonymousType2<int, bool> tuple)
			{
				/*
An exception occurred when decompiling this method (06004368)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.LootSimulation.LootSimulator/<>c::<FillItemExclusions>b__3_5(<>f__AnonymousType2`2<System.Int32,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_06, ldfld:!'<index>j__TPar'[exp:!0]('<>f__AnonymousType2`2'::<index>i__Field, ldloc:class '<>f__AnonymousType2`2'<int32, bool>[exp:'<>f__AnonymousType2`2'](tuple)))
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

			// Token: 0x0400816A RID: 33130
			public static readonly LootSimulator.<>c <>9;

			// Token: 0x0400816B RID: 33131
			public static Func<bool, int, <>f__AnonymousType2<int, bool>> <>9__3_0;

			// Token: 0x0400816C RID: 33132
			public static Func<<>f__AnonymousType2<int, bool>, bool> <>9__3_1;

			// Token: 0x0400816D RID: 33133
			public static Func<<>f__AnonymousType2<int, bool>, int> <>9__3_2;

			// Token: 0x0400816E RID: 33134
			public static Func<bool, int, <>f__AnonymousType2<int, bool>> <>9__3_3;

			// Token: 0x0400816F RID: 33135
			public static Func<<>f__AnonymousType2<int, bool>, bool> <>9__3_4;

			// Token: 0x04008170 RID: 33136
			public static Func<<>f__AnonymousType2<int, bool>, int> <>9__3_5;
		}
	}
}
