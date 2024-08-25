using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020003EB RID: 1003
	public class Chest : IFixLoadedData
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x0006D0AC File Offset: 0x0006B2AC
		public Chest(bool bank = false)
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
		public override string ToString()
		{
			long entityId = this.item.entityId;
			return "{{X: {0}, Y: {1}, Count: {2}}}";
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0006D0F4 File Offset: 0x0006B2F4
		public static void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0006D104 File Offset: 0x0006B304
		private static bool IsPlayerInChest(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0006D124 File Offset: 0x0006B324
		public static List<int> GetCurrentlyOpenChests()
		{
			/*
An exception occurred when decompiling this method (06001AAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> Terraria.Chest::GetCurrentlyOpenChests()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0006D140 File Offset: 0x0006B340
		public static bool IsLocked(int x, int y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0006D154 File Offset: 0x0006B354
		public static bool IsLocked(Tile t)
		{
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0006D168 File Offset: 0x0006B368
		public static void ServerPlaceItem(int plr, int slot)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0006D184 File Offset: 0x0006B384
		public static Item PutItemInNearbyChest(Item item, Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int num4;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool flag = Chest.IsPlayerInChest((int)num2);
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Vector2 vector;
				float num3 = vector.Length();
				if (num == 0)
				{
				}
				num4 = 4;
				if (num4 == 0 || num4 == 0)
				{
				}
			}
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
		public static void VisualizeChestTransfer(Vector2 position, Vector2 chestPosition, Item item, int amountMoved)
		{
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0006D204 File Offset: 0x0006B404
		public static void VisualizeChestTransfer_CoinsBatch(Vector2 position, Vector2 chestPosition, long coinsMoved)
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
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0006D224 File Offset: 0x0006B424
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0006D238 File Offset: 0x0006B438
		public static bool Unlock(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06001AB7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Chest::Unlock(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint16(var_5_0A, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	call:void(AchievementsHelper::NotifyProgressionEvent, ldc.i4:int32(19))
	stloc:uint16(var_13_30, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_12)))
	call:void(AchievementsHelper::NotifyProgressionEvent, ldc.i4:int32(20))
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

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0006D288 File Offset: 0x0006B488
		public static bool Lock(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06001AB8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Chest::Lock(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:uint16(var_5_0A, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	call:void(AchievementsHelper::NotifyProgressionEvent, ldc.i4:int32(20))
	stloc:uint16(var_12_2C, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
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

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		public static int UsingChest(int i)
		{
			/*
An exception occurred when decompiling this method (06001AB9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Chest::UsingChest(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001ABA RID: 6842 RVA: 0x0006D2F0 File Offset: 0x0006B4F0
		public static int FindChest(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06001ABA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Chest::FindChest(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001ABB RID: 6843 RVA: 0x0006D314 File Offset: 0x0006B514
		public static int FindChestByGuessing(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06001ABB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Chest::FindChestByGuessing(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001ABC RID: 6844 RVA: 0x0006D33C File Offset: 0x0006B53C
		public static int FindEmptyChest(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			return 43139072;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0006D360 File Offset: 0x0006B560
		public static bool NearOtherChests(int x, int y)
		{
			int num = 1;
			bool flag = Framing.GetTileSafely(43139072, x).active();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0006D38C File Offset: 0x0006B58C
		public static int AfterPlacement_Hook(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int num3 = Chest.FindEmptyChest(43139072, type, x, (int)num2, style, direction);
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			return num3;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		public static int CreateChest(int X, int Y, int id = -1)
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
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int num2;
			return num2;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0006D408 File Offset: 0x0006B608
		public static bool CanDestroyChest(int X, int Y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0006D430 File Offset: 0x0006B630
		public static bool DestroyChest(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06001AC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Chest::DestroyChest(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:int32(var_6_1B, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_8_25, callgetter:int32(Main::get_myPlayer))
	call:void(Recipe::FindRecipes, ldc.i4:bool(0))
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

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0006D46C File Offset: 0x0006B66C
		public static void DestroyChestDirect(int X, int Y, int id)
		{
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			long num = 0L;
			Recipe.FindRecipes(num != 0L);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0006D49C File Offset: 0x0006B69C
		public void AddItemToShop(Item newItem)
		{
			if (!true)
			{
			}
			int num = Main.shopSellbackHelper.Remove(newItem);
			int stack = newItem.stack;
			Item[] array = this.item;
			if (stack != 0 && stack != 0)
			{
				return;
			}
			Item item = newItem.Clone();
			if (item == null || item != null)
			{
				Item[] array2 = this.item;
				int num2 = 1;
				int stack2 = array2.stack;
				array2.buyOnce = num2 != 0;
				array2.stack = stack2;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0006D510 File Offset: 0x0006B710
		public static void SetupTravelShop_AddToShop(int it, int added, int count)
		{
			if (it != 0)
			{
				if (4555 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
		public static bool SetupTravelShop_CanAddItemToShop(int it)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		public static void SetupTravelShop_GetPainting(Player playerWithHighestLuck, int[] rarity, int it, int minimumRarity = 0)
		{
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (!true)
				{
				}
				if (!true)
				{
					it.m_value = 5121;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (5121 == 0)
				{
				}
				if (5121 == 0)
				{
					it.m_value = 5122;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (5122 == 0)
				{
				}
				if (5122 == 0)
				{
					it.m_value = 5124;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (5124 == 0)
				{
				}
				if (5124 == 0)
				{
					it.m_value = 5123;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (5242 == 0)
				{
				}
				while (5242 == 0)
				{
				}
				if (5242 == 0)
				{
				}
				while (5242 == 0)
				{
				}
				it.m_value = 3596;
				return;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (3596 == 0)
				{
				}
				while (3596 == 0)
				{
				}
				if (3596 == 0)
				{
				}
				while (3596 == 0)
				{
				}
				it.m_value = 2865;
				return;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (2865 == 0)
				{
				}
				while (2865 == 0)
				{
				}
				if (2865 == 0)
				{
				}
				while (2865 == 0)
				{
				}
				it.m_value = 2866;
				return;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (2866 == 0)
				{
				}
				while (2866 == 0)
				{
				}
				if (2866 == 0)
				{
				}
				while (2866 == 0)
				{
				}
				it.m_value = 2867;
				return;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (5123 == 0)
				{
				}
				if (5123 != 0)
				{
					it.m_value = 3055;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (3055 == 0)
				{
				}
				if (3055 != 0)
				{
					it.m_value = 3056;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (3056 == 0)
				{
				}
				if (3056 != 0)
				{
					it.m_value = 3057;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (3057 == 0)
				{
				}
				if (3057 != 0)
				{
					it.m_value = 3058;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (3058 == 0)
				{
				}
				if (3058 != 0)
				{
					it.m_value = 3059;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) != 0)
			{
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (3059 == 0)
					{
					}
					if (3059 != 0)
					{
						it.m_value = 5121;
					}
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (5121 == 0)
					{
					}
					if (5121 != 0)
					{
						it.m_value = 5122;
					}
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (5122 == 0)
					{
					}
					if (5122 != 0)
					{
						it.m_value = 5124;
					}
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (5124 == 0)
					{
					}
					if (5124 != 0)
					{
						it.m_value = 5123;
					}
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5225;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5229;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5232;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5389;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5233;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5241;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5244;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					it.m_value = 5242;
				}
				return;
			}
			if (2867 == 0)
			{
			}
			while (2867 == 0)
			{
			}
			if (2867 == 0)
			{
			}
			while (2867 == 0)
			{
			}
			it.m_value = 5243;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0006D924 File Offset: 0x0006BB24
		public static void SetupTravelShop_AdjustSlotRarities(int slotItemAttempts, int[] rarity)
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0006D934 File Offset: 0x0006BB34
		public static void SetupTravelShop_GetItem(Player playerWithHighestLuck, int[] rarity, int it, int minimumRarity = 0)
		{
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				int num = 3309;
				it.m_value = num;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				int num2 = 3314;
				it.m_value = num2;
			}
			int num3;
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				num3 = 1987;
				it.m_value = num3;
			}
			int num4;
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (num3 == 0)
				{
				}
				if (num3 != 0)
				{
					num4 = 2270;
					it.m_value = num4;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				if (num4 == 0)
				{
				}
				if (num4 != 0)
				{
					int num5 = 4760;
					it.m_value = num5;
				}
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				int num6 = 2278;
				it.m_value = num6;
			}
			if (playerWithHighestLuck.RollLuck(rarity) == 0)
			{
				int num7 = 2271;
				it.m_value = num7;
			}
			int num82;
			int num97;
			if (playerWithHighestLuck.RollLuck(rarity) != 0)
			{
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num8 = 2272;
					it.m_value = num8;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num9 = 2276;
					it.m_value = num9;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num10 = 2284;
					it.m_value = num10;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num11 = 2285;
					it.m_value = num11;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num12 = 2286;
					it.m_value = num12;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num13 = 2287;
					it.m_value = num13;
				}
				int num14;
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					num14 = 4744;
					it.m_value = num14;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (num14 == 0)
					{
					}
					if (num14 != 0)
					{
						int num15 = 2296;
						it.m_value = num15;
					}
				}
				int num16;
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					num16 = 3628;
					it.m_value = num16;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					if (num16 == 0)
					{
					}
					if (num16 != 0)
					{
						int num17 = 4091;
						it.m_value = num17;
					}
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num18 = 4603;
					it.m_value = num18;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num19 = 4604;
					it.m_value = num19;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num20 = 5297;
					it.m_value = num20;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num21 = 4605;
					it.m_value = num21;
				}
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					int num22 = 4550;
					it.m_value = num22;
				}
				int num23;
				if (playerWithHighestLuck.RollLuck(rarity) == 0)
				{
					num23 = 2268;
					it.m_value = num23;
				}
				int num24;
				if (num24 == 0)
				{
					if (num23 == 0)
					{
					}
					if (num23 != 0)
					{
						int num25 = 2269;
						it.m_value = num25;
					}
				}
				int num26;
				if (num26 == 0)
				{
					int num27 = 1988;
					it.m_value = num27;
				}
				int num28;
				if (num28 == 0)
				{
					int num29 = 2275;
					it.m_value = num29;
				}
				int num30;
				if (num30 == 0)
				{
					int num31 = 2279;
					it.m_value = num31;
				}
				int num32;
				if (num32 == 0)
				{
					int num33 = 2277;
					it.m_value = num33;
				}
				int num34;
				if (num34 == 0)
				{
					int num35 = 4555;
					it.m_value = num35;
				}
				int num36;
				if (num36 == 0)
				{
					int num37 = 4321;
					it.m_value = num37;
				}
				int num38;
				if (num38 == 0)
				{
					int num39 = 4323;
					it.m_value = num39;
				}
				int num40;
				if (num40 == 0)
				{
					int num41 = 5390;
					it.m_value = num41;
				}
				int num42;
				if (num42 == 0)
				{
					int num43 = 4549;
					it.m_value = num43;
				}
				int num44;
				if (num44 == 0)
				{
					int num45 = 4561;
					it.m_value = num45;
				}
				int num46;
				if (num46 == 0)
				{
					int num47 = 4774;
					it.m_value = num47;
				}
				int num48;
				if (num48 == 0)
				{
					int num49 = 5136;
					it.m_value = num49;
				}
				int num50;
				if (num50 == 0)
				{
					int num51 = 5305;
					it.m_value = num51;
				}
				int num52;
				if (num52 == 0)
				{
					int num53 = 4562;
					it.m_value = num53;
				}
				int num54;
				if (num54 == 0)
				{
					int num55 = 4558;
					it.m_value = num55;
				}
				int num56;
				if (num56 == 0)
				{
					int num57 = 4559;
					it.m_value = num57;
				}
				int num58;
				if (num58 == 0)
				{
					int num59 = 4563;
					it.m_value = num59;
				}
				int num60;
				int num61;
				if (num60 == 0)
				{
					num61 = 4666;
					it.m_value = num61;
				}
				int num62;
				int num64;
				if (num62 == 0)
				{
					if (num61 == 0)
					{
					}
					int num63 = 4347;
					it.m_value = num63;
					if (num63 == 0)
					{
					}
					if (num63 != 0)
					{
						num64 = 4348;
						it.m_value = num64;
					}
				}
				int num65;
				int num66;
				if (num65 == 0)
				{
					if (num64 == 0)
					{
					}
					if (num64 != 0)
					{
						num66 = 3262;
						it.m_value = num66;
					}
				}
				int num67;
				if (num67 == 0)
				{
					if (num66 == 0)
					{
					}
					if (num66 != 0)
					{
						int num68 = 3284;
						it.m_value = num68;
					}
				}
				int num69;
				if (num69 == 0)
				{
					int num70 = 2267;
					it.m_value = num70;
				}
				int num71;
				if (num71 == 0)
				{
					int num72 = 2214;
					it.m_value = num72;
				}
				int num73;
				if (num73 == 0)
				{
					int num74 = 2215;
					it.m_value = num74;
				}
				int num75;
				if (num75 == 0)
				{
					int num76 = 2216;
					it.m_value = num76;
				}
				int num77;
				if (num77 == 0)
				{
					int num78 = 2217;
					it.m_value = num78;
				}
				int num79;
				int num80;
				if (num79 == 0)
				{
					num80 = 3624;
					it.m_value = num80;
				}
				int num81;
				if (num81 == 0)
				{
					if (num80 == 0)
					{
					}
					num82 = 671;
					int num83 = 2273;
					it.m_value = num83;
				}
				int num84;
				if (num84 == 0)
				{
					int num85 = 2274;
					it.m_value = num85;
				}
				int num86;
				int num87;
				if (num86 == 0)
				{
					num87 = 2266;
					it.m_value = num87;
				}
				int num88;
				int num89;
				if (num88 == 0)
				{
					if (num87 == 0)
					{
					}
					num89 = 3;
					it.m_value = num87;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num90 = 2258;
					it.m_value = num90;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num91 = 2242;
					it.m_value = num91;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num92 = 2260;
					it.m_value = num92;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num93 = 3637;
					it.m_value = num93;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num94 = 4420;
					it.m_value = num94;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num95 = 3119;
					it.m_value = num95;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					int num96 = 3118;
					it.m_value = num96;
				}
				if (playerWithHighestLuck.RollLuck(num89) == 0)
				{
					num97 = 3099;
					it.m_value = num97;
				}
				return;
			}
			if (num97 == 0)
			{
			}
			while (num97 == 0)
			{
			}
			if (num97 == 0)
			{
			}
			while (num82 == 0)
			{
			}
			if (num82 == 0)
			{
			}
			while (num82 == 0)
			{
			}
			if (num82 == 0)
			{
			}
			int num98 = 2223;
			it.m_value = num98;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0006DF1C File Offset: 0x0006C11C
		public static void SetupTravelShop()
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num == 0)
			{
			}
			if (num == 0 || num2 != 0L)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool expertMode = Main.expertMode;
			bool flag = Chest.SetupTravelShop_CanAddItemToShop(int.MinValue);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0006DFC4 File Offset: 0x0006C1C4
		public void SetupShop(int type)
		{
			if (!true)
			{
			}
			double priceAdjustment = Main.LocalPlayer.currentShoppingSettings.PriceAdjustment;
			Item[] array = this.item;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x000712A8 File Offset: 0x0006F4A8
		private static bool BestiaryGirl_IsFairyTorchAvailable()
		{
			if (!true)
			{
			}
			bool flag = Chest.DidDiscoverBestiaryEntry(585);
			if (!true)
			{
			}
			bool flag2 = Chest.DidDiscoverBestiaryEntry(584);
			if (!true)
			{
			}
			return Chest.DidDiscoverBestiaryEntry(583);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000712E0 File Offset: 0x0006F4E0
		private static bool DidDiscoverBestiaryEntry(int npcId)
		{
			/*
An exception occurred when decompiling this method (06001ACC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Chest::DidDiscoverBestiaryEntry(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:IBestiaryUICollectionInfoProvider(var_1_09, ldfld:IBestiaryUICollectionInfoProvider(BestiaryEntry::UIInfoProvider, ldloc:BestiaryEntry(var_0)))
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

		// Token: 0x06001ACD RID: 6861 RVA: 0x000712F8 File Offset: 0x0006F4F8
		public static void AskForChestToEatItem(Vector2 worldPosition, int duration)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007130C File Offset: 0x0006F50C
		public static void UpdateChestFrames()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007135C File Offset: 0x0006F55C
		public void FixLoadedData()
		{
			long entityId = this.item.entityId;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00071378 File Offset: 0x0006F578
		// Note: this type is marked as 'beforefieldinit'.
		static Chest()
		{
		}

		// Token: 0x040027EF RID: 10223
		private static HashSet<int> _chestInUse;

		// Token: 0x040027F0 RID: 10224
		public const float chestStackRange = 600f;

		// Token: 0x040027F1 RID: 10225
		public const int maxChestTypes = 52;

		// Token: 0x040027F2 RID: 10226
		public static int[] chestTypeToIcon;

		// Token: 0x040027F3 RID: 10227
		public static int[] chestItemSpawn;

		// Token: 0x040027F4 RID: 10228
		public const int maxChestTypes2 = 17;

		// Token: 0x040027F5 RID: 10229
		public static int[] chestTypeToIcon2;

		// Token: 0x040027F6 RID: 10230
		public static int[] chestItemSpawn2;

		// Token: 0x040027F7 RID: 10231
		public const int maxDresserTypes = 43;

		// Token: 0x040027F8 RID: 10232
		public static int[] dresserTypeToIcon;

		// Token: 0x040027F9 RID: 10233
		public static int[] dresserItemSpawn;

		// Token: 0x040027FA RID: 10234
		public const int maxItems = 40;

		// Token: 0x040027FB RID: 10235
		public const int MaxNameLength = 29;

		// Token: 0x040027FC RID: 10236
		public Item[] item;

		// Token: 0x040027FD RID: 10237
		public int x;

		// Token: 0x040027FE RID: 10238
		public int y;

		// Token: 0x040027FF RID: 10239
		public bool bankChest;

		// Token: 0x04002800 RID: 10240
		public string name;

		// Token: 0x04002801 RID: 10241
		public int frameCounter;

		// Token: 0x04002802 RID: 10242
		public int frame;

		// Token: 0x04002803 RID: 10243
		public int eatingAnimationTime;

		// Token: 0x04002804 RID: 10244
		private static Item[] bartenderResort;

		// Token: 0x04002805 RID: 10245
		private static int forcedDDTier;
	}
}
