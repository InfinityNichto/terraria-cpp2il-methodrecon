using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AF6 RID: 2806
	public class PirateShipBigProgressBar : IBigProgressBar
	{
		// Token: 0x06005232 RID: 21042 RVA: 0x00282738 File Offset: 0x00280938
		public PirateShipBigProgressBar()
		{
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x0028274C File Offset: 0x0028094C
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005233)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.PirateShipBigProgressBar::ValidateAndCollectNecessaryInfo(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(PirateShipBigProgressBar::TryFindingAnotherPirateShipPiece, ldloc:PirateShipBigProgressBar(this), ldloc:BigProgressBarInfo(info)))
	stloc:NPC(var_1_0E, ldfld:NPC(PirateShipBigProgressBar::_referenceDummy, ldloc:PirateShipBigProgressBar(this)))
	stloc:NPC(var_3_15, ldfld:NPC(PirateShipBigProgressBar::_referenceDummy, ldloc:PirateShipBigProgressBar(this)))
	stloc:int32(var_5_20, ldfld:int32(NPC::lifeMax, ldloc:NPC(var_3_15)))
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

		// Token: 0x06005234 RID: 21044 RVA: 0x00282780 File Offset: 0x00280980
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x002827A8 File Offset: 0x002809A8
		private bool TryFindingAnotherPirateShipPiece(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005235)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.PirateShipBigProgressBar::TryFindingAnotherPirateShipPiece(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<int32>(var_2_0D, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<int32>(PirateShipBigProgressBar::ValidIds, ldloc:PirateShipBigProgressBar(this)))
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

		// Token: 0x04008A76 RID: 35446
		private BigProgressBarCache _cache;

		// Token: 0x04008A77 RID: 35447
		private NPC _referenceDummy;

		// Token: 0x04008A78 RID: 35448
		private HashSet<int> ValidIds;
	}
}
