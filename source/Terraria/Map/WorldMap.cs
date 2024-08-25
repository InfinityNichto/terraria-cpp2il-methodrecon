using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.IO;

namespace Terraria.Map
{
	// Token: 0x020006C1 RID: 1729
	public class WorldMap
	{
		// Token: 0x0600392A RID: 14634 RVA: 0x0022C9FC File Offset: 0x0022ABFC
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, [Out] WorldMapChunk chunk)
		{
			for (;;)
			{
				int maxChunkWidth = this.MaxChunkWidth;
				WorldMapChunk[] chunks = this._chunks;
				byte[] compressedData = chunks.CompressedData;
				if (chunks == null)
				{
					return;
				}
			}
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x0022CA24 File Offset: 0x0022AC24
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, bool utilLoad, [Out] WorldMapChunk chunk)
		{
			/*
An exception occurred when decompiling this method (0600392B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Map.MapTile* Terraria.Map.WorldMap::GetChunkTile(System.Int32,System.Int32,System.Boolean,Terraria.Map.WorldMapChunk)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(WorldMap::MaxChunkWidth, ldloc:WorldMap(this)))
	stloc:class Terraria.Map.WorldMapChunk[](var_1_0D, ldfld:class Terraria.Map.WorldMapChunk[](WorldMap::_chunks, ldloc:WorldMap(this)))
	stloc:uint8[](var_2_14, ldfld:uint8[](WorldMapChunk::CompressedData, ldloc:class Terraria.Map.WorldMapChunk[][exp:WorldMapChunk](var_1_0D)))
	brtrue(IL_0000, ldloc:class Terraria.Map.WorldMapChunk[][exp:bool](var_1_0D))
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

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x0022CA48 File Offset: 0x0022AC48
		public int NumChunksAvailable
		{
			get
			{
				object lockObject = this.LockObject;
				List<IntPtr> tileChunksAvailable = this.TileChunksAvailable;
				long num = 0L;
				int size = tileChunksAvailable._size;
				if (size != 0)
				{
					Monitor.Exit(lockObject);
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000021DB File Offset: 0x000003DB
		public void UnloadChunk()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x000021DB File Offset: 0x000003DB
		public unsafe MapTile* GetTileStorage(WorldMapChunk chunk, bool utilLoad = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x000021DB File Offset: 0x000003DB
		public void ReleaseTileStorage(WorldMapChunk chunk)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x0022CA9C File Offset: 0x0022AC9C
		public void UpdateChunks()
		{
			if (!true)
			{
			}
			WorldGen.PerformCachedMapTileUpdates();
			object lockObject = this.LockObject;
			List<WorldMapChunk> tileChunksInUse = this.TileChunksInUse;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x000021DB File Offset: 0x000003DB
		public void Allocate(int maxWidth, int maxHeight)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0022CB2C File Offset: 0x0022AD2C
		public unsafe void ConsumeUpdate(int x, int y)
		{
			MapTile* ptr;
			byte extraData = ptr->_extraData;
			ptr->_extraData = extraData;
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0022CB48 File Offset: 0x0022AD48
		public unsafe void Update(int x, int y, byte light)
		{
			MapTile mapTile = MapHelper.CreateMapTile(x, y, light);
			MapTile* ptr;
			ptr->Type = mapTile;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0022CB68 File Offset: 0x0022AD68
		public void SetTile(int x, int y, MapTile tile)
		{
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0022CB78 File Offset: 0x0022AD78
		public bool IsRevealed(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06003935)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Map.WorldMap::IsRevealed(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_1_06, ldfld:uint8(MapTile::Light, ldloc:valuetype Terraria.Map.MapTile*[exp:valuetype Terraria.Map.MapTile&](var_0)))
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

		// Token: 0x06003936 RID: 14646 RVA: 0x0022CB8C File Offset: 0x0022AD8C
		public unsafe bool UpdateLighting(int x, int y, byte light)
		{
			MapTile* ptr;
			byte b = Math.Max(ptr->Light, light);
			MapTile mapTile = MapHelper.CreateMapTile(x, y, b);
			byte light2 = ptr->Light;
			byte extraData = ptr->_extraData;
			ptr->Type = mapTile;
			return true;
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0022CBCC File Offset: 0x0022ADCC
		public unsafe bool UpdateType(int x, int y)
		{
			MapTile* ptr;
			byte light = ptr->Light;
			if (!true)
			{
			}
			MapTile mapTile = MapHelper.CreateMapTile(x, y, light);
			byte light2 = ptr->Light;
			byte extraData = ptr->_extraData;
			ptr->Type = mapTile;
			return true;
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x0022CC08 File Offset: 0x0022AE08
		public void UnlockMapSection(int sectionX, int sectionY)
		{
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x0022CC18 File Offset: 0x0022AE18
		public void Load()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Lighting.Clear();
			if (num == 0)
			{
			}
			FileMetadata fileMetadata;
			Main.MapFileMetadata = fileMetadata;
			Main.clearMap = true;
			Main.loadMap = true;
			Main.loadMapLock = true;
			Main.refreshMap = false;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0022CDE8 File Offset: 0x0022AFE8
		public void Save(bool forceSave = false)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			MapHelper.SaveMap(true);
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0022CE04 File Offset: 0x0022B004
		public void Clear()
		{
			int maxChunkHeight = this.MaxChunkHeight;
			int maxChunkWidth = this.MaxChunkWidth;
			WorldMapChunk[] chunks = this._chunks;
			int maxChunkWidth2 = this.MaxChunkWidth;
			int maxChunkHeight2 = this.MaxChunkHeight;
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x0022CE3C File Offset: 0x0022B03C
		public void ClearEdges()
		{
			int maxWidth = this.MaxWidth;
			int maxWidth2 = this.MaxWidth;
			int maxHeight = this.MaxHeight;
			int maxHeight2 = this.MaxHeight;
			int maxWidth3 = this.MaxWidth;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0022CEBC File Offset: 0x0022B0BC
		public WorldMap()
		{
		}

		// Token: 0x040079B7 RID: 31159
		public int MaxWidth;

		// Token: 0x040079B8 RID: 31160
		public int MaxHeight;

		// Token: 0x040079B9 RID: 31161
		public int MaxChunkWidth;

		// Token: 0x040079BA RID: 31162
		public int MaxChunkHeight;

		// Token: 0x040079BB RID: 31163
		public const int BlackEdgeWidth = 40;

		// Token: 0x040079BC RID: 31164
		public WorldMapChunk[] _chunks;

		// Token: 0x040079BD RID: 31165
		public int MaxChunkMapped = 320;

		// Token: 0x040079BE RID: 31166
		public const int ReservedForPlayer = 64;

		// Token: 0x040079BF RID: 31167
		private unsafe MapTile* TileData;

		// Token: 0x040079C0 RID: 31168
		private unsafe byte* TileCompressedData;

		// Token: 0x040079C1 RID: 31169
		public object LockObject;

		// Token: 0x040079C2 RID: 31170
		private List<IntPtr> TileChunksAvailable;

		// Token: 0x040079C3 RID: 31171
		private List<WorldMapChunk> TileChunksInUse;
	}
}
