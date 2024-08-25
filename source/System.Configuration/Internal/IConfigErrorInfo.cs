using System;

namespace System.Configuration.Internal
{
	// Token: 0x0200000E RID: 14
	public interface IConfigErrorInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33
		string Filename { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34
		int LineNumber { get; }
	}
}
