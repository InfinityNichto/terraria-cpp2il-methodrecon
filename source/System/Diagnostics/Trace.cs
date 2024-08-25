using System;
using Cpp2IlInjected;

namespace System.Diagnostics
{
	// Token: 0x020000CB RID: 203
	public sealed class Trace
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00013624 File Offset: 0x00011824
		public static TraceListenerCollection Listeners
		{
			get
			{
				if (!true)
				{
				}
				return TraceInternal.Listeners;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001363C File Offset: 0x0001183C
		public static bool AutoFlush
		{
			get
			{
				if (!true)
				{
				}
				return TraceInternal.AutoFlush;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		public static CorrelationManager CorrelationManager
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000394 RID: 916
		private static CorrelationManager correlationManager;
	}
}
