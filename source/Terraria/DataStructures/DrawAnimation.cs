using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x0200061F RID: 1567
	public class DrawAnimation
	{
		// Token: 0x060035DA RID: 13786 RVA: 0x00211ADC File Offset: 0x0020FCDC
		public virtual void Update()
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00211AEC File Offset: 0x0020FCEC
		public virtual Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			return texture.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00211B10 File Offset: 0x0020FD10
		public DrawAnimation()
		{
		}

		// Token: 0x040076AD RID: 30381
		public int Frame;

		// Token: 0x040076AE RID: 30382
		public int FrameCount;

		// Token: 0x040076AF RID: 30383
		public int TicksPerFrame;

		// Token: 0x040076B0 RID: 30384
		public int FrameCounter;
	}
}
