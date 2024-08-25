using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009DE RID: 2526
	public class StardustSky : CustomSky
	{
		// Token: 0x06004A67 RID: 19047 RVA: 0x00266098 File Offset: 0x00264298
		public override void OnLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x002660CC File Offset: 0x002642CC
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

		// Token: 0x06004A69 RID: 19049 RVA: 0x002660F8 File Offset: 0x002642F8
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

		// Token: 0x06004A6A RID: 19050 RVA: 0x00266118 File Offset: 0x00264318
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
			float num6;
			float num5 = Math.Max(num6, num6);
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			Vector2 screenPosition3 = Main.screenPosition;
			Asset<Texture2D> planetTexture = this._planetTexture;
			float fadeOpacity3 = this._fadeOpacity;
			Color color2;
			Color color = color2 * num5;
			Asset<Texture2D> planetTexture2 = this._planetTexture;
			if (num3 == 0)
			{
			}
			int num7 = Utils.Width(planetTexture2);
			int num8 = Utils.Height(this._planetTexture);
			float alphaAmplitude = this._stars.AlphaAmplitude;
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00266308 File Offset: 0x00264508
		public override float GetCloudAlpha()
		{
			/*
An exception occurred when decompiling this method (06004A6B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.StardustSky::GetCloudAlpha()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(StardustSky::_fadeOpacity, ldloc:StardustSky(this)))
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

		// Token: 0x06004A6C RID: 19052 RVA: 0x0026631C File Offset: 0x0026451C
		public override void Activate(Vector2 position, params object[] args)
		{
			int num = 4719;
			int num2 = 1;
			this._fadeOpacity = (float)num;
			this._isActive = num2 != 0;
			long num3 = 0L;
			int num4 = 17224;
			StardustSky.Star[] stars = this._stars;
			if (num3 != 0L)
			{
				return;
			}
			StardustSky.Star[] stars2 = this._stars;
			UnifiedRandom random = this._random;
			if (num4 == 0)
			{
			}
			long num5 = 0L;
			float num6 = random.NextFloat();
			Asset<Texture2D>[] starTextures = this._starTextures;
			UnifiedRandom random2 = this._random;
			StardustSky.Star[] stars3 = this._stars;
			int num7 = random2.Next((int)num5);
			UnifiedRandom random3 = this._random;
			StardustSky.Star[] stars4 = this._stars;
			float num8 = random3.NextFloat();
			UnifiedRandom random4 = this._random;
			StardustSky.Star[] stars5 = this._stars;
			float num9 = random4.NextFloat();
			float num10 = this._random.NextFloat();
			StardustSky.Star[] stars6 = this._stars;
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x002663E8 File Offset: 0x002645E8
		private int SortMethod(StardustSky.Star meteor1, StardustSky.Star meteor2)
		{
			float depth = meteor1.Depth;
			int num;
			return num;
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00266400 File Offset: 0x00264600
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00266410 File Offset: 0x00264610
		public override void Reset()
		{
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00266420 File Offset: 0x00264620
		public override bool IsActive()
		{
			return !this._isActive || true;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00266438 File Offset: 0x00264638
		public StardustSky()
		{
		}

		// Token: 0x04008502 RID: 34050
		private UnifiedRandom _random;

		// Token: 0x04008503 RID: 34051
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04008504 RID: 34052
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04008505 RID: 34053
		private Asset<Texture2D>[] _starTextures;

		// Token: 0x04008506 RID: 34054
		private bool _isActive;

		// Token: 0x04008507 RID: 34055
		private StardustSky.Star[] _stars;

		// Token: 0x04008508 RID: 34056
		private float _fadeOpacity;

		// Token: 0x020009DF RID: 2527
		private struct Star
		{
			// Token: 0x04008509 RID: 34057
			public Vector2 Position;

			// Token: 0x0400850A RID: 34058
			public float Depth;

			// Token: 0x0400850B RID: 34059
			public int TextureIndex;

			// Token: 0x0400850C RID: 34060
			public float SinOffset;

			// Token: 0x0400850D RID: 34061
			public float AlphaFrequency;

			// Token: 0x0400850E RID: 34062
			public float AlphaAmplitude;
		}
	}
}
