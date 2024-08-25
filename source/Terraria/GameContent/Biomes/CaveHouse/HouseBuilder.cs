using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200090D RID: 2317
	public class HouseBuilder
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00259EB4 File Offset: 0x002580B4
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x00259EC8 File Offset: 0x002580C8
		public double ChestChance
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06004686)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::get_ChestChance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(HouseBuilder::<ChestChance>k__BackingField, ldloc:HouseBuilder(this)))
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
			[CompilerGenerated]
			set
			{
				this.<ChestChance>k__BackingField = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x00259EDC File Offset: 0x002580DC
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x00259EF0 File Offset: 0x002580F0
		public ushort TileType
		{
			[CompilerGenerated]
			get
			{
				return this.<TileType>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<TileType>k__BackingField = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x00259F04 File Offset: 0x00258104
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x00259F18 File Offset: 0x00258118
		public ushort WallType
		{
			[CompilerGenerated]
			get
			{
				return this.<WallType>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<WallType>k__BackingField = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x00259F2C File Offset: 0x0025812C
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x00259F40 File Offset: 0x00258140
		public ushort BeamType
		{
			[CompilerGenerated]
			get
			{
				return this.<BeamType>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<BeamType>k__BackingField = value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x00259F54 File Offset: 0x00258154
		// (set) Token: 0x0600468F RID: 18063 RVA: 0x00259F68 File Offset: 0x00258168
		public int PlatformStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<PlatformStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<PlatformStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x00259F7C File Offset: 0x0025817C
		// (set) Token: 0x06004691 RID: 18065 RVA: 0x00259F90 File Offset: 0x00258190
		public int DoorStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<DoorStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<DoorStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x00259FA4 File Offset: 0x002581A4
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x00259FB8 File Offset: 0x002581B8
		public int TableStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<TableStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<TableStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x00259FCC File Offset: 0x002581CC
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x00259FE0 File Offset: 0x002581E0
		public bool UsesTables2
		{
			[CompilerGenerated]
			get
			{
				return this.<UsesTables2>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x00259FF0 File Offset: 0x002581F0
		// (set) Token: 0x06004697 RID: 18071 RVA: 0x0025A004 File Offset: 0x00258204
		public int WorkbenchStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkbenchStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<WorkbenchStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x0025A018 File Offset: 0x00258218
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x0025A02C File Offset: 0x0025822C
		public int PianoStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<PianoStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<PianoStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x0025A040 File Offset: 0x00258240
		// (set) Token: 0x0600469B RID: 18075 RVA: 0x0025A054 File Offset: 0x00258254
		public int BookcaseStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<BookcaseStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<BookcaseStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x0025A068 File Offset: 0x00258268
		// (set) Token: 0x0600469D RID: 18077 RVA: 0x0025A07C File Offset: 0x0025827C
		public int ChairStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<ChairStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<ChairStyle>k__BackingField = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x0025A090 File Offset: 0x00258290
		// (set) Token: 0x0600469F RID: 18079 RVA: 0x0025A0A4 File Offset: 0x002582A4
		public int ChestStyle
		{
			[CompilerGenerated]
			get
			{
				return this.<ChestStyle>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<ChestStyle>k__BackingField = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x0025A0B8 File Offset: 0x002582B8
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x0025A0CC File Offset: 0x002582CC
		public bool UsesContainers2
		{
			[CompilerGenerated]
			get
			{
				return this.<UsesContainers2>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x0025A0DC File Offset: 0x002582DC
		// (set) Token: 0x060046A3 RID: 18083 RVA: 0x0025A0F0 File Offset: 0x002582F0
		public ReadOnlyCollection<Rectangle> Rooms
		{
			[CompilerGenerated]
			get
			{
				return this.<Rooms>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Rooms>k__BackingField = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x0025A104 File Offset: 0x00258304
		public Rectangle TopRoom
		{
			get
			{
				/*
An exception occurred when decompiling this method (060046A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::get_TopRoom()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_0_06, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x0025A118 File Offset: 0x00258318
		public Rectangle BottomRoom
		{
			get
			{
				/*
An exception occurred when decompiling this method (060046A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::get_BottomRoom()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_0_06, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x0025A12C File Offset: 0x0025832C
		private UnifiedRandom _random
		{
			get
			{
				if (!true)
				{
				}
				return WorldGen.genRand;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x0025A144 File Offset: 0x00258344
		private TileData _tiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (060046A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.TileData Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::get__tiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x060046A8 RID: 18088 RVA: 0x0025A154 File Offset: 0x00258354
		private HouseBuilder()
		{
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x0025A168 File Offset: 0x00258368
		protected HouseBuilder(HouseType type, IEnumerable<Rectangle> rooms)
		{
			this.Type = type;
			this.IsValid = true;
			if (type == HouseType.Wood)
			{
			}
			this.Rooms = rooms;
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0025A194 File Offset: 0x00258394
		protected virtual void AgeRoom(Rectangle room)
		{
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x0025A1A4 File Offset: 0x002583A4
		public virtual void Place(HouseBuilderContext context, StructureMap structures)
		{
			this.PlaceEmptyRooms();
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x0025A254 File Offset: 0x00258454
		private void PlaceEmptyRooms()
		{
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0025A2EC File Offset: 0x002584EC
		private void FillRooms()
		{
			int num = 469;
			if (num != 0)
			{
			}
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x0025A47C File Offset: 0x0025867C
		private void PlaceStairs()
		{
			List<Tuple<Point, Point>> list = this.CreateStairsList();
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x0025A524 File Offset: 0x00258724
		private List<Tuple<Point, Point>> CreateStairsList()
		{
			/*
An exception occurred when decompiling this method (060046AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Tuple`2<Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point>> Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::CreateStairsList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_0_06, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_2_0F, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_3_16, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
	stloc:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(var_4_1D, ldfld:class [mscorlib]System.Collections.ObjectModel.ReadOnlyCollection`1<valuetype Microsoft.Xna.Framework.Rectangle>(HouseBuilder::<Rooms>k__BackingField, ldloc:HouseBuilder(this)))
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

		// Token: 0x060046B0 RID: 18096 RVA: 0x0025A550 File Offset: 0x00258750
		private void PlaceDoors()
		{
			List<Point> list = this.CreateDoorList();
			int num = this.<DoorStyle>k__BackingField;
			if (!true)
			{
			}
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x0025A588 File Offset: 0x00258788
		private List<Point> CreateDoorList()
		{
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
			return 0;
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x0025A5CC File Offset: 0x002587CC
		private void PlacePlatforms()
		{
			List<Point> list = this.CreatePlatformsList();
			int num = this.<PlatformStyle>k__BackingField;
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x0025A61C File Offset: 0x0025881C
		private List<Point> CreatePlatformsList()
		{
			/*
An exception occurred when decompiling this method (060046B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Microsoft.Xna.Framework.Point> Terraria.GameContent.Biomes.CaveHouse.HouseBuilder::CreatePlatformsList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:int32(var_5_1C, ldfld:int32(Rectangle::Width, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_2_0F)))
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

		// Token: 0x060046B4 RID: 18100 RVA: 0x0025A648 File Offset: 0x00258848
		private void PlaceSupportBeams()
		{
			List<Rectangle> list = this.CreateSupportBeamList();
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			ushort num = this.<BeamType>k__BackingField;
			if (!true)
			{
			}
			long num2 = 0L;
			Tile tile2;
			tile2.slope((byte)num2);
			long num3 = 0L;
			tile2.halfBrick(num3 != 0L);
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x0025A6CC File Offset: 0x002588CC
		private List<Rectangle> CreateSupportBeamList()
		{
			int num = 1;
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			ReadOnlyCollection<Rectangle> readOnlyCollection2 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection3 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection4 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection5 = this.<Rooms>k__BackingField;
			int num2 = 50;
			ReadOnlyCollection<Rectangle> readOnlyCollection6 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection7 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection8 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection9 = this.<Rooms>k__BackingField;
			int num3 = Math.Min(num2, -1073741824);
			ReadOnlyCollection<Rectangle> readOnlyCollection10 = this.<Rooms>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection11 = this.<Rooms>k__BackingField;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0025A758 File Offset: 0x00258958
		private static bool FindVerticalExit(Rectangle wall, bool isUp, [Out] int exitX)
		{
			int num = 3;
			int num2 = 5;
			GenCondition genCondition2;
			GenCondition genCondition = genCondition2.AreaOr(num, num2);
			if (genCondition == null || genCondition != null)
			{
				bool flag;
				return flag;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x0025A788 File Offset: 0x00258988
		private static bool FindSideExit(Rectangle wall, bool isLeft, [Out] int exitY)
		{
			int num = 4;
			int num2 = 3;
			GenCondition genCondition2;
			GenCondition genCondition = genCondition2.AreaOr(num, num2);
			if (genCondition == null || genCondition != null)
			{
				bool flag;
				return flag;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x0025A7B8 File Offset: 0x002589B8
		private void PlaceChests()
		{
			UnifiedRandom unifiedRandom;
			double num = unifiedRandom.NextDouble();
			double num2 = this.<ChestChance>k__BackingField;
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x0025AA38 File Offset: 0x00258C38
		private void PlaceBiomeSpecificPriorityTool(HouseBuilderContext context)
		{
			if (this.Type == HouseType.Wood)
			{
			}
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x0025AB58 File Offset: 0x00258D58
		private void PlaceBiomeSpecificTool(HouseBuilderContext context)
		{
			HouseType type = this.Type;
			int sharpenerCount = context.SharpenerCount;
			int num = 2;
			int num2 = 5;
			UnifiedRandom unifiedRandom;
			int num3 = unifiedRandom.Next(num, num2);
			ReadOnlyCollection<Rectangle> readOnlyCollection = this.<Rooms>k__BackingField;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x0025ACD0 File Offset: 0x00258ED0
		// Note: this type is marked as 'beforefieldinit'.
		static HouseBuilder()
		{
		}

		// Token: 0x04008292 RID: 33426
		private const int VERTICAL_EXIT_WIDTH = 3;

		// Token: 0x04008293 RID: 33427
		public static readonly HouseBuilder Invalid;

		// Token: 0x04008294 RID: 33428
		public readonly HouseType Type;

		// Token: 0x04008295 RID: 33429
		public readonly bool IsValid;

		// Token: 0x04008296 RID: 33430
		[CompilerGenerated]
		private double <ChestChance>k__BackingField;

		// Token: 0x04008297 RID: 33431
		[CompilerGenerated]
		private ushort <TileType>k__BackingField;

		// Token: 0x04008298 RID: 33432
		[CompilerGenerated]
		private ushort <WallType>k__BackingField;

		// Token: 0x04008299 RID: 33433
		[CompilerGenerated]
		private ushort <BeamType>k__BackingField;

		// Token: 0x0400829A RID: 33434
		[CompilerGenerated]
		private int <PlatformStyle>k__BackingField;

		// Token: 0x0400829B RID: 33435
		[CompilerGenerated]
		private int <DoorStyle>k__BackingField;

		// Token: 0x0400829C RID: 33436
		[CompilerGenerated]
		private int <TableStyle>k__BackingField;

		// Token: 0x0400829D RID: 33437
		[CompilerGenerated]
		private bool <UsesTables2>k__BackingField;

		// Token: 0x0400829E RID: 33438
		[CompilerGenerated]
		private int <WorkbenchStyle>k__BackingField;

		// Token: 0x0400829F RID: 33439
		[CompilerGenerated]
		private int <PianoStyle>k__BackingField;

		// Token: 0x040082A0 RID: 33440
		[CompilerGenerated]
		private int <BookcaseStyle>k__BackingField;

		// Token: 0x040082A1 RID: 33441
		[CompilerGenerated]
		private int <ChairStyle>k__BackingField;

		// Token: 0x040082A2 RID: 33442
		[CompilerGenerated]
		private int <ChestStyle>k__BackingField;

		// Token: 0x040082A3 RID: 33443
		[CompilerGenerated]
		private bool <UsesContainers2>k__BackingField;

		// Token: 0x040082A4 RID: 33444
		[CompilerGenerated]
		private ReadOnlyCollection<Rectangle> <Rooms>k__BackingField;

		// Token: 0x040082A5 RID: 33445
		protected ushort[] SkipTilesDuringWallAging;

		// Token: 0x0200090E RID: 2318
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060046BC RID: 18108 RVA: 0x0025ACE0 File Offset: 0x00258EE0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060046BD RID: 18109 RVA: 0x0025ACF0 File Offset: 0x00258EF0
			public <>c()
			{
			}

			// Token: 0x060046BE RID: 18110 RVA: 0x0025AD04 File Offset: 0x00258F04
			internal int <.ctor>b__74_0(Rectangle lhs, Rectangle rhs)
			{
				int num;
				return num;
			}

			// Token: 0x060046BF RID: 18111 RVA: 0x000021DB File Offset: 0x000003DB
			internal int <CreateSupportBeamList>b__86_0(Rectangle room)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060046C0 RID: 18112 RVA: 0x0025AD14 File Offset: 0x00258F14
			internal int <CreateSupportBeamList>b__86_1(Rectangle room)
			{
				int num;
				return num;
			}

			// Token: 0x040082A6 RID: 33446
			public static readonly HouseBuilder.<>c <>9;

			// Token: 0x040082A7 RID: 33447
			public static Comparison<Rectangle> <>9__74_0;

			// Token: 0x040082A8 RID: 33448
			public static Func<Rectangle, int> <>9__86_0;

			// Token: 0x040082A9 RID: 33449
			public static Func<Rectangle, int> <>9__86_1;
		}
	}
}
