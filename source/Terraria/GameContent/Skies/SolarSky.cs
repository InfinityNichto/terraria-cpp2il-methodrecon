using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009DC RID: 2524
	public class SolarSky : CustomSky
	{
		// Token: 0x06004A5C RID: 19036 RVA: 0x00265D70 File Offset: 0x00263F70
		public override void OnLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00265D84 File Offset: 0x00263F84
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
			SolarSky.Meteor[] meteors = this._meteors;
			SolarSky.Meteor[] meteors2 = this._meteors;
			SolarSky.Meteor[] meteors3 = this._meteors;
			SolarSky.Meteor[] meteors4 = this._meteors;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00265DD4 File Offset: 0x00263FD4
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

		// Token: 0x06004A5F RID: 19039 RVA: 0x00265DF4 File Offset: 0x00263FF4
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
			long num2 = 0L;
			Vector2 screenPosition = Main.screenPosition;
			int num3 = 32768;
			int num4 = Math.Max(0, (int)num2);
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			Vector2 screenPosition2 = Main.screenPosition;
			float num5 = Math.Min(minDepth, maxDepth);
			float num6 = Math.Max(num5, num5);
			int screenWidth3 = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
			Vector2 screenPosition3 = Main.screenPosition;
			Color color2;
			Color color = color2 * num6;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00265F64 File Offset: 0x00264164
		public override float GetCloudAlpha()
		{
			/*
An exception occurred when decompiling this method (06004A60)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.SolarSky::GetCloudAlpha()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SolarSky::_fadeOpacity, ldloc:SolarSky(this)))
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

		// Token: 0x06004A61 RID: 19041 RVA: 0x00265F78 File Offset: 0x00264178
		public override void Activate(Vector2 position, params object[] args)
		{
			int num = 4719;
			int num2 = 1;
			this._fadeOpacity = (float)num;
			this._isActive = num2 != 0;
			UnifiedRandom random = this._random;
			if (num == 0)
			{
			}
			float num3 = random.NextFloat();
			UnifiedRandom random2 = this._random;
			SolarSky.Meteor[] meteors = this._meteors;
			float num4 = random2.NextFloat();
			int num5 = 3;
			int num6 = this._random.Next(num5);
			SolarSky.Meteor[] meteors2 = this._meteors;
			float num7 = this._random.NextFloat();
			UnifiedRandom random3 = this._random;
			SolarSky.Meteor[] meteors3 = this._meteors;
			int num8 = 12;
			int num9 = random3.Next(num8);
			SolarSky.Meteor[] meteors4 = this._meteors;
			float num10 = this._random.NextFloat();
			SolarSky.Meteor[] meteors5 = this._meteors;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00266034 File Offset: 0x00264234
		private int SortMethod(SolarSky.Meteor meteor1, SolarSky.Meteor meteor2)
		{
			float depth = meteor1.Depth;
			int num;
			return num;
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x0026604C File Offset: 0x0026424C
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0026605C File Offset: 0x0026425C
		public override void Reset()
		{
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0026606C File Offset: 0x0026426C
		public override bool IsActive()
		{
			return !this._isActive || true;
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00266084 File Offset: 0x00264284
		public SolarSky()
		{
		}

		// Token: 0x040084F6 RID: 34038
		private UnifiedRandom _random;

		// Token: 0x040084F7 RID: 34039
		private Asset<Texture2D> _planetTexture;

		// Token: 0x040084F8 RID: 34040
		private Asset<Texture2D> _bgTexture;

		// Token: 0x040084F9 RID: 34041
		private Asset<Texture2D> _meteorTexture;

		// Token: 0x040084FA RID: 34042
		private bool _isActive;

		// Token: 0x040084FB RID: 34043
		private SolarSky.Meteor[] _meteors;

		// Token: 0x040084FC RID: 34044
		private float _fadeOpacity;

		// Token: 0x020009DD RID: 2525
		private struct Meteor
		{
			// Token: 0x040084FD RID: 34045
			public Vector2 Position;

			// Token: 0x040084FE RID: 34046
			public float Depth;

			// Token: 0x040084FF RID: 34047
			public int FrameCounter;

			// Token: 0x04008500 RID: 34048
			public float Scale;

			// Token: 0x04008501 RID: 34049
			public float StartX;
		}
	}
}
