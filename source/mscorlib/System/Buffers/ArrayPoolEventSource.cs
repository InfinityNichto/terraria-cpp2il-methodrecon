using System;
using System.Diagnostics.Tracing;

namespace System.Buffers
{
	// Token: 0x02000661 RID: 1633
	[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
	internal sealed class ArrayPoolEventSource : EventSource
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x0006BA74 File Offset: 0x00069C74
		private ArrayPoolEventSource()
		{
			this.<Name>k__BackingField = "System.Buffers.ArrayPoolEventSource";
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0006BA94 File Offset: 0x00069C94
		[Event(1, Level = EventLevel.Verbose)]
		internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x0006BAA4 File Offset: 0x00069CA4
		[Event(2, Level = EventLevel.Informational)]
		internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0006BAB4 File Offset: 0x00069CB4
		[Event(3, Level = EventLevel.Verbose)]
		internal void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(bufferId, bufferId, bufferSize, poolId);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0006BACC File Offset: 0x00069CCC
		[Event(4, Level = EventLevel.Informational)]
		internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(bufferId, bufferId, bufferSize, poolId);
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0006BAE4 File Offset: 0x00069CE4
		[Event(5, Level = EventLevel.Informational)]
		internal void BufferTrimPoll(int milliseconds, int pressure)
		{
			base.WriteEvent(milliseconds, milliseconds, pressure);
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x0006BAFC File Offset: 0x00069CFC
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayPoolEventSource()
		{
		}

		// Token: 0x04001AAA RID: 6826
		internal static readonly ArrayPoolEventSource Log;

		// Token: 0x02000662 RID: 1634
		internal enum BufferAllocatedReason
		{
			// Token: 0x04001AAC RID: 6828
			Pooled,
			// Token: 0x04001AAD RID: 6829
			OverMaximumSize,
			// Token: 0x04001AAE RID: 6830
			PoolExhausted
		}
	}
}
