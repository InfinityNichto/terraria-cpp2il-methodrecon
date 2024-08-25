using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001E RID: 30
	[Preserve]
	public interface IJsonLineInfo
	{
		// Token: 0x06000044 RID: 68
		bool HasLineInfo();

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69
		int LineNumber { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000046 RID: 70
		int LinePosition { get; }
	}
}
