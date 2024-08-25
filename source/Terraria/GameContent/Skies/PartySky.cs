using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009B2 RID: 2482
	public class PartySky : CustomSky
	{
		// Token: 0x06004973 RID: 18803 RVA: 0x002624EC File Offset: 0x002606EC
		public override void OnLoad()
		{
			if (!true)
			{
			}
			Asset<Texture2D>[] textures = this._textures;
			long num = 0L;
			this.GenerateBalloons(num != 0L);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x0026251C File Offset: 0x0026071C
		private void GenerateBalloons(bool onlyMissing)
		{
			PartySky.Balloon[] balloons = this._balloons;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00262584 File Offset: 0x00260784
		public void ResetBalloon(int i)
		{
			PartySky.Balloon[] balloons = this._balloons;
			float depth = balloons.Depth;
			double num = this._random.NextDouble();
			UnifiedRandom random = this._random;
			Asset<Texture2D>[] textures = this._textures;
			PartySky.Balloon[] balloons2 = this._balloons;
			int num2 = 2;
			int num3 = random.Next(num2);
			int frameWidth = balloons.FrameWidth;
			int num4 = 3;
			PartySky.Balloon[] balloons3 = this._balloons;
			int num5 = this._random.Next(num4);
			UnifiedRandom random2 = this._random;
			int num6 = 30;
			if (random2.Next(num6) == 0)
			{
				Asset<Texture2D>[] textures2 = this._textures;
				this._balloons.Active = textures2 != null;
			}
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00262620 File Offset: 0x00260820
		private bool IsNearParty()
		{
			/*
An exception occurred when decompiling this method (06004976)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Skies.PartySky::IsNearParty()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:int32(var_4_1C, ldfld:int32(SceneMetrics::<PartyMonolithCount>k__BackingField, callgetter:SceneMetrics(Main::get_SceneMetrics)))
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

		// Token: 0x06004977 RID: 18807 RVA: 0x00262650 File Offset: 0x00260850
		public override void Update(GameTime gameTime)
		{
			float opacity = this._opacity;
			int num = true.ToDirectionInt();
			float depth = this._balloons.Depth;
			long num2 = 0L;
			if (depth != null)
			{
				PartySky.Balloon[] balloons = this._balloons;
				if (this._leaving)
				{
					int balloonsDrawing = this._balloonsDrawing;
					this._balloonsDrawing = balloonsDrawing;
					return;
				}
				this.ResetBalloon((int)num2);
				PartySky.Balloon[] balloons2 = this._balloons;
				if (balloons == null)
				{
				}
				int num3 = 30;
				int num4 = this._random.Next(num3);
				PartySky.Balloon[] balloons3 = this._balloons;
				if (num4 == 0)
				{
					Asset<Texture2D>[] textures = this._textures;
				}
			}
			if (this._balloonsDrawing == 0)
			{
			}
			int num5 = 1;
			this._active = num5 != 0;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x002626EC File Offset: 0x002608EC
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			long num;
			if (this._active)
			{
				float depth = this._balloons.Depth;
				num = 0L;
			}
			if (num == 0L)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (num == 0L)
			{
			}
			bool gameMenu2 = Main.gameMenu;
			float opacity = this._opacity;
			float depth2 = this._balloons.Depth;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x002627E8 File Offset: 0x002609E8
		public override void Activate(Vector2 position, params object[] args)
		{
			if (this._active)
			{
				this.GenerateBalloons(true);
				return;
			}
			long num = 0L;
			this.GenerateBalloons(num != 0L);
			this._active = true;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00262818 File Offset: 0x00260A18
		public override void Deactivate(params object[] args)
		{
			this._leaving = true;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0026282C File Offset: 0x00260A2C
		public override bool IsActive()
		{
			return this._active;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00262840 File Offset: 0x00260A40
		public override void Reset()
		{
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00262850 File Offset: 0x00260A50
		public PartySky()
		{
		}

		// Token: 0x04008454 RID: 33876
		public static bool MultipleSkyWorkaroundFix;

		// Token: 0x04008455 RID: 33877
		private bool _active;

		// Token: 0x04008456 RID: 33878
		private bool _leaving;

		// Token: 0x04008457 RID: 33879
		private float _opacity;

		// Token: 0x04008458 RID: 33880
		private Asset<Texture2D>[] _textures;

		// Token: 0x04008459 RID: 33881
		private PartySky.Balloon[] _balloons;

		// Token: 0x0400845A RID: 33882
		private UnifiedRandom _random;

		// Token: 0x0400845B RID: 33883
		private int _balloonsDrawing;

		// Token: 0x020009B3 RID: 2483
		private struct Balloon
		{
			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x0600497E RID: 18814 RVA: 0x00262864 File Offset: 0x00260A64
			// (set) Token: 0x0600497F RID: 18815 RVA: 0x00262878 File Offset: 0x00260A78
			public Texture2D Texture
			{
				get
				{
					return this._texture;
				}
				set
				{
					this._texture = value;
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06004980 RID: 18816 RVA: 0x0026288C File Offset: 0x00260A8C
			// (set) Token: 0x06004981 RID: 18817 RVA: 0x002628A0 File Offset: 0x00260AA0
			public int Frame
			{
				get
				{
					return this._frameCounter;
				}
				set
				{
					int num = 3121;
					this._frameCounter = num;
				}
			}

			// Token: 0x06004982 RID: 18818 RVA: 0x002628BC File Offset: 0x00260ABC
			public Rectangle GetSourceRectangle()
			{
				/*
An exception occurred when decompiling this method (06004982)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Skies.PartySky/Balloon::GetSourceRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Balloon::FrameHeight, ldloc:valuetype Terraria.GameContent.Skies.PartySky/Balloon&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Balloon::Speed, ldloc:valuetype Terraria.GameContent.Skies.PartySky/Balloon&(this)))
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

			// Token: 0x0400845C RID: 33884
			private const int MAX_FRAMES_X = 3;

			// Token: 0x0400845D RID: 33885
			private const int MAX_FRAMES_Y = 3;

			// Token: 0x0400845E RID: 33886
			private const int FRAME_RATE = 14;

			// Token: 0x0400845F RID: 33887
			public int Variant;

			// Token: 0x04008460 RID: 33888
			private Texture2D _texture;

			// Token: 0x04008461 RID: 33889
			public Vector2 Position;

			// Token: 0x04008462 RID: 33890
			public float Depth;

			// Token: 0x04008463 RID: 33891
			public int FrameHeight;

			// Token: 0x04008464 RID: 33892
			public int FrameWidth;

			// Token: 0x04008465 RID: 33893
			public float Speed;

			// Token: 0x04008466 RID: 33894
			public bool Active;

			// Token: 0x04008467 RID: 33895
			private int _frameCounter;
		}
	}
}
