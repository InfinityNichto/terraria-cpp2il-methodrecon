using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007E4 RID: 2020
	public struct PlayerSittingHelper
	{
		// Token: 0x06004105 RID: 16645 RVA: 0x00244448 File Offset: 0x00242648
		public void GetSittingOffsetInfo(Player player, [Out] Vector2 posOffset, [Out] float seatAdjustment)
		{
			int num = this.sittingIndex;
			int direction = player.direction;
			float gravDir = player.gravDir;
			posOffset.X = (float)num;
			float y = this.offsetForSeat.Y;
			float x = posOffset.X;
			float y2 = posOffset.Y;
			float x2 = this.offsetForSeat.X;
			float y3 = this.offsetForSeat.Y;
			Vector2 directions = player.Directions;
			if (32640 == 0)
			{
			}
			posOffset.X = y;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x002444D8 File Offset: 0x002426D8
		public bool TryGetSittingBlock(Player player, [Out] Tile tile)
		{
			if (!true)
			{
			}
			tile._tileOffset = 1;
			Vector2 bottom = player.Bottom;
			Point point;
			Tile tileSafely = Framing.GetTileSafely(point);
			tile._tileOffset = tileSafely;
			return true;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00244510 File Offset: 0x00242710
		public void UpdateSitting(Player player)
		{
			Vector2 bottom = player.Bottom;
			bool active;
			if (!player.controlLeft && !player.controlRight && !player.controlUp && !player.controlDown && !player.controlJump && !player.pulley)
			{
				active = player.mount._active;
				if (!active)
				{
					int direction = player.direction;
				}
			}
			int num = 1;
			this.SitUp(player, num != 0);
			if (!active)
			{
			}
			int num2 = 1;
			this.SitUp(player, num2 != 0);
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x002445A4 File Offset: 0x002427A4
		public void SitUp(Player player, bool multiplayerBroadcast = true)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x002445C4 File Offset: 0x002427C4
		public void SitDown(Player player, int x, int y)
		{
			int num = 1;
			Vector2 bottom = player.Bottom;
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
			Vector2 bottom2 = player.Bottom;
			int num2 = 1;
			this.SitUp(player, num2 != 0);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0024468C File Offset: 0x0024288C
		public static bool GetSittingTargetInfo(Player player, int x, int y, [Out] int targetDirection, [Out] Vector2 playerSittingPosition, [Out] Vector2 seatDownOffset, [Out] ExtraSeatInfo extraInfo)
		{
			/*
An exception occurred when decompiling this method (0600410A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.PlayerSittingHelper::GetSittingTargetInfo(Terraria.Player,System.Int32,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Terraria.GameContent.ExtraSeatInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B5:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](playerSittingPosition), ldloc:float32(var_31_A2))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](targetDirection), ldloc:float32[exp:int32](var_31_A2))
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

		// Token: 0x04007EBC RID: 32444
		public const int ChairSittingMaxDistance = 40;

		// Token: 0x04007EBD RID: 32445
		public bool isSitting;

		// Token: 0x04007EBE RID: 32446
		public ExtraSeatInfo details;

		// Token: 0x04007EBF RID: 32447
		public Vector2 offsetForSeat;

		// Token: 0x04007EC0 RID: 32448
		public int sittingIndex;
	}
}
