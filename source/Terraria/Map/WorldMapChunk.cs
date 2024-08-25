using System;
using System.Runtime.InteropServices;
using System.Threading;
using Ionic.Zlib;
using UnityEngine;

namespace Terraria.Map
{
	// Token: 0x020006C2 RID: 1730
	public class WorldMapChunk
	{
		// Token: 0x0600393E RID: 14654 RVA: 0x0022CEDC File Offset: 0x0022B0DC
		public unsafe WorldMapChunk(WorldMap map, byte* compressedData)
		{
			this.Map = map;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x0022CEF8 File Offset: 0x0022B0F8
		public bool Loaded
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600393F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Map.WorldMapChunk::get_Loaded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Terraria.Map.MapTile*(var_0_06, ldfld:valuetype Terraria.Map.MapTile*(WorldMapChunk::TileData, ldloc:WorldMapChunk(this)))
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

		// Token: 0x06003940 RID: 14656 RVA: 0x0022CF0C File Offset: 0x0022B10C
		public void SaveCompressed()
		{
			if (this.TileData != null)
			{
				bool flag = this.dirty;
				if (!flag || !flag)
				{
				}
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0022CF30 File Offset: 0x0022B130
		public unsafe void LoadTiles(bool utilLoad = false)
		{
			long num = 0L;
			Monitor.Enter(this, utilLoad);
			MapTile* tileData = this.TileData;
			if (tileData != null)
			{
				return;
			}
			MapTile* tileStorage = this.Map.GetTileStorage(this, num != 0L);
			long compressedDataLength = this.CompressedDataLength;
			this.TileData = tileStorage;
			if (compressedDataLength != 0L)
			{
				byte[] compressedData = this.CompressedData;
				if (tileData == null)
				{
				}
				return;
			}
			if (tileData == null)
			{
			}
			long num2 = 0L;
			if (tileData != null)
			{
				Monitor.Exit(this);
			}
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0022CFBC File Offset: 0x0022B1BC
		public unsafe void Reset()
		{
			MapTile* tileData = this.TileData;
			if (tileData != null)
			{
				this.Map.ReleaseTileStorage(this);
				long num = 0L;
				if (tileData != null)
				{
					Monitor.Exit(this);
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0022D00C File Offset: 0x0022B20C
		public unsafe void Compress(byte* srcData, long srcLength, [Out] long resultLength)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			byte[] compressedData = this.CompressedData;
			int num2;
			byte[] compressedData3;
			long num3;
			if (num2 == 0)
			{
				resultLength.m_value = compressedData;
				if (num2 == 0)
				{
					byte[] compressedData2 = this.CompressedData;
					if (compressedData == null)
					{
					}
					Debug.LogWarning("Failed resizing buffer");
					compressedData3 = this.CompressedData;
					return;
				}
			}
			else
			{
				if (compressedData3 == null)
				{
				}
				Debug.LogError("Failed");
				num3 = 0L;
			}
			if (compressedData3 != null)
			{
			}
			if (num3 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0022D09C File Offset: 0x0022B29C
		public unsafe void Decompress(byte[] srcData, long srcLength, byte* dstData, long dstLength, [Out] long resultLength)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int x = this.X;
			if (this.Y == 0)
			{
			}
			string text;
			Debug.LogError(text);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0022D124 File Offset: 0x0022B324
		// Note: this type is marked as 'beforefieldinit'.
		static WorldMapChunk()
		{
		}

		// Token: 0x040079C4 RID: 31172
		public const int InitialChunkCompressedSize = 2048;

		// Token: 0x040079C5 RID: 31173
		public const int MapChunkSize = 64;

		// Token: 0x040079C6 RID: 31174
		public static int MapChunkTileSize;

		// Token: 0x040079C7 RID: 31175
		private readonly WorldMap Map;

		// Token: 0x040079C8 RID: 31176
		public unsafe MapTile* TileData;

		// Token: 0x040079C9 RID: 31177
		public byte[] CompressedData;

		// Token: 0x040079CA RID: 31178
		public long CompressedDataLength;

		// Token: 0x040079CB RID: 31179
		public DateTime LastUsed;

		// Token: 0x040079CC RID: 31180
		public int X;

		// Token: 0x040079CD RID: 31181
		public int Y;

		// Token: 0x040079CE RID: 31182
		public bool dirty;

		// Token: 0x040079CF RID: 31183
		public int frameAge;

		// Token: 0x040079D0 RID: 31184
		public int referenceCount;

		// Token: 0x040079D1 RID: 31185
		private static byte[] ClearData;

		// Token: 0x040079D2 RID: 31186
		private static byte[] resetData;

		// Token: 0x040079D3 RID: 31187
		private static byte[] CopyBuffer;

		// Token: 0x040079D4 RID: 31188
		private static byte[] CompressBuffer;

		// Token: 0x040079D5 RID: 31189
		private static byte[] BlockBuffer;

		// Token: 0x040079D6 RID: 31190
		private static ZlibCodec zlibCompress;

		// Token: 0x040079D7 RID: 31191
		private static ZlibCodec zlibDecompress;

		// Token: 0x040079D8 RID: 31192
		private static long biggestChunk;
	}
}
