using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000644 RID: 1604
	public static class PlayerDrawHeadLayers
	{
		// Token: 0x060036C1 RID: 14017 RVA: 0x0021E67C File Offset: 0x0021C87C
		public static void DrawPlayer_0_(PlayerDrawHeadSet drawinfo)
		{
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0021E68C File Offset: 0x0021C88C
		public static void DrawPlayer_00_BackHelmet(PlayerDrawHeadSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int head = drawPlayer.head;
			if (drawPlayer == null)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
			int width = drawinfo.bodyFrameMemory.Width;
			int cHead = drawinfo.cHead;
			float x = drawinfo.helmetOffset.X;
			float y = drawinfo.helmetOffset.Y;
			float x2 = drawinfo.Position.X;
			if (drawPlayer2 == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int width2 = drawinfo.bodyFrameMemory.Width;
			float y2 = drawinfo.Position.Y;
			int width3 = drawPlayer3.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int height = drawinfo.bodyFrameMemory.Height;
			int height2 = drawPlayer4.height;
			if (drawPlayer4 == null)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			float x3 = drawPlayer5.headPosition.X;
			float y3 = drawPlayer5.headPosition.Y;
			float x4 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float x5 = drawinfo.headVect.X;
			float y5 = drawinfo.headVect.Y;
			float scale = drawinfo.scale;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float headRotation = drawPlayer6.headRotation;
			DrawData[] drawData = drawinfo.DrawData;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0021E7EC File Offset: 0x0021C9EC
		public static void DrawPlayer_01_FaceSkin(PlayerDrawHeadSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			if (head == 0)
			{
			}
			Vector2 faceHeadOffsetFromHelmet = drawinfo.drawPlayer.GetFaceHeadOffsetFromHelmet();
			int cFaceHead = drawinfo.cFaceHead;
			if (head == 0)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int width = drawinfo.bodyFrameMemory.Width;
			float y = drawinfo.Position.Y;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawinfo.bodyFrameMemory.Height;
			int height2 = drawPlayer3.height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x2 = drawPlayer4.headPosition.X;
			float y2 = drawPlayer4.headPosition.Y;
			if (drawPlayer == null)
			{
			}
			float x3 = drawinfo.headVect.X;
			float y3 = drawinfo.headVect.Y;
			Player drawPlayer5 = drawinfo.drawPlayer;
			Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
			int width3 = drawinfo.bodyFrameMemory.Width;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float x4 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			float scale = drawinfo.scale;
			float headRotation = drawPlayer5.headRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			DrawData[] drawData = drawinfo.DrawData;
			int num = 72;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Player drawPlayer7 = drawinfo.drawPlayer;
			if (num != 0)
			{
				int direction = drawPlayer7.direction;
				int cFace = drawinfo.cFace;
				Player drawPlayer8;
				if (direction == 0)
				{
					drawPlayer8 = drawinfo.drawPlayer;
				}
				float x5 = drawinfo.Position.X;
				Vector2 position = drawPlayer8.position;
				if (direction == 0)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				Player drawPlayer9 = drawinfo.drawPlayer;
				int width4 = drawinfo.bodyFrameMemory.Width;
				float y5 = drawinfo.Position.Y;
				int width5 = drawPlayer9.width;
				Vector2 screenPosition4 = Main.screenPosition;
				Player drawPlayer10 = drawinfo.drawPlayer;
				int height3 = drawPlayer10.height;
				int height4 = drawinfo.bodyFrameMemory.Height;
				return;
			}
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0021EFE4 File Offset: 0x0021D1E4
		public static void DrawPlayer_02_DrawArmorWithFullHair(PlayerDrawHeadSet drawinfo)
		{
			bool fullHair = drawinfo.fullHair;
			if (fullHair)
			{
				Color colorArmorHead = drawinfo.colorArmorHead;
				int cHead = drawinfo.cHead;
				if (!fullHair)
				{
				}
				bool isDisplayDollOrInanimate = drawinfo.drawPlayer.isDisplayDollOrInanimate;
				int skinDyePacked = drawinfo.skinDyePacked;
				Player drawPlayer;
				if (!isDisplayDollOrInanimate)
				{
					drawPlayer = drawinfo.drawPlayer;
				}
				float x = drawinfo.helmetOffset.X;
				float y = drawinfo.helmetOffset.Y;
				float x2 = drawinfo.Position.X;
				Vector2 position = drawPlayer.position;
				if (!isDisplayDollOrInanimate)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int width = drawinfo.bodyFrameMemory.Width;
				float y2 = drawinfo.Position.Y;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawinfo.bodyFrameMemory.Height;
				int height2 = drawPlayer3.height;
				if (drawPlayer3 == null)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x3 = drawPlayer4.headPosition.X;
				float y3 = drawPlayer4.headPosition.Y;
				float x4 = drawinfo.headVect.X;
				float y4 = drawinfo.headVect.Y;
				Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
				int width3 = drawinfo.bodyFrameMemory.Width;
				float x5 = drawinfo.headVect.X;
				float y5 = drawinfo.headVect.Y;
				float scale = drawinfo.scale;
				Player drawPlayer5 = drawinfo.drawPlayer;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				float headRotation = drawPlayer5.headRotation;
				DrawData[] drawData = drawinfo.DrawData;
				if (!drawinfo.drawPlayer.invis)
				{
					bool hideHair = drawinfo.hideHair;
					if (!hideHair)
					{
						Rectangle bodyFrameMemory2 = drawinfo.bodyFrameMemory;
						int width4 = drawinfo.bodyFrameMemory.Width;
						int hairShaderPacked = drawinfo.hairShaderPacked;
						Player drawPlayer6;
						if (!hideHair)
						{
							drawPlayer6 = drawinfo.drawPlayer;
						}
						float x6 = drawinfo.Position.X;
						Vector2 position2 = drawPlayer6.position;
						if (!hideHair)
						{
						}
						Vector2 screenPosition3 = Main.screenPosition;
						Player drawPlayer7 = drawinfo.drawPlayer;
						int width5 = drawinfo.bodyFrameMemory.Width;
						float y6 = drawinfo.Position.Y;
						int width6 = drawPlayer7.width;
						Vector2 screenPosition4 = Main.screenPosition;
						int height3 = drawinfo.drawPlayer.height;
						int height4 = drawinfo.bodyFrameMemory.Height;
						Player drawPlayer8 = drawinfo.drawPlayer;
						float x7 = drawPlayer8.headPosition.X;
						float y7 = drawPlayer8.headPosition.Y;
						if (!hideHair)
						{
						}
						float x8 = drawinfo.headVect.X;
						float y8 = drawinfo.headVect.Y;
						float x9 = drawinfo.hairOffset.X;
						float y9 = drawinfo.hairOffset.Y;
						Player drawPlayer9 = drawinfo.drawPlayer;
						Color colorHair = drawinfo.colorHair;
						float x10 = drawinfo.headVect.X;
						float y10 = drawinfo.headVect.Y;
						float scale2 = drawinfo.scale;
						float headRotation2 = drawPlayer9.headRotation;
						SpriteEffects playerEffect2 = drawinfo.playerEffect;
						DrawData[] drawData2 = drawinfo.DrawData;
					}
				}
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0021F2CC File Offset: 0x0021D4CC
		public static void DrawPlayer_03_HelmetHair(PlayerDrawHeadSet drawinfo)
		{
			while (!drawinfo.hideHair)
			{
				if (drawinfo.hatHair)
				{
					bool invis = drawinfo.drawPlayer.invis;
					while (invis)
					{
					}
					Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
					int width = drawinfo.bodyFrameMemory.Width;
					int hairShaderPacked = drawinfo.hairShaderPacked;
					Player drawPlayer;
					if (!invis)
					{
						drawPlayer = drawinfo.drawPlayer;
					}
					float x = drawinfo.Position.X;
					Vector2 position = drawPlayer.position;
					if (!invis)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer2 = drawinfo.drawPlayer;
					int width2 = drawinfo.bodyFrameMemory.Width;
					float y = drawinfo.Position.Y;
					int width3 = drawPlayer2.width;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer3 = drawinfo.drawPlayer;
					int height = drawinfo.bodyFrameMemory.Height;
					int height2 = drawPlayer3.height;
					Player drawPlayer4 = drawinfo.drawPlayer;
					float x2 = drawPlayer4.headPosition.X;
					float y2 = drawPlayer4.headPosition.Y;
					if (!invis)
					{
					}
					float x3 = drawinfo.headVect.X;
					float y3 = drawinfo.headVect.Y;
					Player drawPlayer5 = drawinfo.drawPlayer;
					Color colorHair = drawinfo.colorHair;
					float x4 = drawinfo.headVect.X;
					float y4 = drawinfo.headVect.Y;
					float scale = drawinfo.scale;
					float headRotation = drawPlayer5.headRotation;
					SpriteEffects playerEffect = drawinfo.playerEffect;
					DrawData[] drawData = drawinfo.DrawData;
					return;
				}
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x0021F428 File Offset: 0x0021D628
		public static void DrawPlayer_04_CapricornMask(PlayerDrawHeadSet drawinfo)
		{
			Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
			int width = drawinfo.bodyFrameMemory.Width;
			int cHead = drawinfo.cHead;
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.helmetOffset.X;
			float y = drawinfo.helmetOffset.Y;
			float x2 = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int width2 = drawinfo.bodyFrameMemory.Width;
			float y2 = drawinfo.Position.Y;
			int width3 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawinfo.bodyFrameMemory.Height;
			int height2 = drawPlayer3.height;
			if (drawPlayer3 == null)
			{
			}
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x3 = drawPlayer4.headPosition.X;
			float y3 = drawPlayer4.headPosition.Y;
			float x4 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			Player drawPlayer5 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float x5 = drawinfo.headVect.X;
			float y5 = drawinfo.headVect.Y;
			float scale = drawinfo.scale;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float headRotation = drawPlayer5.headRotation;
			DrawData[] drawData = drawinfo.DrawData;
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0021F574 File Offset: 0x0021D774
		public static void DrawPlayer_04_RabbitOrder(PlayerDrawHeadSet drawinfo)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Player.RabbitOrderFrameHelper rabbitOrderFrame = drawinfo.drawPlayer.rabbitOrderFrame;
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			if (num == 0)
			{
			}
			int num2 = 4955;
			int hatStacks = PlayerDrawHeadLayers.GetHatStacks(drawinfo, num2);
			float x = drawinfo.drawPlayer.position.X;
			int num3 = 14;
			if (!true)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float scale = drawinfo.scale;
			int direction = drawPlayer.direction;
			int cHead = drawinfo.cHead;
			Player drawPlayer2 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float scale2 = drawinfo.scale;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float headRotation = drawPlayer2.headRotation;
			DrawData[] drawData = drawinfo.DrawData;
			if (!drawinfo.drawPlayer.invis)
			{
				bool hideHair = drawinfo.hideHair;
				if (!hideHair)
				{
					Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
					int width = drawinfo.bodyFrameMemory.Width;
					int hairShaderPacked = drawinfo.hairShaderPacked;
					if (!hideHair)
					{
						Player drawPlayer3 = drawinfo.drawPlayer;
					}
					float x2 = drawinfo.Position.X;
					if (num3 == 0)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer4 = drawinfo.drawPlayer;
					int width2 = drawinfo.bodyFrameMemory.Width;
					float y = drawinfo.Position.Y;
					int width3 = drawPlayer4.width;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer5 = drawinfo.drawPlayer;
					int height = drawinfo.bodyFrameMemory.Height;
					int height2 = drawPlayer5.height;
					Player drawPlayer6 = drawinfo.drawPlayer;
					float x3 = drawPlayer6.headPosition.X;
					float y2 = drawPlayer6.headPosition.Y;
					if (num3 == 0)
					{
					}
					float x4 = drawinfo.headVect.X;
					float y3 = drawinfo.headVect.Y;
					float x5 = drawinfo.hairOffset.X;
					float y4 = drawinfo.hairOffset.Y;
					Player drawPlayer7 = drawinfo.drawPlayer;
					Color colorHair = drawinfo.colorHair;
					float x6 = drawinfo.headVect.X;
					float y5 = drawinfo.headVect.Y;
					float scale3 = drawinfo.scale;
					float headRotation2 = drawPlayer7.headRotation;
					SpriteEffects playerEffect2 = drawinfo.playerEffect;
					DrawData[] drawData2 = drawinfo.DrawData;
				}
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0021F788 File Offset: 0x0021D988
		public static void DrawPlayer_04_BadgersHat(PlayerDrawHeadSet drawinfo)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Player.RabbitOrderFrameHelper rabbitOrderFrame = drawinfo.drawPlayer.rabbitOrderFrame;
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			if (num == 0)
			{
			}
			int num2 = 5004;
			int hatStacks = PlayerDrawHeadLayers.GetHatStacks(drawinfo, num2);
			float x = drawinfo.drawPlayer.position.X;
			long num3 = 0L;
			if (num3 != 0L)
			{
				return;
			}
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0021F84C File Offset: 0x0021DA4C
		private static Vector2 DrawPlayer_04_GetHatDrawPosition(PlayerDrawHeadSet drawinfo, Vector2 hatOffset, int usedGravDir)
		{
			/*
An exception occurred when decompiling this method (060036C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.DataStructures.PlayerDrawHeadLayers::DrawPlayer_04_GetHatDrawPosition(Terraria.DataStructures.PlayerDrawHeadSet,Microsoft.Xna.Framework.Vector2,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0036:
	stloc:Player(var_8_3F, ldfld:Player(PlayerDrawHeadSet::drawPlayer, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo)))
	stloc:int32(var_9_4C, ldfld:int32(Rectangle::Width, ldfld:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](PlayerDrawHeadSet::bodyFrameMemory, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo))))
	stloc:bool(var_10_54, ldfld:bool(PlayerDrawHeadSet::fullHair, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo)))
	stloc:int32(var_11_5D, ldfld:int32(Entity::width, ldloc:Player[exp:Entity](var_8_3F)))
	stloc:bool(var_12_66, ldfld:bool(Entity::wet, ldloc:Player[exp:Entity](var_8_3F)))
	stloc:float32(var_17_74, ldfld:float32(PlayerDrawHeadSet::scale, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo)))
	stloc:Player(var_22_82, ldfld:Player(PlayerDrawHeadSet::drawPlayer, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo)))
	stloc:float32(var_23_8F, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](PlayerDrawHeadSet::headVect, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo))))
	stloc:float32(var_24_9C, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](PlayerDrawHeadSet::headVect, ldloc:PlayerDrawHeadSet[exp:valuetype Terraria.DataStructures.PlayerDrawHeadSet&](drawinfo))))
	stloc:float32(var_25_AA, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Player::headPosition, ldloc:Player(var_22_82))))
	stloc:float32(var_26_B8, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Player::headPosition, ldloc:Player(var_22_82))))
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

		// Token: 0x060036CA RID: 14026 RVA: 0x0021F918 File Offset: 0x0021DB18
		private static int GetHatStacks(PlayerDrawHeadSet drawinfo, int itemId)
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0021F928 File Offset: 0x0021DB28
		public static void DrawPlayer_04_HatsWithFullHair(PlayerDrawHeadSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			PlayerDrawHeadLayers.DrawPlayer_04_RabbitOrder(drawinfo);
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0021FC30 File Offset: 0x0021DE30
		public static void DrawPlayer_05_TallHats(PlayerDrawHeadSet drawinfo)
		{
			if (drawinfo.helmetIsTall)
			{
				Player drawPlayer = drawinfo.drawPlayer;
				Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
				int width = drawinfo.bodyFrameMemory.Width;
				int head = drawPlayer.head;
				long num = 0L;
				Color colorArmorHead = drawinfo.colorArmorHead;
				int cHead = drawinfo.cHead;
				Player drawPlayer2;
				int head2;
				if (num == 0L)
				{
					drawPlayer2 = drawinfo.drawPlayer;
					head2 = drawPlayer2.head;
				}
				bool isDisplayDollOrInanimate;
				if (num != 0L)
				{
					isDisplayDollOrInanimate = drawPlayer2.isDisplayDollOrInanimate;
					int skinDyePacked = drawinfo.skinDyePacked;
				}
				Player drawPlayer3;
				if (!isDisplayDollOrInanimate)
				{
					drawPlayer3 = drawinfo.drawPlayer;
				}
				float x = drawinfo.helmetOffset.X;
				float y = drawinfo.helmetOffset.Y;
				float lifeSteal = drawPlayer3.lifeSteal;
				float x2 = drawinfo.Position.X;
				if (head2 == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer4 = drawinfo.drawPlayer;
				int width2 = drawinfo.bodyFrameMemory.Width;
				float y2 = drawinfo.Position.Y;
				int width3 = drawPlayer4.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer5 = drawinfo.drawPlayer;
				int height = drawinfo.bodyFrameMemory.Height;
				int height2 = drawPlayer5.height;
				if (drawPlayer5 == null)
				{
				}
				Player drawPlayer6 = drawinfo.drawPlayer;
				float x3 = drawPlayer6.headPosition.X;
				float y3 = drawPlayer6.headPosition.Y;
				float x4 = drawinfo.headVect.X;
				float y4 = drawinfo.headVect.Y;
				Player drawPlayer7 = drawinfo.drawPlayer;
				float x5 = drawinfo.headVect.X;
				float y5 = drawinfo.headVect.Y;
				float scale = drawinfo.scale;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				float headRotation = drawPlayer7.headRotation;
				DrawData[] drawData = drawinfo.DrawData;
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0021FDE8 File Offset: 0x0021DFE8
		public static void DrawPlayer_06_NormalHats(PlayerDrawHeadSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			PlayerDrawHeadLayers.DrawPlayer_04_CapricornMask(drawinfo);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x002200E4 File Offset: 0x0021E2E4
		public static void DrawPlayer_07_JustHair(PlayerDrawHeadSet drawinfo)
		{
			if (!drawinfo.helmetIsNormal && !drawinfo.helmetIsOverFullHair && !drawinfo.helmetIsTall)
			{
				bool hideHair = drawinfo.hideHair;
				if (!hideHair)
				{
					Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
					int width = drawinfo.bodyFrameMemory.Width;
					int hairShaderPacked = drawinfo.hairShaderPacked;
					if (!hideHair)
					{
					}
					Player drawPlayer = drawinfo.drawPlayer;
					float x = drawinfo.Position.X;
					if (drawPlayer == null)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer2 = drawinfo.drawPlayer;
					int width2 = drawinfo.bodyFrameMemory.Width;
					float y = drawinfo.Position.Y;
					int width3 = drawPlayer2.width;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer3 = drawinfo.drawPlayer;
					int height = drawinfo.bodyFrameMemory.Height;
					int height2 = drawPlayer3.height;
					Player drawPlayer4 = drawinfo.drawPlayer;
					float x2 = drawPlayer4.headPosition.X;
					float y2 = drawPlayer4.headPosition.Y;
					if (drawPlayer == null)
					{
					}
					float x3 = drawinfo.headVect.X;
					float y3 = drawinfo.headVect.Y;
					float x4 = drawinfo.hairOffset.X;
					float y4 = drawinfo.hairOffset.Y;
					Player drawPlayer5 = drawinfo.drawPlayer;
					Color colorHair = drawinfo.colorHair;
					float x5 = drawinfo.headVect.X;
					float y5 = drawinfo.headVect.Y;
					float scale = drawinfo.scale;
					float headRotation = drawPlayer5.headRotation;
					SpriteEffects playerEffect = drawinfo.playerEffect;
					DrawData[] drawData = drawinfo.DrawData;
				}
			}
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00220264 File Offset: 0x0021E464
		public static void DrawPlayer_08_FaceAcc(PlayerDrawHeadSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			Player drawPlayer = drawinfo.drawPlayer;
			int head2 = drawPlayer.head;
			Vector2 beardDrawOffsetFromHelmet = drawPlayer.GetBeardDrawOffsetFromHelmet();
			Color colorArmorHead = drawinfo.colorArmorHead;
			Vector2 position = drawinfo.drawPlayer.position;
			if (position != null)
			{
				Color colorHair = drawinfo.colorHair;
			}
			int cBeard = drawinfo.cBeard;
			Player drawPlayer2;
			if (position == null)
			{
				drawPlayer2 = drawinfo.drawPlayer;
			}
			float x = drawinfo.Position.X;
			Vector2 position2 = drawPlayer2.position;
			if (position == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int width = drawinfo.bodyFrameMemory.Width;
			float y = drawinfo.Position.Y;
			int width2 = drawPlayer3.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int height = drawPlayer4.height;
			int height2 = drawinfo.bodyFrameMemory.Height;
			if (drawPlayer4 == null)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			float x2 = drawPlayer5.headPosition.X;
			float y2 = drawPlayer5.headPosition.Y;
			float x3 = drawinfo.headVect.X;
			float y3 = drawinfo.headVect.Y;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Rectangle bodyFrameMemory = drawinfo.bodyFrameMemory;
			int width3 = drawinfo.bodyFrameMemory.Width;
			float x4 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			float scale = drawinfo.scale;
			float headRotation = drawPlayer6.headRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			DrawData[] drawData = drawinfo.DrawData;
			Player drawPlayer7 = drawinfo.drawPlayer;
			Player drawPlayer8 = drawinfo.drawPlayer;
			if (!true)
			{
			}
			sbyte face = drawinfo.drawPlayer.face;
			int cFace = drawinfo.cFace;
			if (face == 0)
			{
			}
			Player drawPlayer9 = drawinfo.drawPlayer;
			float x5 = drawinfo.Position.X;
			if (drawPlayer9 == null)
			{
			}
			Vector2 screenPosition3 = Main.screenPosition;
			Player drawPlayer10 = drawinfo.drawPlayer;
			int width4 = drawinfo.bodyFrameMemory.Width;
			float y5 = drawinfo.Position.Y;
			int width5 = drawPlayer10.width;
			Vector2 screenPosition4 = Main.screenPosition;
			Player drawPlayer11 = drawinfo.drawPlayer;
			int height3 = drawPlayer11.height;
			int height4 = drawinfo.bodyFrameMemory.Height;
			if (drawPlayer11 == null)
			{
			}
			Player drawPlayer12 = drawinfo.drawPlayer;
			float x6 = drawPlayer12.headPosition.X;
			float y6 = drawPlayer12.headPosition.Y;
			float x7 = drawinfo.headVect.X;
			float y7 = drawinfo.headVect.Y;
			Player drawPlayer13 = drawinfo.drawPlayer;
			Rectangle bodyFrameMemory2 = drawinfo.bodyFrameMemory;
			int width6 = drawinfo.bodyFrameMemory.Width;
			Color colorArmorHead2 = drawinfo.colorArmorHead;
			float x8 = drawinfo.headVect.X;
			float y8 = drawinfo.headVect.Y;
			float scale2 = drawinfo.scale;
			float headRotation2 = drawPlayer13.headRotation;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			DrawData[] drawData2 = drawinfo.DrawData;
			Player drawPlayer14 = drawinfo.drawPlayer;
			if (drawPlayer14 == null)
			{
			}
			int cFaceFlower = drawinfo.cFaceFlower;
			if (drawPlayer14 == null)
			{
			}
			Player drawPlayer15 = drawinfo.drawPlayer;
			float x9 = drawinfo.Position.X;
			bool canCarpet = drawPlayer14.canCarpet;
			if (drawPlayer15 == null)
			{
			}
			Vector2 screenPosition5 = Main.screenPosition;
			Player drawPlayer16 = drawinfo.drawPlayer;
			int width7 = drawinfo.bodyFrameMemory.Width;
			float y9 = drawinfo.Position.Y;
			int width8 = drawPlayer16.width;
			Vector2 screenPosition6 = Main.screenPosition;
			int num = 52992;
			int height5 = drawinfo.drawPlayer.height;
			int height6 = drawinfo.bodyFrameMemory.Height;
			Player drawPlayer17 = drawinfo.drawPlayer;
			float x10 = drawPlayer17.headPosition.X;
			float y10 = drawPlayer17.headPosition.Y;
			if (num == 0)
			{
			}
			float x11 = drawinfo.headVect.X;
			float y11 = drawinfo.headVect.Y;
			Player drawPlayer18 = drawinfo.drawPlayer;
			Rectangle bodyFrameMemory3 = drawinfo.bodyFrameMemory;
			int width9 = drawinfo.bodyFrameMemory.Width;
			Color colorArmorHead3 = drawinfo.colorArmorHead;
			float x12 = drawinfo.headVect.X;
			float y12 = drawinfo.headVect.Y;
			float scale3 = drawinfo.scale;
			float headRotation3 = drawPlayer18.headRotation;
			SpriteEffects playerEffect3 = drawinfo.playerEffect;
			DrawData[] drawData3 = drawinfo.DrawData;
			bool drawUnicornHorn = drawinfo.drawUnicornHorn;
			if (drawUnicornHorn)
			{
				int cUnicornHorn = drawinfo.cUnicornHorn;
				if (!drawUnicornHorn)
				{
				}
				float x13 = drawinfo.Position.X;
				if (num == 0)
				{
				}
				Vector2 screenPosition7 = Main.screenPosition;
				Player drawPlayer19 = drawinfo.drawPlayer;
				int width10 = drawinfo.bodyFrameMemory.Width;
				float y13 = drawinfo.Position.Y;
				int width11 = drawPlayer19.width;
				Vector2 screenPosition8 = Main.screenPosition;
				int height7 = drawinfo.drawPlayer.height;
				int height8 = drawinfo.bodyFrameMemory.Height;
				Player drawPlayer20 = drawinfo.drawPlayer;
				float x14 = drawPlayer20.headPosition.X;
				float y14 = drawPlayer20.headPosition.Y;
				if (num == 0)
				{
				}
				float x15 = drawinfo.headVect.X;
				float y15 = drawinfo.headVect.Y;
				Player drawPlayer21 = drawinfo.drawPlayer;
				Rectangle bodyFrameMemory4 = drawinfo.bodyFrameMemory;
				int width12 = drawinfo.bodyFrameMemory.Width;
				Color colorArmorHead4 = drawinfo.colorArmorHead;
				float x16 = drawinfo.headVect.X;
				float y16 = drawinfo.headVect.Y;
				float scale4 = drawinfo.scale;
				float headRotation4 = drawPlayer21.headRotation;
				SpriteEffects playerEffect4 = drawinfo.playerEffect;
				DrawData[] drawData4 = drawinfo.DrawData;
			}
			bool drawAngelHalo = drawinfo.drawAngelHalo;
			if (drawAngelHalo)
			{
				if (!drawAngelHalo)
				{
				}
				int cAngelHalo = drawinfo.cAngelHalo;
				if (!drawAngelHalo)
				{
				}
				float x17 = drawinfo.Position.X;
				Vector2 screenPosition9 = Main.screenPosition;
				Player drawPlayer22 = drawinfo.drawPlayer;
				int width13 = drawinfo.bodyFrameMemory.Width;
				float y17 = drawinfo.Position.Y;
				int width14 = drawPlayer22.width;
				Vector2 screenPosition10 = Main.screenPosition;
				int num2 = 52992;
				int height9 = drawinfo.drawPlayer.height;
				int height10 = drawinfo.bodyFrameMemory.Height;
				Player drawPlayer23 = drawinfo.drawPlayer;
				float x18 = drawPlayer23.headPosition.X;
				float y18 = drawPlayer23.headPosition.Y;
				if (num2 == 0)
				{
				}
				float x19 = drawinfo.headVect.X;
				float y19 = drawinfo.headVect.Y;
				Rectangle bodyFrameMemory5 = drawinfo.bodyFrameMemory;
				int width15 = drawinfo.bodyFrameMemory.Width;
				Player drawPlayer24 = drawinfo.drawPlayer;
				float x20 = drawinfo.headVect.X;
				float y20 = drawinfo.headVect.Y;
				float scale5 = drawinfo.scale;
				SpriteEffects playerEffect5 = drawinfo.playerEffect;
				float headRotation5 = drawPlayer24.headRotation;
				DrawData[] drawData5 = drawinfo.DrawData;
			}
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x002208EC File Offset: 0x0021EAEC
		public static void DrawPlayer_RenderAllLayers(PlayerDrawHeadSet drawinfo)
		{
			int num = 1;
			DrawData[] drawData = drawinfo.DrawData;
			if (num == 0)
			{
			}
			Effect pixelShader = Main.pixelShader;
			Player drawPlayer = drawinfo.drawPlayer;
			int cHead = drawinfo.cHead;
			EffectTechnique <CurrentTechnique>k__BackingField = pixelShader.<CurrentTechnique>k__BackingField;
			long num2 = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num2];
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0022093C File Offset: 0x0021EB3C
		public static void DrawPlayer_DrawSelectionRect(PlayerDrawHeadSet drawinfo)
		{
			DrawData[] drawData = drawinfo.DrawData;
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			Vector2 screenPosition2 = Main.screenPosition;
			if (!true)
			{
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00220970 File Offset: 0x0021EB70
		public static void QuickCDD(PlayerDrawHeadSet drawData, Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			DrawData[] drawData2 = drawData.DrawData;
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00220984 File Offset: 0x0021EB84
		public static void QuickCDD(PlayerDrawHeadSet drawData, int shaderTechnique, Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			DrawData[] drawData2 = drawData.DrawData;
		}
	}
}
