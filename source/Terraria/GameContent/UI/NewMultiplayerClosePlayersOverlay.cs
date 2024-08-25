using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A64 RID: 2660
	public class NewMultiplayerClosePlayersOverlay : IMultiplayerClosePlayersOverlay
	{
		// Token: 0x06004E8B RID: 20107 RVA: 0x000021DB File Offset: 0x000003DB
		public void Draw()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00276F3C File Offset: 0x0027513C
		private static void GetDistance(int testWidth, int testHeight, Vector2 testPosition, Player localPlayer, SpriteFont font, Player player, string nameToShow, [Out] Vector2 namePlatePos, [Out] float namePlateDist, [Out] Vector2 measurement)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			bool hasValue = font._defaultCharacter.hasValue;
			int defaultGlyphIndex = font._defaultGlyphIndex;
			int screenHeight2 = Main.screenHeight;
			int screenHeight3 = Main.screenHeight;
			int screenWidth2 = Main.screenWidth;
			int screenWidth3 = Main.screenWidth;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00276FEC File Offset: 0x002751EC
		public NewMultiplayerClosePlayersOverlay()
		{
		}

		// Token: 0x040087A8 RID: 34728
		private List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache> _playerOnScreenCache;

		// Token: 0x040087A9 RID: 34729
		private List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache> _playerOffScreenCache;

		// Token: 0x02000A65 RID: 2661
		private struct PlayerOnScreenCache
		{
			// Token: 0x06004E8E RID: 20110 RVA: 0x00277000 File Offset: 0x00275200
			public PlayerOnScreenCache(string name, Vector2 pos, Color color)
			{
				this._name = name;
				this._color = pos;
			}

			// Token: 0x06004E8F RID: 20111 RVA: 0x0027701C File Offset: 0x0027521C
			public void DrawPlayerName_WhenPlayerIsOnScreen(SpriteBatch spriteBatch)
			{
				float x = this._pos.X;
				float y = this._pos.Y;
				float x2 = this._pos.X;
				float y2 = this._pos.Y;
				float x3 = this._pos.X;
				float y3 = this._pos.Y;
				float x4 = this._pos.X;
				float y4 = this._pos.Y;
				float x5 = this._pos.X;
				float y5 = this._pos.Y;
				Color color = this._color;
			}

			// Token: 0x040087AA RID: 34730
			private string _name;

			// Token: 0x040087AB RID: 34731
			private Vector2 _pos;

			// Token: 0x040087AC RID: 34732
			private Color _color;
		}

		// Token: 0x02000A66 RID: 2662
		private struct PlayerOffScreenCache
		{
			// Token: 0x06004E90 RID: 20112 RVA: 0x002770B4 File Offset: 0x002752B4
			public PlayerOffScreenCache(string name, Vector2 pos, Color color, Vector2 npDistPos, string npDist, Player thePlayer, Vector2 theMeasurement)
			{
				this.nameToShow = name;
				if (!true)
				{
				}
				this.namePlateColor = pos;
				Vector2 vector2;
				Vector2 vector = vector2.Floor();
				this.distanceString = color;
				this.player = npDistPos;
			}

			// Token: 0x06004E91 RID: 20113 RVA: 0x002770EC File Offset: 0x002752EC
			public void DrawPlayerName(SpriteBatch spriteBatch)
			{
				float x = this.namePlatePos.X;
				float y = this.namePlatePos.Y;
				if (49696 == 0)
				{
				}
				if (49696 == 0)
				{
				}
				string text = this.nameToShow;
				if (49696 == 0)
				{
				}
				string text2 = this.nameToShow;
				string text3 = this.nameToShow;
				string text4 = this.nameToShow;
				string text5 = this.nameToShow;
				Color color = this.namePlateColor;
			}

			// Token: 0x06004E92 RID: 20114 RVA: 0x00277158 File Offset: 0x00275358
			public void DrawPlayerHead()
			{
				float x = this.measurement.X;
				int num = 49834;
				if (num == 0)
				{
				}
				float x2 = this.namePlatePos.X;
				float y = this.namePlatePos.Y;
				if (num == 0)
				{
				}
				Camera camera = Main.Camera;
			}

			// Token: 0x06004E93 RID: 20115 RVA: 0x002771A4 File Offset: 0x002753A4
			public void DrawLifeBar()
			{
				float x = this.distanceDrawPosition.X;
				float y = this.distanceDrawPosition.Y;
				if (!true)
				{
				}
			}

			// Token: 0x06004E94 RID: 20116 RVA: 0x002771D0 File Offset: 0x002753D0
			public void DrawPlayerDistance(SpriteBatch spriteBatch)
			{
				if (!true)
				{
				}
				float x = this.distanceDrawPosition.X;
				float y = this.distanceDrawPosition.Y;
				string text = this.distanceString;
				if (!true)
				{
				}
				float x2 = this.distanceDrawPosition.X;
				float y2 = this.distanceDrawPosition.Y;
				string text2 = this.distanceString;
				float x3 = this.distanceDrawPosition.X;
				float y3 = this.distanceDrawPosition.Y;
				string text3 = this.distanceString;
				float x4 = this.distanceDrawPosition.X;
				float y4 = this.distanceDrawPosition.Y;
				string text4 = this.distanceString;
				string text5 = this.distanceString;
				float x5 = this.distanceDrawPosition.X;
				float y5 = this.distanceDrawPosition.Y;
				Color color = this.namePlateColor;
			}

			// Token: 0x040087AD RID: 34733
			private Player player;

			// Token: 0x040087AE RID: 34734
			private string nameToShow;

			// Token: 0x040087AF RID: 34735
			private Vector2 namePlatePos;

			// Token: 0x040087B0 RID: 34736
			private Color namePlateColor;

			// Token: 0x040087B1 RID: 34737
			private Vector2 distanceDrawPosition;

			// Token: 0x040087B2 RID: 34738
			private string distanceString;

			// Token: 0x040087B3 RID: 34739
			private Vector2 measurement;
		}
	}
}
