using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.ID
{
	// Token: 0x020005BC RID: 1468
	public static class Colors
	{
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x0020AB6C File Offset: 0x00208D6C
		public static Color CurrentLiquidColor
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600350E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.ID.Colors::get_CurrentLiquidColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:float32[](var_5_21, callgetter:float32[](Main::get_liquidAlpha))
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

		// Token: 0x0600350F RID: 13583 RVA: 0x0020AB9C File Offset: 0x00208D9C
		public static Color AlphaDarken(Color input)
		{
			if (!true)
			{
			}
			return 17279;
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x0020ABB4 File Offset: 0x00208DB4
		public static Color GetSelectionGlowColor(bool isTileSelected, int averageTileLighting)
		{
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x0020ABC8 File Offset: 0x00208DC8
		// Note: this type is marked as 'beforefieldinit'.
		static Colors()
		{
		}

		// Token: 0x04004754 RID: 18260
		public static readonly Color RarityAmber;

		// Token: 0x04004755 RID: 18261
		public static readonly Color RarityTrash;

		// Token: 0x04004756 RID: 18262
		public static readonly Color RarityNormal;

		// Token: 0x04004757 RID: 18263
		public static readonly Color RarityBlue;

		// Token: 0x04004758 RID: 18264
		public static readonly Color RarityGreen;

		// Token: 0x04004759 RID: 18265
		public static readonly Color RarityOrange;

		// Token: 0x0400475A RID: 18266
		public static readonly Color RarityRed;

		// Token: 0x0400475B RID: 18267
		public static readonly Color RarityPink;

		// Token: 0x0400475C RID: 18268
		public static readonly Color RarityPurple;

		// Token: 0x0400475D RID: 18269
		public static readonly Color RarityLime;

		// Token: 0x0400475E RID: 18270
		public static readonly Color RarityYellow;

		// Token: 0x0400475F RID: 18271
		public static readonly Color RarityCyan;

		// Token: 0x04004760 RID: 18272
		public static readonly Color CoinPlatinum;

		// Token: 0x04004761 RID: 18273
		public static readonly Color CoinGold;

		// Token: 0x04004762 RID: 18274
		public static readonly Color CoinSilver;

		// Token: 0x04004763 RID: 18275
		public static readonly Color CoinCopper;

		// Token: 0x04004764 RID: 18276
		public static readonly Color AmbientNPCGastropodLight;

		// Token: 0x04004765 RID: 18277
		public static readonly Color JourneyMode;

		// Token: 0x04004766 RID: 18278
		public static readonly Color Mediumcore;

		// Token: 0x04004767 RID: 18279
		public static readonly Color Hardcore;

		// Token: 0x04004768 RID: 18280
		public static readonly Color LanternBG;

		// Token: 0x04004769 RID: 18281
		public static readonly Color[] _waterfallColors;

		// Token: 0x0400476A RID: 18282
		public static readonly Color[] _liquidColors;

		// Token: 0x0400476B RID: 18283
		public static readonly Color FancyUIFatButtonMouseOver;

		// Token: 0x0400476C RID: 18284
		public static readonly Color InventoryDefaultColor;

		// Token: 0x0400476D RID: 18285
		public static readonly Color InventoryDefaultColorWithOpacity;
	}
}
