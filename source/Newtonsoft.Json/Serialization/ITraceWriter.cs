using System;
using System.Diagnostics;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007B RID: 123
	[Preserve]
	public interface ITraceWriter
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000452 RID: 1106
		TraceLevel LevelFilter { get; }

		// Token: 0x06000453 RID: 1107
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
