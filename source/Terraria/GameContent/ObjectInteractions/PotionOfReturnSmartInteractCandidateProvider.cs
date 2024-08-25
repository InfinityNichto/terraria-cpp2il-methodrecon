using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000850 RID: 2128
	public class PotionOfReturnSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x0600433A RID: 17210 RVA: 0x0024DC70 File Offset: 0x0024BE70
		public void ClearSelfAndPrepareForCheck()
		{
			if (!true)
			{
			}
			Main.SmartInteractPotionOfReturn = false;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x0024DC88 File Offset: 0x0024BE88
		public bool ProvideCandidate(SmartInteractScanSettings settings, [Out] ISmartInteractCandidate candidate)
		{
			float x = settings.mousevec.X;
			float y = settings.mousevec.Y;
			float x2 = settings.mousevec.X;
			float y2 = settings.mousevec.Y;
			int lx = settings.LX;
			int hx = settings.HX;
			int ly = settings.LY;
			int hy = settings.HY;
			this._candidate.<DistanceFromCursor>k__BackingField = y;
			return true;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0024DD00 File Offset: 0x0024BF00
		public PotionOfReturnSmartInteractCandidateProvider()
		{
		}

		// Token: 0x0400815E RID: 33118
		private PotionOfReturnSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x02000851 RID: 2129
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x0600433D RID: 17213 RVA: 0x0024DD14 File Offset: 0x0024BF14
			// (set) Token: 0x0600433E RID: 17214 RVA: 0x0024DD28 File Offset: 0x0024BF28
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (0600433D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ObjectInteractions.PotionOfReturnSmartInteractCandidateProvider/ReusableCandidate::get_DistanceFromCursor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ReusableCandidate::<DistanceFromCursor>k__BackingField, ldloc:ReusableCandidate(this)))
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
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600433F RID: 17215 RVA: 0x0024DD38 File Offset: 0x0024BF38
			public void WinCandidacy()
			{
				if (!true)
				{
				}
				Main.SmartInteractPotionOfReturn = true;
				Main.SmartInteractShowingGenuine = true;
			}

			// Token: 0x06004340 RID: 17216 RVA: 0x0024DD54 File Offset: 0x0024BF54
			public void Reuse(float distanceFromCursor)
			{
			}

			// Token: 0x06004341 RID: 17217 RVA: 0x0024DD64 File Offset: 0x0024BF64
			public ReusableCandidate()
			{
			}

			// Token: 0x0400815F RID: 33119
			[CompilerGenerated]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
