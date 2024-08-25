using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E9 RID: 1257
	public class TileFont
	{
		// Token: 0x0600307A RID: 12410 RVA: 0x001F6630 File Offset: 0x001F4830
		public static void DrawString(Point start, string text, TileFont.DrawMode mode)
		{
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			if (stringLength == 0)
			{
			}
			int stringLength2 = text._stringLength;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x001F6658 File Offset: 0x001F4858
		private static void DrawChar(Point position, byte[] charData, TileFont.DrawMode mode)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			tile.ResetToType((ushort)1610612736);
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			WorldGen.TileFrame(0, 1610612736, num2 != 0L, num3 != 0L);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.TileFrame(0, 1610612736, num4 != 0L, num5 != 0L);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x001F66AC File Offset: 0x001F48AC
		public static Point MeasureString(string text)
		{
			/*
An exception occurred when decompiling this method (0600307C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.WorldBuilding.TileFont::MeasureString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:int32(var_5_1D, call:int32(Math::Max, ldloc:char[exp:int32](var_4), ldloc:char[exp:int32](var_4)))
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

		// Token: 0x0600307D RID: 12413 RVA: 0x001F66D8 File Offset: 0x001F48D8
		public static void HLineLabel(Point start, int width, string text, TileFont.DrawMode mode, bool rightSideText = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Point point = TileFont.MeasureString(text);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x001F66FC File Offset: 0x001F48FC
		public static void VLineLabel(Point start, int height, string text, TileFont.DrawMode mode, bool bottomText = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Point point = TileFont.MeasureString(text);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x001F671C File Offset: 0x001F491C
		public TileFont()
		{
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x001F6730 File Offset: 0x001F4930
		// Note: this type is marked as 'beforefieldinit'.
		static TileFont()
		{
		}

		// Token: 0x04003A8F RID: 14991
		private static readonly Dictionary<char, byte[]> MicroFont;

		// Token: 0x020004EA RID: 1258
		public struct DrawMode
		{
			// Token: 0x06003081 RID: 12417 RVA: 0x001F6740 File Offset: 0x001F4940
			public DrawMode(ushort foregroundTile)
			{
				this.ForegroundTile = foregroundTile;
			}

			// Token: 0x06003082 RID: 12418 RVA: 0x001F6754 File Offset: 0x001F4954
			public DrawMode(ushort foregroundTile, ushort backgroundTile)
			{
				this.ForegroundTile = foregroundTile;
				this.BackgroundTile = backgroundTile;
				this.HasBackground = true;
			}

			// Token: 0x04003A90 RID: 14992
			public readonly ushort ForegroundTile;

			// Token: 0x04003A91 RID: 14993
			public readonly ushort BackgroundTile;

			// Token: 0x04003A92 RID: 14994
			public readonly bool HasBackground;
		}
	}
}
