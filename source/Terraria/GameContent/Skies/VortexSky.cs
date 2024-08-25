using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009E0 RID: 2528
	public class VortexSky : CustomSky
	{
		// Token: 0x06004A72 RID: 19058 RVA: 0x0026644C File Offset: 0x0026464C
		public override void OnLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00266460 File Offset: 0x00264660
		public override void Update(GameTime gameTime)
		{
			int num = 1;
			bool isActive = this._isActive;
			float fadeOpacity = this._fadeOpacity;
			if (num != 0)
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
			int ticksUntilNextBolt = this._ticksUntilNextBolt;
			VortexSky.Bolt[] bolts = this._bolts;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00266550 File Offset: 0x00264750
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

		// Token: 0x06004A75 RID: 19061 RVA: 0x00266570 File Offset: 0x00264770
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
			Vector2 screenPosition4 = Main.screenPosition;
			int num9 = 17530;
			float num10 = Math.Min(num5, num5);
			float num11 = Math.Max(num10, num5);
			Vector2 screenPosition5 = Main.screenPosition;
			int screenWidth4 = Main.screenWidth;
			int screenHeight4 = Main.screenHeight;
			VortexSky.Bolt[] bolts = this._bolts;
			if (num9 != 0)
			{
				if (this._bolts == null)
				{
				}
				Vector2 screenPosition6 = Main.screenPosition;
				VortexSky.Bolt[] bolts2 = this._bolts;
				int num12 = 56;
				if (num12 == 0)
				{
				}
				float fadeOpacity4 = this._fadeOpacity;
				Color color3 = color * num11;
				if (num12 == 0)
				{
				}
			}
			VortexSky.Bolt[] bolts3 = this._bolts;
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00266730 File Offset: 0x00264930
		public override float GetCloudAlpha()
		{
			/*
An exception occurred when decompiling this method (06004A76)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.VortexSky::GetCloudAlpha()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(VortexSky::_fadeOpacity, ldloc:VortexSky(this)))
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

		// Token: 0x06004A77 RID: 19063 RVA: 0x00266744 File Offset: 0x00264944
		public override void Activate(Vector2 position, params object[] args)
		{
			int num = 4719;
			int num2 = 1;
			this._fadeOpacity = (float)num;
			this._isActive = num2 != 0;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00266770 File Offset: 0x00264970
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00266780 File Offset: 0x00264980
		public override void Reset()
		{
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00266790 File Offset: 0x00264990
		public override bool IsActive()
		{
			return !this._isActive || true;
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x002667A8 File Offset: 0x002649A8
		public VortexSky()
		{
		}

		// Token: 0x0400850F RID: 34063
		private UnifiedRandom _random;

		// Token: 0x04008510 RID: 34064
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04008511 RID: 34065
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04008512 RID: 34066
		private Asset<Texture2D> _boltTexture;

		// Token: 0x04008513 RID: 34067
		private Asset<Texture2D> _flashTexture;

		// Token: 0x04008514 RID: 34068
		private bool _isActive;

		// Token: 0x04008515 RID: 34069
		private int _ticksUntilNextBolt;

		// Token: 0x04008516 RID: 34070
		private float _fadeOpacity;

		// Token: 0x04008517 RID: 34071
		private VortexSky.Bolt[] _bolts;

		// Token: 0x020009E1 RID: 2529
		private struct Bolt
		{
			// Token: 0x04008518 RID: 34072
			public Vector2 Position;

			// Token: 0x04008519 RID: 34073
			public float Depth;

			// Token: 0x0400851A RID: 34074
			public int Life;

			// Token: 0x0400851B RID: 34075
			public bool IsAlive;
		}
	}
}
