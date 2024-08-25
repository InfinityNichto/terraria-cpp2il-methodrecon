using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000818 RID: 2072
	public class TETrainingDummy : TileEntity
	{
		// Token: 0x06004279 RID: 17017 RVA: 0x0024B540 File Offset: 0x00249740
		public override void RegisterTileEntityID(int assignedID)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x0024B558 File Offset: 0x00249758
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			if (!true)
			{
			}
			TETrainingDummy.NetPlaceEntity(x, y);
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0024B570 File Offset: 0x00249770
		public static void NetPlaceEntity(int x, int y)
		{
			if (!true)
			{
			}
			int num = TETrainingDummy.Place(x, y);
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x0024B588 File Offset: 0x00249788
		public override bool IsTileValidForEntity(int x, int y)
		{
			if (!true)
			{
			}
			return TETrainingDummy.ValidTile(x, y);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x0024B5A0 File Offset: 0x002497A0
		public static void ClearBoxes()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0024B5B0 File Offset: 0x002497B0
		public override void Update()
		{
			int num = this.npc;
			int num2 = this.npc;
			this.Deactivate();
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x0024B610 File Offset: 0x00249810
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
				if (num == 0 || num != 0)
				{
				}
			}
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x0024B630 File Offset: 0x00249830
		public static bool ValidTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004281)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TETrainingDummy::ValidTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int16(var_12_39, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
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

		// Token: 0x06004282 RID: 17026 RVA: 0x0024B678 File Offset: 0x00249878
		public TETrainingDummy()
		{
			if (!true)
			{
			}
			base..ctor();
			this.npc = 1;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x0024B698 File Offset: 0x00249898
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

		// Token: 0x06004284 RID: 17028 RVA: 0x0024B6E8 File Offset: 0x002498E8
		public static int Hook_AfterPlacement(int x, int y, int type = 378, int style = 0, int direction = 1, int alternate = 0)
		{
			int num = 1;
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

		// Token: 0x06004285 RID: 17029 RVA: 0x0024B730 File Offset: 0x00249930
		public static void Kill(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(x, y);
			if (!true)
			{
			}
			if (!true)
			{
			}
			int key2 = TileEntity.GetKey(x, y);
			if (x == 0)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0024B778 File Offset: 0x00249978
		public static int Find(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004286)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Tile_Entities.TETrainingDummy::Find(System.Int32,System.Int32)

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

		// Token: 0x06004287 RID: 17031 RVA: 0x0024B794 File Offset: 0x00249994
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			int num = this.npc;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x0024B7A8 File Offset: 0x002499A8
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			this.npc = reader;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x0024B7BC File Offset: 0x002499BC
		public void Activate()
		{
			if (!true)
			{
			}
			int num;
			this.npc = num;
			bool netHost = Main.NetHost;
			int id = this.ID;
			Point16 position = this.Position;
			short y = this.Position.Y;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x0024B7FC File Offset: 0x002499FC
		public void Deactivate()
		{
			int num = this.npc;
			int num2 = this.npc;
			this.npc = num2;
			if (num2 == 0)
			{
			}
			bool netHost = Main.NetHost;
			int id = this.ID;
			Point16 position = this.Position;
			short y = this.Position.Y;
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x0024B84C File Offset: 0x00249A4C
		public override string ToString()
		{
			Point16 position = this.Position;
			string text;
			if ((text == null || text != null) && ("x  " == null || "x  " != null))
			{
				short y = this.Position.Y;
				string text2;
				string text3;
				if ((text2 == null || text2 != null) && ("y npc: " == null || "y npc: " != null) && (text3 == null || text3 != null))
				{
					string text4;
					return text4;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x0024B8A8 File Offset: 0x00249AA8
		// Note: this type is marked as 'beforefieldinit'.
		static TETrainingDummy()
		{
		}

		// Token: 0x040080E8 RID: 33000
		private static Dictionary<int, Rectangle> playerBox;

		// Token: 0x040080E9 RID: 33001
		private static bool playerBoxFilled;

		// Token: 0x040080EA RID: 33002
		private static byte _myEntityID;

		// Token: 0x040080EB RID: 33003
		public int npc;
	}
}
