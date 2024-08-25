using System;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000320 RID: 800
	[Flags]
	public enum BatteryChargeStatus
	{
		// Token: 0x04002221 RID: 8737
		Charging = 8,
		// Token: 0x04002222 RID: 8738
		Critical = 4,
		// Token: 0x04002223 RID: 8739
		High = 1,
		// Token: 0x04002224 RID: 8740
		Low = 2,
		// Token: 0x04002225 RID: 8741
		NoSystemBattery = 128,
		// Token: 0x04002226 RID: 8742
		Unknown = 255
	}
}
