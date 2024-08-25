using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent
{
	// Token: 0x020007CF RID: 1999
	public class PlayerTitaniumStormBuffTextureContent : ARenderTargetContentByRequest
	{
		// Token: 0x060040B1 RID: 16561 RVA: 0x002439EC File Offset: 0x00241BEC
		public PlayerTitaniumStormBuffTextureContent()
		{
			if (!true)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00243A10 File Offset: 0x00241C10
		public EffectPass GetRenderEffect()
		{
			/*
An exception occurred when decompiling this method (060040B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.EffectPass Terraria.GameContent.PlayerTitaniumStormBuffTextureContent::GetRenderEffect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EffectPass(var_4_38, callgetter:EffectPass(EffectPassCollection::get_Item, ldfld:EffectPassCollection(EffectTechnique::<Passes>k__BackingField, ldfld:EffectTechnique(Effect::<CurrentTechnique>k__BackingField, callgetter:Effect(ShaderData::get_Shader, ldfld:MiscShaderData[exp:ShaderData](PlayerTitaniumStormBuffTextureContent::_shaderData, ldloc:PlayerTitaniumStormBuffTextureContent(this))))), ldstr:string("TitaniumStorm")))
	stloc:MiscShaderData(var_5_40, ldfld:MiscShaderData(PlayerTitaniumStormBuffTextureContent::_shaderData, ldloc:PlayerTitaniumStormBuffTextureContent(this)))
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

		// Token: 0x060040B3 RID: 16563 RVA: 0x00243A60 File Offset: 0x00241C60
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00243A70 File Offset: 0x00241C70
		public void UpdateSettingsForRendering(float gradientContributionFromOriginalTexture, float gradientScrollingSpeed, float flatGradientOffset, float gradientColorDominance)
		{
			MiscShaderData miscShaderData = this._shaderData.UseColor(gradientScrollingSpeed, gradientContributionFromOriginalTexture, gradientColorDominance);
			MiscShaderData miscShaderData2 = this._shaderData.UseOpacity(flatGradientOffset);
		}

		// Token: 0x04007E5E RID: 32350
		private EffectPass renderEffect;

		// Token: 0x04007E5F RID: 32351
		private MiscShaderData _shaderData;
	}
}
