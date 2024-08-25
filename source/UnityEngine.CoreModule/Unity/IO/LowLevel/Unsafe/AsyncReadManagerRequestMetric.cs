using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	public struct AsyncReadManagerRequestMetric
	{
		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string <AssetName>k__BackingField;

		// Token: 0x04000028 RID: 40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly string <FileName>k__BackingField;

		// Token: 0x04000029 RID: 41
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ulong <OffsetBytes>k__BackingField;

		// Token: 0x0400002A RID: 42
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly ulong <SizeBytes>k__BackingField;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ulong <AssetTypeId>k__BackingField;

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ulong <CurrentBytesRead>k__BackingField;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly uint <BatchReadCount>k__BackingField;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool <IsBatchRead>k__BackingField;

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ProcessingState <State>k__BackingField;

		// Token: 0x04000030 RID: 48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly FileReadType <ReadType>k__BackingField;

		// Token: 0x04000031 RID: 49
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly Priority <PriorityLevel>k__BackingField;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly AssetLoadingSubsystem <Subsystem>k__BackingField;

		// Token: 0x04000033 RID: 51
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly double <RequestTimeMicroseconds>k__BackingField;

		// Token: 0x04000034 RID: 52
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly double <TimeInQueueMicroseconds>k__BackingField;

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly double <TotalTimeMicroseconds>k__BackingField;
	}
}
