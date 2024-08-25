using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

namespace Terraria
{
	// Token: 0x02000470 RID: 1136
	public static class Wiring
	{
		// Token: 0x06002C14 RID: 11284 RVA: 0x001B63C0 File Offset: 0x001B45C0
		public static void SetCurrentUser(int plr = -1)
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x001B63E4 File Offset: 0x001B45E4
		public static void Initialize()
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

		// Token: 0x06002C16 RID: 11286 RVA: 0x001B6400 File Offset: 0x001B4600
		public static void SkipWire(int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x001B6410 File Offset: 0x001B4610
		public static void SkipWire(Point16 point)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x001B6420 File Offset: 0x001B4620
		public static void ClearAll()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x001B6440 File Offset: 0x001B4640
		public static void UpdateMech()
		{
			if (!true)
			{
			}
			Wiring.SetCurrentUser(-1073741824);
			long num = 1L;
			if (num == 0L)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.InWorld(0, 43143168, num2);
			if (num == 0L)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x001B6514 File Offset: 0x001B4714
		public static void HitSwitch(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.InWorld(i, j, (int)num2);
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			int num3 = 1;
			int num4 = 1;
			Wiring.TripWire(i, j, num3, num4);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x001B660C File Offset: 0x001B480C
		public static void PokeLogicGate(int lampX, int lampY)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (!true)
			{
			}
			Wiring.LogicGatePass();
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x001B662C File Offset: 0x001B482C
		public static bool Actuate(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.actuator();
			Wiring.ReActive(0, i);
			return false;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x001B6654 File Offset: 0x001B4854
		public static void ActuateForced(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.inActive();
			Wiring.ReActive(i, j);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x001B667C File Offset: 0x001B487C
		public static void MassWireOperation(Point ps, Point pe, Player master)
		{
			Item[] inventory = master.inventory;
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x001B6750 File Offset: 0x001B4950
		private static bool CheckMech(int i, int j, int time)
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
				return;
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x001B676C File Offset: 0x001B496C
		private static void XferWater()
		{
			if (!true)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			byte b = tile2.liquidType();
			Tile tile3;
			byte liquid2 = tile3.liquid;
			if (-1073741824 == 0)
			{
			}
			Tile tile4;
			byte b2 = tile4.liquidType();
			if (-1073741824 == 0)
			{
			}
			Tile tile5;
			byte liquid3 = tile5.liquid;
			Tile tile6;
			byte liquid4 = tile6.liquid;
			long num = 0L;
			Tile tile7;
			byte liquid5 = tile7.liquid;
			Tile tile8;
			tile8.liquidType((int)num);
			int num2 = 1;
			WorldGen.SquareTileFrame(0, -1073741824, num2 != 0);
			Tile tile9;
			byte liquid6 = tile9.liquid;
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x001B6838 File Offset: 0x001B4A38
		private static void TripWire(int left, int top, int width, int height)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			bool flag = tile.wire();
			if (num2 == 0)
			{
			}
			Wiring.XferWater();
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x001B68B8 File Offset: 0x001B4AB8
		private static void PixelBoxPass()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (!true)
			{
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x001B68F4 File Offset: 0x001B4AF4
		private static void LogicGatePass()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x001B6964 File Offset: 0x001B4B64
		private static void CheckLogicGate(int lampX, int lampY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.InWorld(lampX, lampY, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x001B6A14 File Offset: 0x001B4C14
		private static void HitWire(DoubleStack<Point16> next, int wireType)
		{
			if (!true)
			{
			}
			int size = next._size;
			int size2 = next._size;
			int size3 = next._size;
			Wiring.HitWireSingle(-1073741824, int.MinValue);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetProjectileSource(int sourceTileX, int sourceTileY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetNPCSource(int sourceTileX, int sourceTileY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetItemSource(int sourceTileX, int sourceTileY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x001B6A90 File Offset: 0x001B4C90
		private static void HitWireSingle(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Wiring.ActuateForced(i, j);
			if (num == 0)
			{
			}
			Wiring.HitSwitch(i, j);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleHolidayLight(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleHangingLantern(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Toggle2x2Light(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleLampPost(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleTorch(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleCandle(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleLamp(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleChandelier(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleCampFire(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ToggleFirePlace(int i, int j, Tile theBlock, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x001B78BC File Offset: 0x001B5ABC
		private static void GeyserTrap(int i, int j)
		{
			do
			{
				if (!true)
				{
				}
				Tile tile;
				ushort type = tile.type;
				int num = 200;
				bool flag = Wiring.CheckMech(i, j, num);
				short num2;
				if (num2 == 0)
				{
				}
			}
			while (true);
			if (!true)
			{
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x001B7908 File Offset: 0x001B5B08
		private static void Teleport()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (32640 == 0)
			{
			}
			int num2 = 1;
			bool netHost = Main.NetHost;
			if (-2147483648 == 0)
			{
			}
			bool netHost2 = Main.NetHost;
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					if (num2 == 0)
					{
					}
					if (num2 == 0)
					{
						if (num2 == 0)
						{
						}
						if (num2 == 0)
						{
							if (num2 == 0)
							{
							}
							if (num2 == 0)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x001B7988 File Offset: 0x001B5B88
		private static bool TeleporterHitboxIntersects(Rectangle teleporter, Rectangle entity)
		{
			/*
An exception occurred when decompiling this method (06002C36)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Wiring::TeleporterHitboxIntersects(Microsoft.Xna.Framework.Rectangle,Microsoft.Xna.Framework.Rectangle)

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

		// Token: 0x06002C37 RID: 11319 RVA: 0x001B7998 File Offset: 0x001B5B98
		private static void DeActive(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					Tile tile4;
					ushort type3 = tile4.type;
					return;
				}
				Tile tile5;
				ushort type4 = tile5.type;
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x001B7A6C File Offset: 0x001B5C6C
		private static void ReActive(int i, int j)
		{
			if (!true)
			{
			}
			long num = 0L;
			Tile tile;
			tile.inActive(num != 0L);
			if (!true)
			{
			}
			long num2 = 0L;
			WorldGen.SquareTileFrame(i, j, num2 != 0L);
			bool logicHost = Main.LogicHost;
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x001B7A9C File Offset: 0x001B5C9C
		private static void MassWireOperationInner(Player user, Point ps, Point pe, Vector2 dropPoint, bool dir, int wireCount, int actuatorCount)
		{
			if (!true)
			{
			}
			int num = Math.Sign(Math.Sign(0));
			WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
			Item.StartCachingType(530);
			Item.StartCachingType(849);
			bool value = Wiring.MassWireOperationStep(user, ps, toolMode, dir ? 1 : 0, wireCount).Value != null;
			bool value2 = Wiring.MassWireOperationStep(user, ps, toolMode, dir ? 1 : 0, wireCount).Value != null;
			if (!true)
			{
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x001B7B00 File Offset: 0x001B5D00
		private static bool? MassWireOperationStep(Player user, Point pt, WiresUI.Settings.MultiToolMode mode, int wiresLeftToConsume, int actuatorsLeftToConstume)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 17;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x001B7B20 File Offset: 0x001B5D20
		// Note: this type is marked as 'beforefieldinit'.
		static Wiring()
		{
		}

		// Token: 0x040037DA RID: 14298
		public static bool blockPlayerTeleportationForOneIteration;

		// Token: 0x040037DB RID: 14299
		public static bool running;

		// Token: 0x040037DC RID: 14300
		private static Dictionary<Point16, bool> _wireSkip;

		// Token: 0x040037DD RID: 14301
		private static DoubleStack<Point16> _wireList;

		// Token: 0x040037DE RID: 14302
		private static DoubleStack<byte> _wireDirectionList;

		// Token: 0x040037DF RID: 14303
		private static Dictionary<Point16, byte> _toProcess;

		// Token: 0x040037E0 RID: 14304
		private static Queue<Point16> _GatesCurrent;

		// Token: 0x040037E1 RID: 14305
		private static Queue<Point16> _LampsToCheck;

		// Token: 0x040037E2 RID: 14306
		private static Queue<Point16> _GatesNext;

		// Token: 0x040037E3 RID: 14307
		private static Dictionary<Point16, bool> _GatesDone;

		// Token: 0x040037E4 RID: 14308
		private static Dictionary<Point16, byte> _PixelBoxTriggers;

		// Token: 0x040037E5 RID: 14309
		private static Vector2[] _teleport;

		// Token: 0x040037E6 RID: 14310
		private const int MaxPump = 20;

		// Token: 0x040037E7 RID: 14311
		private static int[] _inPumpX;

		// Token: 0x040037E8 RID: 14312
		private static int[] _inPumpY;

		// Token: 0x040037E9 RID: 14313
		private static int _numInPump;

		// Token: 0x040037EA RID: 14314
		private static int[] _outPumpX;

		// Token: 0x040037EB RID: 14315
		private static int[] _outPumpY;

		// Token: 0x040037EC RID: 14316
		private static int _numOutPump;

		// Token: 0x040037ED RID: 14317
		private const int MaxMech = 1000;

		// Token: 0x040037EE RID: 14318
		private static int[] _mechX;

		// Token: 0x040037EF RID: 14319
		private static int[] _mechY;

		// Token: 0x040037F0 RID: 14320
		private static int _numMechs;

		// Token: 0x040037F1 RID: 14321
		private static int[] _mechTime;

		// Token: 0x040037F2 RID: 14322
		private static int _currentWireColor;

		// Token: 0x040037F3 RID: 14323
		private static int CurrentUser;
	}
}
