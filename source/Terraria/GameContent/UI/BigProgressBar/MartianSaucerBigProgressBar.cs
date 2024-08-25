using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AF7 RID: 2807
	public class MartianSaucerBigProgressBar : IBigProgressBar
	{
		// Token: 0x06005236 RID: 21046 RVA: 0x002827D0 File Offset: 0x002809D0
		public MartianSaucerBigProgressBar()
		{
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x002827E4 File Offset: 0x002809E4
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			bool flag = this.TryFindingAnotherMartianSaucerPiece(info);
			bool expertMode = Main.expertMode;
			NPC referenceDummy = this._referenceDummy;
			int lifeMax = this._referenceDummy.lifeMax;
			int lifeMax2 = this._referenceDummy.lifeMax;
			NPC referenceDummy2 = this._referenceDummy;
			int lifeMax3 = referenceDummy2.lifeMax;
			if (lifeMax3 == 0)
			{
			}
			if (lifeMax3 != 0)
			{
				HashSet<int> validIdsToScanHp = this.ValidIdsToScanHp;
				if (lifeMax3 == 0)
				{
				}
				bool expertMode2 = Main.expertMode;
				return;
			}
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x0028285C File Offset: 0x00280A5C
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00282884 File Offset: 0x00280A84
		private bool TryFindingAnotherMartianSaucerPiece(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005239)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.MartianSaucerBigProgressBar::TryFindingAnotherMartianSaucerPiece(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<int32>(var_2_0D, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<int32>(MartianSaucerBigProgressBar::ValidIds, ldloc:MartianSaucerBigProgressBar(this)))
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

		// Token: 0x04008A79 RID: 35449
		private BigProgressBarCache _cache;

		// Token: 0x04008A7A RID: 35450
		private NPC _referenceDummy;

		// Token: 0x04008A7B RID: 35451
		private HashSet<int> ValidIds;

		// Token: 0x04008A7C RID: 35452
		private HashSet<int> ValidIdsToScanHp;
	}
}
