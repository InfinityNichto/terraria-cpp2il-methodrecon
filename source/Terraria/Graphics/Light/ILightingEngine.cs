using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	// Token: 0x02000775 RID: 1909
	public interface ILightingEngine
	{
		// Token: 0x06003E8A RID: 16010
		void Rebuild();

		// Token: 0x06003E8B RID: 16011
		void AddLight(int x, int y, Vector3 color);

		// Token: 0x06003E8C RID: 16012
		void ProcessArea(Rectangle area);

		// Token: 0x06003E8D RID: 16013
		Vector3 GetColor(int x, int y);

		// Token: 0x06003E8E RID: 16014
		void Clear();

		// Token: 0x06003E8F RID: 16015
		LightMap GetLightMap([Out] Rectangle lightMapRegion);

		// Token: 0x06003E90 RID: 16016
		Rectangle GetScanRegion();
	}
}
