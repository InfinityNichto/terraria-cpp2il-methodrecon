using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000012 RID: 18
	[NativeAsStruct]
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class AsyncReadManagerMetricsFilters
	{
		// Token: 0x04000036 RID: 54
		[NativeName("typeIDs")]
		internal ulong[] TypeIDs;

		// Token: 0x04000037 RID: 55
		[NativeName("states")]
		internal ProcessingState[] States;

		// Token: 0x04000038 RID: 56
		[NativeName("readTypes")]
		internal FileReadType[] ReadTypes;

		// Token: 0x04000039 RID: 57
		[NativeName("priorityLevels")]
		internal Priority[] PriorityLevels;

		// Token: 0x0400003A RID: 58
		[NativeName("subsystems")]
		internal AssetLoadingSubsystem[] Subsystems;
	}
}
