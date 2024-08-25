using System;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics
{
	// Token: 0x02000744 RID: 1860
	public struct VirtualCamera
	{
		// Token: 0x06003D47 RID: 15687 RVA: 0x00238D54 File Offset: 0x00236F54
		public VirtualCamera(Player player)
		{
			this.Player = player;
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x00238D68 File Offset: 0x00236F68
		public Vector2 Position
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00238D80 File Offset: 0x00236F80
		public Vector2 Size
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00238D94 File Offset: 0x00236F94
		public Vector2 Center
		{
			get
			{
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x04007C28 RID: 31784
		public readonly Player Player;
	}
}
