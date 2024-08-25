using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001A2 RID: 418
	internal struct InterlockedGate
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x000234A4 File Offset: 0x000216A4
		internal void Reset()
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Trigger(bool exclusive)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		internal bool StartTriggering(bool exclusive)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000234B4 File Offset: 0x000216B4
		internal void FinishTriggering()
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		internal bool StartSignaling(bool exclusive)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000234C4 File Offset: 0x000216C4
		internal void FinishSignaling()
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Complete()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400085C RID: 2140
		private int m_State;

		// Token: 0x0400085D RID: 2141
		internal const int Open = 0;

		// Token: 0x0400085E RID: 2142
		internal const int Triggering = 1;

		// Token: 0x0400085F RID: 2143
		internal const int Triggered = 2;

		// Token: 0x04000860 RID: 2144
		internal const int Signaling = 3;

		// Token: 0x04000861 RID: 2145
		internal const int Signaled = 4;

		// Token: 0x04000862 RID: 2146
		internal const int Completed = 5;
	}
}
