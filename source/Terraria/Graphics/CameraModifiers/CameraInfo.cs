using System;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x02000771 RID: 1905
	public struct CameraInfo
	{
		// Token: 0x06003E6F RID: 15983 RVA: 0x0023D3A4 File Offset: 0x0023B5A4
		public CameraInfo(Vector2 position)
		{
			if (!true)
			{
			}
			Vector2 vector = Main.ScreenSize.ToVector2();
			Vector2 originalCameraPosition = this.OriginalCameraPosition;
			this.CameraPosition = originalCameraPosition;
		}

		// Token: 0x04007D21 RID: 32033
		public Vector2 CameraPosition;

		// Token: 0x04007D22 RID: 32034
		public Vector2 OriginalCameraCenter;

		// Token: 0x04007D23 RID: 32035
		public Vector2 OriginalCameraPosition;
	}
}
