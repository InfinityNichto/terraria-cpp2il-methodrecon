using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AED RID: 2797
	public class MoonLordProgressBar : IBigProgressBar
	{
		// Token: 0x0600520F RID: 21007 RVA: 0x002823A0 File Offset: 0x002805A0
		public MoonLordProgressBar()
		{
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x002823B4 File Offset: 0x002805B4
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005210)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.MoonLordProgressBar::ValidateAndCollectNecessaryInfo(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0068:
	stfld:float32(BigProgressBarCache::LifeMax, ldfld:BigProgressBarCache[exp:valuetype Terraria.GameContent.UI.BigProgressBar.BigProgressBarCache&](MoonLordProgressBar::_cache, ldloc:MoonLordProgressBar(this)), ldloc:float32(var_9))
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

		// Token: 0x06005211 RID: 21009 RVA: 0x0028243C File Offset: 0x0028063C
		private bool IsInBadAI(NPC npc)
		{
			float[] ai = npc.ai;
			int type = npc.type;
			float[] localAI = npc.localAI;
			return true;
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00282460 File Offset: 0x00280660
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00282488 File Offset: 0x00280688
		private bool TryFindingAnotherMoonLordPiece(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005213)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.MoonLordProgressBar::TryFindingAnotherMoonLordPiece(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x04008A6B RID: 35435
		private BigProgressBarCache _cache;

		// Token: 0x04008A6C RID: 35436
		private NPC _referenceDummy;

		// Token: 0x04008A6D RID: 35437
		private HashSet<int> ValidIds;
	}
}
