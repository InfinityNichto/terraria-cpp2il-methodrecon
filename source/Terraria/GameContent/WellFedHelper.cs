using System;

namespace Terraria.GameContent
{
	// Token: 0x0200080E RID: 2062
	public struct WellFedHelper
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00249010 File Offset: 0x00247210
		public int TimeLeft
		{
			get
			{
				/*
An exception occurred when decompiling this method (060041E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.WellFedHelper::get_TimeLeft()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WellFedHelper::_timeLeftRank1, ldloc:valuetype Terraria.GameContent.WellFedHelper&(this)))
	stloc:int32(var_1_0D, ldfld:int32(WellFedHelper::_timeLeftRank3, ldloc:valuetype Terraria.GameContent.WellFedHelper&(this)))
	stloc:int32(var_2_14, ldfld:int32(WellFedHelper::_timeLeftRank3, ldloc:valuetype Terraria.GameContent.WellFedHelper&(this)))
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x00249034 File Offset: 0x00247234
		public int Rank
		{
			get
			{
				int timeLeftRank = this._timeLeftRank3;
				return 3;
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00249050 File Offset: 0x00247250
		public void Eat(int foodRank, int foodBuffTime)
		{
			if (foodBuffTime == 0)
			{
				return;
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0024909C File Offset: 0x0024729C
		public void Update()
		{
			int timeLeftRank = this._timeLeftRank3;
			int timeLeftRank2 = this._timeLeftRank2;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x002490B8 File Offset: 0x002472B8
		public void Clear()
		{
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x002490C8 File Offset: 0x002472C8
		private void AddTimeTo(int foodTimeCounter, int timeLeftToAdd, int counterMaximumTime)
		{
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x002490D8 File Offset: 0x002472D8
		private void ReduceTimeLeft()
		{
			int timeLeftRank = this._timeLeftRank3;
			int timeLeftRank2 = this._timeLeftRank2;
		}

		// Token: 0x040080AE RID: 32942
		private const int MAXIMUM_TIME_LEFT_PER_COUNTER = 72000;

		// Token: 0x040080AF RID: 32943
		private int _timeLeftRank1;

		// Token: 0x040080B0 RID: 32944
		private int _timeLeftRank2;

		// Token: 0x040080B1 RID: 32945
		private int _timeLeftRank3;
	}
}
