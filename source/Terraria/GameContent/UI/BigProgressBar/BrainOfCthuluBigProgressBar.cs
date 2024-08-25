using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AEB RID: 2795
	public class BrainOfCthuluBigProgressBar : IBigProgressBar
	{
		// Token: 0x06005208 RID: 21000 RVA: 0x00282230 File Offset: 0x00280430
		public BrainOfCthuluBigProgressBar()
		{
			this._creeperForReference = this;
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x0028224C File Offset: 0x0028044C
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (06005209)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.BrainOfCthuluBigProgressBar::ValidateAndCollectNecessaryInfo(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0054:
	stfld:float32(BigProgressBarCache::LifeCurrent, ldfld:BigProgressBarCache[exp:valuetype Terraria.GameContent.UI.BigProgressBar.BigProgressBarCache&](BrainOfCthuluBigProgressBar::_cache, ldloc:BrainOfCthuluBigProgressBar(this)), ldloc:int32[exp:float32](var_10))
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

		// Token: 0x0600520A RID: 21002 RVA: 0x002822C0 File Offset: 0x002804C0
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x04008A66 RID: 35430
		private BigProgressBarCache _cache;

		// Token: 0x04008A67 RID: 35431
		private NPC _creeperForReference;
	}
}
