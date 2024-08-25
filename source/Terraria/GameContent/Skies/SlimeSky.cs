using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009DA RID: 2522
	public class SlimeSky : CustomSky
	{
		// Token: 0x06004A4E RID: 19022 RVA: 0x00265920 File Offset: 0x00263B20
		public override void OnLoad()
		{
			if (!true)
			{
			}
			string text2;
			string text = "Images/Misc/Sky_Slime_" + text2;
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x00265958 File Offset: 0x00263B58
		private void GenerateSlimes()
		{
			if (!true)
			{
			}
			this._slimes = -1073741824;
			int num = 1;
			Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			SlimeSky.Slime[] slimes = this._slimes;
			long num2 = 0L;
			int num3 = this._random.Next((int)num2, -1073741824);
			SlimeSky.Slime[] slimes2 = this._slimes;
			double num4 = this._random.NextDouble();
			SlimeSky.Slime[] slimes3 = this._slimes;
			int num5 = 2;
			int frameWidth = slimes3.FrameWidth;
			UnifiedRandom random = this._random;
			Asset<Texture2D>[] textures = this._textures;
			int num6 = random.Next(num5);
			bool active = slimes3.Active;
			int num7 = 60;
			if (this._random.Next(num7) != 0)
			{
				UnifiedRandom random2 = this._random;
				int num8 = 30;
				if (random2.Next(num8) == 0)
				{
					Asset<Texture2D>[] textures2 = this._textures;
					SlimeSky.Slime[] slimes4 = this._slimes;
					double num9 = this._random.NextDouble();
					return;
				}
			}
			else
			{
				Asset<Texture2D>[] textures3 = this._textures;
				SlimeSky.Slime[] slimes5 = this._slimes;
				double num10 = this._random.NextDouble();
				SlimeSky.Slime[] slimes6 = this._slimes;
			}
			SlimeSky.Slime[] slimes7 = this._slimes;
			slimes7._texture = num;
			int frameWidth2 = slimes7.FrameWidth;
			this._slimesRemaining = frameWidth2;
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00265A84 File Offset: 0x00263C84
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00265BA4 File Offset: 0x00263DA4
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			bool gameMenu = Main.gameMenu;
			int frameWidth = this._slimes.FrameWidth;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00265C8C File Offset: 0x00263E8C
		public override void Activate(Vector2 position, params object[] args)
		{
			this.GenerateSlimes();
			this._isActive = true;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00265CA8 File Offset: 0x00263EA8
		public override void Deactivate(params object[] args)
		{
			this._isLeaving = true;
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00265CBC File Offset: 0x00263EBC
		public override void Reset()
		{
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00265CCC File Offset: 0x00263ECC
		public override bool IsActive()
		{
			return this._isActive;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00265CE0 File Offset: 0x00263EE0
		public SlimeSky()
		{
		}

		// Token: 0x040084E6 RID: 34022
		private Asset<Texture2D>[] _textures;

		// Token: 0x040084E7 RID: 34023
		private SlimeSky.Slime[] _slimes;

		// Token: 0x040084E8 RID: 34024
		private UnifiedRandom _random;

		// Token: 0x040084E9 RID: 34025
		private int _slimesRemaining;

		// Token: 0x040084EA RID: 34026
		private bool _isActive;

		// Token: 0x040084EB RID: 34027
		private bool _isLeaving;

		// Token: 0x020009DB RID: 2523
		private struct Slime
		{
			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06004A57 RID: 19031 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06004A58 RID: 19032 RVA: 0x00265CF4 File Offset: 0x00263EF4
			public Texture2D Texture
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
					this._texture = value;
					int width = value.Width;
					this.FrameWidth = width;
					int height = value.Height;
					this.FrameHeight = height;
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06004A59 RID: 19033 RVA: 0x00265D24 File Offset: 0x00263F24
			// (set) Token: 0x06004A5A RID: 19034 RVA: 0x00265D38 File Offset: 0x00263F38
			public int Frame
			{
				get
				{
					return this._frame;
				}
				set
				{
					int num = 43691;
					this._frame = num;
				}
			}

			// Token: 0x06004A5B RID: 19035 RVA: 0x00265D54 File Offset: 0x00263F54
			public Rectangle GetSourceRectangle()
			{
				/*
An exception occurred when decompiling this method (06004A5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Skies.SlimeSky/Slime::GetSourceRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Slime::FrameHeight, ldloc:valuetype Terraria.GameContent.Skies.SlimeSky/Slime&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Slime::Speed, ldloc:valuetype Terraria.GameContent.Skies.SlimeSky/Slime&(this)))
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

			// Token: 0x040084EC RID: 34028
			private const int MAX_FRAMES = 4;

			// Token: 0x040084ED RID: 34029
			private const int FRAME_RATE = 6;

			// Token: 0x040084EE RID: 34030
			private Texture2D _texture;

			// Token: 0x040084EF RID: 34031
			public Vector2 Position;

			// Token: 0x040084F0 RID: 34032
			public float Depth;

			// Token: 0x040084F1 RID: 34033
			public int FrameHeight;

			// Token: 0x040084F2 RID: 34034
			public int FrameWidth;

			// Token: 0x040084F3 RID: 34035
			public float Speed;

			// Token: 0x040084F4 RID: 34036
			public bool Active;

			// Token: 0x040084F5 RID: 34037
			private int _frame;
		}
	}
}
