using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007AB RID: 1963
	public class CoinLossRevengeSystem
	{
		// Token: 0x06003FEC RID: 16364 RVA: 0x002416B0 File Offset: 0x0023F8B0
		public void AddMarkerFromReader(BinaryReader reader)
		{
			Vector2 vector = reader.ReadVector2();
			int gameTime = this._gameTime;
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x000021DB File Offset: 0x000003DB
		private void AddMarker(CoinLossRevengeSystem.RevengeMarker marker)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x002416CC File Offset: 0x0023F8CC
		public void DestroyMarker(int markerUniqueID)
		{
			long num = 0L;
			object markersLock = this._markersLock;
			Monitor.Enter(markersLock, num != 0L);
			List<CoinLossRevengeSystem.RevengeMarker> markers = this._markers;
			long num2 = 0L;
			Monitor.Exit(markersLock);
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00241720 File Offset: 0x0023F920
		public CoinLossRevengeSystem()
		{
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00241734 File Offset: 0x0023F934
		public void CacheEnemy(NPC npc)
		{
			if (!npc.boss)
			{
				int realLife = npc.realLife;
				int rarity = npc.rarity;
				int extraValue = npc.extraValue;
				if (rarity == 0)
				{
				}
				float x = npc.position.X;
				if (rarity == 0)
				{
				}
				float x2 = npc.position.X;
				int width = npc.width;
				if (17440 == 0)
				{
				}
				float y = npc.position.Y;
				if (49664 == 0)
				{
				}
				float y2 = npc.position.Y;
				if (17440 == 0)
				{
				}
				int height = npc.height;
				int netID = npc.netID;
				if (50208 == 0)
				{
				}
				Vector2 center = npc.Center;
				float lifePercent = npc.GetLifePercent();
				int type = npc.type;
				int aiStyle = npc.aiStyle;
				int extraValue2 = npc.extraValue;
				float value = npc.value;
				bool spawnedFromStatue = npc.SpawnedFromStatue;
				int gameTime = this._gameTime;
				if (50208 == 0)
				{
				}
				bool netHost = Main.NetHost;
				string givenOrTypeName = npc.GivenOrTypeName;
				string text = "Cached " + givenOrTypeName;
				if (49664 == 0)
				{
				}
			}
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x000021DB File Offset: 0x000003DB
		public void Reset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0024183C File Offset: 0x0023FA3C
		public void Update()
		{
			int gameTime = this._gameTime;
			this._gameTime = gameTime;
			if (gameTime == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (gameTime != 0)
			{
				return;
			}
			this.RemoveExpiredOrInvalidMarkers();
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x0024186C File Offset: 0x0023FA6C
		public void CheckRespawns()
		{
			object markersLock = this._markersLock;
			List<CoinLossRevengeSystem.RevengeMarker> markers = this._markers;
			long num = 0L;
			int size = markers._size;
			if (3 != 0)
			{
				Monitor.Exit(markersLock);
			}
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num2 = 0L;
			if (num != 0L)
			{
				return;
			}
			this.RemoveExpiredOrInvalidMarkers();
			Monitor.Enter(this._markersLock, num2 != 0L);
			List<CoinLossRevengeSystem.RevengeMarker> markers2 = this._markers;
			int size2 = markers2._size;
			int size3 = markers2._size;
			object syncRoot = markers2._syncRoot;
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00241980 File Offset: 0x0023FB80
		private void RemoveExpiredOrInvalidMarkers()
		{
			object markersLock = this._markersLock;
			List<CoinLossRevengeSystem.RevengeMarker> markers = this._markers;
			List<CoinLossRevengeSystem.RevengeMarker> markers2 = this._markers;
			List<CoinLossRevengeSystem.RevengeMarker> markers3 = this._markers;
			List<CoinLossRevengeSystem.RevengeMarker> markers4 = this._markers;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00241A7C File Offset: 0x0023FC7C
		public CoinLossRevengeSystem.RevengeMarker DrawMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, string unused)
		{
			object markersLock = this._markersLock;
			List<CoinLossRevengeSystem.RevengeMarker> markers = this._markers;
			if (!false)
			{
				long num = 0L;
				Monitor.Exit(markersLock);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00241ACC File Offset: 0x0023FCCC
		public void SendAllMarkersToPlayer(int plr)
		{
			object markersLock = this._markersLock;
			Monitor.Enter(markersLock, plr != 0);
			List<CoinLossRevengeSystem.RevengeMarker> markers = this._markers;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00241B34 File Offset: 0x0023FD34
		// Note: this type is marked as 'beforefieldinit'.
		static CoinLossRevengeSystem()
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			int num4 = Item.buyPrice((int)num, (int)num2, 10, (int)num3);
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00241B54 File Offset: 0x0023FD54
		[CompilerGenerated]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_0(CoinLossRevengeSystem.RevengeMarker x)
		{
			if (x._forceExpire)
			{
				return true;
			}
			int expirationTime = x._expirationTime;
			return true;
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00241B74 File Offset: 0x0023FD74
		[CompilerGenerated]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_3(CoinLossRevengeSystem.RevengeMarker x)
		{
			if (x._forceExpire)
			{
				return true;
			}
			int expirationTime = x._expirationTime;
			return true;
		}

		// Token: 0x04007DDA RID: 32218
		public static bool DisplayCaching;

		// Token: 0x04007DDB RID: 32219
		public static int MinimumCoinsForCaching;

		// Token: 0x04007DDC RID: 32220
		private const int PLAYER_BOX_WIDTH_INNER = 1968;

		// Token: 0x04007DDD RID: 32221
		private const int PLAYER_BOX_HEIGHT_INNER = 1200;

		// Token: 0x04007DDE RID: 32222
		private const int PLAYER_BOX_WIDTH_OUTER = 2608;

		// Token: 0x04007DDF RID: 32223
		private const int PLAYER_BOX_HEIGHT_OUTER = 1840;

		// Token: 0x04007DE0 RID: 32224
		private static readonly Vector2 _playerBoxSizeInner;

		// Token: 0x04007DE1 RID: 32225
		private static readonly Vector2 _playerBoxSizeOuter;

		// Token: 0x04007DE2 RID: 32226
		private List<CoinLossRevengeSystem.RevengeMarker> _markers;

		// Token: 0x04007DE3 RID: 32227
		private readonly object _markersLock;

		// Token: 0x04007DE4 RID: 32228
		private int _gameTime;

		// Token: 0x020007AC RID: 1964
		public class RevengeMarker
		{
			// Token: 0x06003FFA RID: 16378 RVA: 0x00241B94 File Offset: 0x0023FD94
			public void SetToExpire()
			{
				this._forceExpire = true;
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06003FFB RID: 16379 RVA: 0x00241BA8 File Offset: 0x0023FDA8
			public bool RespawnAttemptLocked
			{
				get
				{
					return this._attemptedRespawn;
				}
			}

			// Token: 0x06003FFC RID: 16380 RVA: 0x00241BBC File Offset: 0x0023FDBC
			public void SetRespawnAttemptLock(bool state)
			{
			}

			// Token: 0x06003FFD RID: 16381 RVA: 0x00241BCC File Offset: 0x0023FDCC
			public RevengeMarker(Vector2 coords, int npcNetId, float npcHPPercent, int npcType, int npcAiStyle, int coinValue, float baseValue, bool spawnedFromStatue, int gameTime, int uniqueID = -1)
			{
				int num = 1;
				long num2 = 0L;
				base..ctor();
				this._npcNetID = coords;
				this._coinsValue = npcAiStyle;
				this._npcAIStyleAgainstDiscouragement = npcNetId;
				this._npcAIStyleAgainstDiscouragement = npcType;
				if (num == 0)
				{
				}
				Rectangle rectangle;
				this._hitbox = rectangle;
				this._hitbox.Width = (int)num2;
				int num3;
				this._expirationTime = num3;
			}

			// Token: 0x06003FFE RID: 16382 RVA: 0x00241C24 File Offset: 0x0023FE24
			public bool IsInvalid()
			{
				int num = 1;
				int npcTypeAgainstDiscouragement = this._npcTypeAgainstDiscouragement;
				if (num == 0)
				{
				}
				int npcinvasionGroup = NPC.GetNPCInvasionGroup(npcTypeAgainstDiscouragement);
				if (num == 0)
				{
				}
				int npcTypeAgainstDiscouragement2 = this._npcTypeAgainstDiscouragement;
				if (npcTypeAgainstDiscouragement2 == 0)
				{
				}
				if (npcTypeAgainstDiscouragement2 == 0)
				{
				}
				if (npcTypeAgainstDiscouragement2 == 0)
				{
				}
				int num2 = 275;
				if (num2 != 0)
				{
					if (num2 == 0)
					{
					}
					return;
				}
			}

			// Token: 0x06003FFF RID: 16383 RVA: 0x00241C6C File Offset: 0x0023FE6C
			public bool IsExpired(int gameTime)
			{
				return !this._forceExpire || true;
			}

			// Token: 0x06004000 RID: 16384 RVA: 0x00241C84 File Offset: 0x0023FE84
			private int CalculateExpirationTime(int gameCacheTime, int coinValue)
			{
				if (true)
				{
					return;
				}
			}

			// Token: 0x06004001 RID: 16385 RVA: 0x00241CA0 File Offset: 0x0023FEA0
			public bool Intersects(Rectangle rectInner, Rectangle rectOuter)
			{
				Rectangle hitbox = this._hitbox;
				int width = this._hitbox.Width;
				bool flag;
				return flag;
			}

			// Token: 0x06004002 RID: 16386 RVA: 0x00241CC4 File Offset: 0x0023FEC4
			public void SpawnEnemy()
			{
				int num = 1;
				float x = this._location.X;
				float y = this._location.Y;
				int npcNetID = this._npcNetID;
				if (num == 0)
				{
				}
				if (32640 == 0)
				{
				}
				int npcNetID2 = this._npcNetID;
				int npcNetID3 = this._npcNetID;
				float baseValue = this._baseValue;
				bool spawnedFromStatue = this._spawnedFromStatue;
				float npcHPPercent = this._npcHPPercent;
				if (!spawnedFromStatue)
				{
				}
				int num2 = 32640;
				int num3 = 32768;
				if (num2 == 0)
				{
				}
				if (num2 != 0)
				{
					int coinsValue = this._coinsValue;
					float x2 = this._location.X;
					float y2 = this._location.Y;
					return;
				}
				float x3 = this._location.X;
				float y3 = this._location.Y;
				string text2;
				string text = "Spawned " + text2;
				if (num3 == 0)
				{
				}
				int num4 = 255;
				int num5 = 255;
				int num6 = 255;
				Main.NewText(text, (byte)num4, (byte)num5, (byte)num6);
			}

			// Token: 0x06004003 RID: 16387 RVA: 0x00241DC0 File Offset: 0x0023FFC0
			public bool WouldNPCBeDiscouraged(Player playerTarget)
			{
				int npcAIStyleAgainstDiscouragement = this._npcAIStyleAgainstDiscouragement;
				int npcTypeAgainstDiscouragement = this._npcTypeAgainstDiscouragement;
				float x = playerTarget.position.X;
				float y = playerTarget.position.Y;
				bool flag;
				return flag;
			}

			// Token: 0x06004004 RID: 16388 RVA: 0x00241E2C File Offset: 0x0024002C
			public bool DrawMapIcon(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, int gameTime)
			{
				int num = 1;
				float x = this._location.X;
				float y = this._location.Y;
				if (num == 0)
				{
				}
				if (mapTopLeft == null)
				{
				}
				if (mapTopLeft == null)
				{
				}
				int coinsValue = this._coinsValue;
				int num2 = 9999;
				if (num2 == 0)
				{
				}
				int num3 = 16959;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				Rectangle rectangle;
				Vector2 vector = rectangle.Size();
				Vector2 vector2 = rectangle.Size();
				Rectangle rectangle2;
				if (rectangle2 == null)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
				bool flag;
				return flag;
			}

			// Token: 0x06004005 RID: 16389 RVA: 0x00241EC4 File Offset: 0x002400C4
			public void UseMouseOver(SpriteBatch spriteBatch, string mouseTextString, float drawScale = 1f)
			{
				if ("" == null)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
				if ("" == null)
				{
				}
				if ("" == null)
				{
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x06004006 RID: 16390 RVA: 0x00241EF8 File Offset: 0x002400F8
			public int UniqueID
			{
				get
				{
					return this._uniqueID;
				}
			}

			// Token: 0x06004007 RID: 16391 RVA: 0x00241F0C File Offset: 0x0024010C
			public void WriteSelfTo(BinaryWriter writer)
			{
				int uniqueID = this._uniqueID;
				float x = this._location.X;
				float y = this._location.Y;
				int npcNetID = this._npcNetID;
				float npcHPPercent = this._npcHPPercent;
				int npcTypeAgainstDiscouragement = this._npcTypeAgainstDiscouragement;
				int npcAIStyleAgainstDiscouragement = this._npcAIStyleAgainstDiscouragement;
				int coinsValue = this._coinsValue;
				float baseValue = this._baseValue;
				bool spawnedFromStatue = this._spawnedFromStatue;
			}

			// Token: 0x06004008 RID: 16392 RVA: 0x00241F70 File Offset: 0x00240170
			// Note: this type is marked as 'beforefieldinit'.
			static RevengeMarker()
			{
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				int num4 = Item.buyPrice((int)num, (int)num2, (int)num3, 1);
				long num5 = 0L;
				long num6 = 0L;
				int num7 = Item.buyPrice(0, (int)num5, 1, (int)num6);
				long num8 = 0L;
				long num9 = 0L;
				int num10 = Item.buyPrice(0, 1, (int)num8, (int)num9);
				long num11 = 0L;
				long num12 = 0L;
				long num13 = 0L;
				int num14 = Item.buyPrice(1, (int)num11, (int)num12, (int)num13);
			}

			// Token: 0x04007DE5 RID: 32229
			private static int _uniqueIDCounter;

			// Token: 0x04007DE6 RID: 32230
			private static readonly int _expirationCompCopper;

			// Token: 0x04007DE7 RID: 32231
			private static readonly int _expirationCompSilver;

			// Token: 0x04007DE8 RID: 32232
			private static readonly int _expirationCompGold;

			// Token: 0x04007DE9 RID: 32233
			private static readonly int _expirationCompPlat;

			// Token: 0x04007DEA RID: 32234
			private const int ONE_MINUTE = 3600;

			// Token: 0x04007DEB RID: 32235
			private const int ENEMY_BOX_WIDTH = 2160;

			// Token: 0x04007DEC RID: 32236
			private const int ENEMY_BOX_HEIGHT = 1440;

			// Token: 0x04007DED RID: 32237
			public static readonly Vector2 EnemyBoxSize;

			// Token: 0x04007DEE RID: 32238
			private readonly Vector2 _location;

			// Token: 0x04007DEF RID: 32239
			private readonly Rectangle _hitbox;

			// Token: 0x04007DF0 RID: 32240
			private readonly int _npcNetID;

			// Token: 0x04007DF1 RID: 32241
			private readonly float _npcHPPercent;

			// Token: 0x04007DF2 RID: 32242
			private readonly float _baseValue;

			// Token: 0x04007DF3 RID: 32243
			private readonly int _coinsValue;

			// Token: 0x04007DF4 RID: 32244
			private readonly int _npcTypeAgainstDiscouragement;

			// Token: 0x04007DF5 RID: 32245
			private readonly int _npcAIStyleAgainstDiscouragement;

			// Token: 0x04007DF6 RID: 32246
			private readonly int _expirationTime;

			// Token: 0x04007DF7 RID: 32247
			private readonly bool _spawnedFromStatue;

			// Token: 0x04007DF8 RID: 32248
			private readonly int _uniqueID;

			// Token: 0x04007DF9 RID: 32249
			private bool _forceExpire;

			// Token: 0x04007DFA RID: 32250
			private bool _attemptedRespawn;
		}

		// Token: 0x020007AD RID: 1965
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004009 RID: 16393 RVA: 0x00241FCC File Offset: 0x002401CC
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0600400A RID: 16394 RVA: 0x00241FE0 File Offset: 0x002401E0
			internal bool <DestroyMarker>b__0(CoinLossRevengeSystem.RevengeMarker x)
			{
				/*
An exception occurred when decompiling this method (0600400A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.CoinLossRevengeSystem/<>c__DisplayClass5_0::<DestroyMarker>b__0(Terraria.GameContent.CoinLossRevengeSystem/RevengeMarker)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RevengeMarker::_uniqueID, ldloc:RevengeMarker(x)))
	stloc:int32(var_1_0D, ldfld:int32('<>c__DisplayClass5_0'::markerUniqueID, ldloc:'<>c__DisplayClass5_0'(this)))
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

			// Token: 0x04007DFB RID: 32251
			public int markerUniqueID;
		}

		// Token: 0x020007AE RID: 1966
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600400B RID: 16395 RVA: 0x00241FFC File Offset: 0x002401FC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600400C RID: 16396 RVA: 0x0024200C File Offset: 0x0024020C
			public <>c()
			{
			}

			// Token: 0x0600400D RID: 16397 RVA: 0x00242020 File Offset: 0x00240220
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_1(CoinLossRevengeSystem.RevengeMarker x)
			{
				return x.IsInvalid();
			}

			// Token: 0x0600400E RID: 16398 RVA: 0x00242034 File Offset: 0x00240234
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_2(CoinLossRevengeSystem.RevengeMarker x)
			{
				return x.IsInvalid();
			}

			// Token: 0x04007DFC RID: 32252
			public static readonly CoinLossRevengeSystem.<>c <>9;

			// Token: 0x04007DFD RID: 32253
			public static Func<CoinLossRevengeSystem.RevengeMarker, bool> <>9__20_1;

			// Token: 0x04007DFE RID: 32254
			public static Predicate<CoinLossRevengeSystem.RevengeMarker> <>9__20_2;
		}
	}
}
