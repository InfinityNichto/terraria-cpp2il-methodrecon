using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Events;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009CE RID: 2510
	public class LanternSky : CustomSky
	{
		// Token: 0x06004A01 RID: 18945 RVA: 0x00264A60 File Offset: 0x00262C60
		public override void OnLoad()
		{
			if (!true)
			{
			}
			long num = 0L;
			this._texture = 1;
			this.GenerateLanterns(num != 0L);
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00264A80 File Offset: 0x00262C80
		private void GenerateLanterns(bool onlyMissing)
		{
			LanternSky.Lantern[] lanterns = this._lanterns;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00264AE8 File Offset: 0x00262CE8
		public void ResetLantern(int i)
		{
			float x = this._lanterns.Position.X;
			double num = this._random.NextDouble();
			Asset<Texture2D> texture = this._texture;
			LanternSky.Lantern[] lanterns = this._lanterns;
			LanternSky.Lantern[] lanterns2 = this._lanterns;
			UnifiedRandom random = this._random;
			int num2 = 3;
			int num3 = random.Next(num2);
			LanternSky.Lantern[] lanterns3 = this._lanterns;
			UnifiedRandom random2 = this._random;
			int num4 = 1200;
			int num5 = random2.Next(num4);
			LanternSky.Lantern[] lanterns4 = this._lanterns;
			float rotation = lanterns4.Rotation;
			lanterns4.FrameHeight = (int)rotation;
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00264B88 File Offset: 0x00262D88
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
			float opacity = this._opacity;
			bool lanternsUp = LanternNight.LanternsUp;
			int num = true.ToDirectionInt();
			Vector2 position = this._lanterns.Position;
			long num2 = 0L;
			LanternSky.Lantern[] lanterns = this._lanterns;
			LanternSky.Lantern[] lanterns2 = this._lanterns;
			long num3 = 0L;
			LanternSky.Lantern[] lanterns3 = this._lanterns;
			float x = lanterns3.Position.X;
			if (lanterns3 == null)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			int num6 = Math.Max((int)num4, (int)num3);
			LanternSky.Lantern[] lanterns4 = this._lanterns;
			int lanternsDrawing;
			if (this._leaving)
			{
				lanternsDrawing = this._lanternsDrawing;
				return;
			}
			this.ResetLantern((int)num2);
			LanternSky.Lantern[] lanterns5 = this._lanterns;
			UnifiedRandom random = this._random;
			if (lanternsDrawing == 0)
			{
			}
			long num7 = 0L;
			int num8 = random.Next((int)num7, (int)num5);
			LanternSky.Lantern[] lanterns6 = this._lanterns;
			int num9 = 1;
			this._active = num9 != 0;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00264C54 File Offset: 0x00262E54
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			long num;
			if (this._active)
			{
				Vector2 position = this._lanterns.Position;
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
			Vector2 position2 = this._lanterns.Position;
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00264D54 File Offset: 0x00262F54
		private void DrawLantern(SpriteBatch spriteBatch, LanternSky.Lantern lantern, Color opacity, Vector2 depthScale, Vector2 position, float alpha)
		{
			if (!true)
			{
			}
			Vector2 vector = alpha.ToRotationVector2();
			float opacity2 = this._opacity;
			Color color2;
			Color color = color2 * alpha * alpha * alpha;
			float rotation = lantern.Rotation;
			Texture2D texture = lantern._texture;
			Rectangle sourceRectangle = lantern.GetSourceRectangle();
			float rotation2 = lantern.Rotation;
			Vector2 vector2 = lantern.GetSourceRectangle().Size();
			Texture2D texture2 = lantern._texture;
			Rectangle sourceRectangle2 = lantern.GetSourceRectangle();
			float opacity3 = this._opacity;
			float rotation3 = lantern.Rotation;
			Vector2 vector3 = lantern.GetSourceRectangle().Size();
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00264E10 File Offset: 0x00263010
		public override void Activate(Vector2 position, params object[] args)
		{
			if (this._active)
			{
				this.GenerateLanterns(true);
				return;
			}
			long num = 0L;
			this.GenerateLanterns(num != 0L);
			this._active = true;
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00264E40 File Offset: 0x00263040
		public override void Deactivate(params object[] args)
		{
			this._leaving = true;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00264E54 File Offset: 0x00263054
		public override bool IsActive()
		{
			return this._active;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00264E68 File Offset: 0x00263068
		public override void Reset()
		{
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00264E78 File Offset: 0x00263078
		public LanternSky()
		{
		}

		// Token: 0x040084A3 RID: 33955
		private bool _active;

		// Token: 0x040084A4 RID: 33956
		private bool _leaving;

		// Token: 0x040084A5 RID: 33957
		private float _opacity;

		// Token: 0x040084A6 RID: 33958
		private Asset<Texture2D> _texture;

		// Token: 0x040084A7 RID: 33959
		private LanternSky.Lantern[] _lanterns;

		// Token: 0x040084A8 RID: 33960
		private UnifiedRandom _random;

		// Token: 0x040084A9 RID: 33961
		private int _lanternsDrawing;

		// Token: 0x040084AA RID: 33962
		private const float slowDown = 0.5f;

		// Token: 0x020009CF RID: 2511
		private struct Lantern
		{
			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06004A0C RID: 18956 RVA: 0x00264E90 File Offset: 0x00263090
			// (set) Token: 0x06004A0D RID: 18957 RVA: 0x00264EA4 File Offset: 0x002630A4
			public Texture2D Texture
			{
				get
				{
					return this._texture;
				}
				set
				{
					this._texture = value;
					int height = value.Height;
					this.FrameHeight = height;
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06004A0E RID: 18958 RVA: 0x00264EC8 File Offset: 0x002630C8
			public float FloatAdjustedSpeed
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004A0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Skies.LanternSky/Lantern::get_FloatAdjustedSpeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Lantern::TimeUntilFloat, ldloc:valuetype Terraria.GameContent.Skies.LanternSky/Lantern&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Lantern::TimeUntilFloatMax, ldloc:valuetype Terraria.GameContent.Skies.LanternSky/Lantern&(this)))
	stloc:float32(var_2_14, ldfld:float32(Lantern::Speed, ldloc:valuetype Terraria.GameContent.Skies.LanternSky/Lantern&(this)))
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

			// Token: 0x06004A0F RID: 18959 RVA: 0x00264EEC File Offset: 0x002630EC
			public Rectangle GetSourceRectangle()
			{
				/*
An exception occurred when decompiling this method (06004A0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Skies.LanternSky/Lantern::GetSourceRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Lantern::FrameHeight, ldloc:valuetype Terraria.GameContent.Skies.LanternSky/Lantern&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Lantern::Speed, ldloc:valuetype Terraria.GameContent.Skies.LanternSky/Lantern&(this)))
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

			// Token: 0x040084AB RID: 33963
			private const int MAX_FRAMES_X = 3;

			// Token: 0x040084AC RID: 33964
			public int Variant;

			// Token: 0x040084AD RID: 33965
			public int TimeUntilFloat;

			// Token: 0x040084AE RID: 33966
			public int TimeUntilFloatMax;

			// Token: 0x040084AF RID: 33967
			private Texture2D _texture;

			// Token: 0x040084B0 RID: 33968
			public Vector2 Position;

			// Token: 0x040084B1 RID: 33969
			public float Depth;

			// Token: 0x040084B2 RID: 33970
			public float Rotation;

			// Token: 0x040084B3 RID: 33971
			public int FrameHeight;

			// Token: 0x040084B4 RID: 33972
			public int FrameWidth;

			// Token: 0x040084B5 RID: 33973
			public float Speed;

			// Token: 0x040084B6 RID: 33974
			public bool Active;
		}
	}
}
