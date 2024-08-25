using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x020009EE RID: 2542
	public class WindGrid
	{
		// Token: 0x06004B52 RID: 19282 RVA: 0x0026E884 File Offset: 0x0026CA84
		public void SetSize(int targetWidth, int targetHeight)
		{
			int width = this._width;
			if (!true)
			{
			}
			int num = Math.Max(width, targetWidth);
			int height = this._height;
			this._width = num;
			int num2 = Math.Max(height, targetHeight);
			this._height = num2;
			this.ResizeGrid();
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x0026E8C8 File Offset: 0x0026CAC8
		public void Update()
		{
			int gameTime = this._gameTime;
			this._gameTime = gameTime;
			if (gameTime == 0)
			{
			}
			bool settingsEnabled_TilesSwayInWind = Main.SettingsEnabled_TilesSwayInWind;
			this.ScanPlayers();
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x0026E8F8 File Offset: 0x0026CAF8
		public void GetWindTime(int tileX, int tileY, int timeThreshold, [Out] int windTimeLeft, [Out] int directionX, [Out] int directionY)
		{
			WindGrid.WindCoord[,] grid = this._grid;
			int width = this._width;
			int gameTime = this._gameTime;
			directionX.m_value = gameTime;
			directionY.m_value = grid;
			int gameTime2 = this._gameTime;
			windTimeLeft.m_value = gameTime2;
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x0026E93C File Offset: 0x0026CB3C
		private void ResizeGrid()
		{
			WindGrid.WindCoord[,] grid = this._grid;
			int width = this._width;
			WindGrid.WindCoord[,] grid2 = this._grid;
			int height = this._height;
			int width2 = this._width;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0026E974 File Offset: 0x0026CB74
		private void SetWindTime(int tileX, int tileY, int directionX, int directionY)
		{
			WindGrid.WindCoord[,] grid = this._grid;
			int width = this._width;
			int gameTime = this._gameTime;
			int gameTime2 = this._gameTime;
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x0026E9A0 File Offset: 0x0026CBA0
		private void ScanPlayers()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool netClient = Main.NetClient;
				long num2 = 0L;
				this.ScanPlayer((int)num2);
				return;
			}
			long num3 = 0L;
			if (num == 0)
			{
			}
			this.ScanPlayer((int)num3);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x0026E9DC File Offset: 0x0026CBDC
		private void ScanPlayer(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (i == 0 || num == 0 || num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			Vector2 center = Main.Camera.Center;
			Vector2 unscaledSize = Main.Camera.UnscaledSize;
			if (num == 0)
			{
			}
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
			if (num == 0)
			{
			}
			WindGrid.WindCoord[,] grid = this._grid;
			int width = this._width;
			int gameTime = this._gameTime;
			int gameTime2 = this._gameTime;
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x0026EA68 File Offset: 0x0026CC68
		public WindGrid()
		{
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x0026EA7C File Offset: 0x0026CC7C
		// Note: this type is marked as 'beforefieldinit'.
		static WindGrid()
		{
		}

		// Token: 0x040085A3 RID: 34211
		private WindGrid.WindCoord[,] _grid;

		// Token: 0x040085A4 RID: 34212
		private int _width;

		// Token: 0x040085A5 RID: 34213
		private int _height;

		// Token: 0x040085A6 RID: 34214
		private int _gameTime;

		// Token: 0x040085A7 RID: 34215
		private static List<Point> points;

		// Token: 0x020009EF RID: 2543
		private struct WindCoord
		{
			// Token: 0x040085A8 RID: 34216
			public int Time;

			// Token: 0x040085A9 RID: 34217
			public int DirectionX;

			// Token: 0x040085AA RID: 34218
			public int DirectionY;
		}
	}
}
