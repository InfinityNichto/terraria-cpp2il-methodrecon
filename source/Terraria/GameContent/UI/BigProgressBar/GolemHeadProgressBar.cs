using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AEC RID: 2796
	public class GolemHeadProgressBar : IBigProgressBar
	{
		// Token: 0x0600520B RID: 21003 RVA: 0x002822E8 File Offset: 0x002804E8
		public GolemHeadProgressBar()
		{
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x002822FC File Offset: 0x002804FC
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			bool flag = this.TryFindingAnotherGolemPiece(info);
			NPC referenceDummy = this._referenceDummy;
			int lifeMax = this._referenceDummy.lifeMax;
			NPC referenceDummy2 = this._referenceDummy;
			int lifeMax2 = referenceDummy2.lifeMax;
			if (referenceDummy2 == null)
			{
			}
			if (referenceDummy2 != null)
			{
				HashSet<int> validIds = this.ValidIds;
				return;
			}
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00282350 File Offset: 0x00280550
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00282378 File Offset: 0x00280578
		private bool TryFindingAnotherGolemPiece(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (0600520E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.GolemHeadProgressBar::TryFindingAnotherGolemPiece(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<int32>(var_2_0D, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<int32>(GolemHeadProgressBar::ValidIds, ldloc:GolemHeadProgressBar(this)))
	stfld:int32(BigProgressBarInfo::npcIndexToAimAt, ldloc:BigProgressBarInfo[exp:valuetype Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo&](info), ldloc:int32(var_0_01))
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

		// Token: 0x04008A68 RID: 35432
		private BigProgressBarCache _cache;

		// Token: 0x04008A69 RID: 35433
		private NPC _referenceDummy;

		// Token: 0x04008A6A RID: 35434
		private HashSet<int> ValidIds;
	}
}
