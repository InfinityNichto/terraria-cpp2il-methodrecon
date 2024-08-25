using System;

namespace Terraria.Graphics.Capture
{
	// Token: 0x02000761 RID: 1889
	public class CaptureBiome
	{
		// Token: 0x06003E19 RID: 15897 RVA: 0x0023BD18 File Offset: 0x00239F18
		public CaptureBiome(int backgroundIndex, int waterStyle, CaptureBiome.TileColorStyle tileColorStyle = CaptureBiome.TileColorStyle.Normal)
		{
			this.WaterStyle = waterStyle;
			this.TileColor = (CaptureBiome.TileColorStyle)backgroundIndex;
			this.TileColor = tileColorStyle;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x0023BD40 File Offset: 0x00239F40
		public static CaptureBiome GetCaptureBiome(int biomeChoice)
		{
			if (!true)
			{
			}
			return CaptureBiome.GetPurityForPlayer();
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x0023BD90 File Offset: 0x00239F90
		private static CaptureBiome GetBiomeByWater()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = Main.CalculateWaterStyle(true);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0023BDB8 File Offset: 0x00239FB8
		private static CaptureBiome GetBiomeByLocation()
		{
			/*
An exception occurred when decompiling this method (06003E1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Capture.CaptureBiome Terraria.Graphics.Capture.CaptureBiome::GetBiomeByLocation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_1_0A))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0023BDF8 File Offset: 0x00239FF8
		private static CaptureBiome GetPurityForPlayer()
		{
			/*
An exception occurred when decompiling this method (06003E1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Capture.CaptureBiome Terraria.Graphics.Capture.CaptureBiome::GetPurityForPlayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0023BE24 File Offset: 0x0023A024
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureBiome()
		{
		}

		// Token: 0x04007CCF RID: 31951
		public static readonly CaptureBiome DefaultPurity;

		// Token: 0x04007CD0 RID: 31952
		public static CaptureBiome[] BiomesByWaterStyle;

		// Token: 0x04007CD1 RID: 31953
		public readonly int WaterStyle;

		// Token: 0x04007CD2 RID: 31954
		public readonly int BackgroundIndex;

		// Token: 0x04007CD3 RID: 31955
		public readonly CaptureBiome.TileColorStyle TileColor;

		// Token: 0x02000762 RID: 1890
		public enum TileColorStyle
		{
			// Token: 0x04007CD5 RID: 31957
			Normal,
			// Token: 0x04007CD6 RID: 31958
			Jungle,
			// Token: 0x04007CD7 RID: 31959
			Crimson,
			// Token: 0x04007CD8 RID: 31960
			Corrupt,
			// Token: 0x04007CD9 RID: 31961
			Mushroom
		}

		// Token: 0x02000763 RID: 1891
		public class Sets
		{
			// Token: 0x06003E1F RID: 15903 RVA: 0x0023BE38 File Offset: 0x0023A038
			public Sets()
			{
			}

			// Token: 0x02000764 RID: 1892
			public class WaterStyles
			{
				// Token: 0x06003E20 RID: 15904 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public WaterStyles()
				{
				}

				// Token: 0x04007CDA RID: 31962
				public const int BloodMoon = 9;
			}
		}

		// Token: 0x02000765 RID: 1893
		public class Styles
		{
			// Token: 0x06003E21 RID: 15905 RVA: 0x0023BE4C File Offset: 0x0023A04C
			public Styles()
			{
			}

			// Token: 0x06003E22 RID: 15906 RVA: 0x0023BE60 File Offset: 0x0023A060
			// Note: this type is marked as 'beforefieldinit'.
			static Styles()
			{
			}

			// Token: 0x04007CDB RID: 31963
			public static CaptureBiome Purity;

			// Token: 0x04007CDC RID: 31964
			public static CaptureBiome Purity2;

			// Token: 0x04007CDD RID: 31965
			public static CaptureBiome Purity3;

			// Token: 0x04007CDE RID: 31966
			public static CaptureBiome Purity4;

			// Token: 0x04007CDF RID: 31967
			public static CaptureBiome Corruption;

			// Token: 0x04007CE0 RID: 31968
			public static CaptureBiome Jungle;

			// Token: 0x04007CE1 RID: 31969
			public static CaptureBiome Hallow;

			// Token: 0x04007CE2 RID: 31970
			public static CaptureBiome Snow;

			// Token: 0x04007CE3 RID: 31971
			public static CaptureBiome Desert;

			// Token: 0x04007CE4 RID: 31972
			public static CaptureBiome DirtLayer;

			// Token: 0x04007CE5 RID: 31973
			public static CaptureBiome RockLayer;

			// Token: 0x04007CE6 RID: 31974
			public static CaptureBiome BloodMoon;

			// Token: 0x04007CE7 RID: 31975
			public static CaptureBiome Crimson;

			// Token: 0x04007CE8 RID: 31976
			public static CaptureBiome UndergroundDesert;

			// Token: 0x04007CE9 RID: 31977
			public static CaptureBiome Ocean;

			// Token: 0x04007CEA RID: 31978
			public static CaptureBiome Mushroom;
		}

		// Token: 0x02000766 RID: 1894
		private enum BiomeChoiceIndex
		{
			// Token: 0x04007CEC RID: 31980
			AutomatedForPlayer = -1,
			// Token: 0x04007CED RID: 31981
			Purity = 1,
			// Token: 0x04007CEE RID: 31982
			Corruption,
			// Token: 0x04007CEF RID: 31983
			Jungle,
			// Token: 0x04007CF0 RID: 31984
			Hallow,
			// Token: 0x04007CF1 RID: 31985
			Snow,
			// Token: 0x04007CF2 RID: 31986
			Desert,
			// Token: 0x04007CF3 RID: 31987
			DirtLayer,
			// Token: 0x04007CF4 RID: 31988
			RockLayer,
			// Token: 0x04007CF5 RID: 31989
			Crimson,
			// Token: 0x04007CF6 RID: 31990
			UndergroundDesert,
			// Token: 0x04007CF7 RID: 31991
			Ocean,
			// Token: 0x04007CF8 RID: 31992
			Mushroom
		}
	}
}
