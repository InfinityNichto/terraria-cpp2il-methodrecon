using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000079 RID: 121
	[Preserve]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000B954 File Offset: 0x00009B54
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return this.<LevelFilter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LevelFilter>k__BackingField = value;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000212A File Offset: 0x0000032A
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000B968 File Offset: 0x00009B68
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			if (level != TraceLevel.Off)
			{
				IEnumerator enumerator = global::System.Diagnostics.Trace.Listeners.GetEnumerator();
				return;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public DiagnosticsTraceWriter()
		{
		}

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private TraceLevel <LevelFilter>k__BackingField;
	}
}
