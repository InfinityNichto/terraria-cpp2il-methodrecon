using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AEA RID: 2794
	public class EaterOfWorldsProgressBar : IBigProgressBar
	{
		// Token: 0x06005204 RID: 20996 RVA: 0x0028217C File Offset: 0x0028037C
		public EaterOfWorldsProgressBar()
		{
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00282190 File Offset: 0x00280390
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			int eaterOfWorldsSegmentsCount = NPC.GetEaterOfWorldsSegmentsCount();
			NPC segmentForReference = this._segmentForReference;
			NPC segmentForReference2 = this._segmentForReference;
			int lifeMax = segmentForReference2.lifeMax;
			if (segmentForReference2 == null)
			{
			}
			if (segmentForReference2.active)
			{
				int type = segmentForReference2.type;
				int life = segmentForReference2.life;
				return;
			}
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x002821E8 File Offset: 0x002803E8
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00282210 File Offset: 0x00280410
		private bool TryFindingAnotherEOWPiece(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005207)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.EaterOfWorldsProgressBar::TryFindingAnotherEOWPiece(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
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

		// Token: 0x04008A64 RID: 35428
		private BigProgressBarCache _cache;

		// Token: 0x04008A65 RID: 35429
		private NPC _segmentForReference;
	}
}
