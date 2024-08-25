using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007D3 RID: 2003
	public class TilePaintSystemV2
	{
		// Token: 0x060040BB RID: 16571 RVA: 0x00243AFC File Offset: 0x00241CFC
		public EffectPass GetTileEffect(int tileType, int tileStyle, int paintColor)
		{
			/*
An exception occurred when decompiling this method (060040BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.EffectPass Terraria.GameContent.TilePaintSystemV2::GetTileEffect(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TreePaintingSettingsId(var_0_12, ldfld:TreePaintingSettingsId(TreePaintingSettings::Id, call:TreePaintingSettings(TreePaintSystemData::GetTileSettings, ldfld:TreePaintSystemData(TilePaintSystemV2::PaintSystemData, ldloc:TilePaintSystemV2(this)), ldloc:int32(tileType), ldloc:int32(tileStyle))))
	stloc:class Microsoft.Xna.Framework.Graphics.EffectPass[](var_1_19, ldfld:class Microsoft.Xna.Framework.Graphics.EffectPass[](TilePaintSystemV2::TileShaders, ldloc:TilePaintSystemV2(this)))
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

		// Token: 0x060040BC RID: 16572 RVA: 0x00243B24 File Offset: 0x00241D24
		public EffectPass GetWallEffect(int wallType, int paintColor)
		{
			TreePaintingSettings defaultNoSpecialGroups_ForWalls = this.PaintSystemData.DefaultNoSpecialGroups_ForWalls;
			return this.GetRealShader(paintColor, defaultNoSpecialGroups_ForWalls);
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00243B48 File Offset: 0x00241D48
		public EffectPass GetTreeBranchEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			/*
An exception occurred when decompiling this method (060040BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.EffectPass Terraria.GameContent.TilePaintSystemV2::GetTreeBranchEffect(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TreePaintingSettingsId(var_0_12, ldfld:TreePaintingSettingsId(TreePaintingSettings::Id, call:TreePaintingSettings(TreePaintSystemData::GetTreeFoliageSettings, ldfld:TreePaintSystemData(TilePaintSystemV2::PaintSystemData, ldloc:TilePaintSystemV2(this)), ldloc:int32(treeTopIndex), ldloc:int32(treeTopStyle))))
	stloc:class Microsoft.Xna.Framework.Graphics.EffectPass[](var_1_19, ldfld:class Microsoft.Xna.Framework.Graphics.EffectPass[](TilePaintSystemV2::TileShaders, ldloc:TilePaintSystemV2(this)))
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

		// Token: 0x060040BE RID: 16574 RVA: 0x00243B70 File Offset: 0x00241D70
		public EffectPass GetTreeTopEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			/*
An exception occurred when decompiling this method (060040BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.EffectPass Terraria.GameContent.TilePaintSystemV2::GetTreeTopEffect(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TreePaintingSettingsId(var_0_12, ldfld:TreePaintingSettingsId(TreePaintingSettings::Id, call:TreePaintingSettings(TreePaintSystemData::GetTreeFoliageSettings, ldfld:TreePaintSystemData(TilePaintSystemV2::PaintSystemData, ldloc:TilePaintSystemV2(this)), ldloc:int32(treeTopIndex), ldloc:int32(treeTopStyle))))
	stloc:class Microsoft.Xna.Framework.Graphics.EffectPass[](var_1_19, ldfld:class Microsoft.Xna.Framework.Graphics.EffectPass[](TilePaintSystemV2::TileShaders, ldloc:TilePaintSystemV2(this)))
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

		// Token: 0x060040BF RID: 16575 RVA: 0x00243B98 File Offset: 0x00241D98
		private Effect InitShader(TreePaintingSettings settings)
		{
			TileShader[] array = this.specialShaders;
			TileShader tileShader = Microsoft.Xna.Framework.Graphics.TileShader.CreateNew();
			if (tileShader == null || tileShader != null)
			{
				EffectParameter effectParameter = tileShader.<Parameters>k__BackingField["leafHueTestOffset"];
				float hueTestOffset = settings.HueTestOffset;
				EffectParameter effectParameter2 = tileShader.<Parameters>k__BackingField["leafMinHue"];
				float specialGroupMinimalHueValue = settings.SpecialGroupMinimalHueValue;
				EffectParameter effectParameter3 = tileShader.<Parameters>k__BackingField["leafMaxHue"];
				float specialGroupMaximumHueValue = settings.SpecialGroupMaximumHueValue;
				EffectParameter effectParameter4 = tileShader.<Parameters>k__BackingField["leafMinSat"];
				float specialGroupMinimumSaturationValue = settings.SpecialGroupMinimumSaturationValue;
				EffectParameter effectParameter5 = tileShader.<Parameters>k__BackingField["leafMaxSat"];
				float specialGroupMaximumSaturationValue = settings.SpecialGroupMaximumSaturationValue;
				EffectParameter effectParameter6 = tileShader.<Parameters>k__BackingField["invertSpecialGroupResult"];
				bool invertSpecialGroupResult = settings.InvertSpecialGroupResult;
				effectParameter6.SetValue(invertSpecialGroupResult);
				int num = 1;
				EffectPass[] tileShaders = this.TileShaders;
				TreePaintingSettings.TreePaintingSettingsId id = settings.Id;
				EffectPass realShader = this.GetRealShader(num, settings);
				if (realShader == null || realShader != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00243C8C File Offset: 0x00241E8C
		public void CreateTileShaders()
		{
			if (this.TileShader == null)
			{
				Effect tileShader = Main.tileShader;
				this.TileShader = tileShader;
			}
			TreePaintingSettings defaultNoSpecialGroups = this.PaintSystemData.DefaultNoSpecialGroups;
			Effect effect = this.InitShader(defaultNoSpecialGroups);
			TreePaintingSettings defaultDirt = this.PaintSystemData.DefaultDirt;
			Effect effect2 = this.InitShader(defaultDirt);
			TreePaintingSettings cullMud = this.PaintSystemData.CullMud;
			Effect effect3 = this.InitShader(cullMud);
			TreePaintingSettings woodPurity = this.PaintSystemData.WoodPurity;
			Effect effect4 = this.InitShader(woodPurity);
			TreePaintingSettings woodCorruption = this.PaintSystemData.WoodCorruption;
			Effect effect5 = this.InitShader(woodCorruption);
			TreePaintingSettings woodJungle = this.PaintSystemData.WoodJungle;
			Effect effect6 = this.InitShader(woodJungle);
			TreePaintingSettings woodHallow = this.PaintSystemData.WoodHallow;
			Effect effect7 = this.InitShader(woodHallow);
			TreePaintingSettings woodSnow = this.PaintSystemData.WoodSnow;
			Effect effect8 = this.InitShader(woodSnow);
			TreePaintingSettings woodCrimson = this.PaintSystemData.WoodCrimson;
			Effect effect9 = this.InitShader(woodCrimson);
			TreePaintingSettings woodJungleUnderground = this.PaintSystemData.WoodJungleUnderground;
			Effect effect10 = this.InitShader(woodJungleUnderground);
			TreePaintingSettings woodGlowingMushroom = this.PaintSystemData.WoodGlowingMushroom;
			Effect effect11 = this.InitShader(woodGlowingMushroom);
			TreePaintingSettings vanityCherry = this.PaintSystemData.VanityCherry;
			Effect effect12 = this.InitShader(vanityCherry);
			TreePaintingSettings vanityYellowWillow = this.PaintSystemData.VanityYellowWillow;
			Effect effect13 = this.InitShader(vanityYellowWillow);
			TreePaintingSettings gemTreeRuby = this.PaintSystemData.GemTreeRuby;
			Effect effect14 = this.InitShader(gemTreeRuby);
			TreePaintingSettings palmTreePurity = this.PaintSystemData.PalmTreePurity;
			Effect effect15 = this.InitShader(palmTreePurity);
			TreePaintingSettings palmTreeCorruption = this.PaintSystemData.PalmTreeCorruption;
			Effect effect16 = this.InitShader(palmTreeCorruption);
			TreePaintingSettings palmTreeCrimson = this.PaintSystemData.PalmTreeCrimson;
			Effect effect17 = this.InitShader(palmTreeCrimson);
			TreePaintingSettings palmTreeHallow = this.PaintSystemData.PalmTreeHallow;
			Effect effect18 = this.InitShader(palmTreeHallow);
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00243E4C File Offset: 0x0024204C
		public EffectPass GetRealShader(int paintColor, TreePaintingSettings settings)
		{
			int num2;
			do
			{
				int num = 1;
				bool useSpecialGroups = settings.UseSpecialGroups;
				bool useWallShaderHacks = settings.UseWallShaderHacks;
				if (num == 0)
				{
				}
				if (num2 != 0)
				{
					Effect tileShader = this.TileShader;
				}
			}
			while (this.specialShaders.<Name>k__BackingField != null);
			return this.InitShader(settings).<CurrentTechnique>k__BackingField.<Passes>k__BackingField[num2];
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00243EA0 File Offset: 0x002420A0
		public EffectPass GetShader(int paintColor, TreePaintingSettings settings)
		{
			/*
An exception occurred when decompiling this method (060040C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.EffectPass Terraria.GameContent.TilePaintSystemV2::GetShader(System.Int32,Terraria.GameContent.TreePaintingSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TreePaintingSettingsId(var_0_06, ldfld:TreePaintingSettingsId(TreePaintingSettings::Id, ldloc:TreePaintingSettings(settings)))
	stloc:class Microsoft.Xna.Framework.Graphics.EffectPass[](var_1_0D, ldfld:class Microsoft.Xna.Framework.Graphics.EffectPass[](TilePaintSystemV2::TileShaders, ldloc:TilePaintSystemV2(this)))
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

		// Token: 0x060040C3 RID: 16579 RVA: 0x00243EBC File Offset: 0x002420BC
		public TilePaintSystemV2()
		{
		}

		// Token: 0x04007E97 RID: 32407
		private Effect TileShader;

		// Token: 0x04007E98 RID: 32408
		private TreePaintSystemData PaintSystemData;

		// Token: 0x04007E99 RID: 32409
		private TileShader[] specialShaders;

		// Token: 0x04007E9A RID: 32410
		private EffectPass[] TileShaders;

		// Token: 0x020007D4 RID: 2004
		public struct TileVariationkey
		{
			// Token: 0x060040C4 RID: 16580 RVA: 0x00243ED0 File Offset: 0x002420D0
			public bool Equals(TilePaintSystemV2.TileVariationkey other)
			{
				/*
An exception occurred when decompiling this method (060040C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TilePaintSystemV2/TileVariationkey::Equals(Terraria.GameContent.TilePaintSystemV2/TileVariationkey)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TileVariationkey::TileStyle, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TileVariationkey&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TileVariationkey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TileVariationkey&(this)))
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

			// Token: 0x060040C5 RID: 16581 RVA: 0x00243EEC File Offset: 0x002420EC
			public override bool Equals(object obj)
			{
				if (obj != null)
				{
					int tileStyle = this.TileStyle;
					int paintColor = this.PaintColor;
					return;
				}
			}

			// Token: 0x060040C6 RID: 16582 RVA: 0x00243F0C File Offset: 0x0024210C
			public override int GetHashCode()
			{
				/*
An exception occurred when decompiling this method (060040C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.TilePaintSystemV2/TileVariationkey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TileVariationkey::TileType, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TileVariationkey&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TileVariationkey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TileVariationkey&(this)))
	stloc:int32(var_2_14, ldfld:int32(TileVariationkey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TileVariationkey&(this)))
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

			// Token: 0x060040C7 RID: 16583 RVA: 0x00243F30 File Offset: 0x00242130
			public static bool operator ==(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
			}

			// Token: 0x060040C8 RID: 16584 RVA: 0x00243F40 File Offset: 0x00242140
			public static bool operator !=(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				return true;
			}

			// Token: 0x04007E9B RID: 32411
			public int TileType;

			// Token: 0x04007E9C RID: 32412
			public int TileStyle;

			// Token: 0x04007E9D RID: 32413
			public int PaintColor;
		}

		// Token: 0x020007D5 RID: 2005
		public struct WallVariationKey
		{
			// Token: 0x060040C9 RID: 16585 RVA: 0x00243F50 File Offset: 0x00242150
			public bool Equals(TilePaintSystemV2.WallVariationKey other)
			{
				/*
An exception occurred when decompiling this method (060040C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TilePaintSystemV2/WallVariationKey::Equals(Terraria.GameContent.TilePaintSystemV2/WallVariationKey)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WallVariationKey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/WallVariationKey&(this)))
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

			// Token: 0x060040CA RID: 16586 RVA: 0x00243F68 File Offset: 0x00242168
			public override bool Equals(object obj)
			{
				if (obj != null)
				{
					int paintColor = this.PaintColor;
					return;
				}
			}

			// Token: 0x060040CB RID: 16587 RVA: 0x00243F80 File Offset: 0x00242180
			public override int GetHashCode()
			{
				/*
An exception occurred when decompiling this method (060040CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.TilePaintSystemV2/WallVariationKey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WallVariationKey::WallType, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/WallVariationKey&(this)))
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

			// Token: 0x060040CC RID: 16588 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool operator ==(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060040CD RID: 16589 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool operator !=(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04007E9E RID: 32414
			public int WallType;

			// Token: 0x04007E9F RID: 32415
			public int PaintColor;
		}

		// Token: 0x020007D6 RID: 2006
		public struct TreeFoliageVariantKey
		{
			// Token: 0x060040CE RID: 16590 RVA: 0x00243F94 File Offset: 0x00242194
			public bool Equals(TilePaintSystemV2.TreeFoliageVariantKey other)
			{
				/*
An exception occurred when decompiling this method (060040CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey::Equals(Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TreeFoliageVariantKey::TextureStyle, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TreeFoliageVariantKey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey&(this)))
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

			// Token: 0x060040CF RID: 16591 RVA: 0x00243FB0 File Offset: 0x002421B0
			public override bool Equals(object obj)
			{
				if (obj != null)
				{
					int textureStyle = this.TextureStyle;
					int paintColor = this.PaintColor;
					return;
				}
			}

			// Token: 0x060040D0 RID: 16592 RVA: 0x00243FD0 File Offset: 0x002421D0
			public override int GetHashCode()
			{
				/*
An exception occurred when decompiling this method (060040D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TreeFoliageVariantKey::TextureIndex, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TreeFoliageVariantKey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey&(this)))
	stloc:int32(var_2_14, ldfld:int32(TreeFoliageVariantKey::PaintColor, ldloc:valuetype Terraria.GameContent.TilePaintSystemV2/TreeFoliageVariantKey&(this)))
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

			// Token: 0x060040D1 RID: 16593 RVA: 0x00243FF4 File Offset: 0x002421F4
			public static bool operator ==(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
			}

			// Token: 0x060040D2 RID: 16594 RVA: 0x00244004 File Offset: 0x00242204
			public static bool operator !=(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				return true;
			}

			// Token: 0x04007EA0 RID: 32416
			public int TextureIndex;

			// Token: 0x04007EA1 RID: 32417
			public int TextureStyle;

			// Token: 0x04007EA2 RID: 32418
			public int PaintColor;
		}
	}
}
