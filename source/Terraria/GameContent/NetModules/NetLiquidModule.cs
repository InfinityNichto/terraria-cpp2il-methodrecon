using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x020009F0 RID: 2544
	public class NetLiquidModule : NetModule
	{
		// Token: 0x06004B5B RID: 19291 RVA: 0x0026EA8C File Offset: 0x0026CC8C
		public static NetPacket Serialize(HashSet<int> changes)
		{
			NetPacket netPacket;
			BinaryWriter writer = netPacket.Writer;
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			byte b = tile2.liquidType();
			throw new OutOfMemoryException();
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x0026EAC8 File Offset: 0x0026CCC8
		public static NetPacket SerializeForPlayer(int playerIndex)
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
			BinaryWriter writer = NetModule.CreatePacket(42181264).Writer;
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			byte b = tile2.liquidType();
			if (false)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0026EB1C File Offset: 0x0026CD1C
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			return true;
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x0026EB34 File Offset: 0x0026CD34
		public static void CreateAndBroadcastByChunk(HashSet<int> dirtiedPackedTileCoords)
		{
			if (!true)
			{
			}
			NetLiquidModule.PrepareChunks(dirtiedPackedTileCoords);
			NetLiquidModule.PrepareAndSendToEachPlayerSeparately();
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x0026EB50 File Offset: 0x0026CD50
		private static void PrepareAndSendToEachPlayerSeparately()
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				NetPacket netPacket = NetLiquidModule.SerializeForPlayer((int)num2);
			}
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x0026EB74 File Offset: 0x0026CD74
		private static void BroadcastEachChunkSeparately()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0026EBA4 File Offset: 0x0026CDA4
		private static void PrepareChunks(HashSet<int> dirtiedPackedTileCoords)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0026EBD4 File Offset: 0x0026CDD4
		private static void BroadcastAllChanges(HashSet<int> dirtiedPackedTileCoords)
		{
			if (!true)
			{
			}
			NetPacket netPacket = NetLiquidModule.Serialize(dirtiedPackedTileCoords);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0026EBEC File Offset: 0x0026CDEC
		private static void DistributeChangesIntoChunks(HashSet<int> dirtiedPackedTileCoords)
		{
			if (!true)
			{
			}
			int sectionY = Netplay.GetSectionY(Netplay.GetSectionX(-1073741824));
			if (!true)
			{
			}
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x0026EC2C File Offset: 0x0026CE2C
		public NetLiquidModule()
		{
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x0026EC40 File Offset: 0x0026CE40
		// Note: this type is marked as 'beforefieldinit'.
		static NetLiquidModule()
		{
		}

		// Token: 0x040085AB RID: 34219
		private static List<int> _changesForPlayerCache;

		// Token: 0x040085AC RID: 34220
		private static Dictionary<Point, NetLiquidModule.ChunkChanges> _changesByChunkCoords;

		// Token: 0x020009F1 RID: 2545
		private class ChunkChanges
		{
			// Token: 0x06004B66 RID: 19302 RVA: 0x0026EC50 File Offset: 0x0026CE50
			public ChunkChanges(int x, int y)
			{
				this.ChunkX = x;
			}

			// Token: 0x06004B67 RID: 19303 RVA: 0x0026EC6C File Offset: 0x0026CE6C
			public bool BroadcastingCondition(int clientIndex)
			{
				/*
An exception occurred when decompiling this method (06004B67)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.NetModules.NetLiquidModule/ChunkChanges::BroadcastingCondition(System.Int32)

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

			// Token: 0x040085AD RID: 34221
			public HashSet<int> DirtiedPackedTileCoords;

			// Token: 0x040085AE RID: 34222
			public int ChunkX;

			// Token: 0x040085AF RID: 34223
			public int ChunkY;
		}
	}
}
