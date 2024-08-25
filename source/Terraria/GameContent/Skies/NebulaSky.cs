using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009D7 RID: 2519
	public class NebulaSky : CustomSky
	{
		// Token: 0x06004A3B RID: 19003 RVA: 0x002654E8 File Offset: 0x002636E8
		public override void OnLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0026551C File Offset: 0x0026371C
		public override void Update(GameTime gameTime)
		{
			bool isActive = this._isActive;
			float fadeOpacity = this._fadeOpacity;
			if (true)
			{
				if (isActive)
				{
					return;
				}
			}
			else
			{
				while (isActive)
				{
				}
			}
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00265548 File Offset: 0x00263748
		public override Color OnTileColor(Color inColor)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			float fadeOpacity = this._fadeOpacity;
			return 1;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x00265568 File Offset: 0x00263768
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			float fadeOpacity = this._fadeOpacity;
			long num2 = 0L;
			Asset<Texture2D> bgTexture = this._bgTexture;
			Vector2 screenPosition = Main.screenPosition;
			int num3 = 32768;
			int num4 = Math.Max(0, (int)num2);
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			Vector2 screenPosition2 = Main.screenPosition;
			float fadeOpacity2 = this._fadeOpacity;
			float num5 = Math.Min(minDepth, maxDepth);
			float num6 = Math.Max(num5, num5);
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			Vector2 screenPosition3 = Main.screenPosition;
			Asset<Texture2D> planetTexture = this._planetTexture;
			float fadeOpacity3 = this._fadeOpacity;
			Color color2;
			Color color = color2 * num6;
			Asset<Texture2D> planetTexture2 = this._planetTexture;
			if (num3 == 0)
			{
			}
			int num7 = Utils.Width(planetTexture2);
			Asset<Texture2D> planetTexture3 = this._planetTexture;
			int num8 = Utils.Height(planetTexture3);
			NebulaSky.LightPillar[] pillars = this._pillars;
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00265764 File Offset: 0x00263964
		public override float GetCloudAlpha()
		{
			/*
An exception occurred when decompiling this method (06004A3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.NebulaSky::GetCloudAlpha()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(NebulaSky::_fadeOpacity, ldloc:NebulaSky(this)))
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

		// Token: 0x06004A40 RID: 19008 RVA: 0x00265778 File Offset: 0x00263978
		public override void Activate(Vector2 position, params object[] args)
		{
			int num = 4719;
			int num2 = 1;
			this._fadeOpacity = (float)num;
			this._isActive = num2 != 0;
			float num3 = this._random.NextFloat();
			NebulaSky.LightPillar[] pillars = this._pillars;
			float num4 = this._random.NextFloat();
			NebulaSky.LightPillar[] pillars2 = this._pillars;
			float num5 = this._random.NextFloat();
			NebulaSky.LightPillar[] pillars3 = this._pillars;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x002657E0 File Offset: 0x002639E0
		private int SortMethod(NebulaSky.LightPillar pillar1, NebulaSky.LightPillar pillar2)
		{
			int num;
			return num;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x002657F0 File Offset: 0x002639F0
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00265800 File Offset: 0x00263A00
		public override void Reset()
		{
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00265810 File Offset: 0x00263A10
		public override bool IsActive()
		{
			return !this._isActive || true;
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00265828 File Offset: 0x00263A28
		public NebulaSky()
		{
		}

		// Token: 0x040084D8 RID: 34008
		private NebulaSky.LightPillar[] _pillars;

		// Token: 0x040084D9 RID: 34009
		private UnifiedRandom _random;

		// Token: 0x040084DA RID: 34010
		private Asset<Texture2D> _planetTexture;

		// Token: 0x040084DB RID: 34011
		private Asset<Texture2D> _bgTexture;

		// Token: 0x040084DC RID: 34012
		private Asset<Texture2D> _beamTexture;

		// Token: 0x040084DD RID: 34013
		private Asset<Texture2D>[] _rockTextures;

		// Token: 0x040084DE RID: 34014
		private bool _isActive;

		// Token: 0x040084DF RID: 34015
		private float _fadeOpacity;

		// Token: 0x020009D8 RID: 2520
		private struct LightPillar
		{
			// Token: 0x040084E0 RID: 34016
			public Vector2 Position;

			// Token: 0x040084E1 RID: 34017
			public float Depth;
		}
	}
}
