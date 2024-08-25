using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics
{
	// Token: 0x02000732 RID: 1842
	public struct SpriteRenderTargetHelper
	{
		// Token: 0x06003CF4 RID: 15604 RVA: 0x00237E74 File Offset: 0x00236074
		public static void GetDrawBoundary(int playerDrawDataCount, DrawData[] playerDrawData, [Out] Vector2 lowest, [Out] Vector2 highest)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!false)
			{
			}
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00237E90 File Offset: 0x00236090
		public static void GetHighsAndLowsOf(Vector2 lowest, Vector2 highest, DrawData cdd)
		{
			Vector2 origin = cdd.origin;
			Vector2 position = cdd.position;
			int width = cdd.sourceRect.Width;
			int height = cdd.sourceRect.Height;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00237EC4 File Offset: 0x002360C4
		public static void GetHighsAndLowsOf(Vector2 lowest, Vector2 highest, DrawData cdd, Vector2 pos, Vector2 origin, Vector2 corner)
		{
			Vector2 corner2 = SpriteRenderTargetHelper.GetCorner(cdd, pos, origin, pos);
			float x = lowest.X;
			float y = lowest.Y;
			if (!true)
			{
			}
			float x2 = highest.X;
			float y2 = highest.Y;
			highest.X = x2;
			highest.Y = y2;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00237F14 File Offset: 0x00236114
		public static Vector2 GetCorner(DrawData cdd, Vector2 pos, Vector2 origin, Vector2 corner)
		{
			float x = origin.X;
			float y = origin.Y;
			if (!true)
			{
			}
			float x2 = pos.X;
			float y2 = pos.Y;
			float rotation = cdd.rotation;
			if (!true)
			{
			}
			float x3 = cdd.scale.X;
			float y3 = cdd.scale.Y;
			return 1;
		}
	}
}
