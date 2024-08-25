using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000907 RID: 2311
	public static class PitEntrance
	{
		// Token: 0x06004678 RID: 18040 RVA: 0x00259A58 File Offset: 0x00257C58
		public static void Place(DesertDescription description)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 6;
			int num2 = 9;
			int num3 = genRand.Next(num, num2);
			int x = description.<CombinedArea>k__BackingField.X;
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			int x2 = <Surface>k__BackingField.X;
			short[] heights = <Surface>k__BackingField._heights;
			Point point;
			PitEntrance.PlaceAt(description, point, num3);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x00259AB0 File Offset: 0x00257CB0
		private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
		{
			Rectangle <Hive>k__BackingField = description.<Hive>k__BackingField;
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			int x = <Surface>k__BackingField.X;
			short[] heights = <Surface>k__BackingField._heights;
			int y = description.<Desert>k__BackingField.Y;
			if (heights == null)
			{
			}
			double num = PitEntrance.SmootherStep(0.35);
			Tile tile;
			tile.ClearEverything();
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x000021DB File Offset: 0x000003DB
		private static double GetHoleRadiusScaleAt(double yProgress)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00259BAC File Offset: 0x00257DAC
		private static double SmootherStep(double delta)
		{
			/*
An exception occurred when decompiling this method (0600467B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.GameContent.Biomes.Desert.PitEntrance::SmootherStep(System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldc.i4:bool(1))
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
	}
}
