using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A51 RID: 2641
	public class MoonlordDeathDrama
	{
		// Token: 0x06004E01 RID: 19969 RVA: 0x00275688 File Offset: 0x00273888
		public static void Update()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x002756C8 File Offset: 0x002738C8
		public static void DrawPieces(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x00275720 File Offset: 0x00273920
		public static void DrawExplosions(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			int screenWidth2 = Main.screenWidth;
			int screenHeight2 = Main.screenHeight;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x00275778 File Offset: 0x00273978
		public static void DrawWhite(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x002757A8 File Offset: 0x002739A8
		public static void ThrowPieces(Vector2 MoonlordCoreCenter, int DramaSeed)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x0027580C File Offset: 0x00273A0C
		public static void AddExplosion(Vector2 spot)
		{
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00275820 File Offset: 0x00273A20
		public static void RequestLight(float light, Vector2 spot)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00275838 File Offset: 0x00273A38
		public MoonlordDeathDrama()
		{
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x0027584C File Offset: 0x00273A4C
		// Note: this type is marked as 'beforefieldinit'.
		static MoonlordDeathDrama()
		{
		}

		// Token: 0x040086C3 RID: 34499
		private static List<MoonlordDeathDrama.MoonlordPiece> _pieces;

		// Token: 0x040086C4 RID: 34500
		private static List<MoonlordDeathDrama.MoonlordExplosion> _explosions;

		// Token: 0x040086C5 RID: 34501
		private static List<Vector2> _lightSources;

		// Token: 0x040086C6 RID: 34502
		private static float whitening;

		// Token: 0x040086C7 RID: 34503
		private static float requestedLight;

		// Token: 0x02000A52 RID: 2642
		public class MoonlordPiece
		{
			// Token: 0x06004E0A RID: 19978 RVA: 0x0027585C File Offset: 0x00273A5C
			public MoonlordPiece(Texture2D pieceTexture, Vector2 textureOrigin, Vector2 centerPos, Vector2 velocity, float rot, float angularVelocity)
			{
				this._texture = pieceTexture;
			}

			// Token: 0x06004E0B RID: 19979 RVA: 0x00275878 File Offset: 0x00273A78
			public void Update()
			{
				float x = this._velocity.X;
				float y = this._velocity.Y;
				float rotation = this._rotation;
				float rotationVelocity = this._rotationVelocity;
				this._rotation = y;
				this._rotationVelocity = y;
				float x2 = this._position.X;
				float y2 = this._position.Y;
				this._position.X = y;
			}

			// Token: 0x06004E0C RID: 19980 RVA: 0x002758E4 File Offset: 0x00273AE4
			public void Draw(SpriteBatch sp)
			{
				Color light = this.GetLight();
				Texture2D texture = this._texture;
				float x = this._position.X;
				float y = this._position.Y;
				Vector2 screenPosition = Main.screenPosition;
				float y2 = this._origin.Y;
				float rotation = this._rotation;
				float x2 = this._origin.X;
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06004E0D RID: 19981 RVA: 0x00275948 File Offset: 0x00273B48
			public bool Dead
			{
				get
				{
					float y = this._position.Y;
					if (!true)
					{
					}
					float x = this._position.X;
					if (17392 == 0)
					{
					}
					return true;
				}
			}

			// Token: 0x06004E0E RID: 19982 RVA: 0x00275978 File Offset: 0x00273B78
			public bool InDrawRange(Rectangle playerScreen)
			{
				float x = this._position.X;
				float y = this._position.Y;
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x06004E0F RID: 19983 RVA: 0x002759A4 File Offset: 0x00273BA4
			public Color GetLight()
			{
				if (!true)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				float x = this._position.X;
				float y = this._position.Y;
				int value = num.m_value;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Color color;
				Vector3 vector = color.ToVector3();
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x040086C8 RID: 34504
			private Texture2D _texture;

			// Token: 0x040086C9 RID: 34505
			private Vector2 _position;

			// Token: 0x040086CA RID: 34506
			private Vector2 _velocity;

			// Token: 0x040086CB RID: 34507
			private Vector2 _origin;

			// Token: 0x040086CC RID: 34508
			private float _rotation;

			// Token: 0x040086CD RID: 34509
			private float _rotationVelocity;
		}

		// Token: 0x02000A53 RID: 2643
		public class MoonlordExplosion
		{
			// Token: 0x06004E10 RID: 19984 RVA: 0x002759F8 File Offset: 0x00273BF8
			public MoonlordExplosion(Texture2D pieceTexture, Vector2 centerPos, int frameSpeed)
			{
				this._texture = pieceTexture;
				if (!true)
				{
				}
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				Rectangle rectangle = pieceTexture.Frame(1, 7, (int)num, (int)num2, (int)num3, (int)num4);
				this._frame = rectangle;
				this._frame.Width = 1;
				Vector2 vector = rectangle.Size();
				if (!true)
				{
				}
			}

			// Token: 0x06004E11 RID: 19985 RVA: 0x00275A50 File Offset: 0x00273C50
			public void Update()
			{
				int frameCounter = this._frameCounter;
				Texture2D texture = this._texture;
				if (frameCounter == 0)
				{
				}
				int num = 1;
				Rectangle rectangle;
				this._frame = rectangle;
				this._frame.Width = num;
			}

			// Token: 0x06004E12 RID: 19986 RVA: 0x00275A84 File Offset: 0x00273C84
			public void Draw(SpriteBatch sp)
			{
				Texture2D texture = this._texture;
				float x = this._position.X;
				float y = this._position.Y;
				if (!true)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				if (!true)
				{
				}
				Rectangle frame = this._frame;
				int width = this._frame.Width;
				float x2 = this._origin.X;
				float y2 = this._origin.Y;
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06004E13 RID: 19987 RVA: 0x00275AF4 File Offset: 0x00273CF4
			public bool Dead
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004E13)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Events.MoonlordDeathDrama/MoonlordExplosion::get_Dead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:int32(var_3_2A, ldfld:int32(MoonlordExplosion::_frameCounter, ldloc:MoonlordExplosion(this)))
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

			// Token: 0x06004E14 RID: 19988 RVA: 0x00275B30 File Offset: 0x00273D30
			public bool InDrawRange(Rectangle playerScreen)
			{
				float x = this._position.X;
				float y = this._position.Y;
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x06004E15 RID: 19989 RVA: 0x00275B5C File Offset: 0x00273D5C
			public Color GetLight()
			{
				Color color;
				return color;
			}

			// Token: 0x040086CE RID: 34510
			private Texture2D _texture;

			// Token: 0x040086CF RID: 34511
			private Vector2 _position;

			// Token: 0x040086D0 RID: 34512
			private Vector2 _origin;

			// Token: 0x040086D1 RID: 34513
			private Rectangle _frame;

			// Token: 0x040086D2 RID: 34514
			private int _frameCounter;

			// Token: 0x040086D3 RID: 34515
			private int _frameSpeed;
		}
	}
}
