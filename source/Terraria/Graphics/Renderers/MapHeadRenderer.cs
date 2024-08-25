using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075E RID: 1886
	public class MapHeadRenderer : INeedRenderTargetContent
	{
		// Token: 0x06003E06 RID: 15878 RVA: 0x0023BA1C File Offset: 0x00239C1C
		public MapHeadRenderer()
		{
			bool wasPrepared = this._playerRenders._wasPrepared;
			PlayerHeadDrawRenderTargetContent[] playerRenders = this._playerRenders;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000021DB File Offset: 0x000003DB
		public void Reset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x0023BA50 File Offset: 0x00239C50
		private void RenderDrawData(Player drawPlayer)
		{
			if (!true)
			{
			}
			Effect pixelShader = Main.pixelShader;
			int size = this._drawData._size;
			int cHead = drawPlayer.cHead;
			int size2 = this._drawData._size;
			EffectTechnique <CurrentTechnique>k__BackingField = pixelShader.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x0023BAA8 File Offset: 0x00239CA8
		public bool IsReady
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003E0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Renderers.MapHeadRenderer::get_IsReady()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(MapHeadRenderer::_anyDirty, ldloc:MapHeadRenderer(this)))
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

		// Token: 0x06003E0B RID: 15883 RVA: 0x0023BABC File Offset: 0x00239CBC
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			if (this._anyDirty)
			{
				PlayerHeadDrawRenderTargetContent[] playerRenders = this._playerRenders;
				bool wasPrepared = playerRenders._wasPrepared;
				int height = playerRenders.height;
				PlayerHeadDrawRenderTargetContent[] playerRenders2 = this._playerRenders;
			}
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x000021DB File Offset: 0x000003DB
		private void CreateOutlines(float alpha, float scale, Color borderColor)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04007CC8 RID: 31944
		private bool _anyDirty;

		// Token: 0x04007CC9 RID: 31945
		private PlayerHeadDrawRenderTargetContent[] _playerRenders;

		// Token: 0x04007CCA RID: 31946
		private readonly List<DrawData> _drawData;
	}
}
