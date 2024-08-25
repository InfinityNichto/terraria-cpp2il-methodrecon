using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.GameInput;

namespace Terraria
{
	// Token: 0x02000430 RID: 1072
	public class TestHighFPSIssues
	{
		// Token: 0x0600280C RID: 10252 RVA: 0x0018F4F4 File Offset: 0x0018D6F4
		public static void TapUpdate(GameTime gt)
		{
			if (!true)
			{
			}
			TimeSpan totalGameTime = gt.totalGameTime;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0018F50C File Offset: 0x0018D70C
		public static void TapUpdateEnd(GameTime gt)
		{
			if (!true)
			{
			}
			TimeSpan totalGameTime = gt.totalGameTime;
			TimeSpan elapsedRealTime = gt.elapsedRealTime;
			bool isRunningSlowly = gt.isRunningSlowly;
			TimeSpan elapsedGameTime = gt.elapsedGameTime;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0018F53C File Offset: 0x0018D73C
		public static void TapDraw(GameTime gt)
		{
			if (!true)
			{
			}
			TimeSpan totalGameTime = gt.totalGameTime;
			TimeSpan elapsedRealTime = gt.elapsedRealTime;
			bool isRunningSlowly = gt.isRunningSlowly;
			TimeSpan elapsedGameTime = gt.elapsedGameTime;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0018F56C File Offset: 0x0018D76C
		public static void Update(GameTime gt)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool down = PlayerInput.Triggers.Current.Down;
			if (num == 0)
			{
			}
			TimeSpan totalGameTime = gt.totalGameTime;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0018F64C File Offset: 0x0018D84C
		public TestHighFPSIssues()
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0018F660 File Offset: 0x0018D860
		// Note: this type is marked as 'beforefieldinit'.
		static TestHighFPSIssues()
		{
		}

		// Token: 0x04003404 RID: 13316
		private static List<double> _tapUpdates;

		// Token: 0x04003405 RID: 13317
		private static List<double> _tapUpdateEnds;

		// Token: 0x04003406 RID: 13318
		private static List<double> _tapDraws;

		// Token: 0x04003407 RID: 13319
		private static int conU;

		// Token: 0x04003408 RID: 13320
		private static int conUH;

		// Token: 0x04003409 RID: 13321
		private static int conD;

		// Token: 0x0400340A RID: 13322
		private static int conDH;

		// Token: 0x0400340B RID: 13323
		private static int race;
	}
}
