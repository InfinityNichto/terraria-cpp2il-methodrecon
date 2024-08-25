using System;
using Cpp2IlInjected;

namespace System.Diagnostics
{
	// Token: 0x020000CE RID: 206
	public abstract class TraceFilter
	{
		// Token: 0x060004AA RID: 1194
		public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
