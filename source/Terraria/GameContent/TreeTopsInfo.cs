using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x02000804 RID: 2052
	public class TreeTopsInfo
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x00248858 File Offset: 0x00246A58
		public void Save(BinaryWriter writer)
		{
			int[] variations = this._variations;
			int[] variations2 = this._variations;
			int[] variations3 = this._variations;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0024887C File Offset: 0x00246A7C
		public void Load(BinaryReader reader, int loadVersion)
		{
			int[] variations = this._variations;
			int[] variations2 = this._variations;
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x002488BC File Offset: 0x00246ABC
		public void SyncSend(BinaryWriter writer)
		{
			int[] variations = this._variations;
			int[] variations2 = this._variations;
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x002488DC File Offset: 0x00246ADC
		public void SyncReceive(BinaryReader reader)
		{
			int[] variations = this._variations;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x002488F4 File Offset: 0x00246AF4
		public int GetTreeStyle(int areaId)
		{
			/*
An exception occurred when decompiling this method (060041C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.TreeTopsInfo::GetTreeStyle(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](TreeTopsInfo::_variations, ldloc:TreeTopsInfo(this)))
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

		// Token: 0x060041C5 RID: 16837 RVA: 0x00248908 File Offset: 0x00246B08
		public void RandomizeTreeStyleBasedOnWorldPosition(UnifiedRandom rand, Vector2 worldPosition)
		{
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00248954 File Offset: 0x00246B54
		public void RandomizeTreeStyle(UnifiedRandom rand, int areaId)
		{
			int[] variations = this._variations;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00248998 File Offset: 0x00246B98
		private void DoTreeFX(int areaID)
		{
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x002489A8 File Offset: 0x00246BA8
		public void CopyExistingWorldInfoForWorldGeneration()
		{
			this.CopyExistingWorldInfo();
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x002489BC File Offset: 0x00246BBC
		public void CopyExistingWorldInfo()
		{
			int[] variations = this._variations;
			if (true)
			{
				return;
			}
			int[] variations2 = this._variations;
			if (true)
			{
				return;
			}
			int[] variations3 = this._variations;
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x002489E8 File Offset: 0x00246BE8
		public TreeTopsInfo()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x04008089 RID: 32905
		private int[] _variations;

		// Token: 0x02000805 RID: 2053
		public class AreaId
		{
			// Token: 0x060041CB RID: 16843 RVA: 0x00248A00 File Offset: 0x00246C00
			public AreaId()
			{
			}

			// Token: 0x060041CC RID: 16844 RVA: 0x00248A14 File Offset: 0x00246C14
			// Note: this type is marked as 'beforefieldinit'.
			static AreaId()
			{
			}

			// Token: 0x0400808A RID: 32906
			public const int Forest1 = 0;

			// Token: 0x0400808B RID: 32907
			public const int Forest2 = 1;

			// Token: 0x0400808C RID: 32908
			public const int Forest3 = 2;

			// Token: 0x0400808D RID: 32909
			public const int Forest4 = 3;

			// Token: 0x0400808E RID: 32910
			public const int Corruption = 4;

			// Token: 0x0400808F RID: 32911
			public const int Jungle = 5;

			// Token: 0x04008090 RID: 32912
			public const int Snow = 6;

			// Token: 0x04008091 RID: 32913
			public const int Hallow = 7;

			// Token: 0x04008092 RID: 32914
			public const int Crimson = 8;

			// Token: 0x04008093 RID: 32915
			public const int Desert = 9;

			// Token: 0x04008094 RID: 32916
			public const int Ocean = 10;

			// Token: 0x04008095 RID: 32917
			public const int GlowingMushroom = 11;

			// Token: 0x04008096 RID: 32918
			public const int Underworld = 12;

			// Token: 0x04008097 RID: 32919
			public static readonly int Count;
		}
	}
}
