using System;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x02000580 RID: 1408
	public class WorldFileData : FileData
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00203048 File Offset: 0x00201248
		public string SeedText
		{
			get
			{
				return this._seedText;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x0020305C File Offset: 0x0020125C
		public int Seed
		{
			get
			{
				return this._seed;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x00203070 File Offset: 0x00201270
		public string WorldSizeName
		{
			get
			{
				return this._worldSizeName.<Value>k__BackingField;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x00203088 File Offset: 0x00201288
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x0020309C File Offset: 0x0020129C
		public bool HasCrimson
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003454)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFileData::get_HasCrimson()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(WorldFileData::HasCorruption, ldloc:WorldFileData(this)))
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
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x002030AC File Offset: 0x002012AC
		public bool HasValidSeed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003456)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFileData::get_HasValidSeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(WorldFileData::WorldGeneratorVersion, ldloc:WorldFileData(this)))
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x002030C0 File Offset: 0x002012C0
		public bool UseGuidAsMapName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003457)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFileData::get_UseGuidAsMapName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint64(var_0_06, ldfld:uint64(WorldFileData::WorldGeneratorVersion, ldloc:WorldFileData(this)))
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

		// Token: 0x06003458 RID: 13400 RVA: 0x002030D4 File Offset: 0x002012D4
		public string GetWorldName(bool allowCropping = false)
		{
			return this.Name;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x002030E8 File Offset: 0x002012E8
		public string GetFullSeedText(bool allowCropping = false)
		{
			int worldSizeX = this.WorldSizeX;
			int worldSizeY = this.WorldSizeY;
			return "{0}.{1}.{2}.{3}";
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00203164 File Offset: 0x00201364
		public WorldFileData()
			: base("World")
		{
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00203198 File Offset: 0x00201398
		public WorldFileData(string path, bool cloudSave)
		{
			LocalizedText text = Language.GetText("UI.WorldSizeUnknown");
			this._worldSizeName = text;
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x002031D0 File Offset: 0x002013D0
		public override void SetAsActive()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x002031E0 File Offset: 0x002013E0
		public void SetWorldSize(int x, int y)
		{
			this.WorldSizeX = x;
			this.WorldGeneratorVersion = (ulong)y;
			LocalizedText localizedText;
			this._worldSizeName = localizedText;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00203204 File Offset: 0x00201404
		public static WorldFileData FromInvalidWorld(string path, bool cloudSave)
		{
			/*
An exception occurred when decompiling this method (0600345E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.IO.WorldFileData Terraria.IO.WorldFileData::FromInvalidWorld(System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:DateTime(var_3_11, callgetter:DateTime(DateTime::get_Now))
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

		// Token: 0x0600345F RID: 13407 RVA: 0x00203224 File Offset: 0x00201424
		public void SetSeedToEmpty()
		{
			this.SetSeed("");
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0020323C File Offset: 0x0020143C
		public void SetSeed(string seedText)
		{
			int num = 1;
			this._seedText = seedText;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00203260 File Offset: 0x00201460
		public void SetSeedToRandom()
		{
			int num;
			string text = num.ToString();
			this.SetSeed(text);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0020327C File Offset: 0x0020147C
		public override void MoveToCloud()
		{
			bool isCloudSave = this._isCloudSave;
			if (!isCloudSave)
			{
				string name = this.Name;
				if (!isCloudSave)
				{
				}
				string worldPathFromName = Main.GetWorldPathFromName(name, true);
				bool flag = FileUtilities.MoveToCloud(this._path, worldPathFromName);
				FavoritesFile localFavoriteData = Main.LocalFavoriteData;
				localFavoriteData.ClearEntry(this);
				this._isCloudSave = true;
				this._path = worldPathFromName;
				localFavoriteData.SaveFavorite(this);
				return;
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x002032DC File Offset: 0x002014DC
		public override void MoveToLocal()
		{
			bool isCloudSave = this._isCloudSave;
			if (isCloudSave)
			{
				string name = this.Name;
				if (!isCloudSave)
				{
				}
				long num = 0L;
				string worldPathFromName = Main.GetWorldPathFromName(name, num != 0L);
				bool flag = FileUtilities.MoveToLocal(this._path, worldPathFromName);
				this._path = worldPathFromName;
				Main.LocalFavoriteData.SaveFavorite(this);
				return;
			}
		}

		// Token: 0x04004131 RID: 16689
		public int _glitchFrameCounter;

		// Token: 0x04004132 RID: 16690
		public int _glitchFrame;

		// Token: 0x04004133 RID: 16691
		public int _glitchVariation;

		// Token: 0x04004134 RID: 16692
		private const ulong GUID_IN_WORLD_FILE_VERSION = 777389080577UL;

		// Token: 0x04004135 RID: 16693
		public bool CurrentSaveFormat;

		// Token: 0x04004136 RID: 16694
		public DateTime CreationTime;

		// Token: 0x04004137 RID: 16695
		public int WorldSizeX;

		// Token: 0x04004138 RID: 16696
		public int WorldSizeY;

		// Token: 0x04004139 RID: 16697
		public ulong WorldGeneratorVersion;

		// Token: 0x0400413A RID: 16698
		private string _seedText = "";

		// Token: 0x0400413B RID: 16699
		private int _seed;

		// Token: 0x0400413C RID: 16700
		public bool IsValid = true;

		// Token: 0x0400413D RID: 16701
		public Guid UniqueId;

		// Token: 0x0400413E RID: 16702
		public LocalizedText _worldSizeName;

		// Token: 0x0400413F RID: 16703
		public int GameMode;

		// Token: 0x04004140 RID: 16704
		public bool DrunkWorld;

		// Token: 0x04004141 RID: 16705
		public bool NotTheBees;

		// Token: 0x04004142 RID: 16706
		public bool ForTheWorthy;

		// Token: 0x04004143 RID: 16707
		public bool Anniversary;

		// Token: 0x04004144 RID: 16708
		public bool DontStarve;

		// Token: 0x04004145 RID: 16709
		public bool RemixWorld;

		// Token: 0x04004146 RID: 16710
		public bool NoTrapsWorld;

		// Token: 0x04004147 RID: 16711
		public bool ZenithWorld;

		// Token: 0x04004148 RID: 16712
		public bool HasCorruption = true;

		// Token: 0x04004149 RID: 16713
		public bool IsHardMode;

		// Token: 0x0400414A RID: 16714
		public bool DefeatedMoonlord;
	}
}
