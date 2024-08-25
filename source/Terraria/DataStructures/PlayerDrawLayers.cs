using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000642 RID: 1602
	public static class PlayerDrawLayers
	{
		// Token: 0x0600366B RID: 13931 RVA: 0x00213158 File Offset: 0x00211358
		public static void DrawPlayer_extra_TorsoPlus(PlayerDrawSet drawinfo)
		{
			float y = drawinfo.Position.Y;
			float torsoOffset = drawinfo.torsoOffset;
			float y2 = drawinfo.ItemLocation.Y;
			drawinfo.Position.Y = y;
			drawinfo.ItemLocation.Y = torsoOffset;
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0021319C File Offset: 0x0021139C
		public static void DrawPlayer_extra_TorsoMinus(PlayerDrawSet drawinfo)
		{
			float y = drawinfo.Position.Y;
			float torsoOffset = drawinfo.torsoOffset;
			float y2 = drawinfo.ItemLocation.Y;
			drawinfo.Position.Y = y;
			drawinfo.ItemLocation.Y = torsoOffset;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x002131E0 File Offset: 0x002113E0
		public static void DrawPlayer_extra_MountPlus(PlayerDrawSet drawinfo)
		{
			float mountOffSet = drawinfo.mountOffSet;
			float y = drawinfo.Position.Y;
			drawinfo.Position.Y = mountOffSet;
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0021320C File Offset: 0x0021140C
		public static void DrawPlayer_extra_MountMinus(PlayerDrawSet drawinfo)
		{
			float mountOffSet = drawinfo.mountOffSet;
			float y = drawinfo.Position.Y;
			drawinfo.Position.Y = mountOffSet;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00213238 File Offset: 0x00211438
		public static void DrawCompositeArmorPiece(PlayerDrawSet drawinfo, CompositePlayerDrawContext context, DrawData data)
		{
			drawinfo.AddDrawData(data);
			uint num;
			if (num != 0U)
			{
				float x = data.position.X;
				float y = data.position.Y;
				Rectangle sourceRect = data.sourceRect;
				int width = data.sourceRect.Width;
				int width2 = data.sourceRect.Width;
				Player drawPlayer = drawinfo.drawPlayer;
				Color armGlowColor = drawinfo.armGlowColor;
				int body = drawPlayer.body;
				long num2 = 0L;
				if (width == 0)
				{
				}
				if (num2 == 0L)
				{
				}
				return;
			}
			int head = drawinfo.drawPlayer.head;
			float x2 = drawinfo.helmetOffset.X;
			float y2 = drawinfo.helmetOffset.Y;
			float x3 = drawinfo.Position.X;
			if (head == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y3 = drawinfo.Position.Y;
			int width3 = drawPlayer2.bodyFrame.Width;
			int width4 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x4 = drawPlayer4.headPosition.X;
			float y4 = drawPlayer4.headPosition.Y;
			float x5 = drawinfo.headVect.X;
			float y5 = drawinfo.headVect.Y;
			if (drawPlayer4 == null)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float x6 = drawinfo.headVect.X;
			int y6 = drawPlayer4.headFrame.Y;
			float y7 = drawinfo.headVect.Y;
			float headRotation = drawPlayer5.headRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cHead = drawinfo.cHead;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color headGlowColor = drawinfo.headGlowColor;
			float x7 = drawinfo.headVect.X;
			float y8 = drawinfo.headVect.Y;
			float headRotation2 = drawPlayer6.headRotation;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			int cHead2 = drawinfo.cHead;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0021351C File Offset: 0x0021171C
		public static void DrawPlayer_01_BackHair(PlayerDrawSet drawinfo)
		{
			if (!drawinfo.hideHair && drawinfo.backHairDraw)
			{
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer.bodyFrame.Width;
				int width2 = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num = 52992;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int height = drawPlayer2.height;
				int height2 = drawPlayer2.bodyFrame.Height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				float x2 = drawPlayer3.headPosition.X;
				float y2 = drawPlayer3.headPosition.Y;
				if (num == 0)
				{
				}
				float x3 = drawinfo.headVect.X;
				float y3 = drawinfo.headVect.Y;
				float x4 = drawinfo.hairOffset.X;
				float y4 = drawinfo.hairOffset.Y;
				int head = drawinfo.drawPlayer.head;
				bool drawsBackHairWithoutHeadgear;
				if (!drawinfo.fullHair)
				{
					drawsBackHairWithoutHeadgear = drawinfo.drawsBackHairWithoutHeadgear;
					if (!drawsBackHairWithoutHeadgear)
					{
						bool hatHair = drawinfo.hatHair;
						while (!hatHair)
						{
						}
						if (!hatHair)
						{
							Player drawPlayer4 = drawinfo.drawPlayer;
						}
						return;
					}
				}
				Player drawPlayer5;
				if (!drawsBackHairWithoutHeadgear)
				{
					drawPlayer5 = drawinfo.drawPlayer;
				}
				Rectangle hairBackFrame = drawinfo.hairBackFrame;
				int width3 = drawinfo.hairBackFrame.Width;
				Color colorHair = drawinfo.colorHair;
				float headRotation = drawPlayer5.headRotation;
				float x5 = drawinfo.headVect.X;
				float y5 = drawinfo.headVect.Y;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int hairDyePacked = drawinfo.hairDyePacked;
			}
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x002136A8 File Offset: 0x002118A8
		public static void DrawPlayer_02_MountBehindPlayer(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer.mount._active)
			{
				PlayerDrawLayers.DrawMeowcartTrail(drawinfo);
				PlayerDrawLayers.DrawTiedBalloons(drawinfo);
				Player drawPlayer = drawinfo.drawPlayer;
				float shadow = drawinfo.shadow;
				float x = drawinfo.Position.X;
				float y = drawinfo.Position.Y;
				Color colorMount = drawinfo.colorMount;
				Mount mount = drawPlayer.mount;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float shadow2 = drawinfo.shadow;
				float x2 = drawinfo.Position.X;
				float y2 = drawinfo.Position.Y;
				Color colorMount2 = drawinfo.colorMount;
				Mount mount2 = drawPlayer2.mount;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
				return;
			}
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00213758 File Offset: 0x00211958
		public static void DrawPlayer_03_Carpet(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int carpetFrame = drawPlayer.carpetFrame;
			float gravDir = drawPlayer.gravDir;
			Color colorArmorLegs = drawinfo.colorArmorLegs;
			if (drawPlayer == null)
			{
			}
			float x = drawinfo.Position.X;
			bool impMinion = drawPlayer.impMinion;
			if (carpetFrame == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			float gravDir2 = drawPlayer3.gravDir;
			if (height == 0)
			{
			}
			int carpetFrame2 = drawinfo.drawPlayer.carpetFrame;
			float bodyRotation = drawinfo.drawPlayer.bodyRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cCarpet = drawinfo.cCarpet;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00213818 File Offset: 0x00211A18
		public static void DrawPlayer_03_PortableStool(PlayerDrawSet drawinfo)
		{
			bool isInUse = drawinfo.drawPlayer.portableStoolInfo.IsInUse;
			if (isInUse)
			{
				if (!isInUse)
				{
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int height = drawinfo.drawPlayer.height;
				if (52992 == 0)
				{
				}
				Rectangle rectangle;
				Vector2 vector = rectangle.Size();
				if (52992 == 0)
				{
				}
				Player drawPlayer2 = drawinfo.drawPlayer;
				Color colorArmorLegs = drawinfo.colorArmorLegs;
				float bodyRotation = drawPlayer2.bodyRotation;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cPortableStool = drawinfo.cPortableStool;
			}
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x002138CC File Offset: 0x00211ACC
		public static void DrawPlayer_04_ElectrifiedDebuffBack(PlayerDrawSet drawinfo)
		{
			bool electrified = drawinfo.drawPlayer.electrified;
			if (electrified)
			{
				float shadow = drawinfo.shadow;
				if (!electrified)
				{
					Player drawPlayer = drawinfo.drawPlayer;
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				Player drawPlayer5 = drawinfo.drawPlayer;
				int width3 = drawPlayer5.bodyFrame.Width;
				int height3 = drawPlayer5.bodyFrame.Height;
				Player drawPlayer6 = drawinfo.drawPlayer;
				Color colorElectricity = drawinfo.colorElectricity;
				float bodyRotation = drawPlayer6.bodyRotation;
				SpriteEffects playerEffect = drawinfo.playerEffect;
			}
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x002139E0 File Offset: 0x00211BE0
		public static void DrawPlayer_05_ForbiddenSetRing(PlayerDrawSet drawinfo)
		{
			bool setForbidden = drawinfo.drawPlayer.setForbidden;
			if (setForbidden)
			{
				float shadow = drawinfo.shadow;
				Color colorArmorBody = drawinfo.colorArmorBody;
				if (!setForbidden)
				{
				}
				Player drawPlayer = drawinfo.drawPlayer;
				bool setForbiddenCooldownLocked = drawPlayer.setForbiddenCooldownLocked;
				int miscCounter = drawPlayer.miscCounter;
				int miscCounter2 = drawinfo.drawPlayer.miscCounter;
				if (setForbiddenCooldownLocked)
				{
					return;
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int num = 52992;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				if (num == 0)
				{
				}
				Player drawPlayer5 = drawinfo.drawPlayer;
				int width3 = drawPlayer5.bodyFrame.Width;
				int height3 = drawPlayer5.bodyFrame.Height;
				Player drawPlayer6 = drawinfo.drawPlayer;
				int head = drawPlayer6.head;
				float gravDir = drawPlayer6.gravDir;
				if (drawPlayer6.direction == 0)
				{
				}
				float bodyRotation = drawinfo.drawPlayer.bodyRotation;
				if (width3 == 0)
				{
				}
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cBody = drawinfo.cBody;
				float bodyRotation2 = drawinfo.drawPlayer.bodyRotation;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
			}
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00213B94 File Offset: 0x00211D94
		public static void DrawPlayer_01_3_BackHead(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int head = drawPlayer.head;
			if (drawPlayer == null)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			float x = drawinfo.helmetOffset.X;
			float y = drawinfo.helmetOffset.Y;
			float x2 = drawinfo.Position.X;
			if (drawPlayer2 == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer3.bodyFrame.Width;
			int width2 = drawPlayer3.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int height = drawPlayer4.height;
			int height2 = drawPlayer4.bodyFrame.Height;
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
			float headRotation = drawPlayer6.headRotation;
			int value = num.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cHead = drawinfo.cHead;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00213CE0 File Offset: 0x00211EE0
		public static void DrawPlayer_01_2_JimsCloak(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int legs = drawPlayer.legs;
			if (!drawinfo.isSitting && !drawPlayer.invis)
			{
				Player drawPlayer2 = drawinfo.drawPlayer;
				sbyte shoe = drawPlayer2.shoe;
				bool wearsRobe = drawPlayer2.wearsRobe;
				if (wearsRobe)
				{
					if (!wearsRobe)
					{
					}
					float x = drawinfo.Position.X;
					if (shoe == 0)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer3 = drawinfo.drawPlayer;
					float y = drawinfo.Position.Y;
					int width = drawPlayer3.legFrame.Width;
					int width2 = drawPlayer3.width;
					Vector2 screenPosition2 = Main.screenPosition;
					int num = 52992;
					Player drawPlayer4 = drawinfo.drawPlayer;
					int height = drawPlayer4.height;
					int height2 = drawPlayer4.legFrame.Height;
					Player drawPlayer5 = drawinfo.drawPlayer;
					float x2 = drawPlayer5.legPosition.X;
					float y2 = drawPlayer5.legPosition.Y;
					if (num == 0)
					{
					}
					float x3 = drawinfo.legVect.X;
					float y3 = drawinfo.legVect.Y;
					Player drawPlayer6 = drawinfo.drawPlayer;
					Color colorArmorLegs = drawinfo.colorArmorLegs;
					float x4 = drawinfo.legVect.X;
					float y4 = drawinfo.legVect.Y;
					float legRotation = drawPlayer6.legRotation;
					int value = num.m_value;
					SpriteEffects playerEffect = drawinfo.playerEffect;
					int cLegs = drawinfo.cLegs;
				}
			}
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00213E3C File Offset: 0x0021203C
		public static void DrawPlayer_05_2_SafemanSun(PlayerDrawSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			float shadow = drawinfo.shadow;
			Color colorArmorBody = drawinfo.colorArmorBody;
			if (head == 0)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			int miscCounter = drawPlayer.miscCounter;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int miscCounter2 = drawPlayer2.miscCounter;
			float x = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer3.bodyFrame.Width;
			int width2 = drawPlayer3.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int num = 52992;
			int height = drawPlayer4.height;
			int height2 = drawPlayer4.bodyFrame.Height;
			Player drawPlayer5 = drawinfo.drawPlayer;
			float x2 = drawPlayer5.bodyPosition.X;
			float y2 = drawPlayer5.bodyPosition.Y;
			if (num == 0)
			{
			}
			Player drawPlayer6 = drawinfo.drawPlayer;
			int width3 = drawPlayer6.bodyFrame.Width;
			int height3 = drawPlayer6.bodyFrame.Height;
			Player drawPlayer7 = drawinfo.drawPlayer;
			int direction = drawPlayer7.direction;
			float gravDir = drawPlayer7.gravDir;
			float bodyRotation = drawinfo.drawPlayer.bodyRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cHead = drawinfo.cHead;
			float bodyRotation2 = drawinfo.drawPlayer.bodyRotation;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			int cHead2 = drawinfo.cHead;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00213FD0 File Offset: 0x002121D0
		public static void DrawPlayer_06_WebbedDebuffBack(PlayerDrawSet drawinfo)
		{
			bool webbed = drawinfo.drawPlayer.webbed;
			if (webbed)
			{
				float shadow = drawinfo.shadow;
				Color colorArmorBody = drawinfo.colorArmorBody;
				if (!webbed)
				{
				}
				float x = drawinfo.Position.X;
				if (!webbed)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer.bodyFrame.Width;
				int width2 = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int height = drawPlayer2.height;
				int height2 = drawPlayer2.bodyFrame.Height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				float x2 = drawPlayer3.bodyPosition.X;
				float y2 = drawPlayer3.bodyPosition.Y;
				if (52992 == 0)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				int width3 = drawPlayer4.bodyFrame.Width;
				int height3 = drawPlayer4.bodyFrame.Height;
				float bodyRotation = drawinfo.drawPlayer.bodyRotation;
				if (width3 == 0)
				{
				}
				SpriteEffects playerEffect = drawinfo.playerEffect;
			}
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x000021DB File Offset: 0x000003DB
		public static void DrawPlayer_07_LeinforsHairShampoo(PlayerDrawSet drawinfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x002140E0 File Offset: 0x002122E0
		public static bool DrawPlayer_08_PlayerVisuallyHasFullArmorSet(PlayerDrawSet drawinfo, int head, int body, int legs)
		{
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x002140F0 File Offset: 0x002122F0
		public static void DrawPlayer_08_Backpacks(PlayerDrawSet drawinfo)
		{
			int num = 1;
			Player drawPlayer = drawinfo.drawPlayer;
			if (num == 0)
			{
			}
			int head = drawPlayer.head;
			int body = drawPlayer.body;
			int legs = drawPlayer.legs;
			Vector2 directions = drawinfo.drawPlayer.Directions;
			float x = drawinfo.Position.X;
			float y = drawinfo.Position.Y;
			if (legs == 0)
			{
			}
			if (legs == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float x2 = drawPlayer2.bodyPosition.X;
			float y2 = drawPlayer2.bodyPosition.Y;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int width = drawPlayer3.width;
			bool wet = drawPlayer3.wet;
			int height = drawPlayer3.bodyFrame.Height;
			if (height == 0)
			{
			}
			if (height == 0)
			{
			}
			Player drawPlayer4 = drawinfo.drawPlayer;
			int num2 = 26215;
			Player drawPlayer5 = drawinfo.drawPlayer;
			float shadow = drawinfo.shadow;
			float stealth = drawinfo.drawPlayer.stealth;
			if (num2 == 0)
			{
			}
			Player drawPlayer6 = drawinfo.drawPlayer;
			float x3 = drawinfo.bodyVect.X;
			float y3 = drawinfo.bodyVect.Y;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float bodyRotation = drawPlayer6.bodyRotation;
			int cBody = drawinfo.cBody;
			Player drawPlayer7 = drawinfo.drawPlayer;
			if (cBody == 0)
			{
			}
			int head2 = drawPlayer7.head;
			int body2 = drawPlayer7.body;
			int legs2 = drawPlayer7.legs;
			Vector2 directions2 = drawinfo.drawPlayer.Directions;
			Vector2 directions3 = drawinfo.drawPlayer.Directions;
			float x4 = drawinfo.Position.X;
			float y4 = drawinfo.Position.Y;
			if (legs2 == 0)
			{
			}
			if (legs2 == 0)
			{
			}
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer8 = drawinfo.drawPlayer;
			float x5 = drawPlayer8.bodyPosition.X;
			float y5 = drawPlayer8.bodyPosition.Y;
			Player drawPlayer9 = drawinfo.drawPlayer;
			int width2 = drawPlayer9.width;
			bool wet2 = drawPlayer9.wet;
			int height2 = drawPlayer9.bodyFrame.Height;
			if (height2 == 0)
			{
			}
			if (height2 == 0)
			{
			}
			Player drawPlayer10 = drawinfo.drawPlayer;
			int num3 = 25;
			int num4 = 26215;
			Player drawPlayer11 = drawinfo.drawPlayer;
			float shadow2 = drawinfo.shadow;
			float stealth2 = drawinfo.drawPlayer.stealth;
			if (num4 == 0)
			{
			}
			Player drawPlayer12 = drawinfo.drawPlayer;
			float x6 = drawinfo.bodyVect.X;
			float y6 = drawinfo.bodyVect.Y;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			float bodyRotation2 = drawPlayer12.bodyRotation;
			int cBody2 = drawinfo.cBody;
			Item heldItem = drawinfo.heldItem;
			int type = heldItem.type;
			int[] ownedProjectileCounts = drawinfo.drawPlayer.ownedProjectileCounts;
			if (ownedProjectileCounts == null)
			{
				float x7 = drawinfo.Position.X;
				float y7 = drawinfo.Position.Y;
				if (ownedProjectileCounts == null)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				if (ownedProjectileCounts == null)
				{
				}
				Player drawPlayer13 = drawinfo.drawPlayer;
				float x8 = drawPlayer13.bodyPosition.X;
				float y8 = drawPlayer13.bodyPosition.Y;
				Player drawPlayer14 = drawinfo.drawPlayer;
				int width3 = drawPlayer14.width;
				bool wet3 = drawPlayer14.wet;
				int height3 = drawPlayer14.bodyFrame.Height;
				if (height3 == 0)
				{
				}
				if (height3 == 0)
				{
				}
				Player drawPlayer15 = drawinfo.drawPlayer;
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x9 = drawinfo.bodyVect.X;
				float y9 = drawinfo.bodyVect.Y;
				float bodyRotation3 = drawPlayer15.bodyRotation;
				bool value = wet3.m_value;
				SpriteEffects playerEffect3 = drawinfo.playerEffect;
			}
			if (drawinfo.drawPlayer == null)
			{
			}
			if (drawinfo.drawPlayer.mount._active)
			{
				int type2 = drawinfo.heldItem.type;
				return;
			}
			float x10 = drawinfo.Position.X;
			float y10 = drawinfo.Position.Y;
			Vector2 screenPosition4 = Main.screenPosition;
			Player drawPlayer16 = drawinfo.drawPlayer;
			float x11 = drawPlayer16.bodyPosition.X;
			float y11 = drawPlayer16.bodyPosition.Y;
			Player drawPlayer17 = drawinfo.drawPlayer;
			int width4 = drawPlayer17.width;
			bool wet4 = drawPlayer17.wet;
			int height4 = drawPlayer17.bodyFrame.Height;
			if (height4 == 0)
			{
			}
			if (height4 == 0)
			{
			}
			Player drawPlayer18 = drawinfo.drawPlayer;
			Color colorArmorBody2 = drawinfo.colorArmorBody;
			float x12 = drawinfo.bodyVect.X;
			float y12 = drawinfo.bodyVect.Y;
			float bodyRotation4 = drawPlayer18.bodyRotation;
			int value2 = num3.m_value;
			SpriteEffects playerEffect4 = drawinfo.playerEffect;
			int cBackpack = drawinfo.cBackpack;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x002147A4 File Offset: 0x002129A4
		public static void DrawPlayer_08_1_Tails(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			bool active = drawinfo.drawPlayer.mount._active;
			if (!active)
			{
				if (!active)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				int value = num.m_value;
				bool isSitting = drawinfo.isSitting;
				float x = drawinfo.Position.X;
				float y = drawinfo.Position.Y;
				if (!isSitting)
				{
				}
				if (!isSitting)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float x2 = drawPlayer.bodyPosition.X;
				float y2 = drawPlayer.bodyPosition.Y;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int width = drawPlayer2.width;
				bool wet = drawPlayer2.wet;
				int height = drawPlayer2.bodyFrame.Height;
				if (height == 0)
				{
				}
				if (height == 0)
				{
				}
				Player drawPlayer3 = drawinfo.drawPlayer;
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x3 = drawinfo.bodyVect.X;
				float y3 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer3.bodyRotation;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cTail = drawinfo.cTail;
			}
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x002148BC File Offset: 0x00212ABC
		public static void DrawPlayer_10_BackAcc(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			sbyte front = drawPlayer.front;
			int y = drawPlayer.bodyFrame.Y;
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00214A58 File Offset: 0x00212C58
		public static void DrawPlayer_09_Wings(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			if (!drawPlayer.dead)
			{
				bool hideEntirePlayer = drawinfo.hideEntirePlayer;
				if (!hideEntirePlayer)
				{
					Vector2 directions = drawPlayer.Directions;
					float x = drawinfo.Position.X;
					float y = drawinfo.Position.Y;
					if (!hideEntirePlayer)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					if (!hideEntirePlayer)
					{
					}
					Vector2 size = drawinfo.drawPlayer.Size;
					float x2 = drawinfo.Position.X;
					float y2 = drawinfo.Position.Y;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer2 = drawinfo.drawPlayer;
					int width = drawPlayer2.width;
					bool wet = drawPlayer2.wet;
					int height = drawPlayer2.bodyFrame.Height;
					Player drawPlayer3 = drawinfo.drawPlayer;
					int wings = drawPlayer3.wings;
					if (drawPlayer3 == null)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00215730 File Offset: 0x00213930
		public static void DrawPlayer_12_1_BalloonFronts(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Vector2 position = drawinfo.drawPlayer.position;
			Player drawPlayer5;
			if (position != null)
			{
				Player drawPlayer;
				if (position == null)
				{
					drawPlayer = drawinfo.drawPlayer;
				}
				float x = drawinfo.Position.X;
				Vector2 position2 = drawPlayer.position;
				if (position == null)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num = 52992;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				if (num == 0)
				{
				}
				float x3 = drawinfo.bodyVect.X;
				float y3 = drawinfo.bodyVect.Y;
				drawPlayer5 = drawinfo.drawPlayer;
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x4 = drawinfo.bodyVect.X;
				float y4 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer5.bodyRotation;
				int value = num.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				return;
			}
			if (drawPlayer5 == null)
			{
			}
			string cursorItemIconText = drawPlayer5.cursorItemIconText;
			if (cursorItemIconText != null)
			{
				if (cursorItemIconText == null)
				{
				}
				bool ingameOptionsWindow = Main.ingameOptionsWindow;
				if (cursorItemIconText == null)
				{
				}
				Main.AutoPauseMode autoPause = Main.autoPause;
			}
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x002159E0 File Offset: 0x00213BE0
		public static void DrawPlayer_11_Balloons(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Vector2 position = drawinfo.drawPlayer.position;
			Player drawPlayer5;
			if (position != null)
			{
				Player drawPlayer;
				if (position == null)
				{
					drawPlayer = drawinfo.drawPlayer;
				}
				float x = drawinfo.Position.X;
				Vector2 position2 = drawPlayer.position;
				if (position == null)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num = 52992;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				if (num == 0)
				{
				}
				float x3 = drawinfo.bodyVect.X;
				float y3 = drawinfo.bodyVect.Y;
				drawPlayer5 = drawinfo.drawPlayer;
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x4 = drawinfo.bodyVect.X;
				float y4 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer5.bodyRotation;
				int value = num.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				return;
			}
			if (drawPlayer5 == null)
			{
			}
			string cursorItemIconText = drawPlayer5.cursorItemIconText;
			if (cursorItemIconText != null)
			{
				if (cursorItemIconText == null)
				{
				}
				bool ingameOptionsWindow = Main.ingameOptionsWindow;
				if (cursorItemIconText == null)
				{
				}
				Main.AutoPauseMode autoPause = Main.autoPause;
			}
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00215C8C File Offset: 0x00213E8C
		public static void DrawPlayer_12_Skin(PlayerDrawSet drawinfo)
		{
			bool usesCompositeTorso = drawinfo.usesCompositeTorso;
			if (usesCompositeTorso)
			{
				if (!usesCompositeTorso)
				{
				}
				PlayerDrawLayers.DrawPlayer_12_Skin_Composite(drawinfo);
				return;
			}
			if (drawinfo.isSitting)
			{
				int num = 1;
				drawinfo.hidesBottomSkin = num != 0;
			}
			bool hidesTopSkin = drawinfo.hidesTopSkin;
			if (!hidesTopSkin)
			{
				float y = drawinfo.Position.Y;
				float torsoOffset = drawinfo.torsoOffset;
				drawinfo.Position.Y = y;
				if (!hidesTopSkin)
				{
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y2 = drawinfo.Position.Y;
				int width = drawPlayer.bodyFrame.Width;
				int width2 = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int num2 = 52992;
				int height = drawPlayer2.height;
				int height2 = drawPlayer2.bodyFrame.Height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				float x2 = drawPlayer3.bodyPosition.X;
				float y3 = drawPlayer3.bodyPosition.Y;
				if (num2 == 0)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				int width3 = drawPlayer4.bodyFrame.Width;
				int height3 = drawPlayer4.bodyFrame.Height;
				Player drawPlayer5 = drawinfo.drawPlayer;
				Color colorBodySkin = drawinfo.colorBodySkin;
				float x3 = drawinfo.bodyVect.X;
				float y4 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer5.bodyRotation;
				int value = width3.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int skinDyePacked = drawinfo.skinDyePacked;
				float y5 = drawinfo.Position.Y;
				float torsoOffset2 = drawinfo.torsoOffset;
				drawinfo.Position.Y = y5;
			}
			bool hidesBottomSkin = drawinfo.hidesBottomSkin;
			if (!hidesBottomSkin)
			{
				if (!hidesBottomSkin)
				{
				}
				bool flag = PlayerDrawLayers.IsBottomOverridden(drawinfo);
				bool isSitting = drawinfo.isSitting;
				if (!hidesBottomSkin)
				{
				}
				if (isSitting)
				{
					Color colorLegs = drawinfo.colorLegs;
					if (!hidesBottomSkin)
					{
					}
					return;
				}
				float x4 = drawinfo.Position.X;
				if (!hidesBottomSkin)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				Player drawPlayer6 = drawinfo.drawPlayer;
				float y6 = drawinfo.Position.Y;
				int width4 = drawPlayer6.width;
				Vector2 screenPosition4 = Main.screenPosition;
				Player drawPlayer7 = drawinfo.drawPlayer;
				int num3 = 52992;
				int height4 = drawPlayer7.height;
				int height5 = drawPlayer7.bodyFrame.Height;
				Player drawPlayer8 = drawinfo.drawPlayer;
				float x5 = drawPlayer8.bodyPosition.X;
				float y7 = drawPlayer8.bodyPosition.Y;
				if (num3 == 0)
				{
				}
				Player drawPlayer9 = drawinfo.drawPlayer;
				int width5 = drawPlayer9.bodyFrame.Width;
				int height6 = drawPlayer9.bodyFrame.Height;
				Player drawPlayer10 = drawinfo.drawPlayer;
				Color colorLegs2 = drawinfo.colorLegs;
				float x6 = drawinfo.bodyVect.X;
				float y8 = drawinfo.bodyVect.Y;
				float legRotation = drawPlayer10.legRotation;
				int value2 = width5.m_value;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
			}
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00215F58 File Offset: 0x00214158
		public static bool IsBottomOverridden(PlayerDrawSet drawinfo)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00215F6C File Offset: 0x0021416C
		public static bool ShouldOverrideLegs_CheckPants(PlayerDrawSet drawinfo)
		{
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool ShouldOverrideLegs_CheckShoes(PlayerDrawSet drawinfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00215F80 File Offset: 0x00214180
		public static void DrawPlayer_12_Skin_Composite(PlayerDrawSet drawinfo)
		{
			bool invis2;
			for (;;)
			{
				if (!drawinfo.hidesTopSkin)
				{
					bool invis = drawinfo.drawPlayer.invis;
					if (!invis)
					{
						float x = drawinfo.Position.X;
						if (!invis)
						{
						}
						Vector2 screenPosition = Main.screenPosition;
						Player drawPlayer = drawinfo.drawPlayer;
						float y = drawinfo.Position.Y;
						int width = drawPlayer.bodyFrame.Width;
						int width2 = drawPlayer.width;
						Vector2 screenPosition2 = Main.screenPosition;
						Player drawPlayer2 = drawinfo.drawPlayer;
						int num = 52992;
						int height = drawPlayer2.height;
						int height2 = drawPlayer2.bodyFrame.Height;
						Player drawPlayer3 = drawinfo.drawPlayer;
						float x2 = drawPlayer3.bodyPosition.X;
						float y2 = drawPlayer3.bodyPosition.Y;
						if (num == 0)
						{
						}
						Player drawPlayer4 = drawinfo.drawPlayer;
						int width3 = drawPlayer4.bodyFrame.Width;
						int height3 = drawPlayer4.bodyFrame.Height;
						Player drawPlayer5 = drawinfo.drawPlayer;
						int y3 = drawPlayer5.bodyFrame.Y;
						int height4 = drawPlayer5.bodyFrame.Height;
						float torsoOffset = drawinfo.torsoOffset;
						SpriteEffects playerEffect = drawinfo.playerEffect;
						int num2 = true.ToDirectionInt();
						Player drawPlayer6 = drawinfo.drawPlayer;
						float x3 = drawinfo.bodyVect.X;
						float y4 = drawinfo.bodyVect.Y;
						float bodyRotation = drawPlayer6.bodyRotation;
						if (drawPlayer6 == null)
						{
						}
						Vector2 compositeOffset_BackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(drawinfo);
						SpriteEffects playerEffect2 = drawinfo.playerEffect;
						bool drawFloatingTube = drawinfo.drawFloatingTube;
						if (!drawFloatingTube)
						{
							continue;
						}
						if (!drawFloatingTube)
						{
						}
						float x4 = drawinfo.bodyVect.X;
						float y5 = drawinfo.bodyVect.Y;
						SpriteEffects playerEffect3 = drawinfo.playerEffect;
						if (drawinfo.cFloatingTube == 0)
						{
						}
						Color colorBodySkin = drawinfo.colorBodySkin;
						float x5 = drawinfo.bodyVect.X;
						float y6 = drawinfo.bodyVect.Y;
						SpriteEffects playerEffect4 = drawinfo.playerEffect;
						int skinDyePacked = drawinfo.skinDyePacked;
					}
				}
				if (!drawinfo.hidesBottomSkin)
				{
					invis2 = drawinfo.drawPlayer.invis;
					if (!invis2)
					{
						break;
					}
				}
			}
			if (!invis2)
			{
			}
			bool flag = PlayerDrawLayers.IsBottomOverridden(drawinfo);
			bool isSitting = drawinfo.isSitting;
			if (!invis2)
			{
			}
			if (isSitting)
			{
				Color colorLegs = drawinfo.colorLegs;
				int skinDyePacked2 = drawinfo.skinDyePacked;
				if (!invis2)
				{
				}
				return;
			}
			float x6 = drawinfo.Position.X;
			if (!invis2)
			{
			}
			Vector2 screenPosition3 = Main.screenPosition;
			Player drawPlayer7 = drawinfo.drawPlayer;
			float y7 = drawinfo.Position.Y;
			int width4 = drawPlayer7.bodyFrame.Width;
			int width5 = drawPlayer7.width;
			Vector2 screenPosition4 = Main.screenPosition;
			Player drawPlayer8 = drawinfo.drawPlayer;
			int num3 = 52992;
			int height5 = drawPlayer8.height;
			int height6 = drawPlayer8.bodyFrame.Height;
			Player drawPlayer9 = drawinfo.drawPlayer;
			float x7 = drawPlayer9.bodyPosition.X;
			float y8 = drawPlayer9.bodyPosition.Y;
			if (num3 == 0)
			{
			}
			Player drawPlayer10 = drawinfo.drawPlayer;
			int width6 = drawPlayer10.bodyFrame.Width;
			int height7 = drawPlayer10.bodyFrame.Height;
			Player drawPlayer11 = drawinfo.drawPlayer;
			Color colorLegs2 = drawinfo.colorLegs;
			float x8 = drawinfo.bodyVect.X;
			float y9 = drawinfo.bodyVect.Y;
			float legRotation = drawPlayer11.legRotation;
			int value = width6.m_value;
			SpriteEffects playerEffect5 = drawinfo.playerEffect;
			if (drawinfo.skinDyePacked == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_12_SkinComposite_BackArmShirt(drawinfo);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x002162E4 File Offset: 0x002144E4
		public static void DrawPlayer_12_SkinComposite_BackArmShirt(PlayerDrawSet drawinfo)
		{
			int num = 1;
			float x = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer.bodyFrame.Width;
			int width2 = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int height = drawPlayer2.height;
			int height2 = drawPlayer2.bodyFrame.Height;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float x2 = drawPlayer3.bodyPosition.X;
			float y2 = drawPlayer3.bodyPosition.Y;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int width3 = drawPlayer4.bodyFrame.Width;
			int height3 = drawPlayer4.bodyFrame.Height;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int y3 = drawPlayer5.bodyFrame.Y;
			int height4 = drawPlayer5.bodyFrame.Height;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int num2 = true.ToDirectionInt();
			Player drawPlayer6 = drawinfo.drawPlayer;
			float torsoOffset = drawinfo.torsoOffset;
			float x3 = drawinfo.bodyVect.X;
			float bodyRotation = drawPlayer6.bodyRotation;
			float y4 = drawinfo.bodyVect.Y;
			if (drawPlayer6 == null)
			{
			}
			Vector2 compositeOffset_BackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(drawinfo);
			float x4 = drawinfo.backShoulderOffset.X;
			Player drawPlayer7 = drawinfo.drawPlayer;
			float compositeBackArmRotation = drawinfo.compositeBackArmRotation;
			int body = drawPlayer7.body;
			bool invis = drawPlayer7.invis;
			if (drawPlayer7 != null)
			{
				return;
			}
			bool hidesTopSkin = drawinfo.hidesTopSkin;
			bool missingHand = drawinfo.missingHand;
			if (invis)
			{
				return;
			}
			bool missingArm = drawinfo.missingArm;
			int num3;
			if (missingArm && !hidesTopSkin)
			{
				if (!missingArm)
				{
				}
				Color colorBodySkin = drawinfo.colorBodySkin;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
				if (drawinfo.skinDyePacked == 0)
				{
				}
				Color colorBodySkin2 = drawinfo.colorBodySkin;
				SpriteEffects playerEffect3 = drawinfo.playerEffect;
				int skinDyePacked = drawinfo.skinDyePacked;
				num3 = 1;
			}
			Player drawPlayer8 = drawinfo.drawPlayer;
			bool invis2 = drawPlayer8.invis;
			if (invis2)
			{
				int body2 = drawPlayer8.body;
				if (!invis2)
				{
				}
			}
			if (drawPlayer8 == null)
			{
			}
			Player drawPlayer9 = drawinfo.drawPlayer;
			int teleportStyle = drawPlayer8.teleportStyle;
			int cBody;
			if (!drawinfo.hideCompositeShoulders)
			{
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x5 = drawinfo.bodyVect.X;
				float y5 = drawinfo.bodyVect.Y;
				SpriteEffects playerEffect4 = drawinfo.playerEffect;
				cBody = drawinfo.cBody;
				if (cBody == 0)
				{
				}
			}
			if (cBody == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_12_1_BalloonFronts(drawinfo);
			Color colorArmorBody2 = drawinfo.colorArmorBody;
			SpriteEffects playerEffect5 = drawinfo.playerEffect;
			int cBody2 = drawinfo.cBody;
			if (num3 == 0)
			{
				return;
			}
			if (cBody2 == 0)
			{
			}
			Color colorBodySkin3 = drawinfo.colorBodySkin;
			SpriteEffects playerEffect6 = drawinfo.playerEffect;
			if (drawinfo.skinDyePacked == 0)
			{
			}
			Color colorBodySkin4 = drawinfo.colorBodySkin;
			SpriteEffects playerEffect7 = drawinfo.playerEffect;
			int skinDyePacked2 = drawinfo.skinDyePacked;
			if (skinDyePacked2 == 0)
			{
			}
			Color colorUnderShirt = drawinfo.colorUnderShirt;
			SpriteEffects playerEffect8 = drawinfo.playerEffect;
			if (skinDyePacked2 == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_12_1_BalloonFronts(drawinfo);
			Color colorShirt = drawinfo.colorShirt;
			SpriteEffects playerEffect9 = drawinfo.playerEffect;
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer10 = drawinfo.drawPlayer;
			Color colorArmorBody3 = drawinfo.colorArmorBody;
			SpriteEffects playerEffect10 = drawinfo.playerEffect;
			if (drawinfo.cHandOff == 0)
			{
			}
			bool drawingFootball = drawinfo.drawPlayer.drawingFootball;
			if (drawingFootball)
			{
				if (!drawingFootball)
				{
				}
				if (!drawingFootball)
				{
				}
				if (drawPlayer10 == null)
				{
				}
				Rectangle rectangle;
				Vector2 vector = rectangle.Size();
				if (!drawingFootball)
				{
				}
				Player drawPlayer11 = drawinfo.drawPlayer;
				int direction = drawPlayer11.direction;
				float gravDir = drawPlayer11.gravDir;
				Player drawPlayer12 = drawinfo.drawPlayer;
				Color colorArmorBody4 = drawinfo.colorArmorBody;
				SpriteEffects playerEffect11 = drawinfo.playerEffect;
				int direction2 = drawPlayer12.direction;
			}
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0021666C File Offset: 0x0021486C
		public static void DrawPlayer_13_Leggings(PlayerDrawSet drawinfo)
		{
			Player drawPlayer2;
			do
			{
				Player drawPlayer = drawinfo.drawPlayer;
				int legs = drawPlayer.legs;
				float x = drawinfo.legsOffset.X;
				bool isSitting = drawinfo.isSitting;
				float y = drawinfo.legsOffset.Y;
				if (!isSitting)
				{
					goto IL_00B3;
				}
				if (drawPlayer == null)
				{
				}
				drawPlayer2 = drawinfo.drawPlayer;
				sbyte shoe = drawPlayer2.shoe;
			}
			while (!drawPlayer2.wearsRobe);
			bool invis = drawPlayer2.invis;
			if (!invis)
			{
				Player drawPlayer3;
				if (!invis)
				{
					drawPlayer3 = drawinfo.drawPlayer;
				}
				Color colorArmorLegs = drawinfo.colorArmorLegs;
				int cLegs = drawinfo.cLegs;
				Vector2 position = drawPlayer3.position;
				if (!invis)
				{
				}
				int legsGlowMask = drawinfo.legsGlowMask;
				if (!invis)
				{
					int legsGlowMask2 = drawinfo.legsGlowMask;
				}
				Color legsGlowColor = drawinfo.legsGlowColor;
				int cLegs2 = drawinfo.cLegs;
				if (!invis)
				{
				}
				return;
			}
			return;
			IL_00B3:
			if (!invis)
			{
				Player drawPlayer4;
				if (!invis)
				{
					drawPlayer4 = drawinfo.drawPlayer;
				}
				int y2 = drawPlayer4.legFrame.Y;
				int height = drawPlayer4.legFrame.Height;
				if (drawPlayer4 == null)
				{
				}
				bool gameMenu = Main.gameMenu;
				Player drawPlayer5 = drawinfo.drawPlayer;
				return;
			}
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00216E60 File Offset: 0x00215060
		private static void DrawSittingLongCoats(PlayerDrawSet drawinfo, int specialLegCoat, Texture2D textureToDraw, Color matchingColor, int shaderIndex = 0, bool glowmask = false)
		{
			int num = 1;
			float x = drawinfo.legsOffset.X;
			float y = drawinfo.legsOffset.Y;
			float x2 = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer.legFrame.Width;
			int width2 = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num2 = 52992;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int height = drawPlayer2.height;
			int height2 = drawPlayer2.legFrame.Height;
			float x3 = drawPlayer2.legPosition.X;
			float y3 = drawPlayer2.legPosition.Y;
			if (num2 == 0)
			{
			}
			float x4 = drawinfo.legVect.X;
			float y4 = drawinfo.legVect.Y;
			Player drawPlayer3 = drawinfo.drawPlayer;
			Rectangle legFrame = drawPlayer3.legFrame;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int value = drawPlayer4.direction.m_value;
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00216F94 File Offset: 0x00215194
		private static void DrawSittingLegs(PlayerDrawSet drawinfo, Texture2D textureToDraw, Color matchingColor, int shaderIndex = 0, bool glowmask = false)
		{
			int num = 1;
			float x = drawinfo.legsOffset.X;
			float y = drawinfo.legsOffset.Y;
			float x2 = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer.legFrame.Width;
			int width2 = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num2 = 52992;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int height = drawPlayer2.height;
			int height2 = drawPlayer2.legFrame.Height;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float x3 = drawPlayer3.legPosition.X;
			float y3 = drawPlayer3.legPosition.Y;
			if (num2 == 0)
			{
			}
			float x4 = drawinfo.legVect.X;
			float y4 = drawinfo.legVect.Y;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float seatYOffset = drawinfo.seatYOffset;
			Rectangle legFrame = drawPlayer4.legFrame;
			int y5 = drawPlayer4.legFrame.Y;
			int width3 = drawPlayer4.legFrame.Width;
			int height3 = drawPlayer4.legFrame.Height;
			int legs = drawinfo.drawPlayer.legs;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00217178 File Offset: 0x00215378
		public static void DrawPlayer_14_Shoes(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			bool flag = PlayerDrawLayers.ShouldOverrideLegs_CheckPants(drawinfo);
			sbyte shoe = drawinfo.drawPlayer.shoe;
			bool isSitting = drawinfo.isSitting;
			sbyte shoe2 = drawinfo.drawPlayer.shoe;
			if (isSitting)
			{
				Color colorArmorLegs = drawinfo.colorArmorLegs;
				if (shoe2 == 0)
				{
				}
				return;
			}
			float x = drawinfo.Position.X;
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer.legFrame.Width;
			int width2 = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			int height = drawinfo.drawPlayer.height;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float x2 = drawPlayer2.legPosition.X;
			float y2 = drawPlayer2.legPosition.Y;
			if (num == 0)
			{
			}
			float x3 = drawinfo.legVect.X;
			float y3 = drawinfo.legVect.Y;
			Player drawPlayer3 = drawinfo.drawPlayer;
			Color colorArmorLegs2 = drawinfo.colorArmorLegs;
			float x4 = drawinfo.legVect.X;
			float y4 = drawinfo.legVect.Y;
			float legRotation = drawPlayer3.legRotation;
			int value = num.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			if (drawinfo.drawPlayer.shoe == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_14_2_GlassSlipperSparkles(drawinfo);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000021DB File Offset: 0x000003DB
		public static void DrawPlayer_14_2_GlassSlipperSparkles(PlayerDrawSet drawinfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x002172C4 File Offset: 0x002154C4
		public static void DrawPlayer_15_SkinLongCoat(PlayerDrawSet drawinfo)
		{
			int skinVar = drawinfo.skinVar;
			Player drawPlayer = drawinfo.drawPlayer;
			int body = drawPlayer.body;
			if (drawPlayer == null)
			{
			}
			bool invis = drawinfo.drawPlayer.invis;
			if (!invis)
			{
				bool isSitting = drawinfo.isSitting;
				if (!invis)
				{
				}
				if (isSitting)
				{
					Color colorShirt = drawinfo.colorShirt;
					return;
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.legFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num = 52992;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.legFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.legPosition.X;
				float y2 = drawPlayer4.legPosition.Y;
				if (num == 0)
				{
				}
				float x3 = drawinfo.legVect.X;
				float y3 = drawinfo.legVect.Y;
				Player drawPlayer5 = drawinfo.drawPlayer;
				Color colorShirt2 = drawinfo.colorShirt;
				float x4 = drawinfo.legVect.X;
				float y4 = drawinfo.legVect.Y;
				float legRotation = drawPlayer5.legRotation;
				int value = num.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
			}
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00217414 File Offset: 0x00215614
		public static void DrawPlayer_16_ArmorLongCoat(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int body = drawPlayer.body;
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00217590 File Offset: 0x00215790
		public static void DrawPlayer_17_Torso(PlayerDrawSet drawinfo)
		{
			if (drawinfo.usesCompositeTorso)
			{
				PlayerDrawLayers.DrawPlayer_17_TorsoComposite(drawinfo);
				return;
			}
			int body = drawinfo.drawPlayer.body;
			Player drawPlayer = drawinfo.drawPlayer;
			int direction = drawPlayer.direction;
			int armorAdjust = drawinfo.armorAdjust;
			int body2;
			if (drawPlayer.invis)
			{
				body2 = drawPlayer.body;
			}
			bool male = drawPlayer.Male;
			if (body2 == 0)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			int num = 496;
			float x = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer3.bodyFrame.Width;
			int width2 = drawPlayer3.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer4 = drawinfo.drawPlayer;
			int height = drawPlayer4.height;
			int height2 = drawPlayer4.bodyFrame.Height;
			int num2 = 32768;
			Player drawPlayer5 = drawinfo.drawPlayer;
			float x2 = drawPlayer5.bodyPosition.X;
			float y2 = drawPlayer5.bodyPosition.Y;
			if (num2 == 0)
			{
			}
			Player drawPlayer6 = drawinfo.drawPlayer;
			int width3 = drawPlayer6.bodyFrame.Width;
			int height3 = drawPlayer6.bodyFrame.Height;
			Player drawPlayer7 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			float x3 = drawinfo.bodyVect.X;
			float y3 = drawinfo.bodyVect.Y;
			float bodyRotation = drawPlayer7.bodyRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cBody = drawinfo.cBody;
			int bodyGlowMask = drawinfo.bodyGlowMask;
			if (width3 == 0)
			{
				int bodyGlowMask2 = drawinfo.bodyGlowMask;
			}
			float x4 = drawinfo.Position.X;
			if (width3 == 0)
			{
			}
			Vector2 screenPosition3 = Main.screenPosition;
			Player drawPlayer8 = drawinfo.drawPlayer;
			float y4 = drawinfo.Position.Y;
			int width4 = drawPlayer8.bodyFrame.Width;
			int width5 = drawPlayer8.width;
			Vector2 screenPosition4 = Main.screenPosition;
			Player drawPlayer9 = drawinfo.drawPlayer;
			int height4 = drawPlayer9.height;
			int height5 = drawPlayer9.bodyFrame.Height;
			int num3 = 32768;
			Player drawPlayer10 = drawinfo.drawPlayer;
			float x5 = drawPlayer10.bodyPosition.X;
			float y5 = drawPlayer10.bodyPosition.Y;
			if (num3 == 0)
			{
			}
			Player drawPlayer11 = drawinfo.drawPlayer;
			int width6 = drawPlayer11.bodyFrame.Width;
			int height6 = drawPlayer11.bodyFrame.Height;
			Player drawPlayer12 = drawinfo.drawPlayer;
			Color bodyGlowColor = drawinfo.bodyGlowColor;
			float x6 = drawinfo.bodyVect.X;
			float y6 = drawinfo.bodyVect.Y;
			float bodyRotation2 = drawPlayer12.bodyRotation;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			int cBody2 = drawinfo.cBody;
			if (drawinfo.missingHand)
			{
				bool invis = drawinfo.drawPlayer.invis;
				if (!invis)
				{
					if (!invis)
					{
					}
					float x7 = drawinfo.Position.X;
					if (width6 == 0)
					{
					}
					Vector2 screenPosition5 = Main.screenPosition;
					Player drawPlayer13 = drawinfo.drawPlayer;
					float y7 = drawinfo.Position.Y;
					int width7 = drawPlayer13.bodyFrame.Width;
					int width8 = drawPlayer13.width;
					Vector2 screenPosition6 = Main.screenPosition;
					Player drawPlayer14 = drawinfo.drawPlayer;
					int height7 = drawPlayer14.height;
					int height8 = drawPlayer14.bodyFrame.Height;
					return;
				}
			}
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00217C00 File Offset: 0x00215E00
		public static void DrawPlayer_17_TorsoComposite(PlayerDrawSet drawinfo)
		{
			int num = 1;
			float x = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num2 = 52992;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int height = drawPlayer2.height;
			int height2 = drawPlayer2.bodyFrame.Height;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float x2 = drawPlayer3.bodyPosition.X;
			float y2 = drawPlayer3.bodyPosition.Y;
			if (num2 == 0)
			{
			}
			Player drawPlayer4 = drawinfo.drawPlayer;
			int width2 = drawPlayer4.bodyFrame.Width;
			int height3 = drawPlayer4.bodyFrame.Height;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int y3 = drawPlayer5.bodyFrame.Y;
			int height4 = drawPlayer5.bodyFrame.Height;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int num3 = true.ToDirectionInt();
			Player drawPlayer6 = drawinfo.drawPlayer;
			float x3 = drawinfo.bodyVect.X;
			float y4 = drawinfo.bodyVect.Y;
			float bodyRotation = drawPlayer6.bodyRotation;
			if (drawPlayer6 == null)
			{
			}
			Vector2 compositeOffset_BackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(drawinfo);
			Player drawPlayer7 = drawinfo.drawPlayer;
			int body = drawPlayer7.body;
			if (drawPlayer7 == null)
			{
			}
			Player drawPlayer8 = drawinfo.drawPlayer;
			bool invis = drawPlayer8.invis;
			if (invis)
			{
				int body2 = drawPlayer8.body;
				if (!invis)
				{
				}
			}
			if (drawPlayer8 == null)
			{
			}
			Player drawPlayer9 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			int teleportStyle = drawPlayer8.teleportStyle;
			float x4 = drawinfo.bodyVect.X;
			float y5 = drawinfo.bodyVect.Y;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			if (drawinfo.cBody == 0)
			{
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00217EC8 File Offset: 0x002160C8
		public static void DrawPlayer_18_OffhandAcc(PlayerDrawSet drawinfo)
		{
			if (drawinfo.usesCompositeBackHandAcc)
			{
				return;
			}
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x2 = drawPlayer4.bodyPosition.X;
			float y2 = drawPlayer4.bodyPosition.Y;
			if (num == 0)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			int width3 = drawPlayer5.bodyFrame.Width;
			int height3 = drawPlayer5.bodyFrame.Height;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			float x3 = drawinfo.bodyVect.X;
			float y3 = drawinfo.bodyVect.Y;
			float bodyRotation = drawPlayer6.bodyRotation;
			int value = width3.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cHandOff = drawinfo.cHandOff;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00218000 File Offset: 0x00216200
		public static void DrawPlayer_JimsDroneRadio(PlayerDrawSet drawinfo)
		{
			int type = drawinfo.drawPlayer.HeldItem.type;
			Player drawPlayer = drawinfo.drawPlayer;
			int itemAnimation = drawPlayer.itemAnimation;
			if (itemAnimation == 0)
			{
				if (itemAnimation == 0)
				{
				}
				float x = drawinfo.Position.X;
				int y = drawPlayer.headFrame.Y;
				if (itemAnimation == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y2 = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int direction = drawPlayer2.direction;
				int height = drawPlayer2.height;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height2 = drawPlayer3.height;
				int height3 = drawPlayer3.bodyFrame.Height;
				int num = 32768;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y3 = drawPlayer4.bodyPosition.Y;
				if (num == 0)
				{
				}
				Player drawPlayer5 = drawinfo.drawPlayer;
				int width2 = drawPlayer5.bodyFrame.Width;
				int height4 = drawPlayer5.bodyFrame.Height;
				Player drawPlayer6 = drawinfo.drawPlayer;
				Color colorArmorLegs = drawinfo.colorArmorLegs;
				float x3 = drawinfo.legVect.X;
				float y4 = drawinfo.legVect.Y;
				float legRotation = drawPlayer6.legRotation;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cWaist = drawinfo.cWaist;
			}
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x0021815C File Offset: 0x0021635C
		public static void DrawPlayer_19_WaistAcc(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			Player drawPlayer2 = drawinfo.drawPlayer;
			Player drawPlayer3;
			if (drawPlayer2 == null)
			{
				drawPlayer3 = drawinfo.drawPlayer;
			}
			float x = drawinfo.Position.X;
			int slideDir = drawPlayer2.slideDir;
			Vector2 position = drawPlayer3.position;
			if (slideDir == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer4.legFrame.Width;
			int width2 = drawPlayer4.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int height = drawPlayer5.height;
			int height2 = drawPlayer5.legFrame.Height;
			Player drawPlayer6 = drawinfo.drawPlayer;
			float x2 = drawPlayer6.legPosition.X;
			float y2 = drawPlayer6.legPosition.Y;
			if (num == 0)
			{
			}
			float x3 = drawinfo.legVect.X;
			float y3 = drawinfo.legVect.Y;
			Player drawPlayer7 = drawinfo.drawPlayer;
			Color colorArmorLegs = drawinfo.colorArmorLegs;
			float x4 = drawinfo.legVect.X;
			float y4 = drawinfo.legVect.Y;
			float legRotation = drawPlayer7.legRotation;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cWaist = drawinfo.cWaist;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x0021829C File Offset: 0x0021649C
		public static void DrawPlayer_20_NeckAcc(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x2 = drawPlayer4.bodyPosition.X;
			float y2 = drawPlayer4.bodyPosition.Y;
			if (num == 0)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			int width3 = drawPlayer5.bodyFrame.Width;
			int height3 = drawPlayer5.bodyFrame.Height;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			float x3 = drawinfo.bodyVect.X;
			float y3 = drawinfo.bodyVect.Y;
			float bodyRotation = drawPlayer6.bodyRotation;
			int value = width3.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cNeck = drawinfo.cNeck;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x002183CC File Offset: 0x002165CC
		public static void DrawPlayer_21_Head(PlayerDrawSet drawinfo)
		{
			int num = 1;
			Vector2 helmetOffset = drawinfo.helmetOffset;
			if (num == 0)
			{
			}
			PlayerDrawLayers.DrawPlayer_21_Head_TheFace(drawinfo);
			Player drawPlayer = drawinfo.drawPlayer;
			int head = drawPlayer.head;
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00219DCC File Offset: 0x00217FCC
		public static int DrawPlayer_Head_GetTVScreen(Player plr)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			bool flag = NPC.AnyDanger(num != 0L, num2 != 0L);
			return 1;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00219E0C File Offset: 0x0021800C
		private static int GetHatStacks(PlayerDrawSet drawinfo, int hatItemId)
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00219E1C File Offset: 0x0021801C
		private static Vector2 DrawPlayer_21_Head_GetSpecialHatDrawPosition(PlayerDrawSet drawinfo, Vector2 helmetOffset, Vector2 hatOffset)
		{
			if (!true)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			int y = drawPlayer.bodyFrame.Y;
			int height = drawPlayer.bodyFrame.Height;
			Vector2 directions = drawPlayer.Directions;
			if (drawPlayer == null)
			{
			}
			float x = drawinfo.Position.X;
			float y2 = drawinfo.Position.Y;
			Vector2 screenPosition = Main.screenPosition;
			float x2 = helmetOffset.X;
			float y3 = helmetOffset.Y;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			bool wet = drawPlayer2.wet;
			int height2 = drawPlayer2.bodyFrame.Height;
			Vector2 directions2 = drawinfo.drawPlayer.Directions;
			if (height2 == 0)
			{
			}
			Player drawPlayer3 = drawinfo.drawPlayer;
			float x3 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			float y5 = drawPlayer3.headPosition.Y;
			float x4 = drawPlayer3.headPosition.X;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float gravDir = drawPlayer4.gravDir;
			if (drawPlayer4 == null)
			{
				return;
			}
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00219F44 File Offset: 0x00218144
		private static void DrawPlayer_21_Head_TheFace(PlayerDrawSet drawinfo)
		{
			int head = drawinfo.drawPlayer.head;
			if (head == 0)
			{
			}
			Vector2 faceHeadOffsetFromHelmet = drawinfo.drawPlayer.GetFaceHeadOffsetFromHelmet();
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
			float y = drawinfo.Position.Y;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x2 = drawPlayer4.headPosition.X;
			float y2 = drawPlayer4.headPosition.Y;
			if (num == 0)
			{
			}
			float x3 = drawinfo.headVect.X;
			float y3 = drawinfo.headVect.Y;
			Player drawPlayer5 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float y4 = drawinfo.headVect.Y;
			float headRotation = drawPlayer5.headRotation;
			int value = num.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cFaceHead = drawinfo.cFaceHead;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Player drawPlayer7 = drawinfo.drawPlayer;
			sbyte face = drawPlayer7.face;
			Player drawPlayer8;
			if (drawPlayer7.direction == 0)
			{
				drawPlayer8 = drawinfo.drawPlayer;
			}
			float x4 = drawinfo.Position.X;
			bool canCarpet = drawPlayer8.canCarpet;
			if (face == 0)
			{
			}
			Vector2 screenPosition3 = Main.screenPosition;
			Player drawPlayer9 = drawinfo.drawPlayer;
			float y5 = drawinfo.Position.Y;
			int width3 = drawPlayer9.bodyFrame.Width;
			int width4 = drawPlayer9.width;
			Vector2 screenPosition4 = Main.screenPosition;
			Player drawPlayer10 = drawinfo.drawPlayer;
			int height3 = drawPlayer10.height;
			int height4 = drawPlayer10.bodyFrame.Height;
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0021A7C4 File Offset: 0x002189C4
		public static void DrawPlayer_21_1_Magiluminescence(PlayerDrawSet drawinfo)
		{
			float shadow = drawinfo.shadow;
			sbyte neck = drawinfo.drawPlayer.neck;
			bool hideEntirePlayer = drawinfo.hideEntirePlayer;
			if (!hideEntirePlayer)
			{
				byte b = drawinfo.colorArmorBody.B;
				byte g = drawinfo.colorArmorBody.G;
				byte r = drawinfo.colorArmorBody.R;
				int num = 17279;
				if (!hideEntirePlayer)
				{
				}
				float x = drawinfo.Position.X;
				if (num == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num2 = 52992;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int height = drawPlayer2.height;
				int height2 = drawPlayer2.bodyFrame.Height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				float x2 = drawPlayer3.bodyPosition.X;
				float y2 = drawPlayer3.bodyPosition.Y;
				if (num2 == 0)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				int width2 = drawPlayer4.bodyFrame.Width;
				int height3 = drawPlayer4.bodyFrame.Height;
				Player drawPlayer5 = drawinfo.drawPlayer;
				float x3 = drawinfo.bodyVect.X;
				float y3 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer5.bodyRotation;
				int value = width2.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cNeck = drawinfo.cNeck;
			}
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x0021A938 File Offset: 0x00218B38
		public static void DrawPlayer_22_FaceAcc(PlayerDrawSet drawinfo)
		{
			Mount mount;
			do
			{
				if (!true)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				int value = num.m_value;
				mount = drawinfo.drawPlayer.mount;
			}
			while (!mount._active);
			int type = mount._type;
			Vector2 directions = drawinfo.drawPlayer.Directions;
			if (type == 0)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			if (drawPlayer == null)
			{
			}
			if (drawPlayer == null)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			long entityId = drawPlayer.entityId;
			if (entityId == 0L)
			{
				if (entityId == 0L)
				{
				}
				if (!true)
				{
				}
				sbyte face = drawinfo.drawPlayer.face;
				Vector2 directions2 = drawinfo.drawPlayer.Directions;
				if (face == 0)
				{
				}
				return;
			}
			Player drawPlayer3 = drawinfo.drawPlayer;
			if (drawPlayer3 == null)
			{
			}
			if (drawPlayer3 == null)
			{
			}
			Player drawPlayer4 = drawinfo.drawPlayer;
			bool canCarpet = drawPlayer3.canCarpet;
			float x = drawinfo.helmetOffset.X;
			float y = drawinfo.helmetOffset.Y;
			if (drawPlayer4 == null)
			{
			}
			float x2 = drawinfo.Position.X;
			if (!canCarpet)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer5 = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer5.bodyFrame.Width;
			int width2 = drawPlayer5.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer6 = drawinfo.drawPlayer;
			int num2 = 52992;
			int height = drawPlayer6.height;
			int height2 = drawPlayer6.bodyFrame.Height;
			Player drawPlayer7 = drawinfo.drawPlayer;
			float x3 = drawPlayer7.headPosition.X;
			float y3 = drawPlayer7.headPosition.Y;
			float x4 = drawinfo.headVect.X;
			float y4 = drawinfo.headVect.Y;
			Player drawPlayer8 = drawinfo.drawPlayer;
			Color colorArmorHead = drawinfo.colorArmorHead;
			float x5 = drawinfo.headVect.X;
			float y5 = drawinfo.headVect.Y;
			float headRotation = drawPlayer8.headRotation;
			int value2 = num2.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cFaceFlower = drawinfo.cFaceFlower;
			bool drawUnicornHorn = drawinfo.drawUnicornHorn;
			if (drawUnicornHorn)
			{
				if (!drawUnicornHorn)
				{
				}
				float x6 = drawinfo.Position.X;
				if (num2 == 0)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				Player drawPlayer9 = drawinfo.drawPlayer;
				float y6 = drawinfo.Position.Y;
				int width3 = drawPlayer9.bodyFrame.Width;
				int width4 = drawPlayer9.width;
				Vector2 screenPosition4 = Main.screenPosition;
				Player drawPlayer10 = drawinfo.drawPlayer;
				int num3 = 52992;
				int height3 = drawPlayer10.height;
				int height4 = drawPlayer10.bodyFrame.Height;
				if (drawPlayer10 == null)
				{
				}
				Player drawPlayer11 = drawinfo.drawPlayer;
				float x7 = drawPlayer11.headPosition.X;
				float y7 = drawPlayer11.headPosition.Y;
				float x8 = drawinfo.headVect.X;
				float y8 = drawinfo.headVect.Y;
				Player drawPlayer12 = drawinfo.drawPlayer;
				Color colorArmorHead2 = drawinfo.colorArmorHead;
				float x9 = drawinfo.headVect.X;
				float y9 = drawinfo.headVect.Y;
				float headRotation2 = drawPlayer12.headRotation;
				int value3 = num3.m_value;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
				int cUnicornHorn = drawinfo.cUnicornHorn;
			}
			if (drawinfo.drawAngelHalo)
			{
				Player drawPlayer13 = drawinfo.drawPlayer;
				return;
			}
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0021AEA8 File Offset: 0x002190A8
		public static void DrawTiedBalloons(PlayerDrawSet drawinfo)
		{
			int type = drawinfo.drawPlayer.mount._type;
			if (type == 0)
			{
			}
			Color colorMount = drawinfo.colorMount;
			if (type == 0)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			int num = 16968;
			float x = drawPlayer.position.X;
			if (num == 0)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			float x2 = drawPlayer2.velocity.X;
			float fullRotation = drawPlayer2.fullRotation;
			Vector2 mountedCenter = drawPlayer2.MountedCenter;
			Vector2 screenPosition = Main.screenPosition;
			SpriteEffects playerEffect = drawinfo.playerEffect;
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0021AF34 File Offset: 0x00219134
		public static void DrawStarboardRainbowTrail(PlayerDrawSet drawinfo, Vector2 commonWingPosPreFloor, Vector2 dirsVec)
		{
			float shadow = drawinfo.shadow;
			Player drawPlayer = drawinfo.drawPlayer;
			int availableAdvancedShadowsCount = drawPlayer.availableAdvancedShadowsCount;
			int num = 30;
			int num2 = Math.Min(0, num);
			EntityShadowInfo advancedShadow = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			EntityShadowInfo advancedShadow2 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			if (drawPlayer == null)
			{
			}
			int num3 = 17184;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			int width = drawPlayer2.width;
			int height = drawPlayer2.height;
			if (drawPlayer2 == null)
			{
			}
			if (drawPlayer2 == null)
			{
			}
			Vector2 defaultSize = drawinfo.drawPlayer.DefaultSize;
			Vector2 defaultSize2 = drawinfo.drawPlayer.DefaultSize;
			if (drawPlayer2 == null)
			{
			}
			EntityShadowInfo advancedShadow3 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			EntityShadowInfo advancedShadow4 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			Player drawPlayer3 = drawinfo.drawPlayer;
			Player drawPlayer4 = drawinfo.drawPlayer;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int direction = drawPlayer5.direction;
			int num4 = 1;
			float num5;
			float num6;
			float lerpValue = Utils.GetLerpValue(num5, num6, num6, num4 != 0);
			if (drawPlayer5 == null)
			{
			}
			Color color2;
			Color color = color2 * num6;
			Vector2 screenPosition = Main.screenPosition;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cWings = drawinfo.cWings;
			if (cWings == 0)
			{
			}
			if (cWings == 0)
			{
			}
			Vector2 screenPosition2 = Main.screenPosition;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			int cWings2 = drawinfo.cWings;
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0021B0A8 File Offset: 0x002192A8
		public static void DrawMeowcartTrail(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int type = drawPlayer.mount._type;
			float shadow = drawinfo.shadow;
			int availableAdvancedShadowsCount = drawPlayer.availableAdvancedShadowsCount;
			int num = 20;
			int num2 = Math.Min(0, num);
			EntityShadowInfo advancedShadow = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			EntityShadowInfo advancedShadow2 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			if (drawPlayer == null)
			{
			}
			int num3 = 17184;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Player drawPlayer2 = drawinfo.drawPlayer;
			int width = drawPlayer2.width;
			int height = drawPlayer2.height;
			if (drawPlayer2 == null)
			{
			}
			if (drawinfo.drawPlayer.direction == 0)
			{
			}
			int num4 = 1;
			if (num4 == 0)
			{
			}
			Player drawPlayer3 = drawinfo.drawPlayer;
			int value = num4.m_value;
			Vector2 center = drawPlayer3.Center;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x = drawPlayer4.position.X;
			float y = drawPlayer4.position.Y;
			EntityShadowInfo advancedShadow3 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			EntityShadowInfo advancedShadow4 = drawinfo.drawPlayer.GetAdvancedShadow(num2);
			Player drawPlayer5 = drawinfo.drawPlayer;
			Player drawPlayer6 = drawinfo.drawPlayer;
			if (!false)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			SpriteEffects playerEffect = drawinfo.playerEffect;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0021B1FC File Offset: 0x002193FC
		public static void DrawPlayer_23_MountFront(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer.mount._active)
			{
				float shadow = drawinfo.shadow;
				float x = drawinfo.Position.X;
				float y = drawinfo.Position.Y;
				Color colorMount = drawinfo.colorMount;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				Player drawPlayer = drawinfo.drawPlayer;
				float shadow2 = drawinfo.shadow;
				float x2 = drawinfo.Position.X;
				float y2 = drawinfo.Position.Y;
				Color colorMount2 = drawinfo.colorMount;
				Mount mount = drawPlayer.mount;
				SpriteEffects playerEffect2 = drawinfo.playerEffect;
				return;
			}
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0021B290 File Offset: 0x00219490
		public static void DrawPlayer_24_Pulley(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			if (drawPlayer.pulley && drawPlayer.itemAnimation == 0)
			{
				byte pulleyDir = drawPlayer.pulleyDir;
				if (drawPlayer == null)
				{
				}
				float x = drawinfo.Position.X;
				bool sandStorm = drawPlayer.sandStorm;
				if (pulleyDir == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int direction = drawPlayer2.direction;
				int height = drawPlayer2.height;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height2 = drawPlayer3.height;
				float gravDir = drawPlayer3.gravDir;
				if (height2 == 0)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				int pulleyFrame = drawPlayer4.pulleyFrame;
				Color colorArmorHead = drawinfo.colorArmorHead;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				return;
			}
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0021B3E4 File Offset: 0x002195E4
		public static void DrawPlayer_25_Shield(PlayerDrawSet drawinfo)
		{
			Player drawPlayer20;
			for (;;)
			{
				if (drawinfo.drawPlayer == null)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				Player drawPlayer = drawinfo.drawPlayer;
				bool shieldRaised = drawPlayer.shieldRaised;
				int value = num.m_value;
				if (shieldRaised)
				{
					float gravDir = drawPlayer.gravDir;
				}
				int value2 = num.m_value;
				if (drawPlayer == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				float x = drawinfo.bodyVect.X;
				float y = drawinfo.bodyVect.Y;
				if (num2 == 0)
				{
				}
				Player drawPlayer2 = drawinfo.drawPlayer;
				bool iceSkate = drawPlayer.iceSkate;
				Player drawPlayer3;
				if (value2 == 0)
				{
					drawPlayer3 = drawinfo.drawPlayer;
				}
				SpriteEffects playerEffect = drawinfo.playerEffect;
				bool shieldRaised2 = drawPlayer3.shieldRaised;
				if (shieldRaised2)
				{
					if (!shieldRaised2)
					{
					}
					if (!iceSkate)
					{
					}
					byte r = drawinfo.colorArmorBody.R;
					if (!iceSkate)
					{
					}
					Player drawPlayer4 = drawinfo.drawPlayer;
					float x2 = drawinfo.Position.X;
					if (drawPlayer4 == null)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer5 = drawinfo.drawPlayer;
					float y2 = drawinfo.Position.Y;
					int width = drawPlayer5.width;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer6 = drawinfo.drawPlayer;
					int height = drawPlayer6.height;
					int height2 = drawPlayer6.bodyFrame.Height;
					Player drawPlayer7 = drawinfo.drawPlayer;
					float x3 = drawPlayer7.bodyPosition.X;
					float y3 = drawPlayer7.bodyPosition.Y;
					if (drawinfo.drawPlayer.bodyFrame.Height == 0)
					{
					}
					Player drawPlayer8 = drawinfo.drawPlayer;
					SpriteEffects playerEffect2 = drawinfo.playerEffect;
					float bodyRotation = drawPlayer8.bodyRotation;
					if (drawinfo.cShield == 0)
					{
					}
					Player drawPlayer9 = drawinfo.drawPlayer;
					float x4 = drawinfo.Position.X;
					if (drawPlayer9 == null)
					{
					}
					Vector2 screenPosition3 = Main.screenPosition;
					Player drawPlayer10 = drawinfo.drawPlayer;
					float y4 = drawinfo.Position.Y;
					int width2 = drawPlayer10.width;
					Vector2 screenPosition4 = Main.screenPosition;
					Player drawPlayer11 = drawinfo.drawPlayer;
					int height3 = drawPlayer11.height;
					int height4 = drawPlayer11.bodyFrame.Height;
					if (drawPlayer11 == null)
					{
					}
					Player drawPlayer12 = drawinfo.drawPlayer;
					float x5 = drawPlayer12.bodyPosition.X;
					float y5 = drawPlayer12.bodyPosition.Y;
					int height5 = drawinfo.drawPlayer.bodyFrame.Height;
					Player drawPlayer13 = drawinfo.drawPlayer;
					Color colorArmorBody = drawinfo.colorArmorBody;
					SpriteEffects playerEffect3 = drawinfo.playerEffect;
					float bodyRotation2 = drawPlayer13.bodyRotation;
					int cShield = drawinfo.cShield;
					Player drawPlayer14 = drawinfo.drawPlayer;
					bool shieldRaised3 = drawPlayer14.shieldRaised;
					if (shieldRaised3)
					{
						Color colorArmorBody2 = drawinfo.colorArmorBody;
						byte r2 = drawinfo.colorArmorBody.R;
						if (drawPlayer14 == null)
						{
						}
						if (!shieldRaised3)
						{
						}
						if (!shieldRaised3)
						{
						}
						Player drawPlayer15 = drawinfo.drawPlayer;
						float x6 = drawinfo.Position.X;
						Vector2 screenPosition5 = Main.screenPosition;
						Player drawPlayer16 = drawinfo.drawPlayer;
						int width3 = drawPlayer16.width;
						Vector2 screenPosition6 = Main.screenPosition;
						Player drawPlayer17 = drawinfo.drawPlayer;
						int height6 = drawPlayer17.height;
						int height7 = drawPlayer17.bodyFrame.Height;
						if (drawPlayer17 == null)
						{
						}
						Player drawPlayer18 = drawinfo.drawPlayer;
						float x7 = drawPlayer18.bodyPosition.X;
						float y6 = drawPlayer18.bodyPosition.Y;
						int height8 = drawinfo.drawPlayer.bodyFrame.Height;
						Player drawPlayer19 = drawinfo.drawPlayer;
						SpriteEffects playerEffect4 = drawinfo.playerEffect;
						float bodyRotation3 = drawPlayer19.bodyRotation;
						int cShield2 = drawinfo.cShield;
						drawPlayer20 = drawinfo.drawPlayer;
						if (drawPlayer20.shieldRaised)
						{
							break;
						}
					}
				}
			}
			int shieldParryTimeLeft = drawPlayer20.shieldParryTimeLeft;
			float x8 = drawinfo.Position.X;
			if (drawPlayer20 == null)
			{
			}
			Vector2 screenPosition7 = Main.screenPosition;
			Player drawPlayer21 = drawinfo.drawPlayer;
			float y7 = drawinfo.Position.Y;
			int width4 = drawPlayer21.width;
			Vector2 screenPosition8 = Main.screenPosition;
			Player drawPlayer22 = drawinfo.drawPlayer;
			int num3 = 52992;
			int height9 = drawPlayer22.height;
			int height10 = drawPlayer22.bodyFrame.Height;
			if (drawPlayer22 == null)
			{
			}
			Player drawPlayer23 = drawinfo.drawPlayer;
			float x9 = drawPlayer23.bodyPosition.X;
			float y8 = drawPlayer23.bodyPosition.Y;
			int height11 = drawinfo.drawPlayer.bodyFrame.Height;
			byte r3 = drawinfo.colorArmorBody.R;
			Player drawPlayer24 = drawinfo.drawPlayer;
			float x10 = drawinfo.Position.X;
			float y9 = drawinfo.Position.Y;
			byte a = drawinfo.colorArmorBody.A;
			Vector2 size = drawPlayer24.Size;
			Vector2 screenPosition9 = Main.screenPosition;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			Player drawPlayer25 = drawinfo.drawPlayer;
			SpriteEffects playerEffect5 = drawinfo.playerEffect;
			float bodyRotation4 = drawPlayer25.bodyRotation;
			int cShield3 = drawinfo.cShield;
			bool cart = drawinfo.drawPlayer.mount.Cart;
			DrawData[] drawDataCache = drawinfo.DrawDataCache;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0021B8B8 File Offset: 0x00219AB8
		public static void DrawPlayer_26_SolarShield(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			int solarShields = drawPlayer.solarShields;
			float shadow = drawinfo.shadow;
			bool dead = drawPlayer.dead;
			if (!dead)
			{
				if (!dead)
				{
					int solarShields2 = drawinfo.drawPlayer.solarShields;
				}
				Vector2[] solarShieldPos = drawinfo.drawPlayer.solarShieldPos;
				if (solarShieldPos == null)
				{
				}
				if (solarShieldPos == null)
				{
				}
				int direction = drawinfo.drawPlayer.direction;
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int height = drawinfo.drawPlayer.height;
				if (drawinfo.drawPlayer.solarShieldPos == null)
				{
				}
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cBody = drawinfo.cBody;
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0021B9AC File Offset: 0x00219BAC
		public static void DrawPlayer_27_HeldItem(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			if (drawPlayer.JustDroppedAnItem)
			{
				return;
			}
			int heldProj = drawPlayer.heldProj;
			float shadow = drawinfo.shadow;
			if (!drawinfo.heldProjOverHand)
			{
			}
			Item heldItem = drawinfo.heldItem;
			int type = heldItem.type;
			bool usingBiomeTorches = drawPlayer.UsingBiomeTorches;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x0021C25C File Offset: 0x0021A45C
		public static void DrawPlayer_28_ArmOverItem(PlayerDrawSet drawinfo)
		{
			while (!drawinfo.usesCompositeTorso)
			{
				Player drawPlayer = drawinfo.drawPlayer;
				int body = drawPlayer.body;
				if (drawPlayer == null)
				{
				}
				Player drawPlayer2 = drawinfo.drawPlayer;
				int direction = drawPlayer2.direction;
				int armorAdjust = drawinfo.armorAdjust;
				bool invis = drawPlayer2.invis;
				if (invis)
				{
					int body2 = drawPlayer2.body;
					return;
				}
				int num;
				if (drawinfo.missingHand && num == 0)
				{
					bool missingArm = drawinfo.missingArm;
					if (missingArm)
					{
						if (!missingArm)
						{
						}
						float x = drawinfo.Position.X;
						if (num == 0)
						{
						}
						Vector2 screenPosition = Main.screenPosition;
						Player drawPlayer3 = drawinfo.drawPlayer;
						float y = drawinfo.Position.Y;
						int width = drawPlayer3.bodyFrame.Width;
						int width2 = drawPlayer3.width;
						Vector2 screenPosition2 = Main.screenPosition;
						Player drawPlayer4 = drawinfo.drawPlayer;
						int height = drawPlayer4.height;
						int height2 = drawPlayer4.bodyFrame.Height;
						Player drawPlayer5 = drawinfo.drawPlayer;
						float x2 = drawPlayer5.bodyPosition.X;
						float y2 = drawPlayer5.bodyPosition.Y;
						Player drawPlayer6 = drawinfo.drawPlayer;
						int width3 = drawPlayer6.bodyFrame.Width;
						int height3 = drawPlayer6.bodyFrame.Height;
						Player drawPlayer7 = drawinfo.drawPlayer;
						Color colorBodySkin = drawinfo.colorBodySkin;
						float x3 = drawinfo.bodyVect.X;
						float y3 = drawinfo.bodyVect.Y;
						float bodyRotation = drawPlayer7.bodyRotation;
						int value = width3.m_value;
						SpriteEffects playerEffect = drawinfo.playerEffect;
						if (drawinfo.skinDyePacked == 0)
						{
						}
						float x4 = drawinfo.Position.X;
						if (width3 == 0)
						{
						}
						Vector2 screenPosition3 = Main.screenPosition;
						Player drawPlayer8 = drawinfo.drawPlayer;
						float y4 = drawinfo.Position.Y;
						int width4 = drawPlayer8.bodyFrame.Width;
						int width5 = drawPlayer8.width;
						Vector2 screenPosition4 = Main.screenPosition;
						Player drawPlayer9 = drawinfo.drawPlayer;
						int height4 = drawPlayer9.height;
						int height5 = drawPlayer9.bodyFrame.Height;
						Player drawPlayer10 = drawinfo.drawPlayer;
						float x5 = drawPlayer10.bodyPosition.X;
						float y5 = drawPlayer10.bodyPosition.Y;
						Player drawPlayer11 = drawinfo.drawPlayer;
						int width6 = drawPlayer11.bodyFrame.Width;
						int height6 = drawPlayer11.bodyFrame.Height;
						Player drawPlayer12 = drawinfo.drawPlayer;
						Color colorBodySkin2 = drawinfo.colorBodySkin;
						float x6 = drawinfo.bodyVect.X;
						float y6 = drawinfo.bodyVect.Y;
						float bodyRotation2 = drawPlayer12.bodyRotation;
						int value2 = width6.m_value;
						SpriteEffects playerEffect2 = drawinfo.playerEffect;
						if (drawinfo.skinDyePacked == 0)
						{
						}
						Player drawPlayer13 = drawinfo.drawPlayer;
						float x7 = drawinfo.Position.X;
						if (drawPlayer13 == null)
						{
						}
						Vector2 screenPosition5 = Main.screenPosition;
						Player drawPlayer14 = drawinfo.drawPlayer;
						float y7 = drawinfo.Position.Y;
						int width7 = drawPlayer14.bodyFrame.Width;
						int width8 = drawPlayer14.width;
						Vector2 screenPosition6 = Main.screenPosition;
						Player drawPlayer15 = drawinfo.drawPlayer;
						int height7 = drawPlayer15.height;
						int height8 = drawPlayer15.bodyFrame.Height;
						Player drawPlayer16 = drawinfo.drawPlayer;
						float x8 = drawPlayer16.bodyPosition.X;
						float y8 = drawPlayer16.bodyPosition.Y;
						Player drawPlayer17 = drawinfo.drawPlayer;
						int width9 = drawPlayer17.bodyFrame.Width;
						int height9 = drawPlayer17.bodyFrame.Height;
						Player drawPlayer18 = drawinfo.drawPlayer;
						Color colorArmorBody = drawinfo.colorArmorBody;
						float x9 = drawinfo.bodyVect.X;
						float y9 = drawinfo.bodyVect.Y;
						float bodyRotation3 = drawPlayer18.bodyRotation;
						SpriteEffects playerEffect3 = drawinfo.playerEffect;
						int cBody = drawinfo.cBody;
						int armGlowMask = drawinfo.armGlowMask;
						if (width9 == 0)
						{
							int armGlowMask2 = drawinfo.armGlowMask;
						}
						float x10 = drawinfo.Position.X;
						if (width9 == 0)
						{
						}
						Vector2 screenPosition7 = Main.screenPosition;
						Player drawPlayer19 = drawinfo.drawPlayer;
						float y10 = drawinfo.Position.Y;
						int width10 = drawPlayer19.bodyFrame.Width;
						int width11 = drawPlayer19.width;
						Vector2 screenPosition8 = Main.screenPosition;
						Player drawPlayer20 = drawinfo.drawPlayer;
						int height10 = drawPlayer20.height;
						int height11 = drawPlayer20.bodyFrame.Height;
						Player drawPlayer21 = drawinfo.drawPlayer;
						float x11 = drawPlayer21.bodyPosition.X;
						float y11 = drawPlayer21.bodyPosition.Y;
						Player drawPlayer22 = drawinfo.drawPlayer;
						int width12 = drawPlayer22.bodyFrame.Width;
						int height12 = drawPlayer22.bodyFrame.Height;
						Player drawPlayer23 = drawinfo.drawPlayer;
						Color armGlowColor = drawinfo.armGlowColor;
						float x12 = drawinfo.bodyVect.X;
						float y12 = drawinfo.bodyVect.Y;
						float bodyRotation4 = drawPlayer23.bodyRotation;
						SpriteEffects playerEffect4 = drawinfo.playerEffect;
						int cBody2 = drawinfo.cBody;
						int body3 = drawinfo.drawPlayer.body;
						int num2 = 100;
						if (drawinfo.drawPlayer.miscCounter == 0)
						{
						}
						int num3 = 11;
						int num4 = Utils.RandomInt((ulong)4720931368828141568L, num2, num3);
						int num5 = 1;
						int num6 = Utils.RandomInt((ulong)num4, num2, num5);
						float x13 = drawinfo.Position.X;
						Vector2 screenPosition9 = Main.screenPosition;
						Player drawPlayer24 = drawinfo.drawPlayer;
						float y13 = drawinfo.Position.Y;
						int width13 = drawPlayer24.bodyFrame.Width;
						int width14 = drawPlayer24.width;
						Vector2 screenPosition10 = Main.screenPosition;
						Player drawPlayer25 = drawinfo.drawPlayer;
						int height13 = drawPlayer25.height;
						int height14 = drawPlayer25.bodyFrame.Height;
						Player drawPlayer26 = drawinfo.drawPlayer;
						float x14 = drawPlayer26.bodyPosition.X;
						float y14 = drawPlayer26.bodyPosition.Y;
						Player drawPlayer27 = drawinfo.drawPlayer;
						int width15 = drawPlayer27.bodyFrame.Width;
						int height15 = drawPlayer27.bodyFrame.Height;
						Player drawPlayer28 = drawinfo.drawPlayer;
						float x15 = drawinfo.bodyVect.X;
						float y15 = drawinfo.bodyVect.Y;
						float bodyRotation5 = drawPlayer28.bodyRotation;
						SpriteEffects playerEffect5 = drawinfo.playerEffect;
						int cBody3 = drawinfo.cBody;
						return;
					}
				}
			}
			PlayerDrawLayers.DrawPlayer_28_ArmOverItemComposite(drawinfo);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0021CB68 File Offset: 0x0021AD68
		public static void DrawPlayer_28_ArmOverItemComposite(PlayerDrawSet drawinfo)
		{
			int num = 1;
			float x = drawinfo.Position.X;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer.bodyFrame.Width;
			int width2 = drawPlayer.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num2 = 52992;
			Player drawPlayer2 = drawinfo.drawPlayer;
			int height = drawPlayer2.height;
			int height2 = drawPlayer2.bodyFrame.Height;
			Player drawPlayer3 = drawinfo.drawPlayer;
			float x2 = drawPlayer3.bodyPosition.X;
			float y2 = drawPlayer3.bodyPosition.Y;
			if (num2 == 0)
			{
			}
			Player drawPlayer4 = drawinfo.drawPlayer;
			int width3 = drawPlayer4.bodyFrame.Width;
			int height3 = drawPlayer4.bodyFrame.Height;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int y3 = drawPlayer5.bodyFrame.Y;
			int height4 = drawPlayer5.bodyFrame.Height;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int num3 = true.ToDirectionInt();
			Player drawPlayer6 = drawinfo.drawPlayer;
			float compositeFrontArmRotation = drawinfo.compositeFrontArmRotation;
			float x3 = drawinfo.bodyVect.X;
			float bodyRotation = drawPlayer6.bodyRotation;
			float y4 = drawinfo.bodyVect.Y;
			if (drawPlayer6 == null)
			{
			}
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			float x4 = drawinfo.frontShoulderOffset.X;
			float y5 = drawinfo.frontShoulderOffset.Y;
			Rectangle compFrontArmFrame = drawinfo.compFrontArmFrame;
			int width4 = drawinfo.compFrontArmFrame.Width;
			if (drawinfo.playerEffect == SpriteEffects.None)
			{
			}
			int body = drawinfo.drawPlayer.body;
			if (width4 == 0)
			{
				Player drawPlayer7 = drawinfo.drawPlayer;
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0021D044 File Offset: 0x0021B244
		public static void DrawPlayer_29_OnhandAcc(PlayerDrawSet drawinfo)
		{
			if (drawinfo.usesCompositeFrontHandAcc)
			{
				return;
			}
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.Position.X;
			if (drawPlayer == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y = drawinfo.Position.Y;
			int width = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			int num = 52992;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x2 = drawPlayer4.bodyPosition.X;
			float y2 = drawPlayer4.bodyPosition.Y;
			if (num == 0)
			{
			}
			Player drawPlayer5 = drawinfo.drawPlayer;
			int width2 = drawPlayer5.bodyFrame.Width;
			int height3 = drawPlayer5.bodyFrame.Height;
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			float x3 = drawinfo.bodyVect.X;
			float y3 = drawinfo.bodyVect.Y;
			float bodyRotation = drawPlayer6.bodyRotation;
			int value = width2.m_value;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			int cHandOn = drawinfo.cHandOn;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x0021D16C File Offset: 0x0021B36C
		public static void DrawPlayer_30_BladedGlove(PlayerDrawSet drawinfo)
		{
			int num = 1;
			Item heldItem = drawinfo.heldItem;
			int type = heldItem.type;
			if (num == 0)
			{
				int type2 = heldItem.type;
			}
			if (num != 0)
			{
				float shadow = drawinfo.shadow;
				if (num == 0)
				{
					int type3 = heldItem.type;
				}
				if (num == 0)
				{
				}
				Player drawPlayer = drawinfo.drawPlayer;
				if (!drawPlayer.frozen)
				{
					int itemAnimation = drawPlayer.itemAnimation;
					return;
				}
			}
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x0021D2A0 File Offset: 0x0021B4A0
		public static void DrawPlayer_31_ProjectileOverArm(PlayerDrawSet drawinfo)
		{
			int heldProj = drawinfo.drawPlayer.heldProj;
			float shadow = drawinfo.shadow;
			if (drawinfo.heldProjOverHand)
			{
			}
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0021D2C8 File Offset: 0x0021B4C8
		public static void DrawPlayer_32_FrontAcc(PlayerDrawSet drawinfo)
		{
			if (!true)
			{
			}
			bool active = drawinfo.drawPlayer.mount._active;
			if (!active)
			{
				if (!active)
				{
				}
				if (!true)
				{
				}
				Player drawPlayer = drawinfo.drawPlayer;
				float x = drawinfo.Position.X;
				if (drawPlayer == null)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				int width3 = drawPlayer4.bodyFrame.Width;
				int height3 = drawPlayer4.bodyFrame.Height;
				Player drawPlayer5 = drawinfo.drawPlayer;
				Color colorArmorBody = drawinfo.colorArmorBody;
				float x3 = drawinfo.bodyVect.X;
				float y3 = drawinfo.bodyVect.Y;
				float bodyRotation = drawPlayer5.bodyRotation;
				int value = width3.m_value;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				int cFront = drawinfo.cFront;
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0021D400 File Offset: 0x0021B600
		public static void DrawPlayer_32_FrontAcc_FrontPart(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.bodyVect.X;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float y = drawinfo.bodyVect.Y;
			int num = 1;
			if (num == 0)
			{
			}
			float x2 = drawinfo.Position.X;
			int value = num.m_value;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x3 = drawPlayer4.bodyPosition.X;
			float y3 = drawPlayer4.bodyPosition.Y;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int width3 = drawPlayer5.bodyFrame.Width;
			if (drawPlayer5.bodyFrame.Height == 0)
			{
			}
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			float bodyRotation = drawPlayer6.bodyRotation;
			int cFront = drawinfo.cFront;
			sbyte front = drawinfo.drawPlayer.front;
			SpriteEffects playerEffect3 = drawinfo.playerEffect;
			float shadow = drawinfo.shadow;
			Color colorArmorBody2 = drawinfo.colorArmorBody;
			if (drawPlayer6 == null)
			{
			}
			if (drawPlayer6 == null)
			{
			}
			Player drawPlayer7 = drawinfo.drawPlayer;
			SpriteEffects playerEffect4 = drawinfo.playerEffect;
			float bodyRotation2 = drawPlayer7.bodyRotation;
			int cFront2 = drawinfo.cFront;
			Player drawPlayer8 = drawinfo.drawPlayer;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0021D59C File Offset: 0x0021B79C
		public static void DrawPlayer_32_FrontAcc_BackPart(PlayerDrawSet drawinfo)
		{
			if (drawinfo.drawPlayer == null)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.bodyVect.X;
			SpriteEffects playerEffect = drawinfo.playerEffect;
			float y = drawinfo.bodyVect.Y;
			int num = 1;
			if (num == 0)
			{
			}
			float x2 = drawinfo.Position.X;
			int value = num.m_value;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Player drawPlayer2 = drawinfo.drawPlayer;
			float y2 = drawinfo.Position.Y;
			int width = drawPlayer2.bodyFrame.Width;
			int width2 = drawPlayer2.width;
			Vector2 screenPosition2 = Main.screenPosition;
			Player drawPlayer3 = drawinfo.drawPlayer;
			int height = drawPlayer3.height;
			int height2 = drawPlayer3.bodyFrame.Height;
			Player drawPlayer4 = drawinfo.drawPlayer;
			float x3 = drawPlayer4.bodyPosition.X;
			float y3 = drawPlayer4.bodyPosition.Y;
			Player drawPlayer5 = drawinfo.drawPlayer;
			int width3 = drawPlayer5.bodyFrame.Width;
			if (drawPlayer5 == null)
			{
			}
			Player drawPlayer6 = drawinfo.drawPlayer;
			Color colorArmorBody = drawinfo.colorArmorBody;
			SpriteEffects playerEffect2 = drawinfo.playerEffect;
			BitsByte ownedLargeGems = drawPlayer5.ownedLargeGems;
			int cFront = drawinfo.cFront;
			sbyte front = drawinfo.drawPlayer.front;
			SpriteEffects playerEffect3 = drawinfo.playerEffect;
			float shadow = drawinfo.shadow;
			Color colorArmorBody2 = drawinfo.colorArmorBody;
			if (drawPlayer6 == null)
			{
			}
			if (drawPlayer6 == null)
			{
			}
			Player drawPlayer7 = drawinfo.drawPlayer;
			SpriteEffects playerEffect4 = drawinfo.playerEffect;
			float bodyRotation = drawPlayer7.bodyRotation;
			int cFront2 = drawinfo.cFront;
			Player drawPlayer8 = drawinfo.drawPlayer;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0021D728 File Offset: 0x0021B928
		public static void DrawPlayer_33_FrozenOrWebbedDebuff(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			if (!drawPlayer.shimmering)
			{
				bool frozen = drawPlayer.frozen;
				int width2;
				Player drawPlayer6;
				if (frozen)
				{
					float shadow = drawinfo.shadow;
					byte r = drawinfo.colorArmorBody.R;
					byte g = drawinfo.colorArmorBody.G;
					byte b = drawinfo.colorArmorBody.B;
					byte a = drawinfo.colorArmorBody.A;
					if (!frozen)
					{
					}
					float x = drawinfo.Position.X;
					if (!frozen)
					{
					}
					Vector2 screenPosition = Main.screenPosition;
					Player drawPlayer2 = drawinfo.drawPlayer;
					float y = drawinfo.Position.Y;
					int width = drawPlayer2.bodyFrame.Width;
					width2 = drawPlayer2.width;
					Vector2 screenPosition2 = Main.screenPosition;
					Player drawPlayer3 = drawinfo.drawPlayer;
					int height = drawPlayer3.height;
					int height2 = drawPlayer3.bodyFrame.Height;
					Player drawPlayer4 = drawinfo.drawPlayer;
					float x2 = drawPlayer4.bodyPosition.X;
					float y2 = drawPlayer4.bodyPosition.Y;
					if (52992 == 0)
					{
					}
					Player drawPlayer5 = drawinfo.drawPlayer;
					int width3 = drawPlayer5.bodyFrame.Width;
					int height3 = drawPlayer5.bodyFrame.Height;
					if (width3 == 0)
					{
					}
					drawPlayer6 = drawinfo.drawPlayer;
					float bodyRotation = drawPlayer6.bodyRotation;
					SpriteEffects playerEffect = drawinfo.playerEffect;
					return;
				}
				if (drawPlayer6 != null)
				{
					float shadow2 = drawinfo.shadow;
					Color color = drawinfo.colorArmorBody * (float)width2;
					if (drawPlayer6 == null)
					{
					}
					Player drawPlayer7 = drawinfo.drawPlayer;
					float x3 = drawinfo.Position.X;
					int height4 = drawPlayer7.height;
					Vector2 screenPosition3 = Main.screenPosition;
					Player drawPlayer8 = drawinfo.drawPlayer;
					float y3 = drawinfo.Position.Y;
					int width4 = drawPlayer8.bodyFrame.Width;
					int width5 = drawPlayer8.width;
					Vector2 screenPosition4 = Main.screenPosition;
					Player drawPlayer9 = drawinfo.drawPlayer;
					int height5 = drawPlayer9.height;
					int height6 = drawPlayer9.bodyFrame.Height;
					Player drawPlayer10 = drawinfo.drawPlayer;
					float x4 = drawPlayer10.bodyPosition.X;
					float y4 = drawPlayer10.bodyPosition.Y;
					if (52992 == 0)
					{
					}
					Player drawPlayer11 = drawinfo.drawPlayer;
					int width6 = drawPlayer11.bodyFrame.Width;
					int height7 = drawPlayer11.bodyFrame.Height;
					float bodyRotation2 = drawinfo.drawPlayer.bodyRotation;
					if (width6 == 0)
					{
					}
					SpriteEffects playerEffect2 = drawinfo.playerEffect;
				}
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0021D98C File Offset: 0x0021BB8C
		public static void DrawPlayer_34_ElectrifiedDebuffFront(PlayerDrawSet drawinfo)
		{
			bool electrified = drawinfo.drawPlayer.electrified;
			if (electrified)
			{
				float shadow = drawinfo.shadow;
				if (!electrified)
				{
					Player drawPlayer = drawinfo.drawPlayer;
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.bodyFrame.Width;
				int width2 = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				Player drawPlayer3 = drawinfo.drawPlayer;
				int height = drawPlayer3.height;
				int height2 = drawPlayer3.bodyFrame.Height;
				Player drawPlayer4 = drawinfo.drawPlayer;
				float x2 = drawPlayer4.bodyPosition.X;
				float y2 = drawPlayer4.bodyPosition.Y;
				Player drawPlayer5 = drawinfo.drawPlayer;
				int width3 = drawPlayer5.bodyFrame.Width;
				int height3 = drawPlayer5.bodyFrame.Height;
				Player drawPlayer6 = drawinfo.drawPlayer;
				Color colorElectricity = drawinfo.colorElectricity;
				float bodyRotation = drawPlayer6.bodyRotation;
				SpriteEffects playerEffect = drawinfo.playerEffect;
			}
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0021DAA0 File Offset: 0x0021BCA0
		public static void DrawPlayer_35_IceBarrier(PlayerDrawSet drawinfo)
		{
			bool iceBarrier = drawinfo.drawPlayer.iceBarrier;
			if (iceBarrier)
			{
				float shadow = drawinfo.shadow;
				if (!iceBarrier)
				{
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer.bodyFrame.Width;
				int width2 = drawPlayer.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int num = 52992;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int height = drawPlayer2.height;
				int height2 = drawPlayer2.bodyFrame.Height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				float x2 = drawPlayer3.bodyPosition.X;
				float y2 = drawPlayer3.bodyPosition.Y;
				if (num == 0)
				{
				}
				Player drawPlayer4 = drawinfo.drawPlayer;
				int width3 = drawPlayer4.bodyFrame.Width;
				int height3 = drawPlayer4.bodyFrame.Height;
				byte iceBarrierFrame = drawinfo.drawPlayer.iceBarrierFrame;
				SpriteEffects playerEffect = drawinfo.playerEffect;
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x0021DBA4 File Offset: 0x0021BDA4
		public static void DrawPlayer_36_CTG(PlayerDrawSet drawinfo)
		{
			float shadow = drawinfo.shadow;
			BitsByte ownedLargeGems = drawinfo.drawPlayer.ownedLargeGems;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0021DC74 File Offset: 0x0021BE74
		public static void DrawPlayer_37_BeetleBuff(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			if (drawPlayer.beetleOffense || drawPlayer.beetleDefense)
			{
				float shadow = drawinfo.shadow;
				int beetleOrbs = drawPlayer.beetleOrbs;
				byte r = drawinfo.colorArmorBody.R;
				byte g = drawinfo.colorArmorBody.G;
				byte b = drawinfo.colorArmorBody.B;
				byte a = drawinfo.colorArmorBody.A;
				if (drawPlayer.beetleVel == null)
				{
				}
				float x = drawinfo.Position.X;
				Vector2 screenPosition = Main.screenPosition;
				Player drawPlayer2 = drawinfo.drawPlayer;
				float y = drawinfo.Position.Y;
				int width = drawPlayer2.width;
				Vector2 screenPosition2 = Main.screenPosition;
				int height = drawinfo.drawPlayer.height;
				Player drawPlayer3 = drawinfo.drawPlayer;
				Vector2[] beetlePos = drawPlayer3.beetlePos;
				int beetleFrame = drawinfo.drawPlayer.beetleFrame;
				SpriteEffects playerEffect = drawinfo.playerEffect;
				Player drawPlayer4 = drawinfo.drawPlayer;
				return;
			}
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0021DE08 File Offset: 0x0021C008
		public static void DrawPlayer_38_EyebrellaCloud(PlayerDrawSet drawinfo)
		{
			bool eyebrellaCloud = drawinfo.drawPlayer.eyebrellaCloud;
			if (eyebrellaCloud)
			{
				float shadow = drawinfo.shadow;
				if (!eyebrellaCloud)
				{
					Player drawPlayer = drawinfo.drawPlayer;
				}
				if (18 == 0)
				{
				}
				Vector2 mountedCenter = drawinfo.drawPlayer.MountedCenter;
				Player drawPlayer2 = drawinfo.drawPlayer;
				int height = drawPlayer2.height;
				if (drawPlayer2 == null)
				{
				}
				if (drawPlayer2 == null)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Vector2 top = drawinfo.drawPlayer.Top;
				if (!eyebrellaCloud)
				{
				}
				Point point;
				Color color = Lighting.GetColor(point);
				Player drawPlayer3 = drawinfo.drawPlayer;
				float gravDir = drawinfo.drawPlayer.gravDir;
				int cHead = drawinfo.cHead;
				float gravDir2 = drawinfo.drawPlayer.gravDir;
				int cHead2 = drawinfo.cHead;
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0021DEE0 File Offset: 0x0021C0E0
		private static Vector2 GetCompositeOffset_BackArm(PlayerDrawSet drawinfo)
		{
			/*
An exception occurred when decompiling this method (060036B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.DataStructures.PlayerDrawLayers::GetCompositeOffset_BackArm(Terraria.DataStructures.PlayerDrawSet)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SpriteEffects(var_0_06, ldfld:SpriteEffects(PlayerDrawSet::playerEffect, ldloc:PlayerDrawSet[exp:valuetype Terraria.DataStructures.PlayerDrawSet&](drawinfo)))
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

		// Token: 0x060036B3 RID: 14003 RVA: 0x0021DEF4 File Offset: 0x0021C0F4
		private static Vector2 GetCompositeOffset_FrontArm(PlayerDrawSet drawinfo)
		{
			/*
An exception occurred when decompiling this method (060036B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.DataStructures.PlayerDrawLayers::GetCompositeOffset_FrontArm(Terraria.DataStructures.PlayerDrawSet)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SpriteEffects(var_0_06, ldfld:SpriteEffects(PlayerDrawSet::playerEffect, ldloc:PlayerDrawSet[exp:valuetype Terraria.DataStructures.PlayerDrawSet&](drawinfo)))
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

		// Token: 0x060036B4 RID: 14004 RVA: 0x0021DF08 File Offset: 0x0021C108
		public static void DrawPlayer_TransformDrawData(PlayerDrawSet drawinfo, [Optional] Vector2[] positionalOffsets)
		{
			Vector2 legsOffset = drawinfo.legsOffset;
			int num = 1;
			float rotation = drawinfo.rotation;
			float x = drawinfo.Position.X;
			float y = drawinfo.Position.Y;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			float x2 = drawinfo.rotationOrigin.X;
			float y2 = drawinfo.rotationOrigin.Y;
			Player drawPlayer = drawinfo.drawPlayer;
			float x3 = drawinfo.rotationOrigin.X;
			float y3 = drawinfo.rotationOrigin.Y;
			float x4 = drawPlayer.position.X;
			float y4 = drawPlayer.position.Y;
			float rotation2 = drawinfo.rotation;
			if (drawPlayer == null)
			{
			}
			int size = drawinfo.DustCache._size;
			List<int> dustCache = drawinfo.DustCache;
			List<int> dustCache2 = drawinfo.DustCache;
			int size2 = drawinfo.DustCache._size;
			int size3 = drawinfo.GoreCache._size;
			List<int> goreCache = drawinfo.GoreCache;
			List<int> goreCache2 = drawinfo.GoreCache;
			int size4 = drawinfo.GoreCache._size;
			long num2 = 0L;
			DrawData[] drawDataCache = drawinfo.DrawDataCache;
			float rotation3 = drawinfo.rotation;
			if (positionalOffsets != null)
			{
				long value = num2.m_value;
				num2.m_value = (long)rotation3;
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0021E058 File Offset: 0x0021C258
		public static void DrawPlayer_ScaleDrawData(PlayerDrawSet drawinfo, float scale)
		{
			int num = 1;
			Player drawPlayer = drawinfo.drawPlayer;
			float x = drawinfo.Position.X;
			float y = drawinfo.Position.Y;
			Vector2 size = drawPlayer.Size;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			if (drawinfo.DrawDataCache == null)
			{
			}
			Vector2 vector2;
			Vector2 vector = vector2 * scale;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0021E0C4 File Offset: 0x0021C2C4
		public static void DrawPlayer_AddSelectionGlow(PlayerDrawSet drawinfo)
		{
			int num = 1;
			Color selectionGlowColor = drawinfo.selectionGlowColor;
			if (num == 0)
			{
			}
			Color selectionGlowColor2 = drawinfo.selectionGlowColor;
			if (num == 0)
			{
			}
			DrawData[] drawDataCache = drawinfo.DrawDataCache;
			DrawData[] drawDataCache2 = drawinfo.DrawDataCache;
			DrawData[] drawDataCache3 = drawinfo.DrawDataCache;
			DrawData[] drawDataCache4 = drawinfo.DrawDataCache;
			DrawData[] drawDataCache5 = drawinfo.DrawDataCache;
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0021E110 File Offset: 0x0021C310
		public static void DrawPlayer_MakeIntoFirstFractalAfterImage(PlayerDrawSet drawinfo)
		{
			Player drawPlayer = drawinfo.drawPlayer;
			Player drawPlayer2;
			if (drawPlayer.isFirstFractalAfterImage)
			{
				DrawData[] drawDataCache = drawinfo.DrawDataCache;
				float firstFractalAfterImageOpacity = drawPlayer.firstFractalAfterImageOpacity;
				Color color;
				drawDataCache.texture = color;
				drawPlayer2 = drawinfo.drawPlayer;
				return;
			}
			Item heldItem = drawPlayer2.HeldItem;
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x0021E158 File Offset: 0x0021C358
		private static bool inBatchMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (060036B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.PlayerDrawLayers::get_inBatchMode()

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
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x0021E168 File Offset: 0x0021C368
		public static void DrawPlayer_RenderAllLayers(PlayerDrawSet drawinfo, [Optional] Vector2[] positionalOffsets)
		{
			int num = 1;
			DrawData[] drawDataCache = drawinfo.DrawDataCache;
			if (num == 0)
			{
			}
			Effect pixelShader = Main.pixelShader;
			int num2 = 1;
			int projectileDrawPosition = drawinfo.projectileDrawPosition;
			if (num2 == 0)
			{
			}
			if (!true)
			{
			}
			Player drawPlayer = drawinfo.drawPlayer;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0021E24C File Offset: 0x0021C44C
		public static void DrawPlayer_DrawSelectionRect(PlayerDrawSet drawinfo)
		{
			DrawData[] drawDataCache = drawinfo.DrawDataCache;
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

		// Token: 0x060036BB RID: 14011 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool IsArmorDrawnWhenInvisible(int torsoID)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0021E280 File Offset: 0x0021C480
		private static DrawData[] GetFlatColoredCloneData(PlayerDrawSet drawinfo, Vector2 offset, Color color)
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

		// Token: 0x060036BD RID: 14013 RVA: 0x0021E298 File Offset: 0x0021C498
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDrawLayers()
		{
		}

		// Token: 0x04007799 RID: 30617
		private static List<DrawData> ctgSorter;

		// Token: 0x0400779A RID: 30618
		private static List<DrawData> modifiedDrawDataBackup;

		// Token: 0x0400779B RID: 30619
		private static int lastBatchTextureIndex;

		// Token: 0x0400779C RID: 30620
		private static EffectPass lastEffectPass;
	}
}
