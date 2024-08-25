using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.IO;

namespace Terraria
{
	// Token: 0x0200046E RID: 1134
	public class WaterfallManager
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x001B5BF4 File Offset: 0x001B3DF4
		public WaterfallManager()
		{
			if (1000 == 0)
			{
			}
			Preferences configuration = Main.Configuration;
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x001B5C2C File Offset: 0x001B3E2C
		public void LoadContent()
		{
			if (!true)
			{
			}
			string text2;
			string text = "Images/Waterfall_" + text2;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x001B5C54 File Offset: 0x001B3E54
		public bool CheckForWaterfall(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002C0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WaterfallManager::CheckForWaterfall(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Terraria.WaterfallManager/WaterfallData[](var_0_06, ldfld:valuetype Terraria.WaterfallManager/WaterfallData[](WaterfallManager::waterfalls, ldloc:WaterfallManager(this)))
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

		// Token: 0x06002C0B RID: 11275 RVA: 0x001B5C70 File Offset: 0x001B3E70
		public void Reset()
		{
			this.findWaterfallCount = 30;
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x001B5C88 File Offset: 0x001B3E88
		public void FindWaterfalls(bool forced = false)
		{
			int num = this.findWaterfallCount;
			this.findWaterfallCount = num;
			if (num == 0)
			{
			}
			float gfxQuality = Main.gfxQuality;
			int num2 = 32640;
			float gfxQuality2 = Main.gfxQuality;
			int num3 = 32768;
			bool gameMenu = Main.gameMenu;
			if (num3 == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int num4 = 15744;
			int num5 = 32640;
			Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			Vector2 screenPosition3 = Main.screenPosition;
			Vector2 screenPosition4 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			if (num5 == 0)
			{
			}
			if (num5 != 0)
			{
				return;
			}
			if (num4 == 0)
			{
			}
			if (num5 != 0)
			{
				return;
			}
			if (num4 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool flag = WorldGen.SolidTile((short)num4, 0);
			if (!false)
			{
			}
			if (!false)
			{
			}
			if (num4 == 0)
			{
			}
			if (num5 == 0)
			{
			}
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x001B5D58 File Offset: 0x001B3F58
		public void UpdateFrame()
		{
			int num = this.wFallFrCounter;
			this.wFallFrCounter = num;
			int num2 = this.regularFrame;
			this.wFallFrCounter2 = num2;
			int num3 = this.wFallFrCounter2;
			this.wFallFrCounter2 = num3;
			int num4 = this.slowFrame;
			this.rainFrameCounter = num4;
			int num5 = this.rainFrameCounter;
			this.rainFrameCounter = num5;
			int num6 = this.rainFrameForeground;
			this.rainFrameForeground = num6;
			int num7 = this.rainFrameBackground;
			this.rainFrameBackground = num7;
			int num8 = this.snowFrameCounter;
			this.snowFrameCounter = num8;
			int num9 = this.snowFrameForeground;
			this.findWaterfallCount = num9;
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x001B5DF0 File Offset: 0x001B3FF0
		private void DrawWaterfall(SpriteBatch spriteBatch, int Style = 0, float Alpha = 1f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			float gfxQuality = Main.gfxQuality;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			int num2 = this.currentMax;
			WaterfallManager.WaterfallData[] array = this.waterfalls;
			if (num2 != 0 && num2 != 0)
			{
				bool drewLava = Main.drewLava;
				WaterfallManager.WaterfallData[] array2 = this.waterfalls;
				int num3 = this.waterfallDist;
				array2.x = screenHeight;
				if (screenHeight != 0)
				{
					int num4 = this.rainFrameForeground;
					int num5 = this.rainFrameBackground;
					int num6 = this.snowFrameForeground;
					return;
				}
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x001B61CC File Offset: 0x001B43CC
		private void DrawWaterfall(int waterfallType, int x, int y, float opacity, Vector2 position, Rectangle sourceRect, Color color, SpriteEffects effects)
		{
			if (!true)
			{
			}
			float y2 = position.Y;
			position.Y = y2;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x001B61F0 File Offset: 0x001B43F0
		private static void TrySparkling(int x, int y, int direction, Color aColor2)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 6;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x001B6220 File Offset: 0x001B4420
		public void Draw(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x001B638C File Offset: 0x001B458C
		// Note: this type is marked as 'beforefieldinit'.
		static WaterfallManager()
		{
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x001B639C File Offset: 0x001B459C
		[CompilerGenerated]
		private void <.ctor>b__21_0(Preferences preferences)
		{
			int num;
			this.maxWaterfallCount = num;
			this.waterfalls = int.MinValue;
		}

		// Token: 0x040037C1 RID: 14273
		private const int minWet = 160;

		// Token: 0x040037C2 RID: 14274
		private const int maxWaterfallCountDefault = 1000;

		// Token: 0x040037C3 RID: 14275
		private const int maxLength = 100;

		// Token: 0x040037C4 RID: 14276
		private const int maxTypes = 26;

		// Token: 0x040037C5 RID: 14277
		public int maxWaterfallCount = 1000;

		// Token: 0x040037C6 RID: 14278
		private int qualityMax;

		// Token: 0x040037C7 RID: 14279
		private int currentMax;

		// Token: 0x040037C8 RID: 14280
		private WaterfallManager.WaterfallData[] waterfalls;

		// Token: 0x040037C9 RID: 14281
		private static Asset<Texture2D>[] waterfallTexture;

		// Token: 0x040037CA RID: 14282
		private int wFallFrCounter;

		// Token: 0x040037CB RID: 14283
		private int regularFrame;

		// Token: 0x040037CC RID: 14284
		private int wFallFrCounter2;

		// Token: 0x040037CD RID: 14285
		private int slowFrame;

		// Token: 0x040037CE RID: 14286
		private int rainFrameCounter;

		// Token: 0x040037CF RID: 14287
		private int rainFrameForeground;

		// Token: 0x040037D0 RID: 14288
		private int rainFrameBackground;

		// Token: 0x040037D1 RID: 14289
		private int snowFrameCounter;

		// Token: 0x040037D2 RID: 14290
		private int snowFrameForeground;

		// Token: 0x040037D3 RID: 14291
		private int findWaterfallCount;

		// Token: 0x040037D4 RID: 14292
		private int waterfallDist = 100;

		// Token: 0x040037D5 RID: 14293
		private VertexColors shimmerWaterFallColours;

		// Token: 0x0200046F RID: 1135
		public struct WaterfallData
		{
			// Token: 0x040037D6 RID: 14294
			public int x;

			// Token: 0x040037D7 RID: 14295
			public int y;

			// Token: 0x040037D8 RID: 14296
			public int type;

			// Token: 0x040037D9 RID: 14297
			public int stopAtStep;
		}
	}
}
