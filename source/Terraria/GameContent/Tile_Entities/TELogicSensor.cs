using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000815 RID: 2069
	public class TELogicSensor : TileEntity
	{
		// Token: 0x0600424E RID: 16974 RVA: 0x0024ACB8 File Offset: 0x00248EB8
		public override void RegisterTileEntityID(int assignedID)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x0024ACD0 File Offset: 0x00248ED0
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			if (!true)
			{
			}
			TELogicSensor.NetPlaceEntity(x, y);
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x0024ACE8 File Offset: 0x00248EE8
		public static void NetPlaceEntity(int x, int y)
		{
			if (!true)
			{
			}
			int num = TELogicSensor.Place(x, y);
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0024AD0C File Offset: 0x00248F0C
		public override bool IsTileValidForEntity(int x, int y)
		{
			if (!true)
			{
			}
			return TELogicSensor.ValidTile(x, y);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0024AD24 File Offset: 0x00248F24
		private static void UpdateStartInternal()
		{
			if (!true)
			{
			}
			TELogicSensor.FillPlayerHitboxes();
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0024AD3C File Offset: 0x00248F3C
		private static void FillPlayerHitboxes()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0 || num != 0 || num != 0 || num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0024AD68 File Offset: 0x00248F68
		private static void UpdateEndInternal()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Wiring.HitSwitch(-1073741824, 0);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0024AE00 File Offset: 0x00249000
		public override void Update()
		{
			int num = 1;
			TELogicSensor.LogicCheckType logicCheckType = this.logicCheck;
			if (num == 0)
			{
			}
			bool state = TELogicSensor.GetState(1, 1, logicCheckType, this);
			TELogicSensor.LogicCheckType logicCheckType2 = this.logicCheck;
			bool on = this.On;
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0024AE64 File Offset: 0x00249064
		public void ChangeState(bool onState, bool TripWire)
		{
			bool on = this.On;
			if (!on)
			{
			}
			bool flag = TELogicSensor.SanityCheck(43134976, onState ? 1 : 0);
			if (!on)
			{
			}
			int num = 18;
			Tile tile;
			tile.frameX = (onState ? 1 : 0);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
			}
			bool logicHost = Main.LogicHost;
			if (!false)
			{
			}
			TELogicSensor.LogicCheckType logicCheckType = this.logicCheck;
			Point16 position = this.Position;
			byte type = this.type;
			bool on2 = this.On;
			int id = this.ID;
			this.logicCheck = (on2 ? TELogicSensor.LogicCheckType.Day : TELogicSensor.LogicCheckType.None);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0024AEE4 File Offset: 0x002490E4
		public static bool ValidTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004258)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TELogicSensor::ValidTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stloc:int16(var_12_3C, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
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

		// Token: 0x06004259 RID: 16985 RVA: 0x0024AF30 File Offset: 0x00249130
		public TELogicSensor()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0024AF48 File Offset: 0x00249148
		public static TELogicSensor.LogicCheckType FigureCheckType(int x, int y, [Out] bool on)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.InWorld(0, x, (int)num2);
			if (num == 0)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
			if (36409 == 0)
			{
			}
			y.m_value = num;
			return (TELogicSensor.LogicCheckType)42186880;
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0024AF84 File Offset: 0x00249184
		public static bool GetState(int x, int y, TELogicSensor.LogicCheckType type, [Optional] TELogicSensor instance)
		{
			int num = 1;
			if (type == TELogicSensor.LogicCheckType.None)
			{
				throw new OutOfMemoryException();
			}
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			if (num != 0)
			{
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0024AFDC File Offset: 0x002491DC
		public void FigureCheckState()
		{
			int num = 1;
			if (num == 0)
			{
			}
			TELogicSensor.LogicCheckType logicCheckType = TELogicSensor.FigureCheckType(1, 43134976, true);
			this.logicCheck = logicCheckType;
			bool on = this.On;
			TELogicSensor.GetFrame(num, 43134976, logicCheckType, on);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0024B018 File Offset: 0x00249218
		public static void GetFrame(int x, int y, TELogicSensor.LogicCheckType type, bool on)
		{
			if (!true)
			{
			}
			Tile tile;
			tile.frameX = (short)y;
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x0024B044 File Offset: 0x00249244
		public static bool SanityCheck(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (!true)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			return true;
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0024B078 File Offset: 0x00249278
		public static int Place(int x, int y)
		{
			if (!true)
			{
			}
			int num = TileEntity.AssignNewID();
			if (!true)
			{
			}
			Monitor.Enter(x, x != 0);
			long num2 = 0L;
			Monitor.Exit(x);
			if (num2 == 0L)
			{
				return x;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0024B0C8 File Offset: 0x002492C8
		public static int Hook_AfterPlacement(int x, int y, int type = 423, int style = 0, int direction = 1, int alternate = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			TELogicSensor.LogicCheckType logicCheckType = TELogicSensor.FigureCheckType(42186880, x, y != 0);
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			return 87;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0024B124 File Offset: 0x00249324
		public static void Kill(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(x, y);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0024B190 File Offset: 0x00249390
		public static int Find(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004262)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Tile_Entities.TELogicSensor::Find(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0E, call:int32(TileEntity::GetKey, ldc.i4:int32(-2147483648), ldloc:int32(x)))
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

		// Token: 0x06004263 RID: 16995 RVA: 0x0024B1AC File Offset: 0x002493AC
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0024B1C8 File Offset: 0x002493C8
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0024B1D8 File Offset: 0x002493D8
		public override string ToString()
		{
			Point16 position = this.Position;
			string text;
			if ((text == null || text != null) && ("x  " == null || "x  " != null))
			{
				short y = this.Position.Y;
				string text2;
				if ((text2 == null || text2 != null) && ("y " == null || "y " != null))
				{
					TELogicSensor.LogicCheckType logicCheckType = this.logicCheck;
					string text3;
					if (text3 == null || text3 != null)
					{
						string text4;
						return text4;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0024B23C File Offset: 0x0024943C
		// Note: this type is marked as 'beforefieldinit'.
		static TELogicSensor()
		{
		}

		// Token: 0x040080D2 RID: 32978
		private static byte _myEntityID;

		// Token: 0x040080D3 RID: 32979
		private static Dictionary<int, Rectangle> playerBox;

		// Token: 0x040080D4 RID: 32980
		private static List<Tuple<Point16, bool>> tripPoints;

		// Token: 0x040080D5 RID: 32981
		private static List<int> markedIDsForRemoval;

		// Token: 0x040080D6 RID: 32982
		private static bool inUpdateLoop;

		// Token: 0x040080D7 RID: 32983
		private static bool playerBoxFilled;

		// Token: 0x040080D8 RID: 32984
		public TELogicSensor.LogicCheckType logicCheck;

		// Token: 0x040080D9 RID: 32985
		public bool On;

		// Token: 0x040080DA RID: 32986
		public int CountedData;

		// Token: 0x02000816 RID: 2070
		public enum LogicCheckType
		{
			// Token: 0x040080DC RID: 32988
			None,
			// Token: 0x040080DD RID: 32989
			Day,
			// Token: 0x040080DE RID: 32990
			Night,
			// Token: 0x040080DF RID: 32991
			PlayerAbove,
			// Token: 0x040080E0 RID: 32992
			Water,
			// Token: 0x040080E1 RID: 32993
			Lava,
			// Token: 0x040080E2 RID: 32994
			Honey,
			// Token: 0x040080E3 RID: 32995
			Liquid
		}
	}
}
