using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000620 RID: 1568
	public class DrawAnimationVertical : DrawAnimation
	{
		// Token: 0x060035DD RID: 13789 RVA: 0x00211B24 File Offset: 0x0020FD24
		public DrawAnimationVertical(int ticksperframe, int frameCount, bool pingPong = false)
		{
			this.TicksPerFrame = ticksperframe;
			this.TicksPerFrame = frameCount;
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00211B48 File Offset: 0x0020FD48
		public override void Update()
		{
			if (!this.NotActuallyAnimating)
			{
				int ticksPerFrame = this.TicksPerFrame;
				bool pingPong = this.PingPong;
				this.FrameCounter = (pingPong ? 1 : 0);
				int frame = this.Frame;
				int ticksPerFrame2 = this.TicksPerFrame;
				bool pingPong2 = this.PingPong;
				this.Frame = frame;
				if (pingPong2)
				{
				}
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00211B94 File Offset: 0x0020FD94
		public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			int frameCount = this.FrameCount;
			int frameCounter = this.FrameCounter;
			int frame;
			int ticksPerFrame;
			if (this.PingPong)
			{
				bool pingPong = this.PingPong;
				frame = this.Frame;
				ticksPerFrame = this.TicksPerFrame;
				if (pingPong)
				{
				}
			}
			int num = 1;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			return texture.Frame(num, frame, (int)num2, ticksPerFrame, (int)num3, (int)num4);
		}

		// Token: 0x040076B1 RID: 30385
		public bool PingPong;

		// Token: 0x040076B2 RID: 30386
		public bool NotActuallyAnimating;
	}
}
