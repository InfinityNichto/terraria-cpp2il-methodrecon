using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes.Desert;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008EA RID: 2282
	public class DunesBiome : MicroBiome
	{
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x00256738 File Offset: 0x00254938
		public int MaximumWidth
		{
			get
			{
				return this._singleDunesWidth.ScaledMaximum;
			}
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00256750 File Offset: 0x00254950
		public override bool Place(Point origin, StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (060045F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.DunesBiome::Place(Microsoft.Xna.Framework.Point,Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnifiedRandom(var_1_07, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int32(var_2_0A, ldc.i4:int32(60))
	stloc:int32(var_3_0D, ldc.i4:int32(100))
	stloc:int32(var_4_16, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_1_07), ldloc:int32(var_2_0A), ldloc:int32(var_3_0D)))
	stloc:float64(var_5_1E, ldfld:float64(DunesBiome::_heightScale, ldloc:DunesBiome(this)))
	stloc:UnifiedRandom(var_7_28, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int32(var_8_2C, ldc.i4:int32(60))
	stloc:int32(var_9_30, ldc.i4:int32(100))
	stloc:int32(var_10_3D, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_7_28), ldloc:int32(var_8_2C), ldloc:int32(var_9_30)))
	stloc:float64(var_11_45, ldfld:float64(DunesBiome::_heightScale, ldloc:DunesBiome(this)))
	stloc:WorldGenRange(var_12_4D, ldfld:WorldGenRange(DunesBiome::_singleDunesWidth, ldloc:DunesBiome(this)))
	stloc:UnifiedRandom(var_14_57, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int32(var_15_62, call:int32(WorldGenRange::GetRandom, ldloc:WorldGenRange(var_12_4D), ldloc:UnifiedRandom(var_14_57)))
	stloc:WorldGenRange(var_16_6A, ldfld:WorldGenRange(DunesBiome::_singleDunesWidth, ldloc:DunesBiome(this)))
	stloc:UnifiedRandom(var_18_74, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int32(var_20_82, call:int32(WorldGenRange::GetRandom, ldloc:WorldGenRange(var_16_6A), ldloc:UnifiedRandom(var_18_74)))
	call:void(DunesBiome::PlaceSingle, ldloc:DunesBiome(this), ldloc:DunesDescription(var_21), ldloc:StructureMap(structures))
	call:void(DunesBiome::PlaceSingle, ldloc:DunesBiome(this), ldloc:DunesDescription(var_22), ldloc:StructureMap(structures))
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

		// Token: 0x060045FA RID: 17914 RVA: 0x002567F8 File Offset: 0x002549F8
		private void PlaceSingle(DunesBiome.DunesDescription description, StructureMap structures)
		{
			UnifiedRandom random = GenBase._random;
			int num = 3;
			int num2 = random.Next(num);
			Rectangle <Area>k__BackingField = description.<Area>k__BackingField;
			int width = description.<Area>k__BackingField.Width;
			UnifiedRandom random2 = GenBase._random;
			int num3 = 6;
			int num4 = random2.Next(num, num3);
			double heightScale = this._heightScale;
			UnifiedRandom random3 = GenBase._random;
			int num5 = 2;
			int num6 = random3.Next(num5);
			Rectangle <Area>k__BackingField2 = description.<Area>k__BackingField;
			int width2 = description.<Area>k__BackingField.Width;
			long num7 = 0L;
			UnifiedRandom random4 = GenBase._random;
			int num8 = 11;
			int num9 = random4.Next((int)num7, num8);
			double heightScale2 = this._heightScale;
			DunesBiome.PlaceHill(num9, (int)num7, heightScale2, description);
			Rectangle <Area>k__BackingField3 = description.<Area>k__BackingField;
			int width3 = description.<Area>k__BackingField.Width;
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x002568D0 File Offset: 0x00254AD0
		private static void PlaceHill(int startX, int endX, double scale, DunesBiome.DunesDescription description)
		{
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			short num = <Surface>k__BackingField[startX];
			SurfaceMap <Surface>k__BackingField2 = description.<Surface>k__BackingField;
			long num2 = 0L;
			short num3 = <Surface>k__BackingField2[endX];
			DunesBiome.WindDirection <WindDirection>k__BackingField = description.<WindDirection>k__BackingField;
			int num4 = WorldGen.genRand.Next(endX, (int)num2);
			DunesBiome.WindDirection <WindDirection>k__BackingField2 = description.<WindDirection>k__BackingField;
			DunesBiome.WindDirection <WindDirection>k__BackingField3 = description.<WindDirection>k__BackingField;
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x0025693C File Offset: 0x00254B3C
		private static void PlaceCurvedLine(Point startPoint, Point endPoint, Point anchorOffset, DunesBiome.DunesDescription description)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2D vector2D = startPoint.ToVector2D();
			Vector2D vector2D2 = endPoint.ToVector2D();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Point point;
			bool flag = point == anchorOffset;
			Rectangle <Area>k__BackingField = description.<Area>k__BackingField;
			int width = description.<Area>k__BackingField.Width;
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			Tile tile;
			bool flag2 = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			tile3.ClearEverything();
			int num2 = 53;
			Tile tile4;
			tile4.ResetToType((ushort)num2);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x002569C0 File Offset: 0x00254BC0
		public DunesBiome()
		{
			if (!true)
			{
			}
			this._singleDunesWidth = 1;
			base..ctor();
		}

		// Token: 0x04008250 RID: 33360
		[JsonProperty("SingleDunesWidth")]
		private WorldGenRange _singleDunesWidth;

		// Token: 0x04008251 RID: 33361
		[JsonProperty("HeightScale")]
		private double _heightScale;

		// Token: 0x020008EB RID: 2283
		private class DunesDescription
		{
			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x060045FE RID: 17918 RVA: 0x002569E0 File Offset: 0x00254BE0
			// (set) Token: 0x060045FF RID: 17919 RVA: 0x002569F4 File Offset: 0x00254BF4
			public bool IsValid
			{
				[CompilerGenerated]
				get
				{
					return this.<IsValid>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x06004600 RID: 17920 RVA: 0x00256A04 File Offset: 0x00254C04
			// (set) Token: 0x06004601 RID: 17921 RVA: 0x00256A18 File Offset: 0x00254C18
			public SurfaceMap Surface
			{
				[CompilerGenerated]
				get
				{
					return this.<Surface>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<Surface>k__BackingField = value;
				}
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x06004602 RID: 17922 RVA: 0x00256A2C File Offset: 0x00254C2C
			// (set) Token: 0x06004603 RID: 17923 RVA: 0x00256A50 File Offset: 0x00254C50
			public Rectangle Area
			{
				[CompilerGenerated]
				get
				{
					Rectangle rectangle = this.<Area>k__BackingField;
					int width = this.<Area>k__BackingField.Width;
					return rectangle;
				}
				[CompilerGenerated]
				private set
				{
					this.<Area>k__BackingField = value;
				}
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x06004604 RID: 17924 RVA: 0x00256A64 File Offset: 0x00254C64
			// (set) Token: 0x06004605 RID: 17925 RVA: 0x00256A78 File Offset: 0x00254C78
			public DunesBiome.WindDirection WindDirection
			{
				[CompilerGenerated]
				get
				{
					return this.<WindDirection>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<WindDirection>k__BackingField = value;
				}
			}

			// Token: 0x06004606 RID: 17926 RVA: 0x00256A8C File Offset: 0x00254C8C
			private DunesDescription()
			{
			}

			// Token: 0x06004607 RID: 17927 RVA: 0x00256AA0 File Offset: 0x00254CA0
			public static DunesBiome.DunesDescription CreateFromPlacement(Point origin, int width, int height)
			{
				int num = 1;
				long num2 = 0L;
				SurfaceMap surfaceMap = SurfaceMap.FromArea(-1073741824, (int)num2);
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 2;
				int num4 = genRand.Next(num3);
				return -1073741824;
			}

			// Token: 0x04008252 RID: 33362
			[CompilerGenerated]
			private bool <IsValid>k__BackingField;

			// Token: 0x04008253 RID: 33363
			[CompilerGenerated]
			private SurfaceMap <Surface>k__BackingField;

			// Token: 0x04008254 RID: 33364
			[CompilerGenerated]
			private Rectangle <Area>k__BackingField;

			// Token: 0x04008255 RID: 33365
			[CompilerGenerated]
			private DunesBiome.WindDirection <WindDirection>k__BackingField;
		}

		// Token: 0x020008EC RID: 2284
		private enum WindDirection
		{
			// Token: 0x04008257 RID: 33367
			Left,
			// Token: 0x04008258 RID: 33368
			Right
		}
	}
}
