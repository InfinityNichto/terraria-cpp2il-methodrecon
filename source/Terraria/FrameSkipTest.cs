using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria
{
	// Token: 0x0200042F RID: 1071
	public class FrameSkipTest
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x0018F480 File Offset: 0x0018D680
		public static void Update(GameTime gameTime)
		{
			TimeSpan elapsedGameTime = gameTime.elapsedGameTime;
			Thread.Sleep(0);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0018F49C File Offset: 0x0018D69C
		public static void CheckReset(GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			TimeSpan totalGameTime = gameTime.totalGameTime;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0018F4C0 File Offset: 0x0018D6C0
		public static void UpdateServerTest()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0018F4D0 File Offset: 0x0018D6D0
		public FrameSkipTest()
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0018F4E4 File Offset: 0x0018D6E4
		// Note: this type is marked as 'beforefieldinit'.
		static FrameSkipTest()
		{
		}

		// Token: 0x040033FE RID: 13310
		private static int LastRecordedSecondNumber;

		// Token: 0x040033FF RID: 13311
		private static float CallsThisSecond;

		// Token: 0x04003400 RID: 13312
		private static float DeltasThisSecond;

		// Token: 0x04003401 RID: 13313
		private static List<float> DeltaSamples;

		// Token: 0x04003402 RID: 13314
		private const int SamplesCount = 5;

		// Token: 0x04003403 RID: 13315
		private static MultiTimer serverFramerateTest;
	}
}
