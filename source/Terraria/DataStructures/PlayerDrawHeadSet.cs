using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000643 RID: 1603
	public struct PlayerDrawHeadSet
	{
		// Token: 0x060036BE RID: 14014 RVA: 0x0021E2A8 File Offset: 0x0021C4A8
		public void AddDrawData(DrawData data)
		{
			DrawData[] drawData = this.DrawData;
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x0021E2BC File Offset: 0x0021C4BC
		public Rectangle HairFrame
		{
			get
			{
				return this.bodyFrameMemory;
			}
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0021E2D0 File Offset: 0x0021C4D0
		public void BoringSetup(Player drawPlayer2, DrawData[] drawData, List<int> dust, List<int> gore, float X, float Y, float Alpha, float Scale)
		{
			this.DrawData = drawData;
			this.Dust = dust;
			this.Gore = gore;
			this.drawPlayer = drawPlayer2;
			Vector2 position = drawPlayer2.position;
			this.cHead = (int)X;
			this.cUnicornHorn = (int)X;
			this.Position = position;
			int skinVariant = drawPlayer2.skinVariant;
			this.skinVar = skinVariant;
			byte hairDye = drawPlayer2.hairDye;
			if (skinVariant == 0)
			{
			}
			Player player = this.drawPlayer;
			int num;
			this.hairShaderPacked = num;
			if (player.head == 0 && player.hairDye == 0)
			{
				if (player == null)
				{
				}
				Player player2 = this.drawPlayer;
				int num2;
				this.hairShaderPacked = num2;
			}
			int num3;
			this.skinDyePacked = num3;
			Player player3 = this.drawPlayer;
			Player player4 = this.drawPlayer;
			int num4 = player4.cHead;
			this.cHead = num4;
			int num5 = player4.cFaceFlower;
			this.cFaceFlower = num5;
			this.cUnicornHorn = num5;
			int num6 = player4.cBeard;
			this.cBeard = num6;
			bool hasUnicornHorn = player4.hasUnicornHorn;
			this.drawUnicornHorn = hasUnicornHorn;
			bool hasAngelHalo = player4.hasAngelHalo;
			this.drawAngelHalo = hasAngelHalo;
			Player player5;
			if (!hasAngelHalo)
			{
				player5 = this.drawPlayer;
			}
			int hair = player5.hair;
			if (player5 == null)
			{
			}
			int gemCount = player5.gemCount;
			Player player6 = this.drawPlayer;
			Color color;
			this.colorEyeWhites = color;
			Color color2 = Main.quickAlpha(player6.eyeColor, Alpha);
			Player player7 = this.drawPlayer;
			this.colorEyes = color2;
			long num7 = 0L;
			Color color3 = Main.quickAlpha(player7.GetHairColor(num7 != 0L), Alpha);
			Player player8 = this.drawPlayer;
			this.colorHair = color3;
			Color color4 = Main.quickAlpha(player8.skinColor, Alpha);
			this.colorHead = color4;
			Color color5 = Main.quickAlpha(color4, Alpha);
			Player player9 = this.drawPlayer;
			this.colorArmorHead = color5;
			Player player10;
			if (player9.isDisplayDollOrInanimate)
			{
				if (player9 == null)
				{
				}
				player10 = this.drawPlayer;
				Color color6;
				this.colorDisplayDollSkin = color6;
				return;
			}
			Color color7 = this.colorHead;
			this.colorDisplayDollSkin = color7;
			int direction = player10.direction;
			this.playerEffect = (SpriteEffects)direction;
			int width = player10.legFrame.Width;
			int height = player10.legFrame.Height;
			Player player11 = this.drawPlayer;
			this.headVect = player10;
			if (player10 == null)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int heightMapOffset = this.drawPlayer.HeightMapOffset;
			Player player12 = this.drawPlayer;
			int head = player12.head;
			if (player12 == null)
			{
			}
			int head2 = this.drawPlayer.head;
			Player player13 = this.drawPlayer;
			Player player14 = this.drawPlayer;
			if (player14 == null)
			{
			}
			if (player14 == null)
			{
			}
			Player player15 = this.drawPlayer;
			long entityId = player14.entityId;
			Player player16 = this.drawPlayer;
			if (player16 == null)
			{
			}
			if (player16 == null)
			{
			}
			Player player17 = this.drawPlayer;
			long entityId2 = player16.entityId;
			Player player18 = this.drawPlayer;
			if (player18 == null)
			{
			}
			if (player18 == null)
			{
			}
			Player player19 = this.drawPlayer;
			long entityId3 = player18.entityId;
			Player player20 = this.drawPlayer;
			if (player20 == null)
			{
			}
			if (player20 == null)
			{
			}
			Player player21 = this.drawPlayer;
			long entityId4 = player20.entityId;
			Player player22 = this.drawPlayer;
			Player player23 = this.drawPlayer;
			bool flag = this.hatHair;
			int hair2 = player23.hair;
			Vector2 hairDrawOffset = player23.GetHairDrawOffset(hair2, flag);
			Player player24 = this.drawPlayer;
			this.hairOffset.Y = (float)width;
			Vector2 directions = player24.Directions;
			Vector2 helmetDrawOffset = this.drawPlayer.GetHelmetDrawOffset();
			Player player25 = this.drawPlayer;
			this.helmetOffset.Y = (float)width;
			Vector2 directions2 = player25.Directions;
			int head3 = this.drawPlayer.head;
			int num8 = 1;
			this.helmetIsTall = num8 != 0;
		}

		// Token: 0x0400779D RID: 30621
		public int DrawDataCount;

		// Token: 0x0400779E RID: 30622
		public DrawData[] DrawData;

		// Token: 0x0400779F RID: 30623
		public List<int> Dust;

		// Token: 0x040077A0 RID: 30624
		public List<int> Gore;

		// Token: 0x040077A1 RID: 30625
		public Player drawPlayer;

		// Token: 0x040077A2 RID: 30626
		public int cHead;

		// Token: 0x040077A3 RID: 30627
		public int cFace;

		// Token: 0x040077A4 RID: 30628
		public int cFaceHead;

		// Token: 0x040077A5 RID: 30629
		public int cFaceFlower;

		// Token: 0x040077A6 RID: 30630
		public int cUnicornHorn;

		// Token: 0x040077A7 RID: 30631
		public int cAngelHalo;

		// Token: 0x040077A8 RID: 30632
		public int cBeard;

		// Token: 0x040077A9 RID: 30633
		public int skinVar;

		// Token: 0x040077AA RID: 30634
		public int hairShaderPacked;

		// Token: 0x040077AB RID: 30635
		public int skinDyePacked;

		// Token: 0x040077AC RID: 30636
		public float scale;

		// Token: 0x040077AD RID: 30637
		public Color colorEyeWhites;

		// Token: 0x040077AE RID: 30638
		public Color colorEyes;

		// Token: 0x040077AF RID: 30639
		public Color colorHair;

		// Token: 0x040077B0 RID: 30640
		public Color colorHead;

		// Token: 0x040077B1 RID: 30641
		public Color colorArmorHead;

		// Token: 0x040077B2 RID: 30642
		public Color colorDisplayDollSkin;

		// Token: 0x040077B3 RID: 30643
		public SpriteEffects playerEffect;

		// Token: 0x040077B4 RID: 30644
		public Vector2 headVect;

		// Token: 0x040077B5 RID: 30645
		public Rectangle bodyFrameMemory;

		// Token: 0x040077B6 RID: 30646
		public bool fullHair;

		// Token: 0x040077B7 RID: 30647
		public bool hatHair;

		// Token: 0x040077B8 RID: 30648
		public bool hideHair;

		// Token: 0x040077B9 RID: 30649
		public bool helmetIsTall;

		// Token: 0x040077BA RID: 30650
		public bool helmetIsOverFullHair;

		// Token: 0x040077BB RID: 30651
		public bool helmetIsNormal;

		// Token: 0x040077BC RID: 30652
		public bool drawUnicornHorn;

		// Token: 0x040077BD RID: 30653
		public bool drawAngelHalo;

		// Token: 0x040077BE RID: 30654
		public Vector2 Position;

		// Token: 0x040077BF RID: 30655
		public Vector2 hairOffset;

		// Token: 0x040077C0 RID: 30656
		public Vector2 helmetOffset;
	}
}
