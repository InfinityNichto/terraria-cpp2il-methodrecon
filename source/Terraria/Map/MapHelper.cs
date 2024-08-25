using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Ionic.Zlib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.Map
{
	// Token: 0x020006B3 RID: 1715
	public static class MapHelper
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x000021DB File Offset: 0x000003DB
		private static object IOLock
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00226A6C File Offset: 0x00224C6C
		public static void Initialize()
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0022B818 File Offset: 0x00229A18
		public static void ResetMapData()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0022B828 File Offset: 0x00229A28
		public static bool HasOption(int tileType, int option)
		{
			/*
An exception occurred when decompiling this method (060038EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Map.MapHelper::HasOption(System.Int32,System.Int32)

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

		// Token: 0x060038F0 RID: 14576 RVA: 0x0022B838 File Offset: 0x00229A38
		public static int TileToLookup(int tileType, int option)
		{
			/*
An exception occurred when decompiling this method (060038F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Map.MapHelper::TileToLookup(System.Int32,System.Int32)

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

		// Token: 0x060038F1 RID: 14577 RVA: 0x0022B848 File Offset: 0x00229A48
		public static int LookupCount()
		{
			/*
An exception occurred when decompiling this method (060038F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Map.MapHelper::LookupCount()

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

		// Token: 0x060038F2 RID: 14578 RVA: 0x0022B858 File Offset: 0x00229A58
		public static void MapColor(ushort type, Color oldColor, byte colorType)
		{
			if (!true)
			{
			}
			Color color = WorldGen.paintColor((int)colorType);
			byte r = oldColor.R;
			byte g = oldColor.G;
			byte b = oldColor.B;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0022B8F8 File Offset: 0x00229AF8
		public static Color GetMapTileXnaColor(MapTile tile)
		{
			/*
An exception occurred when decompiling this method (060038F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Map.MapHelper::GetMapTileXnaColor(Terraria.Map.MapTile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint8(var_0_09, callgetter:uint8(MapTile::get_Color, ldloc:MapTile[exp:valuetype Terraria.Map.MapTile&](tile)))
	stloc:uint8(var_1_10, ldfld:uint8(MapTile::Light, ldloc:MapTile[exp:valuetype Terraria.Map.MapTile&](tile)))
	brtrue(IL_0000, ldc.i4:int32[exp:bool](17279))
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

		// Token: 0x060038F4 RID: 14580 RVA: 0x0022B91C File Offset: 0x00229B1C
		public static MapTile CreateMapTile(int i, int j, byte Light)
		{
			if (!true)
			{
			}
			WorldMap map = Main.Map;
			int num = 100;
			int underworldLayer = Main.UnderworldLayer;
			Rectangle scanRegion = Lighting.GetScanRegion();
			int num2;
			int num3;
			if (num == 0 && num == 0)
			{
				num2 = 255;
				SceneMetrics sceneMetrics = Main.SceneMetrics;
				int <SnowTileCount>k__BackingField = sceneMetrics.<SnowTileCount>k__BackingField;
				int <HoneyBlockCount>k__BackingField = sceneMetrics.<HoneyBlockCount>k__BackingField;
				if (17279 == 0)
				{
				}
				bool flag = WorldGen.IsThisAMushroomTree(<SnowTileCount>k__BackingField, 0);
				num3 = 1;
				if (num != 0)
				{
					goto IL_0098;
				}
				if (num == 0)
				{
					if (num != 0 || num != 0)
					{
						goto IL_0098;
					}
					while (num == 0)
					{
					}
				}
			}
			if (num3 == 0)
			{
			}
			long num4 = 0L;
			IL_0098:
			byte b;
			return MapTile.Create((ushort)b, (byte)num2, (byte)num4);
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0022B9E8 File Offset: 0x00229BE8
		public static void GetTileBaseOption(int x, int y, int tileType, Tile tileCache, int baseOption)
		{
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0022BAF4 File Offset: 0x00229CF4
		public static void GetTileBaseOption(int y, ushort tileType, int frameX, int frameY, int baseOption)
		{
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x0022BBE4 File Offset: 0x00229DE4
		public static void SaveMap(bool forceSave = false)
		{
			if (!true)
			{
			}
			if (Main.ActivePlayerFileData._isCloudSave)
			{
			}
			bool mapEnabled = Main.mapEnabled;
			Thread.Sleep(0);
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0022BC6C File Offset: 0x00229E6C
		private static void InternalSaveMapCompressed()
		{
			if (!true)
			{
			}
			bool isCloudSave = Main.ActivePlayerFileData._isCloudSave;
			string playerPathName = Main.playerPathName;
			int stringLength = Main.playerPathName._stringLength;
			string text;
			if (!isCloudSave)
			{
				if (stringLength == 0)
				{
				}
				FileUtilities.CreateDirectory(text);
			}
			if (stringLength == 0)
			{
			}
			string text3;
			string text2 = text + text3;
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0022BEA8 File Offset: 0x0022A0A8
		private static void InternalSaveMap()
		{
			if (!true)
			{
			}
			bool isCloudSave = Main.ActivePlayerFileData._isCloudSave;
			string playerPathName = Main.playerPathName;
			int stringLength = Main.playerPathName._stringLength;
			string text;
			if (!isCloudSave)
			{
				if (stringLength == 0)
				{
				}
				FileUtilities.CreateDirectory(text);
			}
			if (stringLength == 0)
			{
			}
			string text3;
			string text2 = text + text3;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x0022C114 File Offset: 0x0022A314
		private static void LoadMapHeader(BinaryReader fileIO)
		{
			Main.MapFileMetadata = FileMetadata.Read(fileIO, FileType.Map);
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x0022C130 File Offset: 0x0022A330
		private static void ReadRunLengthEncodingData(MapHelper.RunLengthEncodingCompressionProfile compressionProfile, DeflateStream deflateStream, Action<int, int, uint> dataRead)
		{
			int num = 8;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 32768;
			string text2;
			string text = text2 + " " + text2 + "%";
			if (num2 == 0)
			{
			}
			uint bitCountPerValue = compressionProfile.BitCountPerValue;
			uint num3;
			if (num3 != 0U)
			{
				uint bitCountForRunLengths = compressionProfile.BitCountForRunLengths;
				uint num4;
				if (num4 != 0U)
				{
				}
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0022C184 File Offset: 0x0022A384
		public static void LoadMapWithUltraCompression(MemoryStream wholeStream, bool isLocalMap)
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0022C1E4 File Offset: 0x0022A3E4
		public static void LoadMapVersion1(BinaryReader fileIO, int release)
		{
			string text;
			if (text == null)
			{
			}
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0022C270 File Offset: 0x0022A470
		public static void LoadMapVersion2(BinaryReader fileIO, int release)
		{
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0022C324 File Offset: 0x0022A524
		public static void LoadMapVersionCompressed(BinaryReader fileIO, int release)
		{
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x0022C440 File Offset: 0x0022A640
		// Note: this type is marked as 'beforefieldinit'.
		static MapHelper()
		{
		}

		// Token: 0x04007968 RID: 31080
		public static int maxUpdateTile;

		// Token: 0x04007969 RID: 31081
		public static int numUpdateTile;

		// Token: 0x0400796A RID: 31082
		public static short[] updateTileX;

		// Token: 0x0400796B RID: 31083
		public static short[] updateTileY;

		// Token: 0x0400796C RID: 31084
		public static bool noStatusText;

		// Token: 0x0400796D RID: 31085
		public const int drawLoopMilliseconds = 5;

		// Token: 0x0400796E RID: 31086
		public const int drawMapLoadingLoopMilliseconds = 30;

		// Token: 0x0400796F RID: 31087
		private const int HeaderEmpty = 0;

		// Token: 0x04007970 RID: 31088
		private const int HeaderTile = 1;

		// Token: 0x04007971 RID: 31089
		private const int HeaderWall = 2;

		// Token: 0x04007972 RID: 31090
		private const int HeaderWater = 3;

		// Token: 0x04007973 RID: 31091
		private const int HeaderLava = 4;

		// Token: 0x04007974 RID: 31092
		private const int HeaderHoney = 5;

		// Token: 0x04007975 RID: 31093
		private const int HeaderHeavenAndHell = 6;

		// Token: 0x04007976 RID: 31094
		private const int HeaderBackground = 7;

		// Token: 0x04007977 RID: 31095
		private const int Header2_ReadHeader3Bit = 1;

		// Token: 0x04007978 RID: 31096
		private const int Header2Color1 = 2;

		// Token: 0x04007979 RID: 31097
		private const int Header2Color2 = 4;

		// Token: 0x0400797A RID: 31098
		private const int Header2Color3 = 8;

		// Token: 0x0400797B RID: 31099
		private const int Header2Color4 = 16;

		// Token: 0x0400797C RID: 31100
		private const int Header2Color5 = 32;

		// Token: 0x0400797D RID: 31101
		private const int Header2ShimmerBit = 64;

		// Token: 0x0400797E RID: 31102
		private const int Header2_UnusedBit8 = 128;

		// Token: 0x0400797F RID: 31103
		private const int Header3_ReservedForHeader4Bit = 1;

		// Token: 0x04007980 RID: 31104
		private const int Header3_UnusudBit2 = 2;

		// Token: 0x04007981 RID: 31105
		private const int Header3_UnusudBit3 = 4;

		// Token: 0x04007982 RID: 31106
		private const int Header3_UnusudBit4 = 8;

		// Token: 0x04007983 RID: 31107
		private const int Header3_UnusudBit5 = 16;

		// Token: 0x04007984 RID: 31108
		private const int Header3_UnusudBit6 = 32;

		// Token: 0x04007985 RID: 31109
		private const int Header3_UnusudBit7 = 64;

		// Token: 0x04007986 RID: 31110
		private const int Header3_UnusudBit8 = 128;

		// Token: 0x04007987 RID: 31111
		public const int maxTileOptions = 12;

		// Token: 0x04007988 RID: 31112
		public const int maxWallOptions = 2;

		// Token: 0x04007989 RID: 31113
		public const int maxLiquidTypes = 4;

		// Token: 0x0400798A RID: 31114
		public const int maxSkyGradients = 256;

		// Token: 0x0400798B RID: 31115
		public const int maxDirtGradients = 256;

		// Token: 0x0400798C RID: 31116
		public const int maxRockGradients = 256;

		// Token: 0x0400798D RID: 31117
		public static int[] tileOptionCounts;

		// Token: 0x0400798E RID: 31118
		public static int[] wallOptionCounts;

		// Token: 0x0400798F RID: 31119
		public static ushort[] tileLookup;

		// Token: 0x04007990 RID: 31120
		public static ushort[] wallLookup;

		// Token: 0x04007991 RID: 31121
		private static ushort tilePosition;

		// Token: 0x04007992 RID: 31122
		public static ushort wallPosition;

		// Token: 0x04007993 RID: 31123
		public static ushort liquidPosition;

		// Token: 0x04007994 RID: 31124
		public static ushort skyPosition;

		// Token: 0x04007995 RID: 31125
		public static ushort dirtPosition;

		// Token: 0x04007996 RID: 31126
		public static ushort rockPosition;

		// Token: 0x04007997 RID: 31127
		public static ushort hellPosition;

		// Token: 0x04007998 RID: 31128
		public static Color[] colorLookup;

		// Token: 0x04007999 RID: 31129
		public static Dictionary<ushort, bool> snowLookup;

		// Token: 0x0400799A RID: 31130
		private static ushort wallRangeStart;

		// Token: 0x0400799B RID: 31131
		private static ushort wallRangeEnd;

		// Token: 0x020006B4 RID: 1716
		private class RunLengthEncodingCompressionProfile
		{
			// Token: 0x06003901 RID: 14593 RVA: 0x0022C450 File Offset: 0x0022A650
			public RunLengthEncodingCompressionProfile(uint numBitsPerValue, uint bitCountForRunLengths)
			{
				int num = 1;
				base..ctor();
				this.BitCountPerValue = numBitsPerValue;
				this.MinRepeatsToUseRunLengthEncoding = bitCountForRunLengths;
				this.MinRepeatsToUseRunLengthEncoding = (uint)num;
				if (num == 0)
				{
				}
				uint bitCountForRunLengths2 = this.BitCountForRunLengths;
				this.MaxCompressedValue = (uint)num;
				this.MaxRunLengthRepeatValue = (uint)num;
			}

			// Token: 0x0400799C RID: 31132
			public readonly uint BitCountPerValue;

			// Token: 0x0400799D RID: 31133
			public readonly uint BitCountForRunLengths;

			// Token: 0x0400799E RID: 31134
			public readonly uint MinRepeatsToUseRunLengthEncoding;

			// Token: 0x0400799F RID: 31135
			public readonly uint MaxCompressedValue;

			// Token: 0x040079A0 RID: 31136
			public readonly uint MaxRunLengthRepeatValue;
		}

		// Token: 0x020006B5 RID: 1717
		private struct OldMapHelper
		{
			// Token: 0x06003902 RID: 14594 RVA: 0x000021DB File Offset: 0x000003DB
			public bool active()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003903 RID: 14595 RVA: 0x000021DB File Offset: 0x000003DB
			public bool water()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003904 RID: 14596 RVA: 0x000021DB File Offset: 0x000003DB
			public bool lava()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003905 RID: 14597 RVA: 0x0022C498 File Offset: 0x0022A698
			public bool honey()
			{
				/*
An exception occurred when decompiling this method (06003905)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Map.MapHelper/OldMapHelper::honey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(OldMapHelper::misc2, ldloc:valuetype Terraria.Map.MapHelper/OldMapHelper&(this)))
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

			// Token: 0x06003906 RID: 14598 RVA: 0x000021DB File Offset: 0x000003DB
			public bool changed()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x000021DB File Offset: 0x000003DB
			public bool wall()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x0022C4AC File Offset: 0x0022A6AC
			public byte option()
			{
				/*
An exception occurred when decompiling this method (06003908)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Terraria.Map.MapHelper/OldMapHelper::option()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(OldMapHelper::misc2, ldloc:valuetype Terraria.Map.MapHelper/OldMapHelper&(this)))
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

			// Token: 0x06003909 RID: 14601 RVA: 0x0022C4C0 File Offset: 0x0022A6C0
			public byte color()
			{
				/*
An exception occurred when decompiling this method (06003909)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Terraria.Map.MapHelper/OldMapHelper::color()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(OldMapHelper::misc2, ldloc:valuetype Terraria.Map.MapHelper/OldMapHelper&(this)))
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

			// Token: 0x040079A1 RID: 31137
			public byte misc;

			// Token: 0x040079A2 RID: 31138
			public byte misc2;
		}

		// Token: 0x020006B6 RID: 1718
		public class BitReader
		{
			// Token: 0x0600390A RID: 14602 RVA: 0x0022C4D4 File Offset: 0x0022A6D4
			public BitReader(Stream input)
			{
				this.InnerStream = input;
				this.CurBit = 8U;
			}

			// Token: 0x0600390B RID: 14603 RVA: 0x0022C4F8 File Offset: 0x0022A6F8
			public uint Read(uint bitCount)
			{
				/*
An exception occurred when decompiling this method (0600390B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Terraria.Map.MapHelper/BitReader::Read(System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_1_0B, ldfld:uint32(BitReader::CurBit, ldloc:BitReader(this)))
	stloc:Stream(var_2_12, ldfld:Stream(BitReader::InnerStream, ldloc:BitReader(this)))
	stloc:int64(var_3_14, ldc.i4:int64(0))
	stfld:uint8(BitReader::CurByteOfData, ldloc:BitReader(this), ldloc:Stream[exp:uint8](var_2_12))
	stloc:uint32(var_4_24, call:uint32(Math::Min, conv.u4:uint32(ldc.i4:int32[exp:uint32](0)), ldloc:uint32(bitCount)))
	stloc:uint32(var_5_2C, ldfld:uint32(BitReader::CurBit, ldloc:BitReader(this)))
	stloc:uint8(var_6_34, ldfld:uint8(BitReader::CurByteOfData, ldloc:BitReader(this)))
	stfld:uint32(BitReader::CurBit, ldloc:BitReader(this), ldloc:int64[exp:uint32](var_3_14))
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

			// Token: 0x040079A3 RID: 31139
			private readonly Stream InnerStream;

			// Token: 0x040079A4 RID: 31140
			private byte CurByteOfData;

			// Token: 0x040079A5 RID: 31141
			private uint CurBit;
		}

		// Token: 0x020006B7 RID: 1719
		[CompilerGenerated]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x0600390C RID: 14604 RVA: 0x0022C544 File Offset: 0x0022A744
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x0600390D RID: 14605 RVA: 0x0022C558 File Offset: 0x0022A758
			internal void <LoadMapWithUltraCompression>b__0(int x, int y, uint compressedLightValue)
			{
				MapHelper.RunLengthEncodingCompressionProfile runLengthEncodingCompressionProfile = this.lightCompressionProfile;
				uint maxCompressedValue = runLengthEncodingCompressionProfile.MaxCompressedValue;
				if (runLengthEncodingCompressionProfile == null)
				{
				}
				bool flag = Main.Map.UpdateLighting(x, y, (byte)compressedLightValue);
			}

			// Token: 0x040079A6 RID: 31142
			public MapHelper.RunLengthEncodingCompressionProfile lightCompressionProfile;
		}
	}
}
