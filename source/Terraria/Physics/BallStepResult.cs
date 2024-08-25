using System;

namespace Terraria.Physics
{
	// Token: 0x02000542 RID: 1346
	public struct BallStepResult
	{
		// Token: 0x06003265 RID: 12901 RVA: 0x001F9B90 File Offset: 0x001F7D90
		private BallStepResult(BallState state)
		{
			this.State = state;
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x001F9BA4 File Offset: 0x001F7DA4
		public static BallStepResult OutOfBounds()
		{
			return 2;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x001F9BB4 File Offset: 0x001F7DB4
		public static BallStepResult Moving()
		{
			return 1;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x001F9BC4 File Offset: 0x001F7DC4
		public static BallStepResult Resting()
		{
		}

		// Token: 0x04003BA1 RID: 15265
		public readonly BallState State;
	}
}
