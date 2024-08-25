using System;
using Cpp2IlInjected;

namespace Terraria.GameContent
{
	// Token: 0x020007D2 RID: 2002
	public class TreePaintSystemData
	{
		// Token: 0x060040B6 RID: 16566 RVA: 0x00243AB0 File Offset: 0x00241CB0
		public TreePaintingSettings GetTileSettings(int tileType, int tileStyle)
		{
			/*
An exception occurred when decompiling this method (060040B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.TreePaintingSettings Terraria.GameContent.TreePaintSystemData::GetTileSettings(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](tileStyle))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060040B7 RID: 16567 RVA: 0x000021DB File Offset: 0x000003DB
		public TreePaintingSettings GetTreeFoliageSettings(int foliageIndex, int foliageStyle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00243AC4 File Offset: 0x00241CC4
		public TreePaintingSettings GetWallSettings(int wallType)
		{
			return this.DefaultNoSpecialGroups_ForWalls;
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00243AD8 File Offset: 0x00241CD8
		public TreePaintSystemData()
		{
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00243AEC File Offset: 0x00241CEC
		// Note: this type is marked as 'beforefieldinit'.
		static TreePaintSystemData()
		{
		}

		// Token: 0x04007E7D RID: 32381
		public TreePaintingSettings DefaultNoSpecialGroups;

		// Token: 0x04007E7E RID: 32382
		public TreePaintingSettings DefaultNoSpecialGroups_ForWalls;

		// Token: 0x04007E7F RID: 32383
		public TreePaintingSettings DefaultDirt;

		// Token: 0x04007E80 RID: 32384
		public TreePaintingSettings CullMud;

		// Token: 0x04007E81 RID: 32385
		public TreePaintingSettings WoodPurity;

		// Token: 0x04007E82 RID: 32386
		public TreePaintingSettings WoodCorruption;

		// Token: 0x04007E83 RID: 32387
		public TreePaintingSettings WoodJungle;

		// Token: 0x04007E84 RID: 32388
		public TreePaintingSettings WoodHallow;

		// Token: 0x04007E85 RID: 32389
		public TreePaintingSettings WoodSnow;

		// Token: 0x04007E86 RID: 32390
		public TreePaintingSettings WoodCrimson;

		// Token: 0x04007E87 RID: 32391
		public TreePaintingSettings WoodJungleUnderground;

		// Token: 0x04007E88 RID: 32392
		public TreePaintingSettings WoodGlowingMushroom;

		// Token: 0x04007E89 RID: 32393
		public TreePaintingSettings VanityCherry;

		// Token: 0x04007E8A RID: 32394
		public TreePaintingSettings VanityYellowWillow;

		// Token: 0x04007E8B RID: 32395
		private static TreePaintingSettings TreeAsh;

		// Token: 0x04007E8C RID: 32396
		public TreePaintingSettings GemTreeRuby;

		// Token: 0x04007E8D RID: 32397
		private TreePaintingSettings GemTreeAmber;

		// Token: 0x04007E8E RID: 32398
		private TreePaintingSettings GemTreeSapphire;

		// Token: 0x04007E8F RID: 32399
		private TreePaintingSettings GemTreeEmerald;

		// Token: 0x04007E90 RID: 32400
		private TreePaintingSettings GemTreeAmethyst;

		// Token: 0x04007E91 RID: 32401
		private TreePaintingSettings GemTreeTopaz;

		// Token: 0x04007E92 RID: 32402
		private TreePaintingSettings GemTreeDiamond;

		// Token: 0x04007E93 RID: 32403
		public TreePaintingSettings PalmTreePurity;

		// Token: 0x04007E94 RID: 32404
		public TreePaintingSettings PalmTreeCorruption;

		// Token: 0x04007E95 RID: 32405
		public TreePaintingSettings PalmTreeCrimson;

		// Token: 0x04007E96 RID: 32406
		public TreePaintingSettings PalmTreeHallow;
	}
}
