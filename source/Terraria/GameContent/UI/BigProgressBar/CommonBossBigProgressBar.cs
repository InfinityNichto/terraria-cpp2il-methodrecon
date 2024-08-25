using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AE8 RID: 2792
	public class CommonBossBigProgressBar : IBigProgressBar
	{
		// Token: 0x060051FE RID: 20990 RVA: 0x002820CC File Offset: 0x002802CC
		public bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info)
		{
			/*
An exception occurred when decompiling this method (060051FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.CommonBossBigProgressBar::ValidateAndCollectNecessaryInfo(Terraria.GameContent.UI.BigProgressBar.BigProgressBarInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(CommonBossBigProgressBar::_headIndex, ldloc:CommonBossBigProgressBar(this), ldloc:int32(var_0))
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

		// Token: 0x060051FF RID: 20991 RVA: 0x002820E4 File Offset: 0x002802E4
		public void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			float lifeCurrent = this._cache.LifeCurrent;
			float lifeMax = this._cache.LifeMax;
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x0028210C File Offset: 0x0028030C
		public CommonBossBigProgressBar()
		{
		}

		// Token: 0x04008A60 RID: 35424
		private BigProgressBarCache _cache;

		// Token: 0x04008A61 RID: 35425
		private int _headIndex;
	}
}
