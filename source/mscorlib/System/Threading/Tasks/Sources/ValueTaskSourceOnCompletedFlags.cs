using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000258 RID: 600
	[Flags]
	public enum ValueTaskSourceOnCompletedFlags
	{
		// Token: 0x04000ADB RID: 2779
		None = 0,
		// Token: 0x04000ADC RID: 2780
		UseSchedulingContext = 1,
		// Token: 0x04000ADD RID: 2781
		FlowExecutionContext = 2
	}
}
