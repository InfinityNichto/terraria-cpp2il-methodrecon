using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000911 RID: 2321
	public static class HouseUtils
	{
		// Token: 0x060046C2 RID: 18114 RVA: 0x0025AD38 File Offset: 0x00258F38
		public static HouseBuilder CreateBuilder(Point origin, StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (060046C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Biomes.CaveHouse.HouseBuilder Terraria.GameContent.Biomes.CaveHouse.HouseUtils::CreateBuilder(Microsoft.Xna.Framework.Point,Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:HouseType(var_3_20, call:HouseType(HouseUtils::GetHouseType, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Microsoft.Xna.Framework.Rectangle>[exp:IEnumerable`1](var_0)))
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

		// Token: 0x060046C3 RID: 18115 RVA: 0x0025AD68 File Offset: 0x00258F68
		private static List<Rectangle> CreateRooms(Point origin)
		{
			Rectangle rectangle2;
			Rectangle rectangle = HouseUtils.FindRoom(rectangle2.Center);
			Rectangle rectangle3 = HouseUtils.FindRoom(rectangle.Center);
			double roomSolidPrecentage = HouseUtils.GetRoomSolidPrecentage(rectangle);
			double roomSolidPrecentage2 = HouseUtils.GetRoomSolidPrecentage(rectangle3);
			double num = WorldGen.genRand.NextDouble();
			double num2 = WorldGen.genRand.NextDouble();
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x0025ADCC File Offset: 0x00258FCC
		private static Rectangle FindRoom(Point origin)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0025ADF8 File Offset: 0x00258FF8
		private static double GetRoomSolidPrecentage(Rectangle room)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000021DB File Offset: 0x000003DB
		private static int SortBiomeResults(Tuple<HouseType, int> item1, Tuple<HouseType, int> item2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0025AE0C File Offset: 0x0025900C
		private static bool AreRoomLocationsValid(IEnumerable<Rectangle> rooms)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0025AE3C File Offset: 0x0025903C
		private static HouseType GetHouseType(IEnumerable<Rectangle> rooms)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0025AE88 File Offset: 0x00259088
		private static bool AreRoomsValid(IEnumerable<Rectangle> rooms, StructureMap structures, HouseType style)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0025AEE0 File Offset: 0x002590E0
		// Note: this type is marked as 'beforefieldinit'.
		static HouseUtils()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040082B4 RID: 33460
		private static readonly bool[] BlacklistedTiles;

		// Token: 0x040082B5 RID: 33461
		private static readonly bool[] BeelistedTiles;
	}
}
